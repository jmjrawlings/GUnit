using GUnit;

var mm = new Unit
{
    Id="mm",
    Name = "millimetre",
    Class = "mm",
    Tex = @"\milli\metre",
    Suffix="mm"
};

var g = new Unit
{
    Id="g",
    Name = "gram",
    Tex = @"\gram",
    Class = "g",
    Suffix="g"
};

var s = new Unit
{
    Id="s",
    Name = "second",
    Class = "s",
    Tex = @"\second",
    Suffix="s"
};
var one = new One { Id = "unit", Class = "double", Name = "1", Suffix = "", Tex = "" };
var s2 = MkExp(s, 2);
var m = new Scale(mm, 1000) {Id="m", Name = "metre", Tex = @"\metre", Class = "m", Suffix = "m"};
var m2 = MkExp(m, 2);
var mm2 = MkExp(mm, 2);
var mm3 = MkExp(mm, 3);
var mm4 = MkExp(mm, 4);
var kg = new Scale(g, 1000) {Id="kg",Name = "kilogram", Tex = @"\kilo\gram", Class = "kg" , Suffix = "kg"};
var tonne = new Scale(kg, 1000) { Id="t", Name = "tonne", Tex = @"\tonne", Class = "tonne", Suffix = "t"};
var m_s = MkDiv(m, s) with { Name = "metres per second", Class = "m_s", Suffix= "m/s" };
var N = MkMul(kg, m_s) with { Name = "newton", Tex = @"\newton", Class = "N" };
var kN = new Scale(N, 1000) { Id="kN", Name = "kilonewton", Tex = @"\kilo\newton", Class = "kN" };
var Pa = MkDiv(N, m2) with { Name = "pascal", Tex = @"\pascal", Class = "Pa" };
var kPa = new Scale(Pa, 1000) {Id="kPA", Name = "kilopascal", Tex = @"\kilo\pascal", Class = "kPa" };
var MPa = new Scale(kPa, 1000) {Id="MPa", Name = "megapascal", Tex = @"\mega\pascal", Class = "MPa" };

List<Unit> unitList =
[
    mm, 
    g, 
    s, 
    m, 
    m2, 
    s2,
    mm2,
    mm3,
    mm4, 
    kg, 
    tonne, 
    m_s,
    N,
    kN,
    Pa,
    kPa,
    MPa,
    one
];


int n = unitList.Count;
for (int i = 0; i < n; i++)
{
    var t = unitList[i];
    var u = MkDiv(one, t);
    unitList.Add(u);
}

Dictionary<string, Unit> units = [];

string code;
var cb = new CodeBuilder();
foreach (var unit in unitList)
{
    units[unit.Id] = unit;
    if (unit is not One)
        WriteUnit(unit);
}
cb.WriteLn("namespace Units;");
cb.NewLine();
using (cb.Block("public interface IUnitOfMeasure<T> where T:IUnitOfMeasure<T>"))
{
    cb.WriteLn("public double Value {get;}");
    cb.WriteLn("public abstract static string Name {get;}");
    cb.WriteLn("public abstract static string TexUnitString {get;}");
    cb.WriteLn("public abstract static string UnitString {get;}");
    cb.WriteLn("public abstract static string TexUnitsOnly {get;}");
}
cb.NewLine();


foreach (var t in unitList)
{
    if (t is One)
        continue;

    using (t.Code.Block("public string ToString(string? format, IFormatProvider? formatProvider = null)"))
    {
        t.Code.Write("""
            string s;
            if (format is null)
            {
                s = Value.ToString("g", formatProvider);
            }
            else if (format.StartsWith("T", StringComparison.OrdinalIgnoreCase))
            {
                string rounded = Value.ToString(
                    string.Concat("F", format.AsSpan(1, format.Length - 1))
                );
                s = $@"\qty{{{rounded}}}{{{TexUnitString}}}";
            }
            else
            {
                s = Value.ToString(format, formatProvider);
            }
            return s;
        """);
    }

    t.Code.Dispose();
    code = t.Code.ToString();
    // foreach (var line in code.Split('\n', StringSplitOptions.RemoveEmptyEntries))
    cb.Write(code);
    cb.NewLine();
}

cb.Dispose();
code = cb.ToString();
File.WriteAllText("C:/Users/hrkn/projects/GUnit/Unit.g.cs", code);
return;


void WriteUnit(Unit t)
{
    var c = t.Class;
    var cb = t.Code;
    cb.Summary(t.Name);
    cb.Block("public", "readonly", "struct", c, $": IUnitOfMeasure<{c}>, IFormattable");
    cb.WriteLn($"public static string Name => @\"{t.Name}\";");
    cb.WriteLn($"public static string TexUnitString => @\"{t.Tex}\";");
    cb.WriteLn($"public static string UnitString => @\"{t.Suffix}\";");
    cb.WriteLn($"public static string TexUnitsOnly => @\"\\si{{ TexUnitString }}\";");
    cb.WriteLn("public double Value { get; }");
    
    using (cb.Function($"public {c}", "double value"))
        cb.Assign("Value", "value");
    
    using (cb.Explicit(c, "double", "value"))
        cb.Return("new(value)");
    
    using (cb.Explicit(c, "int", "value"))
        cb.Return("new(value)");
    
    using (cb.Operator(c, "+", $"{c} a, {c} b"))
        cb.Return("new(a.Value + b.Value)");
    
    using (cb.Operator(c, "-", $"{c} a, {c} b"))
        cb.Return("new(a.Value - b.Value)");
    
    using (cb.Operator(c, "*", $"{c} a, int b"))
        cb.Return("new(a.Value * b)");

    using (cb.Operator(c, "*", $"{c} a, double b"))
        cb.Return(t.New("a.Value * b"));

    using (cb.Operator(c, "*", $"int a, {c} b"))
        cb.Return(t.New("a * b.Value"));

    using (cb.Operator(c, "*", $"double a, {c} b"))
        cb.Return(t.New("a * b.Value"));
    
    using (cb.Operator("double", "/", $"{c} a, {c} b"))
        cb.Return("a.Value / b.Value");
    
    using (cb.Operator(c, "/", $"{c} a, int b"))
        cb.Return(t.New("a.Value / b"));
    
    using (cb.Operator(c, "/", $"{c} a, double b"))
        cb.Return(t.New("a.Value / b"));

    if (t is Scale s) 
        WriteScaled(s.Base, s.Factor, t);
    
    WriteOperators(t);
}

void WriteScaled(Unit b, double factor, Unit t)
{
    using (b.Code.Implicit(b.Class, t.Class, "x"))
        b.Code.Return(t.New($"x.Value * {factor:F1}"));
            
    using (t.Code.Implicit(t.Class, b.Class, "x"))
        t.Code.Return(t.New($"x.Value / {factor:F1}"));
    
    if (b is Scale s)
        WriteScaled(s.Base, factor * s.Factor, t);
}

Unit Pwr(Unit b, int n) => n switch
{
    0 => throw new Exception(),
    1 => b,
    _ => units[$"{b.Id}^{n}"]
};

void WriteExp(Unit b, int n, Unit t)
{
    if (n is 2)
    {
        WriteMul(b, b, t);
        WriteDiv(t, b, b);
    }
    else
    {
        // return;
        for (int i = 2; i < n; i++)
        {
            Unit x = Pwr(b, i);
            Unit y = Pwr(b, n - i);
            WriteMul(x, y, t);
            WriteDiv(t, y, x);
        }
    }
}

void WriteMul(Unit a, Unit b, Unit t)
{
    // A * B = T
    using (a.Code.Operator(t.Class, "*", $"{a.Class} a, {b.Class} b"))
        a.Code.Return(t.New($"a.Value * b.Value"));
      
    if (a.Id == b.Id)
        return;
    
    // B * A = T
    using (b.Code.Operator(t.Class, "*", $"{b.Class} a, {a.Class} b"))
        b.Code.Return(t.New($"a.Value * b.Value"));
}

void WriteDiv(Unit a, Unit b, Unit t)
{
    // A / B = T
    using (a.Code.Operator(t.Class, "/", $"{a.Class} a, {b.Class} b"))
        a.Code.Return(t.New("a.Value / b.Value"));
    
    if (b.Id == t.Id)
        return;
            
    // A / T = B
    using (a.Code.Operator(b.Class, "/", $"{a.Class} a, {t.Class} b"))
        a.Code.Return(t.New($"a.Value / b.Value"));
}

void WriteOperators(Unit t)
{
    switch (t)
    {
        case Mul { A: var a, B: var b }:
            WriteMul(a, b, t);
            WriteDiv(t, a, b);
            break;
        
        case Div { A: var a, B: var b }:
            WriteDiv(a, b, t);
            WriteMul(b, t, a);
            break;
        
        case Exp { B: var b, N: var n}:
            WriteExp(b, n, t);
            break;

    }
}

Unit MkExp(Unit b, int n)
{
    Unit t;
    switch (n)
    {
        case 0:
            t = one;
            break;

        case 1:
            t = b;
            break;

        default:
            t = new Exp(b, n)
            {
                Id = $"{b.Id}^{n}",
                Class = $"{b.Class}{n}",
                Name = $"{b.Name}^{n}",
                Tex = $"{b.Tex}^{n}",
                Suffix = $"{b.Suffix}^{n}"
            };
            break;
    }

    return t;
};

Unit MkMul(Unit a, Unit b)
{
    Unit t;
    switch (a, b)
    {
        case (Exp e, Exp f) when e.B.Id == f.B.Id:
            t = MkExp(e, e.N + f.N);
            break;
        
        case (Exp e, var f) when e.B.Id == f.Id:
            t = MkExp(e, e.N + 1);
            break;
        
        case (var f, Exp e) when e.B.Id == f.Id:
            t = MkExp(e, e.N + 1);
            break;
        
        case (var f, Exp {N: <0} g):
            t = MkDiv(f, MkExp(g.B, Math.Abs(g.N)));
            break;
        
        case (Exp{N:<0} g, var f):
            t = MkDiv(f, MkExp(g.B, Math.Abs(g.N)));
            break;
        
        case (One _, _):
            return b;
        
        case (_, One _):
            return a;
        
        default:
            t = new Mul(a, b)
            {
                Id = $"{a.Id}.{b.Id}",
                Name = $"{a.Name}.{b.Name}",
                Tex = $"{a.Tex}{b.Tex}",
                Suffix = $"{a.Suffix}.{b.Suffix}"
            };
            break;
    }
    return t;
}

Unit MkDiv(Unit a, Unit b)
{
    Unit t;
    switch (a, b)
    {
        case (_, One):
            return a;
        
        case (_, _) when a.Id == b.Id:
            t = one;
            break;
        
        case (_, Exp {N: <0} e):
            t = MkMul(a, MkExp(e, Math.Abs(e.N)));
            break;
        
        case (_, Div d):
            t = MkDiv(MkMul(a, d.B), d.A);
            break;
        
        case (One, _):
            t = new Div(a, b)
            {
                Id = $"1/{b.Id}",
                Name = $"1/{b.Name}",
                Class = $"per_{b.Class}",
                Tex = $"1/{b.Tex}",
                Suffix = $"1/{b.Suffix}"
            };
            break;
        
        default:
            t = new Div(a, b)
            {
                Id = $"{a.Id}/{b.Id}",
                Name = $"{a.Name} / {b.Name}",
                Class = $"{a.Class}_{b.Class}",
                Tex = $"{a.Tex}/{b.Tex}",
                Suffix = $"{a.Suffix}/{b.Suffix}"
            };
            break;
    }

    return t;
}
