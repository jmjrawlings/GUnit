namespace GUnit;

/// <summary>
/// A unit of measure
/// </summary>
public record Unit
{
    
    /// Class name
    public string Class { get; set; } = "";

    public string Id => Class;
    
    /// Human name
    public string Name { get; set; } = "";
    
    /// Suffix
    public string Suffix { get; set; } = "";
    
    /// LaTeX `suinitx` unit name
    public string Tex { get; set; } = "";
    
    /// Stores the class definition
    public CodeBuilder Code { get; init; } = new();
    
    public static Unit operator /(Unit a, Unit b)
    {
        var unit = new Div(a, b);
        unit.Name = $"{a.Name} / {b.Name}";
        unit.Tex = $"{a.Tex}/{b.Tex}";
        unit.Suffix = $"{a.Suffix}/{b.Suffix}";
        return unit;
    }

    public static Unit operator *(Unit a, Unit b)
    {
        var unit = new Mul(a, b);
        unit.Name = $"{a.Name}.{b.Name}";
        unit.Tex = $"{a.Tex}{b.Tex}";
        unit.Suffix = $"{a.Suffix}.{b.Suffix}";
        return unit;
    }

    public static Unit operator *(Unit u, int n) => new Scale(u, n);

    public static Unit operator *(int n, Unit u) => new Scale(u, n);

    public static Unit operator *(Unit u, double n) => new Scale(u, n);

    public static Unit operator *(double n, Unit u) => new Scale(u, n);

    public static Unit operator ^(Unit a, int n)
    {
        var unit = new Power(a, n);
        unit.Class = $"{a.Class}{n}";
        unit.Name = $"{a.Name}^{n}";
        unit.Tex = $"{a.Tex}^{n}";
        unit.Suffix = $"{a.Suffix}^{n}";
        return unit;
    }

    public override string ToString() => Class;
}

public sealed record Div(Unit A, Unit B) : Unit { }

public sealed record Mul(Unit A, Unit B) : Unit { }

public record Scale(Unit Base, double Factor) : Unit { }

public sealed record Power(Unit Base, int N) : Unit { }