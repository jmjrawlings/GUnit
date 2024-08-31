namespace Units;

public readonly struct mm
{
    public static string Name => @"millimetre";
    public static string Tex => @"\milli\metre";
    public static string Code => @"mm";
    public readonly double Value;
    public mm(double value)
    {
        Value = value;
    }

    public static explicit operator mm(double value)
    {
        return new(value);
    }

    public static explicit operator mm(int value)
    {
        return new(value);
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

    public static implicit operator mm(m x)
    {
        return new(x.Value * 1000.0);
    }

}


public readonly struct g
{
    public static string Name => @"gram";
    public static string Tex => @"\gram";
    public static string Code => @"g";
    public readonly double Value;
    public g(double value)
    {
        Value = value;
    }

    public static explicit operator g(double value)
    {
        return new(value);
    }

    public static explicit operator g(int value)
    {
        return new(value);
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

    public static implicit operator g(kg x)
    {
        return new(x.Value * 1000.0);
    }

    public static implicit operator g(tonne x)
    {
        return new(x.Value * 1000000.0);
    }

}


public readonly struct sec
{
    public static string Name => @"second";
    public static string Tex => @"\second";
    public static string Code => @"sec";
    public readonly double Value;
    public sec(double value)
    {
        Value = value;
    }

    public static explicit operator sec(double value)
    {
        return new(value);
    }

    public static explicit operator sec(int value)
    {
        return new(value);
    }

    public static sec operator *(sec a, int b)
    {
        return new(a.Value * b);
    }

    public static sec operator *(sec a, double b)
    {
        return new(a.Value * b);
    }

    public static sec operator *(int a, sec b)
    {
        return new(a * b.Value);
    }

    public static sec operator *(double a, sec b)
    {
        return new(a * b.Value);
    }

    public static sec2 operator *(sec a, sec b)
    {
        return new(a.Value * b.Value);
    }

}


public readonly struct m
{
    public static string Name => @"metre";
    public static string Tex => @"\metre";
    public static string Code => @"m";
    public readonly double Value;
    public m(double value)
    {
        Value = value;
    }

    public static explicit operator m(double value)
    {
        return new(value);
    }

    public static explicit operator m(int value)
    {
        return new(value);
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

    public static implicit operator m(mm x)
    {
        return new(x.Value / 1000.0);
    }

    public static m2 operator *(m a, m b)
    {
        return new(a.Value * b.Value);
    }

    public static m_s operator /(m a, sec b)
    {
        return new(a.Value / b.Value);
    }

    public static sec operator /(m a, m_s b)
    {
        return new(a.Value / b.Value);
    }

    public static sec operator *(m a, m_s b)
    {
        return new(a.Value * b.Value);
    }

}


public readonly struct m2
{
    public static string Name => @"metre^2";
    public static string Tex => @"\metre^2";
    public static string Code => @"m2";
    public readonly double Value;
    public m2(double value)
    {
        Value = value;
    }

    public static explicit operator m2(double value)
    {
        return new(value);
    }

    public static explicit operator m2(int value)
    {
        return new(value);
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

    public static m operator /(m2 a, m b)
    {
        return new(a.Value / b.Value);
    }

}


public readonly struct sec2
{
    public static string Name => @"second^2";
    public static string Tex => @"\second^2";
    public static string Code => @"sec2";
    public readonly double Value;
    public sec2(double value)
    {
        Value = value;
    }

    public static explicit operator sec2(double value)
    {
        return new(value);
    }

    public static explicit operator sec2(int value)
    {
        return new(value);
    }

    public static sec2 operator *(sec2 a, int b)
    {
        return new(a.Value * b);
    }

    public static sec2 operator *(sec2 a, double b)
    {
        return new(a.Value * b);
    }

    public static sec2 operator *(int a, sec2 b)
    {
        return new(a * b.Value);
    }

    public static sec2 operator *(double a, sec2 b)
    {
        return new(a * b.Value);
    }

    public static sec operator /(sec2 a, sec b)
    {
        return new(a.Value / b.Value);
    }

}


public readonly struct kg
{
    public static string Name => @"kilogram";
    public static string Tex => @"\kilo\gram";
    public static string Code => @"kg";
    public readonly double Value;
    public kg(double value)
    {
        Value = value;
    }

    public static explicit operator kg(double value)
    {
        return new(value);
    }

    public static explicit operator kg(int value)
    {
        return new(value);
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

    public static implicit operator kg(g x)
    {
        return new(x.Value / 1000.0);
    }

    public static implicit operator kg(tonne x)
    {
        return new(x.Value * 1000.0);
    }

}


public readonly struct tonne
{
    public static string Name => @"tonne";
    public static string Tex => @"\tonne";
    public static string Code => @"tonne";
    public readonly double Value;
    public tonne(double value)
    {
        Value = value;
    }

    public static explicit operator tonne(double value)
    {
        return new(value);
    }

    public static explicit operator tonne(int value)
    {
        return new(value);
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

    public static implicit operator tonne(kg x)
    {
        return new(x.Value / 1000.0);
    }

    public static implicit operator tonne(g x)
    {
        return new(x.Value / 1000000.0);
    }

}


public readonly struct m_s
{
    public static string Name => @"metres per second";
    public static string Tex => @"\metre/\second";
    public static string Code => @"m_s";
    public readonly double Value;
    public m_s(double value)
    {
        Value = value;
    }

    public static explicit operator m_s(double value)
    {
        return new(value);
    }

    public static explicit operator m_s(int value)
    {
        return new(value);
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

    public static sec operator *(m_s a, m b)
    {
        return new(a.Value * b.Value);
    }

}


