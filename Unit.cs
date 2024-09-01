namespace GUnit;

/// <summary>
/// A unit of measure
/// </summary>
public record Unit
{
    /// Class name
    public virtual string Class { get; set; } = "";
    
    /// Human name
    public virtual string Name { get; set; } = "";
    
    /// Suffix
    public virtual string Suffix { get; set; } = "";
    
    /// LaTeX `suinitx` unit name
    public virtual string Tex { get; set; } = "";

    public virtual required string Id { get; init; }

    public virtual string New(string expr) => $"new({expr})";
    
    /// Stores the class definition
    public CodeBuilder Code { get; } = new();
    
    public override string ToString() => Class;
}

public sealed record Div(Unit A, Unit B) : Unit { }

public sealed record Mul(Unit A, Unit B) : Unit { }

public sealed record Exp(Unit B, int N) : Unit { }

public record Scale(Unit B, double Factor) : Unit { }

public sealed record One : Unit
{
    public override string New(string expr) => expr;
}