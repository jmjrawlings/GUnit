namespace Units;

public interface IUnitOfMeasure<T> where T:IUnitOfMeasure<T>
{
    public double Value {get;}
    public abstract static string Name {get;}
    public abstract static string Suffix {get;}
    public abstract static string TexUnitString {get;}
    public abstract static string TexUnitsOnly {get;}
}


/// <summary>
/// millimetre
/// </summary>
public readonly struct mm : IUnitOfMeasure<mm>, IFormattable
{
    public static string Name => @"millimetre";
    public static string Suffix => @"mm";
    public static string TexUnitString => @"\milli\metre";
    public static string TexUnitsOnly => @$"\si{{ {TexUnitString} }}";
    public double Value { get; }
    public mm(double value)
    {
        Value = value;
    }

    public static implicit operator mm(double value)
    {
        return new(value);
    }

    public static implicit operator mm(int value)
    {
        return new(value);
    }

    public static implicit operator double(mm x)
    {
        return x.Value;
    }

    public static mm operator +(mm a, mm b)
    {
        return new(a.Value + b.Value);
    }

    public static mm operator -(mm a, mm b)
    {
        return new(a.Value - b.Value);
    }

    public static mm operator *(mm a, int b)
    {
        return new(a.Value * b);
    }

    public static mm operator *(mm a, double b)
    {
        return new(a.Value * b);
    }

    public static mm operator *(int a, mm b)
    {
        return new(a * b.Value);
    }

    public static mm operator *(double a, mm b)
    {
        return new(a * b.Value);
    }

    public static double operator /(mm a, mm b)
    {
        return a.Value / b.Value;
    }

    public static mm operator /(mm a, int b)
    {
        return new(a.Value / b);
    }

    public static mm operator /(mm a, double b)
    {
        return new(a.Value / b);
    }

    public static implicit operator mm(m x)
    {
        return new(x.Value * 1000.0);
    }

    public static mm2 operator *(mm a, mm b)
    {
        return new(a.Value * b.Value);
    }

    public static mm3 operator *(mm a, mm2 b)
    {
        return new(a.Value * b.Value);
    }

    public static mm4 operator *(mm a, mm3 b)
    {
        return new(a.Value * b.Value);
    }

    public static double operator *(mm a, per_mm b)
    {
        return a.Value * b.Value;
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
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
    return s;    }

}


/// <summary>
/// gram
/// </summary>
public readonly struct g : IUnitOfMeasure<g>, IFormattable
{
    public static string Name => @"gram";
    public static string Suffix => @"g";
    public static string TexUnitString => @"\gram";
    public static string TexUnitsOnly => @$"\si{{ {TexUnitString} }}";
    public double Value { get; }
    public g(double value)
    {
        Value = value;
    }

    public static implicit operator g(double value)
    {
        return new(value);
    }

    public static implicit operator g(int value)
    {
        return new(value);
    }

    public static implicit operator double(g x)
    {
        return x.Value;
    }

    public static g operator +(g a, g b)
    {
        return new(a.Value + b.Value);
    }

    public static g operator -(g a, g b)
    {
        return new(a.Value - b.Value);
    }

    public static g operator *(g a, int b)
    {
        return new(a.Value * b);
    }

    public static g operator *(g a, double b)
    {
        return new(a.Value * b);
    }

    public static g operator *(int a, g b)
    {
        return new(a * b.Value);
    }

    public static g operator *(double a, g b)
    {
        return new(a * b.Value);
    }

    public static double operator /(g a, g b)
    {
        return a.Value / b.Value;
    }

    public static g operator /(g a, int b)
    {
        return new(a.Value / b);
    }

    public static g operator /(g a, double b)
    {
        return new(a.Value / b);
    }

    public static implicit operator g(kg x)
    {
        return new(x.Value * 1000.0);
    }

    public static double operator *(g a, per_g b)
    {
        return a.Value * b.Value;
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
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
    return s;    }

}


/// <summary>
/// second
/// </summary>
public readonly struct s : IUnitOfMeasure<s>, IFormattable
{
    public static string Name => @"second";
    public static string Suffix => @"s";
    public static string TexUnitString => @"\second";
    public static string TexUnitsOnly => @$"\si{{ {TexUnitString} }}";
    public double Value { get; }
    public s(double value)
    {
        Value = value;
    }

    public static implicit operator s(double value)
    {
        return new(value);
    }

    public static implicit operator s(int value)
    {
        return new(value);
    }

    public static implicit operator double(s x)
    {
        return x.Value;
    }

    public static s operator +(s a, s b)
    {
        return new(a.Value + b.Value);
    }

    public static s operator -(s a, s b)
    {
        return new(a.Value - b.Value);
    }

    public static s operator *(s a, int b)
    {
        return new(a.Value * b);
    }

    public static s operator *(s a, double b)
    {
        return new(a.Value * b);
    }

    public static s operator *(int a, s b)
    {
        return new(a * b.Value);
    }

    public static s operator *(double a, s b)
    {
        return new(a * b.Value);
    }

    public static double operator /(s a, s b)
    {
        return a.Value / b.Value;
    }

    public static s operator /(s a, int b)
    {
        return new(a.Value / b);
    }

    public static s operator /(s a, double b)
    {
        return new(a.Value / b);
    }

    public static s2 operator *(s a, s b)
    {
        return new(a.Value * b.Value);
    }

    public static m operator *(s a, m_s b)
    {
        return new(a.Value * b.Value);
    }

    public static double operator *(s a, per_s b)
    {
        return a.Value * b.Value;
    }

    public static s_m operator /(s a, m b)
    {
        return new(a.Value / b.Value);
    }

    public static m operator /(s a, s_m b)
    {
        return new(a.Value / b.Value);
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
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
    return s;    }

}


/// <summary>
/// metre
/// </summary>
public readonly struct m : IUnitOfMeasure<m>, IFormattable
{
    public static string Name => @"metre";
    public static string Suffix => @"m";
    public static string TexUnitString => @"\metre";
    public static string TexUnitsOnly => @$"\si{{ {TexUnitString} }}";
    public double Value { get; }
    public m(double value)
    {
        Value = value;
    }

    public static implicit operator m(double value)
    {
        return new(value);
    }

    public static implicit operator m(int value)
    {
        return new(value);
    }

    public static implicit operator double(m x)
    {
        return x.Value;
    }

    public static m operator +(m a, m b)
    {
        return new(a.Value + b.Value);
    }

    public static m operator -(m a, m b)
    {
        return new(a.Value - b.Value);
    }

    public static m operator *(m a, int b)
    {
        return new(a.Value * b);
    }

    public static m operator *(m a, double b)
    {
        return new(a.Value * b);
    }

    public static m operator *(int a, m b)
    {
        return new(a * b.Value);
    }

    public static m operator *(double a, m b)
    {
        return new(a * b.Value);
    }

    public static double operator /(m a, m b)
    {
        return a.Value / b.Value;
    }

    public static m operator /(m a, int b)
    {
        return new(a.Value / b);
    }

    public static m operator /(m a, double b)
    {
        return new(a.Value / b);
    }

    public static implicit operator m(mm x)
    {
        return new(x.Value / 1000.0);
    }

    public static m2 operator *(m a, m b)
    {
        return new(a.Value * b.Value);
    }

    public static m3 operator *(m a, m2 b)
    {
        return new(a.Value * b.Value);
    }

    public static m_s operator /(m a, s b)
    {
        return new(a.Value / b.Value);
    }

    public static s operator /(m a, m_s b)
    {
        return new(a.Value / b.Value);
    }

    public static kNm operator *(m a, kN b)
    {
        return new(a.Value * b.Value);
    }

    public static kN operator *(m a, kN_m b)
    {
        return new(a.Value * b.Value);
    }

    public static double operator *(m a, per_m b)
    {
        return a.Value * b.Value;
    }

    public static s operator *(m a, s_m b)
    {
        return new(a.Value * b.Value);
    }

    public static m_kN operator /(m a, kN b)
    {
        return new(a.Value / b.Value);
    }

    public static kN operator /(m a, m_kN b)
    {
        return new(a.Value / b.Value);
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
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
    return s;    }

}


/// <summary>
/// metre^2
/// </summary>
public readonly struct m2 : IUnitOfMeasure<m2>, IFormattable
{
    public static string Name => @"metre^2";
    public static string Suffix => @"m^2";
    public static string TexUnitString => @"\metre^2";
    public static string TexUnitsOnly => @$"\si{{ {TexUnitString} }}";
    public double Value { get; }
    public m2(double value)
    {
        Value = value;
    }

    public static implicit operator m2(double value)
    {
        return new(value);
    }

    public static implicit operator m2(int value)
    {
        return new(value);
    }

    public static implicit operator double(m2 x)
    {
        return x.Value;
    }

    public static m2 operator +(m2 a, m2 b)
    {
        return new(a.Value + b.Value);
    }

    public static m2 operator -(m2 a, m2 b)
    {
        return new(a.Value - b.Value);
    }

    public static m2 operator *(m2 a, int b)
    {
        return new(a.Value * b);
    }

    public static m2 operator *(m2 a, double b)
    {
        return new(a.Value * b);
    }

    public static m2 operator *(int a, m2 b)
    {
        return new(a * b.Value);
    }

    public static m2 operator *(double a, m2 b)
    {
        return new(a * b.Value);
    }

    public static double operator /(m2 a, m2 b)
    {
        return a.Value / b.Value;
    }

    public static m2 operator /(m2 a, int b)
    {
        return new(a.Value / b);
    }

    public static m2 operator /(m2 a, double b)
    {
        return new(a.Value / b);
    }

    public static m operator /(m2 a, m b)
    {
        return new(a.Value / b.Value);
    }

    public static implicit operator m2(mm2 x)
    {
        return new(x / 1000000);
    }

    public static m3 operator *(m2 a, m b)
    {
        return new(a.Value * b.Value);
    }

    public static N operator *(m2 a, Pa b)
    {
        return new(a.Value * b.Value);
    }

    public static double operator *(m2 a, per_m2 b)
    {
        return a.Value * b.Value;
    }

    public static m2_N operator /(m2 a, N b)
    {
        return new(a.Value / b.Value);
    }

    public static N operator /(m2 a, m2_N b)
    {
        return new(a.Value / b.Value);
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
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
    return s;    }

}


/// <summary>
/// metre^3
/// </summary>
public readonly struct m3 : IUnitOfMeasure<m3>, IFormattable
{
    public static string Name => @"metre^3";
    public static string Suffix => @"m^3";
    public static string TexUnitString => @"\metre^3";
    public static string TexUnitsOnly => @$"\si{{ {TexUnitString} }}";
    public double Value { get; }
    public m3(double value)
    {
        Value = value;
    }

    public static implicit operator m3(double value)
    {
        return new(value);
    }

    public static implicit operator m3(int value)
    {
        return new(value);
    }

    public static implicit operator double(m3 x)
    {
        return x.Value;
    }

    public static m3 operator +(m3 a, m3 b)
    {
        return new(a.Value + b.Value);
    }

    public static m3 operator -(m3 a, m3 b)
    {
        return new(a.Value - b.Value);
    }

    public static m3 operator *(m3 a, int b)
    {
        return new(a.Value * b);
    }

    public static m3 operator *(m3 a, double b)
    {
        return new(a.Value * b);
    }

    public static m3 operator *(int a, m3 b)
    {
        return new(a * b.Value);
    }

    public static m3 operator *(double a, m3 b)
    {
        return new(a * b.Value);
    }

    public static double operator /(m3 a, m3 b)
    {
        return a.Value / b.Value;
    }

    public static m3 operator /(m3 a, int b)
    {
        return new(a.Value / b);
    }

    public static m3 operator /(m3 a, double b)
    {
        return new(a.Value / b);
    }

    public static m2 operator /(m3 a, m b)
    {
        return new(a.Value / b.Value);
    }

    public static m operator /(m3 a, m2 b)
    {
        return new(a.Value / b.Value);
    }

    public static implicit operator m3(mm2 x)
    {
        return new(x / 1000000);
    }

    public static implicit operator m3(mm3 x)
    {
        return new(x / 1000000000);
    }

    public static double operator *(m3 a, per_m3 b)
    {
        return a.Value * b.Value;
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
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
    return s;    }

}


/// <summary>
/// second^2
/// </summary>
public readonly struct s2 : IUnitOfMeasure<s2>, IFormattable
{
    public static string Name => @"second^2";
    public static string Suffix => @"s^2";
    public static string TexUnitString => @"\second^2";
    public static string TexUnitsOnly => @$"\si{{ {TexUnitString} }}";
    public double Value { get; }
    public s2(double value)
    {
        Value = value;
    }

    public static implicit operator s2(double value)
    {
        return new(value);
    }

    public static implicit operator s2(int value)
    {
        return new(value);
    }

    public static implicit operator double(s2 x)
    {
        return x.Value;
    }

    public static s2 operator +(s2 a, s2 b)
    {
        return new(a.Value + b.Value);
    }

    public static s2 operator -(s2 a, s2 b)
    {
        return new(a.Value - b.Value);
    }

    public static s2 operator *(s2 a, int b)
    {
        return new(a.Value * b);
    }

    public static s2 operator *(s2 a, double b)
    {
        return new(a.Value * b);
    }

    public static s2 operator *(int a, s2 b)
    {
        return new(a * b.Value);
    }

    public static s2 operator *(double a, s2 b)
    {
        return new(a * b.Value);
    }

    public static double operator /(s2 a, s2 b)
    {
        return a.Value / b.Value;
    }

    public static s2 operator /(s2 a, int b)
    {
        return new(a.Value / b);
    }

    public static s2 operator /(s2 a, double b)
    {
        return new(a.Value / b);
    }

    public static s operator /(s2 a, s b)
    {
        return new(a.Value / b.Value);
    }

    public static double operator *(s2 a, per_s2 b)
    {
        return a.Value * b.Value;
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
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
    return s;    }

}


/// <summary>
/// millimetre^2
/// </summary>
public readonly struct mm2 : IUnitOfMeasure<mm2>, IFormattable
{
    public static string Name => @"millimetre^2";
    public static string Suffix => @"mm^2";
    public static string TexUnitString => @"\milli\metre^2";
    public static string TexUnitsOnly => @$"\si{{ {TexUnitString} }}";
    public double Value { get; }
    public mm2(double value)
    {
        Value = value;
    }

    public static implicit operator mm2(double value)
    {
        return new(value);
    }

    public static implicit operator mm2(int value)
    {
        return new(value);
    }

    public static implicit operator double(mm2 x)
    {
        return x.Value;
    }

    public static mm2 operator +(mm2 a, mm2 b)
    {
        return new(a.Value + b.Value);
    }

    public static mm2 operator -(mm2 a, mm2 b)
    {
        return new(a.Value - b.Value);
    }

    public static mm2 operator *(mm2 a, int b)
    {
        return new(a.Value * b);
    }

    public static mm2 operator *(mm2 a, double b)
    {
        return new(a.Value * b);
    }

    public static mm2 operator *(int a, mm2 b)
    {
        return new(a * b.Value);
    }

    public static mm2 operator *(double a, mm2 b)
    {
        return new(a * b.Value);
    }

    public static double operator /(mm2 a, mm2 b)
    {
        return a.Value / b.Value;
    }

    public static mm2 operator /(mm2 a, int b)
    {
        return new(a.Value / b);
    }

    public static mm2 operator /(mm2 a, double b)
    {
        return new(a.Value / b);
    }

    public static mm operator /(mm2 a, mm b)
    {
        return new(a.Value / b.Value);
    }

    public static mm3 operator *(mm2 a, mm b)
    {
        return new(a.Value * b.Value);
    }

    public static mm4 operator *(mm2 a, mm2 b)
    {
        return new(a.Value * b.Value);
    }

    public static double operator *(mm2 a, per_mm2 b)
    {
        return a.Value * b.Value;
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
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
    return s;    }

}


/// <summary>
/// millimetre^3
/// </summary>
public readonly struct mm3 : IUnitOfMeasure<mm3>, IFormattable
{
    public static string Name => @"millimetre^3";
    public static string Suffix => @"mm^3";
    public static string TexUnitString => @"\milli\metre^3";
    public static string TexUnitsOnly => @$"\si{{ {TexUnitString} }}";
    public double Value { get; }
    public mm3(double value)
    {
        Value = value;
    }

    public static implicit operator mm3(double value)
    {
        return new(value);
    }

    public static implicit operator mm3(int value)
    {
        return new(value);
    }

    public static implicit operator double(mm3 x)
    {
        return x.Value;
    }

    public static mm3 operator +(mm3 a, mm3 b)
    {
        return new(a.Value + b.Value);
    }

    public static mm3 operator -(mm3 a, mm3 b)
    {
        return new(a.Value - b.Value);
    }

    public static mm3 operator *(mm3 a, int b)
    {
        return new(a.Value * b);
    }

    public static mm3 operator *(mm3 a, double b)
    {
        return new(a.Value * b);
    }

    public static mm3 operator *(int a, mm3 b)
    {
        return new(a * b.Value);
    }

    public static mm3 operator *(double a, mm3 b)
    {
        return new(a * b.Value);
    }

    public static double operator /(mm3 a, mm3 b)
    {
        return a.Value / b.Value;
    }

    public static mm3 operator /(mm3 a, int b)
    {
        return new(a.Value / b);
    }

    public static mm3 operator /(mm3 a, double b)
    {
        return new(a.Value / b);
    }

    public static mm2 operator /(mm3 a, mm b)
    {
        return new(a.Value / b.Value);
    }

    public static mm operator /(mm3 a, mm2 b)
    {
        return new(a.Value / b.Value);
    }

    public static mm4 operator *(mm3 a, mm b)
    {
        return new(a.Value * b.Value);
    }

    public static double operator *(mm3 a, per_mm3 b)
    {
        return a.Value * b.Value;
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
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
    return s;    }

}


/// <summary>
/// millimetre^4
/// </summary>
public readonly struct mm4 : IUnitOfMeasure<mm4>, IFormattable
{
    public static string Name => @"millimetre^4";
    public static string Suffix => @"mm^4";
    public static string TexUnitString => @"\milli\metre^4";
    public static string TexUnitsOnly => @$"\si{{ {TexUnitString} }}";
    public double Value { get; }
    public mm4(double value)
    {
        Value = value;
    }

    public static implicit operator mm4(double value)
    {
        return new(value);
    }

    public static implicit operator mm4(int value)
    {
        return new(value);
    }

    public static implicit operator double(mm4 x)
    {
        return x.Value;
    }

    public static mm4 operator +(mm4 a, mm4 b)
    {
        return new(a.Value + b.Value);
    }

    public static mm4 operator -(mm4 a, mm4 b)
    {
        return new(a.Value - b.Value);
    }

    public static mm4 operator *(mm4 a, int b)
    {
        return new(a.Value * b);
    }

    public static mm4 operator *(mm4 a, double b)
    {
        return new(a.Value * b);
    }

    public static mm4 operator *(int a, mm4 b)
    {
        return new(a * b.Value);
    }

    public static mm4 operator *(double a, mm4 b)
    {
        return new(a * b.Value);
    }

    public static double operator /(mm4 a, mm4 b)
    {
        return a.Value / b.Value;
    }

    public static mm4 operator /(mm4 a, int b)
    {
        return new(a.Value / b);
    }

    public static mm4 operator /(mm4 a, double b)
    {
        return new(a.Value / b);
    }

    public static mm2 operator /(mm4 a, mm2 b)
    {
        return new(a.Value / b.Value);
    }

    public static mm3 operator /(mm4 a, mm b)
    {
        return new(a.Value / b.Value);
    }

    public static mm operator /(mm4 a, mm3 b)
    {
        return new(a.Value / b.Value);
    }

    public static double operator *(mm4 a, per_mm4 b)
    {
        return a.Value * b.Value;
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
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
    return s;    }

}


/// <summary>
/// kilogram
/// </summary>
public readonly struct kg : IUnitOfMeasure<kg>, IFormattable
{
    public static string Name => @"kilogram";
    public static string Suffix => @"kg";
    public static string TexUnitString => @"\kilo\gram";
    public static string TexUnitsOnly => @$"\si{{ {TexUnitString} }}";
    public double Value { get; }
    public kg(double value)
    {
        Value = value;
    }

    public static implicit operator kg(double value)
    {
        return new(value);
    }

    public static implicit operator kg(int value)
    {
        return new(value);
    }

    public static implicit operator double(kg x)
    {
        return x.Value;
    }

    public static kg operator +(kg a, kg b)
    {
        return new(a.Value + b.Value);
    }

    public static kg operator -(kg a, kg b)
    {
        return new(a.Value - b.Value);
    }

    public static kg operator *(kg a, int b)
    {
        return new(a.Value * b);
    }

    public static kg operator *(kg a, double b)
    {
        return new(a.Value * b);
    }

    public static kg operator *(int a, kg b)
    {
        return new(a * b.Value);
    }

    public static kg operator *(double a, kg b)
    {
        return new(a * b.Value);
    }

    public static double operator /(kg a, kg b)
    {
        return a.Value / b.Value;
    }

    public static kg operator /(kg a, int b)
    {
        return new(a.Value / b);
    }

    public static kg operator /(kg a, double b)
    {
        return new(a.Value / b);
    }

    public static implicit operator kg(g x)
    {
        return new(x.Value / 1000.0);
    }

    public static implicit operator kg(tonne x)
    {
        return new(x.Value * 1000.0);
    }

    public static N operator *(kg a, m_s b)
    {
        return new(a.Value * b.Value);
    }

    public static double operator *(kg a, per_kg b)
    {
        return a.Value * b.Value;
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
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
    return s;    }

}


/// <summary>
/// tonne
/// </summary>
public readonly struct tonne : IUnitOfMeasure<tonne>, IFormattable
{
    public static string Name => @"tonne";
    public static string Suffix => @"t";
    public static string TexUnitString => @"\tonne";
    public static string TexUnitsOnly => @$"\si{{ {TexUnitString} }}";
    public double Value { get; }
    public tonne(double value)
    {
        Value = value;
    }

    public static implicit operator tonne(double value)
    {
        return new(value);
    }

    public static implicit operator tonne(int value)
    {
        return new(value);
    }

    public static implicit operator double(tonne x)
    {
        return x.Value;
    }

    public static tonne operator +(tonne a, tonne b)
    {
        return new(a.Value + b.Value);
    }

    public static tonne operator -(tonne a, tonne b)
    {
        return new(a.Value - b.Value);
    }

    public static tonne operator *(tonne a, int b)
    {
        return new(a.Value * b);
    }

    public static tonne operator *(tonne a, double b)
    {
        return new(a.Value * b);
    }

    public static tonne operator *(int a, tonne b)
    {
        return new(a * b.Value);
    }

    public static tonne operator *(double a, tonne b)
    {
        return new(a * b.Value);
    }

    public static double operator /(tonne a, tonne b)
    {
        return a.Value / b.Value;
    }

    public static tonne operator /(tonne a, int b)
    {
        return new(a.Value / b);
    }

    public static tonne operator /(tonne a, double b)
    {
        return new(a.Value / b);
    }

    public static implicit operator tonne(kg x)
    {
        return new(x.Value / 1000.0);
    }

    public static double operator *(tonne a, per_tonne b)
    {
        return a.Value * b.Value;
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
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
    return s;    }

}


/// <summary>
/// metres per second
/// </summary>
public readonly struct m_s : IUnitOfMeasure<m_s>, IFormattable
{
    public static string Name => @"metres per second";
    public static string Suffix => @"m/s";
    public static string TexUnitString => @"\metre/\second";
    public static string TexUnitsOnly => @$"\si{{ {TexUnitString} }}";
    public double Value { get; }
    public m_s(double value)
    {
        Value = value;
    }

    public static implicit operator m_s(double value)
    {
        return new(value);
    }

    public static implicit operator m_s(int value)
    {
        return new(value);
    }

    public static implicit operator double(m_s x)
    {
        return x.Value;
    }

    public static m_s operator +(m_s a, m_s b)
    {
        return new(a.Value + b.Value);
    }

    public static m_s operator -(m_s a, m_s b)
    {
        return new(a.Value - b.Value);
    }

    public static m_s operator *(m_s a, int b)
    {
        return new(a.Value * b);
    }

    public static m_s operator *(m_s a, double b)
    {
        return new(a.Value * b);
    }

    public static m_s operator *(int a, m_s b)
    {
        return new(a * b.Value);
    }

    public static m_s operator *(double a, m_s b)
    {
        return new(a * b.Value);
    }

    public static double operator /(m_s a, m_s b)
    {
        return a.Value / b.Value;
    }

    public static m_s operator /(m_s a, int b)
    {
        return new(a.Value / b);
    }

    public static m_s operator /(m_s a, double b)
    {
        return new(a.Value / b);
    }

    public static m operator *(m_s a, s b)
    {
        return new(a.Value * b.Value);
    }

    public static N operator *(m_s a, kg b)
    {
        return new(a.Value * b.Value);
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
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
    return s;    }

}


/// <summary>
/// newton
/// </summary>
public readonly struct N : IUnitOfMeasure<N>, IFormattable
{
    public static string Name => @"newton";
    public static string Suffix => @"kg.m/s";
    public static string TexUnitString => @"\newton";
    public static string TexUnitsOnly => @$"\si{{ {TexUnitString} }}";
    public double Value { get; }
    public N(double value)
    {
        Value = value;
    }

    public static implicit operator N(double value)
    {
        return new(value);
    }

    public static implicit operator N(int value)
    {
        return new(value);
    }

    public static implicit operator double(N x)
    {
        return x.Value;
    }

    public static N operator +(N a, N b)
    {
        return new(a.Value + b.Value);
    }

    public static N operator -(N a, N b)
    {
        return new(a.Value - b.Value);
    }

    public static N operator *(N a, int b)
    {
        return new(a.Value * b);
    }

    public static N operator *(N a, double b)
    {
        return new(a.Value * b);
    }

    public static N operator *(int a, N b)
    {
        return new(a * b.Value);
    }

    public static N operator *(double a, N b)
    {
        return new(a * b.Value);
    }

    public static double operator /(N a, N b)
    {
        return a.Value / b.Value;
    }

    public static N operator /(N a, int b)
    {
        return new(a.Value / b);
    }

    public static N operator /(N a, double b)
    {
        return new(a.Value / b);
    }

    public static m_s operator /(N a, kg b)
    {
        return new(a.Value / b.Value);
    }

    public static kg operator /(N a, m_s b)
    {
        return new(a.Value / b.Value);
    }

    public static implicit operator N(kN x)
    {
        return new(x.Value * 1000.0);
    }

    public static Pa operator /(N a, m2 b)
    {
        return new(a.Value / b.Value);
    }

    public static m2 operator /(N a, Pa b)
    {
        return new(a.Value / b.Value);
    }

    public static double operator *(N a, per_N b)
    {
        return a.Value * b.Value;
    }

    public static m2 operator *(N a, m2_N b)
    {
        return new(a.Value * b.Value);
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
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
    return s;    }

}


/// <summary>
/// kilonewton
/// </summary>
public readonly struct kN : IUnitOfMeasure<kN>, IFormattable
{
    public static string Name => @"kilonewton";
    public static string Suffix => @"";
    public static string TexUnitString => @"\kilo\newton";
    public static string TexUnitsOnly => @$"\si{{ {TexUnitString} }}";
    public double Value { get; }
    public kN(double value)
    {
        Value = value;
    }

    public static implicit operator kN(double value)
    {
        return new(value);
    }

    public static implicit operator kN(int value)
    {
        return new(value);
    }

    public static implicit operator double(kN x)
    {
        return x.Value;
    }

    public static kN operator +(kN a, kN b)
    {
        return new(a.Value + b.Value);
    }

    public static kN operator -(kN a, kN b)
    {
        return new(a.Value - b.Value);
    }

    public static kN operator *(kN a, int b)
    {
        return new(a.Value * b);
    }

    public static kN operator *(kN a, double b)
    {
        return new(a.Value * b);
    }

    public static kN operator *(int a, kN b)
    {
        return new(a * b.Value);
    }

    public static kN operator *(double a, kN b)
    {
        return new(a * b.Value);
    }

    public static double operator /(kN a, kN b)
    {
        return a.Value / b.Value;
    }

    public static kN operator /(kN a, int b)
    {
        return new(a.Value / b);
    }

    public static kN operator /(kN a, double b)
    {
        return new(a.Value / b);
    }

    public static implicit operator kN(N x)
    {
        return new(x.Value / 1000.0);
    }

    public static kNm operator *(kN a, m b)
    {
        return new(a.Value * b.Value);
    }

    public static kN_m operator /(kN a, m b)
    {
        return new(a.Value / b.Value);
    }

    public static m operator /(kN a, kN_m b)
    {
        return new(a.Value / b.Value);
    }

    public static double operator *(kN a, per_kN b)
    {
        return a.Value * b.Value;
    }

    public static m operator *(kN a, m_kN b)
    {
        return new(a.Value * b.Value);
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
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
    return s;    }

}


/// <summary>
/// kilonewton.metre
/// </summary>
public readonly struct kNm : IUnitOfMeasure<kNm>, IFormattable
{
    public static string Name => @"kilonewton.metre";
    public static string Suffix => @".m";
    public static string TexUnitString => @"\kilo\newton\metre";
    public static string TexUnitsOnly => @$"\si{{ {TexUnitString} }}";
    public double Value { get; }
    public kNm(double value)
    {
        Value = value;
    }

    public static implicit operator kNm(double value)
    {
        return new(value);
    }

    public static implicit operator kNm(int value)
    {
        return new(value);
    }

    public static implicit operator double(kNm x)
    {
        return x.Value;
    }

    public static kNm operator +(kNm a, kNm b)
    {
        return new(a.Value + b.Value);
    }

    public static kNm operator -(kNm a, kNm b)
    {
        return new(a.Value - b.Value);
    }

    public static kNm operator *(kNm a, int b)
    {
        return new(a.Value * b);
    }

    public static kNm operator *(kNm a, double b)
    {
        return new(a.Value * b);
    }

    public static kNm operator *(int a, kNm b)
    {
        return new(a * b.Value);
    }

    public static kNm operator *(double a, kNm b)
    {
        return new(a * b.Value);
    }

    public static double operator /(kNm a, kNm b)
    {
        return a.Value / b.Value;
    }

    public static kNm operator /(kNm a, int b)
    {
        return new(a.Value / b);
    }

    public static kNm operator /(kNm a, double b)
    {
        return new(a.Value / b);
    }

    public static m operator /(kNm a, kN b)
    {
        return new(a.Value / b.Value);
    }

    public static kN operator /(kNm a, m b)
    {
        return new(a.Value / b.Value);
    }

    public static double operator *(kNm a, per_kNm b)
    {
        return a.Value * b.Value;
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
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
    return s;    }

}


/// <summary>
/// kilonewton / metre
/// </summary>
public readonly struct kN_m : IUnitOfMeasure<kN_m>, IFormattable
{
    public static string Name => @"kilonewton / metre";
    public static string Suffix => @"/m";
    public static string TexUnitString => @"\kilo\newton/\metre";
    public static string TexUnitsOnly => @$"\si{{ {TexUnitString} }}";
    public double Value { get; }
    public kN_m(double value)
    {
        Value = value;
    }

    public static implicit operator kN_m(double value)
    {
        return new(value);
    }

    public static implicit operator kN_m(int value)
    {
        return new(value);
    }

    public static implicit operator double(kN_m x)
    {
        return x.Value;
    }

    public static kN_m operator +(kN_m a, kN_m b)
    {
        return new(a.Value + b.Value);
    }

    public static kN_m operator -(kN_m a, kN_m b)
    {
        return new(a.Value - b.Value);
    }

    public static kN_m operator *(kN_m a, int b)
    {
        return new(a.Value * b);
    }

    public static kN_m operator *(kN_m a, double b)
    {
        return new(a.Value * b);
    }

    public static kN_m operator *(int a, kN_m b)
    {
        return new(a * b.Value);
    }

    public static kN_m operator *(double a, kN_m b)
    {
        return new(a * b.Value);
    }

    public static double operator /(kN_m a, kN_m b)
    {
        return a.Value / b.Value;
    }

    public static kN_m operator /(kN_m a, int b)
    {
        return new(a.Value / b);
    }

    public static kN_m operator /(kN_m a, double b)
    {
        return new(a.Value / b);
    }

    public static kN operator *(kN_m a, m b)
    {
        return new(a.Value * b.Value);
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
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
    return s;    }

}


/// <summary>
/// pascal
/// </summary>
public readonly struct Pa : IUnitOfMeasure<Pa>, IFormattable
{
    public static string Name => @"pascal";
    public static string Suffix => @"kg.m/s/m^2";
    public static string TexUnitString => @"\pascal";
    public static string TexUnitsOnly => @$"\si{{ {TexUnitString} }}";
    public double Value { get; }
    public Pa(double value)
    {
        Value = value;
    }

    public static implicit operator Pa(double value)
    {
        return new(value);
    }

    public static implicit operator Pa(int value)
    {
        return new(value);
    }

    public static implicit operator double(Pa x)
    {
        return x.Value;
    }

    public static Pa operator +(Pa a, Pa b)
    {
        return new(a.Value + b.Value);
    }

    public static Pa operator -(Pa a, Pa b)
    {
        return new(a.Value - b.Value);
    }

    public static Pa operator *(Pa a, int b)
    {
        return new(a.Value * b);
    }

    public static Pa operator *(Pa a, double b)
    {
        return new(a.Value * b);
    }

    public static Pa operator *(int a, Pa b)
    {
        return new(a * b.Value);
    }

    public static Pa operator *(double a, Pa b)
    {
        return new(a * b.Value);
    }

    public static double operator /(Pa a, Pa b)
    {
        return a.Value / b.Value;
    }

    public static Pa operator /(Pa a, int b)
    {
        return new(a.Value / b);
    }

    public static Pa operator /(Pa a, double b)
    {
        return new(a.Value / b);
    }

    public static N operator *(Pa a, m2 b)
    {
        return new(a.Value * b.Value);
    }

    public static implicit operator Pa(kPa x)
    {
        return new(x.Value * 1000.0);
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
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
    return s;    }

}


/// <summary>
/// kilopascal
/// </summary>
public readonly struct kPa : IUnitOfMeasure<kPa>, IFormattable
{
    public static string Name => @"kilopascal";
    public static string Suffix => @"";
    public static string TexUnitString => @"\kilo\pascal";
    public static string TexUnitsOnly => @$"\si{{ {TexUnitString} }}";
    public double Value { get; }
    public kPa(double value)
    {
        Value = value;
    }

    public static implicit operator kPa(double value)
    {
        return new(value);
    }

    public static implicit operator kPa(int value)
    {
        return new(value);
    }

    public static implicit operator double(kPa x)
    {
        return x.Value;
    }

    public static kPa operator +(kPa a, kPa b)
    {
        return new(a.Value + b.Value);
    }

    public static kPa operator -(kPa a, kPa b)
    {
        return new(a.Value - b.Value);
    }

    public static kPa operator *(kPa a, int b)
    {
        return new(a.Value * b);
    }

    public static kPa operator *(kPa a, double b)
    {
        return new(a.Value * b);
    }

    public static kPa operator *(int a, kPa b)
    {
        return new(a * b.Value);
    }

    public static kPa operator *(double a, kPa b)
    {
        return new(a * b.Value);
    }

    public static double operator /(kPa a, kPa b)
    {
        return a.Value / b.Value;
    }

    public static kPa operator /(kPa a, int b)
    {
        return new(a.Value / b);
    }

    public static kPa operator /(kPa a, double b)
    {
        return new(a.Value / b);
    }

    public static implicit operator kPa(Pa x)
    {
        return new(x.Value / 1000.0);
    }

    public static implicit operator kPa(MPa x)
    {
        return new(x.Value * 1000.0);
    }

    public static double operator *(kPa a, per_kPa b)
    {
        return a.Value * b.Value;
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
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
    return s;    }

}


/// <summary>
/// megapascal
/// </summary>
public readonly struct MPa : IUnitOfMeasure<MPa>, IFormattable
{
    public static string Name => @"megapascal";
    public static string Suffix => @"";
    public static string TexUnitString => @"\mega\pascal";
    public static string TexUnitsOnly => @$"\si{{ {TexUnitString} }}";
    public double Value { get; }
    public MPa(double value)
    {
        Value = value;
    }

    public static implicit operator MPa(double value)
    {
        return new(value);
    }

    public static implicit operator MPa(int value)
    {
        return new(value);
    }

    public static implicit operator double(MPa x)
    {
        return x.Value;
    }

    public static MPa operator +(MPa a, MPa b)
    {
        return new(a.Value + b.Value);
    }

    public static MPa operator -(MPa a, MPa b)
    {
        return new(a.Value - b.Value);
    }

    public static MPa operator *(MPa a, int b)
    {
        return new(a.Value * b);
    }

    public static MPa operator *(MPa a, double b)
    {
        return new(a.Value * b);
    }

    public static MPa operator *(int a, MPa b)
    {
        return new(a * b.Value);
    }

    public static MPa operator *(double a, MPa b)
    {
        return new(a * b.Value);
    }

    public static double operator /(MPa a, MPa b)
    {
        return a.Value / b.Value;
    }

    public static MPa operator /(MPa a, int b)
    {
        return new(a.Value / b);
    }

    public static MPa operator /(MPa a, double b)
    {
        return new(a.Value / b);
    }

    public static implicit operator MPa(kPa x)
    {
        return new(x.Value / 1000.0);
    }

    public static double operator *(MPa a, per_MPa b)
    {
        return a.Value * b.Value;
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
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
    return s;    }

}


/// <summary>
/// 1/millimetre
/// </summary>
public readonly struct per_mm : IUnitOfMeasure<per_mm>, IFormattable
{
    public static string Name => @"1/millimetre";
    public static string Suffix => @"1/mm";
    public static string TexUnitString => @"1/\milli\metre";
    public static string TexUnitsOnly => @$"\si{{ {TexUnitString} }}";
    public double Value { get; }
    public per_mm(double value)
    {
        Value = value;
    }

    public static implicit operator per_mm(double value)
    {
        return new(value);
    }

    public static implicit operator per_mm(int value)
    {
        return new(value);
    }

    public static implicit operator double(per_mm x)
    {
        return x.Value;
    }

    public static per_mm operator +(per_mm a, per_mm b)
    {
        return new(a.Value + b.Value);
    }

    public static per_mm operator -(per_mm a, per_mm b)
    {
        return new(a.Value - b.Value);
    }

    public static per_mm operator *(per_mm a, int b)
    {
        return new(a.Value * b);
    }

    public static per_mm operator *(per_mm a, double b)
    {
        return new(a.Value * b);
    }

    public static per_mm operator *(int a, per_mm b)
    {
        return new(a * b.Value);
    }

    public static per_mm operator *(double a, per_mm b)
    {
        return new(a * b.Value);
    }

    public static double operator /(per_mm a, per_mm b)
    {
        return a.Value / b.Value;
    }

    public static per_mm operator /(per_mm a, int b)
    {
        return new(a.Value / b);
    }

    public static per_mm operator /(per_mm a, double b)
    {
        return new(a.Value / b);
    }

    public static double operator *(per_mm a, mm b)
    {
        return a.Value * b.Value;
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
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
    return s;    }

}


/// <summary>
/// 1/gram
/// </summary>
public readonly struct per_g : IUnitOfMeasure<per_g>, IFormattable
{
    public static string Name => @"1/gram";
    public static string Suffix => @"1/g";
    public static string TexUnitString => @"1/\gram";
    public static string TexUnitsOnly => @$"\si{{ {TexUnitString} }}";
    public double Value { get; }
    public per_g(double value)
    {
        Value = value;
    }

    public static implicit operator per_g(double value)
    {
        return new(value);
    }

    public static implicit operator per_g(int value)
    {
        return new(value);
    }

    public static implicit operator double(per_g x)
    {
        return x.Value;
    }

    public static per_g operator +(per_g a, per_g b)
    {
        return new(a.Value + b.Value);
    }

    public static per_g operator -(per_g a, per_g b)
    {
        return new(a.Value - b.Value);
    }

    public static per_g operator *(per_g a, int b)
    {
        return new(a.Value * b);
    }

    public static per_g operator *(per_g a, double b)
    {
        return new(a.Value * b);
    }

    public static per_g operator *(int a, per_g b)
    {
        return new(a * b.Value);
    }

    public static per_g operator *(double a, per_g b)
    {
        return new(a * b.Value);
    }

    public static double operator /(per_g a, per_g b)
    {
        return a.Value / b.Value;
    }

    public static per_g operator /(per_g a, int b)
    {
        return new(a.Value / b);
    }

    public static per_g operator /(per_g a, double b)
    {
        return new(a.Value / b);
    }

    public static double operator *(per_g a, g b)
    {
        return a.Value * b.Value;
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
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
    return s;    }

}


/// <summary>
/// 1/second
/// </summary>
public readonly struct per_s : IUnitOfMeasure<per_s>, IFormattable
{
    public static string Name => @"1/second";
    public static string Suffix => @"1/s";
    public static string TexUnitString => @"1/\second";
    public static string TexUnitsOnly => @$"\si{{ {TexUnitString} }}";
    public double Value { get; }
    public per_s(double value)
    {
        Value = value;
    }

    public static implicit operator per_s(double value)
    {
        return new(value);
    }

    public static implicit operator per_s(int value)
    {
        return new(value);
    }

    public static implicit operator double(per_s x)
    {
        return x.Value;
    }

    public static per_s operator +(per_s a, per_s b)
    {
        return new(a.Value + b.Value);
    }

    public static per_s operator -(per_s a, per_s b)
    {
        return new(a.Value - b.Value);
    }

    public static per_s operator *(per_s a, int b)
    {
        return new(a.Value * b);
    }

    public static per_s operator *(per_s a, double b)
    {
        return new(a.Value * b);
    }

    public static per_s operator *(int a, per_s b)
    {
        return new(a * b.Value);
    }

    public static per_s operator *(double a, per_s b)
    {
        return new(a * b.Value);
    }

    public static double operator /(per_s a, per_s b)
    {
        return a.Value / b.Value;
    }

    public static per_s operator /(per_s a, int b)
    {
        return new(a.Value / b);
    }

    public static per_s operator /(per_s a, double b)
    {
        return new(a.Value / b);
    }

    public static double operator *(per_s a, s b)
    {
        return a.Value * b.Value;
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
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
    return s;    }

}


/// <summary>
/// 1/metre
/// </summary>
public readonly struct per_m : IUnitOfMeasure<per_m>, IFormattable
{
    public static string Name => @"1/metre";
    public static string Suffix => @"1/m";
    public static string TexUnitString => @"1/\metre";
    public static string TexUnitsOnly => @$"\si{{ {TexUnitString} }}";
    public double Value { get; }
    public per_m(double value)
    {
        Value = value;
    }

    public static implicit operator per_m(double value)
    {
        return new(value);
    }

    public static implicit operator per_m(int value)
    {
        return new(value);
    }

    public static implicit operator double(per_m x)
    {
        return x.Value;
    }

    public static per_m operator +(per_m a, per_m b)
    {
        return new(a.Value + b.Value);
    }

    public static per_m operator -(per_m a, per_m b)
    {
        return new(a.Value - b.Value);
    }

    public static per_m operator *(per_m a, int b)
    {
        return new(a.Value * b);
    }

    public static per_m operator *(per_m a, double b)
    {
        return new(a.Value * b);
    }

    public static per_m operator *(int a, per_m b)
    {
        return new(a * b.Value);
    }

    public static per_m operator *(double a, per_m b)
    {
        return new(a * b.Value);
    }

    public static double operator /(per_m a, per_m b)
    {
        return a.Value / b.Value;
    }

    public static per_m operator /(per_m a, int b)
    {
        return new(a.Value / b);
    }

    public static per_m operator /(per_m a, double b)
    {
        return new(a.Value / b);
    }

    public static double operator *(per_m a, m b)
    {
        return a.Value * b.Value;
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
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
    return s;    }

}


/// <summary>
/// 1/metre^2
/// </summary>
public readonly struct per_m2 : IUnitOfMeasure<per_m2>, IFormattable
{
    public static string Name => @"1/metre^2";
    public static string Suffix => @"1/m^2";
    public static string TexUnitString => @"1/\metre^2";
    public static string TexUnitsOnly => @$"\si{{ {TexUnitString} }}";
    public double Value { get; }
    public per_m2(double value)
    {
        Value = value;
    }

    public static implicit operator per_m2(double value)
    {
        return new(value);
    }

    public static implicit operator per_m2(int value)
    {
        return new(value);
    }

    public static implicit operator double(per_m2 x)
    {
        return x.Value;
    }

    public static per_m2 operator +(per_m2 a, per_m2 b)
    {
        return new(a.Value + b.Value);
    }

    public static per_m2 operator -(per_m2 a, per_m2 b)
    {
        return new(a.Value - b.Value);
    }

    public static per_m2 operator *(per_m2 a, int b)
    {
        return new(a.Value * b);
    }

    public static per_m2 operator *(per_m2 a, double b)
    {
        return new(a.Value * b);
    }

    public static per_m2 operator *(int a, per_m2 b)
    {
        return new(a * b.Value);
    }

    public static per_m2 operator *(double a, per_m2 b)
    {
        return new(a * b.Value);
    }

    public static double operator /(per_m2 a, per_m2 b)
    {
        return a.Value / b.Value;
    }

    public static per_m2 operator /(per_m2 a, int b)
    {
        return new(a.Value / b);
    }

    public static per_m2 operator /(per_m2 a, double b)
    {
        return new(a.Value / b);
    }

    public static double operator *(per_m2 a, m2 b)
    {
        return a.Value * b.Value;
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
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
    return s;    }

}


/// <summary>
/// 1/metre^3
/// </summary>
public readonly struct per_m3 : IUnitOfMeasure<per_m3>, IFormattable
{
    public static string Name => @"1/metre^3";
    public static string Suffix => @"1/m^3";
    public static string TexUnitString => @"1/\metre^3";
    public static string TexUnitsOnly => @$"\si{{ {TexUnitString} }}";
    public double Value { get; }
    public per_m3(double value)
    {
        Value = value;
    }

    public static implicit operator per_m3(double value)
    {
        return new(value);
    }

    public static implicit operator per_m3(int value)
    {
        return new(value);
    }

    public static implicit operator double(per_m3 x)
    {
        return x.Value;
    }

    public static per_m3 operator +(per_m3 a, per_m3 b)
    {
        return new(a.Value + b.Value);
    }

    public static per_m3 operator -(per_m3 a, per_m3 b)
    {
        return new(a.Value - b.Value);
    }

    public static per_m3 operator *(per_m3 a, int b)
    {
        return new(a.Value * b);
    }

    public static per_m3 operator *(per_m3 a, double b)
    {
        return new(a.Value * b);
    }

    public static per_m3 operator *(int a, per_m3 b)
    {
        return new(a * b.Value);
    }

    public static per_m3 operator *(double a, per_m3 b)
    {
        return new(a * b.Value);
    }

    public static double operator /(per_m3 a, per_m3 b)
    {
        return a.Value / b.Value;
    }

    public static per_m3 operator /(per_m3 a, int b)
    {
        return new(a.Value / b);
    }

    public static per_m3 operator /(per_m3 a, double b)
    {
        return new(a.Value / b);
    }

    public static double operator *(per_m3 a, m3 b)
    {
        return a.Value * b.Value;
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
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
    return s;    }

}


/// <summary>
/// 1/second^2
/// </summary>
public readonly struct per_s2 : IUnitOfMeasure<per_s2>, IFormattable
{
    public static string Name => @"1/second^2";
    public static string Suffix => @"1/s^2";
    public static string TexUnitString => @"1/\second^2";
    public static string TexUnitsOnly => @$"\si{{ {TexUnitString} }}";
    public double Value { get; }
    public per_s2(double value)
    {
        Value = value;
    }

    public static implicit operator per_s2(double value)
    {
        return new(value);
    }

    public static implicit operator per_s2(int value)
    {
        return new(value);
    }

    public static implicit operator double(per_s2 x)
    {
        return x.Value;
    }

    public static per_s2 operator +(per_s2 a, per_s2 b)
    {
        return new(a.Value + b.Value);
    }

    public static per_s2 operator -(per_s2 a, per_s2 b)
    {
        return new(a.Value - b.Value);
    }

    public static per_s2 operator *(per_s2 a, int b)
    {
        return new(a.Value * b);
    }

    public static per_s2 operator *(per_s2 a, double b)
    {
        return new(a.Value * b);
    }

    public static per_s2 operator *(int a, per_s2 b)
    {
        return new(a * b.Value);
    }

    public static per_s2 operator *(double a, per_s2 b)
    {
        return new(a * b.Value);
    }

    public static double operator /(per_s2 a, per_s2 b)
    {
        return a.Value / b.Value;
    }

    public static per_s2 operator /(per_s2 a, int b)
    {
        return new(a.Value / b);
    }

    public static per_s2 operator /(per_s2 a, double b)
    {
        return new(a.Value / b);
    }

    public static double operator *(per_s2 a, s2 b)
    {
        return a.Value * b.Value;
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
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
    return s;    }

}


/// <summary>
/// 1/millimetre^2
/// </summary>
public readonly struct per_mm2 : IUnitOfMeasure<per_mm2>, IFormattable
{
    public static string Name => @"1/millimetre^2";
    public static string Suffix => @"1/mm^2";
    public static string TexUnitString => @"1/\milli\metre^2";
    public static string TexUnitsOnly => @$"\si{{ {TexUnitString} }}";
    public double Value { get; }
    public per_mm2(double value)
    {
        Value = value;
    }

    public static implicit operator per_mm2(double value)
    {
        return new(value);
    }

    public static implicit operator per_mm2(int value)
    {
        return new(value);
    }

    public static implicit operator double(per_mm2 x)
    {
        return x.Value;
    }

    public static per_mm2 operator +(per_mm2 a, per_mm2 b)
    {
        return new(a.Value + b.Value);
    }

    public static per_mm2 operator -(per_mm2 a, per_mm2 b)
    {
        return new(a.Value - b.Value);
    }

    public static per_mm2 operator *(per_mm2 a, int b)
    {
        return new(a.Value * b);
    }

    public static per_mm2 operator *(per_mm2 a, double b)
    {
        return new(a.Value * b);
    }

    public static per_mm2 operator *(int a, per_mm2 b)
    {
        return new(a * b.Value);
    }

    public static per_mm2 operator *(double a, per_mm2 b)
    {
        return new(a * b.Value);
    }

    public static double operator /(per_mm2 a, per_mm2 b)
    {
        return a.Value / b.Value;
    }

    public static per_mm2 operator /(per_mm2 a, int b)
    {
        return new(a.Value / b);
    }

    public static per_mm2 operator /(per_mm2 a, double b)
    {
        return new(a.Value / b);
    }

    public static double operator *(per_mm2 a, mm2 b)
    {
        return a.Value * b.Value;
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
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
    return s;    }

}


/// <summary>
/// 1/millimetre^3
/// </summary>
public readonly struct per_mm3 : IUnitOfMeasure<per_mm3>, IFormattable
{
    public static string Name => @"1/millimetre^3";
    public static string Suffix => @"1/mm^3";
    public static string TexUnitString => @"1/\milli\metre^3";
    public static string TexUnitsOnly => @$"\si{{ {TexUnitString} }}";
    public double Value { get; }
    public per_mm3(double value)
    {
        Value = value;
    }

    public static implicit operator per_mm3(double value)
    {
        return new(value);
    }

    public static implicit operator per_mm3(int value)
    {
        return new(value);
    }

    public static implicit operator double(per_mm3 x)
    {
        return x.Value;
    }

    public static per_mm3 operator +(per_mm3 a, per_mm3 b)
    {
        return new(a.Value + b.Value);
    }

    public static per_mm3 operator -(per_mm3 a, per_mm3 b)
    {
        return new(a.Value - b.Value);
    }

    public static per_mm3 operator *(per_mm3 a, int b)
    {
        return new(a.Value * b);
    }

    public static per_mm3 operator *(per_mm3 a, double b)
    {
        return new(a.Value * b);
    }

    public static per_mm3 operator *(int a, per_mm3 b)
    {
        return new(a * b.Value);
    }

    public static per_mm3 operator *(double a, per_mm3 b)
    {
        return new(a * b.Value);
    }

    public static double operator /(per_mm3 a, per_mm3 b)
    {
        return a.Value / b.Value;
    }

    public static per_mm3 operator /(per_mm3 a, int b)
    {
        return new(a.Value / b);
    }

    public static per_mm3 operator /(per_mm3 a, double b)
    {
        return new(a.Value / b);
    }

    public static double operator *(per_mm3 a, mm3 b)
    {
        return a.Value * b.Value;
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
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
    return s;    }

}


/// <summary>
/// 1/millimetre^4
/// </summary>
public readonly struct per_mm4 : IUnitOfMeasure<per_mm4>, IFormattable
{
    public static string Name => @"1/millimetre^4";
    public static string Suffix => @"1/mm^4";
    public static string TexUnitString => @"1/\milli\metre^4";
    public static string TexUnitsOnly => @$"\si{{ {TexUnitString} }}";
    public double Value { get; }
    public per_mm4(double value)
    {
        Value = value;
    }

    public static implicit operator per_mm4(double value)
    {
        return new(value);
    }

    public static implicit operator per_mm4(int value)
    {
        return new(value);
    }

    public static implicit operator double(per_mm4 x)
    {
        return x.Value;
    }

    public static per_mm4 operator +(per_mm4 a, per_mm4 b)
    {
        return new(a.Value + b.Value);
    }

    public static per_mm4 operator -(per_mm4 a, per_mm4 b)
    {
        return new(a.Value - b.Value);
    }

    public static per_mm4 operator *(per_mm4 a, int b)
    {
        return new(a.Value * b);
    }

    public static per_mm4 operator *(per_mm4 a, double b)
    {
        return new(a.Value * b);
    }

    public static per_mm4 operator *(int a, per_mm4 b)
    {
        return new(a * b.Value);
    }

    public static per_mm4 operator *(double a, per_mm4 b)
    {
        return new(a * b.Value);
    }

    public static double operator /(per_mm4 a, per_mm4 b)
    {
        return a.Value / b.Value;
    }

    public static per_mm4 operator /(per_mm4 a, int b)
    {
        return new(a.Value / b);
    }

    public static per_mm4 operator /(per_mm4 a, double b)
    {
        return new(a.Value / b);
    }

    public static double operator *(per_mm4 a, mm4 b)
    {
        return a.Value * b.Value;
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
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
    return s;    }

}


/// <summary>
/// 1/kilogram
/// </summary>
public readonly struct per_kg : IUnitOfMeasure<per_kg>, IFormattable
{
    public static string Name => @"1/kilogram";
    public static string Suffix => @"1/kg";
    public static string TexUnitString => @"1/\kilo\gram";
    public static string TexUnitsOnly => @$"\si{{ {TexUnitString} }}";
    public double Value { get; }
    public per_kg(double value)
    {
        Value = value;
    }

    public static implicit operator per_kg(double value)
    {
        return new(value);
    }

    public static implicit operator per_kg(int value)
    {
        return new(value);
    }

    public static implicit operator double(per_kg x)
    {
        return x.Value;
    }

    public static per_kg operator +(per_kg a, per_kg b)
    {
        return new(a.Value + b.Value);
    }

    public static per_kg operator -(per_kg a, per_kg b)
    {
        return new(a.Value - b.Value);
    }

    public static per_kg operator *(per_kg a, int b)
    {
        return new(a.Value * b);
    }

    public static per_kg operator *(per_kg a, double b)
    {
        return new(a.Value * b);
    }

    public static per_kg operator *(int a, per_kg b)
    {
        return new(a * b.Value);
    }

    public static per_kg operator *(double a, per_kg b)
    {
        return new(a * b.Value);
    }

    public static double operator /(per_kg a, per_kg b)
    {
        return a.Value / b.Value;
    }

    public static per_kg operator /(per_kg a, int b)
    {
        return new(a.Value / b);
    }

    public static per_kg operator /(per_kg a, double b)
    {
        return new(a.Value / b);
    }

    public static double operator *(per_kg a, kg b)
    {
        return a.Value * b.Value;
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
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
    return s;    }

}


/// <summary>
/// 1/tonne
/// </summary>
public readonly struct per_tonne : IUnitOfMeasure<per_tonne>, IFormattable
{
    public static string Name => @"1/tonne";
    public static string Suffix => @"1/t";
    public static string TexUnitString => @"1/\tonne";
    public static string TexUnitsOnly => @$"\si{{ {TexUnitString} }}";
    public double Value { get; }
    public per_tonne(double value)
    {
        Value = value;
    }

    public static implicit operator per_tonne(double value)
    {
        return new(value);
    }

    public static implicit operator per_tonne(int value)
    {
        return new(value);
    }

    public static implicit operator double(per_tonne x)
    {
        return x.Value;
    }

    public static per_tonne operator +(per_tonne a, per_tonne b)
    {
        return new(a.Value + b.Value);
    }

    public static per_tonne operator -(per_tonne a, per_tonne b)
    {
        return new(a.Value - b.Value);
    }

    public static per_tonne operator *(per_tonne a, int b)
    {
        return new(a.Value * b);
    }

    public static per_tonne operator *(per_tonne a, double b)
    {
        return new(a.Value * b);
    }

    public static per_tonne operator *(int a, per_tonne b)
    {
        return new(a * b.Value);
    }

    public static per_tonne operator *(double a, per_tonne b)
    {
        return new(a * b.Value);
    }

    public static double operator /(per_tonne a, per_tonne b)
    {
        return a.Value / b.Value;
    }

    public static per_tonne operator /(per_tonne a, int b)
    {
        return new(a.Value / b);
    }

    public static per_tonne operator /(per_tonne a, double b)
    {
        return new(a.Value / b);
    }

    public static double operator *(per_tonne a, tonne b)
    {
        return a.Value * b.Value;
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
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
    return s;    }

}


/// <summary>
/// second / metre
/// </summary>
public readonly struct s_m : IUnitOfMeasure<s_m>, IFormattable
{
    public static string Name => @"second / metre";
    public static string Suffix => @"s/m";
    public static string TexUnitString => @"\second/\metre";
    public static string TexUnitsOnly => @$"\si{{ {TexUnitString} }}";
    public double Value { get; }
    public s_m(double value)
    {
        Value = value;
    }

    public static implicit operator s_m(double value)
    {
        return new(value);
    }

    public static implicit operator s_m(int value)
    {
        return new(value);
    }

    public static implicit operator double(s_m x)
    {
        return x.Value;
    }

    public static s_m operator +(s_m a, s_m b)
    {
        return new(a.Value + b.Value);
    }

    public static s_m operator -(s_m a, s_m b)
    {
        return new(a.Value - b.Value);
    }

    public static s_m operator *(s_m a, int b)
    {
        return new(a.Value * b);
    }

    public static s_m operator *(s_m a, double b)
    {
        return new(a.Value * b);
    }

    public static s_m operator *(int a, s_m b)
    {
        return new(a * b.Value);
    }

    public static s_m operator *(double a, s_m b)
    {
        return new(a * b.Value);
    }

    public static double operator /(s_m a, s_m b)
    {
        return a.Value / b.Value;
    }

    public static s_m operator /(s_m a, int b)
    {
        return new(a.Value / b);
    }

    public static s_m operator /(s_m a, double b)
    {
        return new(a.Value / b);
    }

    public static s operator *(s_m a, m b)
    {
        return new(a.Value * b.Value);
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
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
    return s;    }

}


/// <summary>
/// 1/newton
/// </summary>
public readonly struct per_N : IUnitOfMeasure<per_N>, IFormattable
{
    public static string Name => @"1/newton";
    public static string Suffix => @"1/kg.m/s";
    public static string TexUnitString => @"1/\newton";
    public static string TexUnitsOnly => @$"\si{{ {TexUnitString} }}";
    public double Value { get; }
    public per_N(double value)
    {
        Value = value;
    }

    public static implicit operator per_N(double value)
    {
        return new(value);
    }

    public static implicit operator per_N(int value)
    {
        return new(value);
    }

    public static implicit operator double(per_N x)
    {
        return x.Value;
    }

    public static per_N operator +(per_N a, per_N b)
    {
        return new(a.Value + b.Value);
    }

    public static per_N operator -(per_N a, per_N b)
    {
        return new(a.Value - b.Value);
    }

    public static per_N operator *(per_N a, int b)
    {
        return new(a.Value * b);
    }

    public static per_N operator *(per_N a, double b)
    {
        return new(a.Value * b);
    }

    public static per_N operator *(int a, per_N b)
    {
        return new(a * b.Value);
    }

    public static per_N operator *(double a, per_N b)
    {
        return new(a * b.Value);
    }

    public static double operator /(per_N a, per_N b)
    {
        return a.Value / b.Value;
    }

    public static per_N operator /(per_N a, int b)
    {
        return new(a.Value / b);
    }

    public static per_N operator /(per_N a, double b)
    {
        return new(a.Value / b);
    }

    public static double operator *(per_N a, N b)
    {
        return a.Value * b.Value;
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
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
    return s;    }

}


/// <summary>
/// 1/kilonewton
/// </summary>
public readonly struct per_kN : IUnitOfMeasure<per_kN>, IFormattable
{
    public static string Name => @"1/kilonewton";
    public static string Suffix => @"1/";
    public static string TexUnitString => @"1/\kilo\newton";
    public static string TexUnitsOnly => @$"\si{{ {TexUnitString} }}";
    public double Value { get; }
    public per_kN(double value)
    {
        Value = value;
    }

    public static implicit operator per_kN(double value)
    {
        return new(value);
    }

    public static implicit operator per_kN(int value)
    {
        return new(value);
    }

    public static implicit operator double(per_kN x)
    {
        return x.Value;
    }

    public static per_kN operator +(per_kN a, per_kN b)
    {
        return new(a.Value + b.Value);
    }

    public static per_kN operator -(per_kN a, per_kN b)
    {
        return new(a.Value - b.Value);
    }

    public static per_kN operator *(per_kN a, int b)
    {
        return new(a.Value * b);
    }

    public static per_kN operator *(per_kN a, double b)
    {
        return new(a.Value * b);
    }

    public static per_kN operator *(int a, per_kN b)
    {
        return new(a * b.Value);
    }

    public static per_kN operator *(double a, per_kN b)
    {
        return new(a * b.Value);
    }

    public static double operator /(per_kN a, per_kN b)
    {
        return a.Value / b.Value;
    }

    public static per_kN operator /(per_kN a, int b)
    {
        return new(a.Value / b);
    }

    public static per_kN operator /(per_kN a, double b)
    {
        return new(a.Value / b);
    }

    public static double operator *(per_kN a, kN b)
    {
        return a.Value * b.Value;
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
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
    return s;    }

}


/// <summary>
/// 1/kilonewton.metre
/// </summary>
public readonly struct per_kNm : IUnitOfMeasure<per_kNm>, IFormattable
{
    public static string Name => @"1/kilonewton.metre";
    public static string Suffix => @"1/.m";
    public static string TexUnitString => @"1/\kilo\newton\metre";
    public static string TexUnitsOnly => @$"\si{{ {TexUnitString} }}";
    public double Value { get; }
    public per_kNm(double value)
    {
        Value = value;
    }

    public static implicit operator per_kNm(double value)
    {
        return new(value);
    }

    public static implicit operator per_kNm(int value)
    {
        return new(value);
    }

    public static implicit operator double(per_kNm x)
    {
        return x.Value;
    }

    public static per_kNm operator +(per_kNm a, per_kNm b)
    {
        return new(a.Value + b.Value);
    }

    public static per_kNm operator -(per_kNm a, per_kNm b)
    {
        return new(a.Value - b.Value);
    }

    public static per_kNm operator *(per_kNm a, int b)
    {
        return new(a.Value * b);
    }

    public static per_kNm operator *(per_kNm a, double b)
    {
        return new(a.Value * b);
    }

    public static per_kNm operator *(int a, per_kNm b)
    {
        return new(a * b.Value);
    }

    public static per_kNm operator *(double a, per_kNm b)
    {
        return new(a * b.Value);
    }

    public static double operator /(per_kNm a, per_kNm b)
    {
        return a.Value / b.Value;
    }

    public static per_kNm operator /(per_kNm a, int b)
    {
        return new(a.Value / b);
    }

    public static per_kNm operator /(per_kNm a, double b)
    {
        return new(a.Value / b);
    }

    public static double operator *(per_kNm a, kNm b)
    {
        return a.Value * b.Value;
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
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
    return s;    }

}


/// <summary>
/// metre / kilonewton
/// </summary>
public readonly struct m_kN : IUnitOfMeasure<m_kN>, IFormattable
{
    public static string Name => @"metre / kilonewton";
    public static string Suffix => @"m/";
    public static string TexUnitString => @"\metre/\kilo\newton";
    public static string TexUnitsOnly => @$"\si{{ {TexUnitString} }}";
    public double Value { get; }
    public m_kN(double value)
    {
        Value = value;
    }

    public static implicit operator m_kN(double value)
    {
        return new(value);
    }

    public static implicit operator m_kN(int value)
    {
        return new(value);
    }

    public static implicit operator double(m_kN x)
    {
        return x.Value;
    }

    public static m_kN operator +(m_kN a, m_kN b)
    {
        return new(a.Value + b.Value);
    }

    public static m_kN operator -(m_kN a, m_kN b)
    {
        return new(a.Value - b.Value);
    }

    public static m_kN operator *(m_kN a, int b)
    {
        return new(a.Value * b);
    }

    public static m_kN operator *(m_kN a, double b)
    {
        return new(a.Value * b);
    }

    public static m_kN operator *(int a, m_kN b)
    {
        return new(a * b.Value);
    }

    public static m_kN operator *(double a, m_kN b)
    {
        return new(a * b.Value);
    }

    public static double operator /(m_kN a, m_kN b)
    {
        return a.Value / b.Value;
    }

    public static m_kN operator /(m_kN a, int b)
    {
        return new(a.Value / b);
    }

    public static m_kN operator /(m_kN a, double b)
    {
        return new(a.Value / b);
    }

    public static m operator *(m_kN a, kN b)
    {
        return new(a.Value * b.Value);
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
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
    return s;    }

}


/// <summary>
/// metre^2 / newton
/// </summary>
public readonly struct m2_N : IUnitOfMeasure<m2_N>, IFormattable
{
    public static string Name => @"metre^2 / newton";
    public static string Suffix => @"m^2/kg.m/s";
    public static string TexUnitString => @"\metre^2/\newton";
    public static string TexUnitsOnly => @$"\si{{ {TexUnitString} }}";
    public double Value { get; }
    public m2_N(double value)
    {
        Value = value;
    }

    public static implicit operator m2_N(double value)
    {
        return new(value);
    }

    public static implicit operator m2_N(int value)
    {
        return new(value);
    }

    public static implicit operator double(m2_N x)
    {
        return x.Value;
    }

    public static m2_N operator +(m2_N a, m2_N b)
    {
        return new(a.Value + b.Value);
    }

    public static m2_N operator -(m2_N a, m2_N b)
    {
        return new(a.Value - b.Value);
    }

    public static m2_N operator *(m2_N a, int b)
    {
        return new(a.Value * b);
    }

    public static m2_N operator *(m2_N a, double b)
    {
        return new(a.Value * b);
    }

    public static m2_N operator *(int a, m2_N b)
    {
        return new(a * b.Value);
    }

    public static m2_N operator *(double a, m2_N b)
    {
        return new(a * b.Value);
    }

    public static double operator /(m2_N a, m2_N b)
    {
        return a.Value / b.Value;
    }

    public static m2_N operator /(m2_N a, int b)
    {
        return new(a.Value / b);
    }

    public static m2_N operator /(m2_N a, double b)
    {
        return new(a.Value / b);
    }

    public static m2 operator *(m2_N a, N b)
    {
        return new(a.Value * b.Value);
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
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
    return s;    }

}


/// <summary>
/// 1/kilopascal
/// </summary>
public readonly struct per_kPa : IUnitOfMeasure<per_kPa>, IFormattable
{
    public static string Name => @"1/kilopascal";
    public static string Suffix => @"1/";
    public static string TexUnitString => @"1/\kilo\pascal";
    public static string TexUnitsOnly => @$"\si{{ {TexUnitString} }}";
    public double Value { get; }
    public per_kPa(double value)
    {
        Value = value;
    }

    public static implicit operator per_kPa(double value)
    {
        return new(value);
    }

    public static implicit operator per_kPa(int value)
    {
        return new(value);
    }

    public static implicit operator double(per_kPa x)
    {
        return x.Value;
    }

    public static per_kPa operator +(per_kPa a, per_kPa b)
    {
        return new(a.Value + b.Value);
    }

    public static per_kPa operator -(per_kPa a, per_kPa b)
    {
        return new(a.Value - b.Value);
    }

    public static per_kPa operator *(per_kPa a, int b)
    {
        return new(a.Value * b);
    }

    public static per_kPa operator *(per_kPa a, double b)
    {
        return new(a.Value * b);
    }

    public static per_kPa operator *(int a, per_kPa b)
    {
        return new(a * b.Value);
    }

    public static per_kPa operator *(double a, per_kPa b)
    {
        return new(a * b.Value);
    }

    public static double operator /(per_kPa a, per_kPa b)
    {
        return a.Value / b.Value;
    }

    public static per_kPa operator /(per_kPa a, int b)
    {
        return new(a.Value / b);
    }

    public static per_kPa operator /(per_kPa a, double b)
    {
        return new(a.Value / b);
    }

    public static double operator *(per_kPa a, kPa b)
    {
        return a.Value * b.Value;
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
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
    return s;    }

}


/// <summary>
/// 1/megapascal
/// </summary>
public readonly struct per_MPa : IUnitOfMeasure<per_MPa>, IFormattable
{
    public static string Name => @"1/megapascal";
    public static string Suffix => @"1/";
    public static string TexUnitString => @"1/\mega\pascal";
    public static string TexUnitsOnly => @$"\si{{ {TexUnitString} }}";
    public double Value { get; }
    public per_MPa(double value)
    {
        Value = value;
    }

    public static implicit operator per_MPa(double value)
    {
        return new(value);
    }

    public static implicit operator per_MPa(int value)
    {
        return new(value);
    }

    public static implicit operator double(per_MPa x)
    {
        return x.Value;
    }

    public static per_MPa operator +(per_MPa a, per_MPa b)
    {
        return new(a.Value + b.Value);
    }

    public static per_MPa operator -(per_MPa a, per_MPa b)
    {
        return new(a.Value - b.Value);
    }

    public static per_MPa operator *(per_MPa a, int b)
    {
        return new(a.Value * b);
    }

    public static per_MPa operator *(per_MPa a, double b)
    {
        return new(a.Value * b);
    }

    public static per_MPa operator *(int a, per_MPa b)
    {
        return new(a * b.Value);
    }

    public static per_MPa operator *(double a, per_MPa b)
    {
        return new(a * b.Value);
    }

    public static double operator /(per_MPa a, per_MPa b)
    {
        return a.Value / b.Value;
    }

    public static per_MPa operator /(per_MPa a, int b)
    {
        return new(a.Value / b);
    }

    public static per_MPa operator /(per_MPa a, double b)
    {
        return new(a.Value / b);
    }

    public static double operator *(per_MPa a, MPa b)
    {
        return a.Value * b.Value;
    }

    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
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
    return s;    }

}


