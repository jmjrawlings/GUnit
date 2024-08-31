using GUnit;

var mm = new Unit
{
    Name = "millimetre",
    Class = "mm",
    Tex = @"\milli\metre"
};

var g = new Unit
{
    Name = "gram",
    Tex = @"\gram",
    Class = "g"
};

var s = new Unit
{
    Name = "second",
    Class = "sec",
    Tex = @"\second"
};
var s2 = s ^ 2;
var m = (mm * 1000) with { Name = "metre", Tex = @"\metre", Class = "m" };
var m2 = m ^ 2;
// var mm2 = mm ^ 2;
// var mm3 = mm ^ 3;
// var mm4 = mm ^ 4;
var kg = (1000 * g) with { Name = "kilogram", Tex = @"\kilo\gram", Class = "kg" };
var tonne = (kg * 1000) with { Name = "tonne", Tex = @"\tonne", Class = "tonne" };
var m_s = (m / s) with { Name = "metres per second", Class = "m_s" };
// var N = (kg * m_s) with { Name = "newton", Tex = @"\newton", Class = "N" };
// var kN = (1000 * N) with { Name = "kilonewton", Tex = @"\kilo\newton", Class = "kN" };
// var Pa = (N / m2) with { Name = "pascal", Tex = @"\pascal", Class = "Pa" };
// var kPa = (1000 * Pa) with { Name = "kilopascal", Tex = @"\kilo\pascal", Class = "kPa" };
// var MPa = (1000 * kPa) with { Name = "megapascal", Tex = @"\mega\pascal", Class = "MPa" };


Unit[] unitArray =
[
    mm, 
    g, 
    s, 
    m, 
    m2, 
    s2,
    // mm2,
    // mm3,
    // mm4, 
    kg, 
    tonne, 
    m_s
    // ,
    // N,
    // kN,
    // Pa,
    // kPa,
    // MPa); 
];

Dictionary<string, Unit> units = [];

void WriteUnitClass(Unit unit)
{

    var t = unit.Class!;
    var cb = unit.Code;
    cb.Block("public", "readonly", "struct", t);
    cb.WriteLn($"public static string Name => @\"{unit.Name}\";");
    cb.WriteLn($"public static string Tex => @\"{unit.Tex}\";");
    cb.WriteLn($"public static string Code => @\"{unit.Class}\";");
    cb.Declare("public readonly double", "Value");
    
    using (cb.Function($"public {t}", "double value"))
    {
        cb.Assign("Value", "value");
    }

    using (cb.Operator(t, "*", $"{t} a, int b"))
        cb.Return("new(a.Value * b)");

    using (cb.Operator(t, "*", $"{t} a, double b"))
        cb.Return("new(a.Value * b)");

    using (cb.Operator(t, "*", $"int a, {t} b"))
        cb.Return("new(a * b.Value)");

    using (cb.Operator(t, "*", $"double a, {t} b"))
        cb.Return("new(a * b.Value)");

    WriteConversions(unit);
}
    
void WriteConversions(Unit t)
{
    switch (t)
    {
        // Add implicit transforms for scaled units
        case Scale { Base: var b, Factor: var factor }:
            
            using (b.Code.Implicit(b.Class, t.Class, "x"))
                b.Code.Return($"new(x.Value * {factor:F1})");
            
            using (t.Code.Implicit(t.Class, b.Class, "x"))
                t.Code.Return($"new(x.Value / {factor:F1})");

            break;
        
        // Add construction via multiplication
        case Mul { A: var a, B: var b }:
            
            using (a.Code.Operator(t.Class, "*", $"{a.Class} a, {b.Class} b"))
                a.Code.Return($"new(a.Value * b.Value)");

            using (b.Code.Operator(t.Class, "*", $"{b.Class} a, {a.Class} b"))
                b.Code.Return($"new(a.Value * b.Value)");

            break;

        // Add construction via division
        case Div { A: var a, B: var b }:
            
            using (a.Code.Operator(t.Class, "/", $"{a.Class} a, {b.Class} b"))
                a.Code.Return($"new(a.Value / b.Value)");

            break;
    }
}

string code;
var cb = new CodeBuilder();
foreach (var unit in unitArray)
{
    units[unit.Id] = unit;
    WriteUnitClass(unit);
}
cb.WriteLn("namespace Units;");
cb.NewLine();
foreach (var unit in unitArray)
{
    unit.Code.Dispose();
    code = unit.Code.ToString();
    foreach (var line in code.Split('\n', StringSplitOptions.RemoveEmptyEntries))
        cb.Write(line);
}
cb.Dispose();
code = cb.ToString();
File.WriteAllText("C:/Users/hrkn/projects/GUnit/Unit.gen.cs", code);