using System;
using System.Globalization;
using System.Numerics;

namespace Raylib_cs;

public struct Point : IEquatable<Point>
{
    public int X;
    public int Y;

    public Point(int value) : this(value, value) { }
    public Point(float x, float y) : this((int)x, (int)y) { }
    public Point(float value) : this((int)value, (int)value) { }
    public Point(Vector2 vector2) : this((int)vector2.X, (int)vector2.Y) { }
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public static Point Zero => new(0, 0);

    public static Point operator +(Point point1, Point point2) => new(point1.X + point2.X, point1.Y + point2.Y);
    public static Point operator +(Point point, Vector2 vector) => new(point.X + vector.X, point.Y + vector.Y);
    public static Vector2 operator +(Vector2 vector, Point point) => new(vector.X + point.X, vector.Y + point.Y);
    public static Rectangle operator +(Rectangle rect, Point point) => new(rect.x + point.X, rect.y + point.Y, rect.width, rect.height);

    public static Point operator *(Point point1, Point point2) => new(point1.X * point2.X, point1.Y * point2.Y);
    public static Point operator *(Point point, Vector2 vector) => new(point.X * vector.X, point.Y * vector.Y);
    public static Point operator *(Point point, int amount) => new(point.X * amount, point.Y * amount);

    public static Point operator /(Point point1, Point point2) => new(point1.X / point2.X, point1.Y / point2.Y);
    public static Point operator /(Point point, Vector2 vector) => new(point.X / vector.X, point.Y / vector.Y);
    public static Point operator /(Point point, int amount) => new(point.X / amount, point.Y / amount);

    public static bool operator ==(Point first, Point second) => first.Equals(second);
    public static bool operator !=(Point first, Point second) => !first.Equals(second);

    public static bool operator >(Point point, int comp) => point.X > comp && point.Y > comp;
    public static bool operator <(Point point, int comp) => point.X < comp && point.Y < comp;

    public static implicit operator Vector2(Point point) => new(point.X, point.Y);
    public static implicit operator Point(Vector2 point) => new(point.X, point.Y);

    public bool Equals(Point other) => X == other.X && Y == other.Y;
    public override bool Equals(object? o) => o is Point other && X == other.X && Y == other.Y;

    public override int GetHashCode() => X.GetHashCode() ^ Y.GetHashCode();

    /// <summary>Returns the string representation of the current instance using default formatting.</summary>
    /// <returns>The string representation of the current instance.</returns>
    /// <remarks>This method returns a string in which each element of the vector is formatted using the "G" (general) format string and the formatting conventions of the current thread culture. The "&lt;" and "&gt;" characters are used to begin and end the string, and the current culture's <see cref="NumberFormatInfo.NumberGroupSeparator" /> property followed by a space is used to separate each element.</remarks>
    public override readonly string ToString()
    {
        return ToString("G", CultureInfo.CurrentCulture);
    }

    /// <summary>Returns the string representation of the current instance using the specified format string to format individual elements.</summary>
    /// <param name="format">A standard or custom numeric format string that defines the format of individual elements.</param>
    /// <returns>The string representation of the current instance.</returns>
    /// <remarks>This method returns a string in which each element of the vector is formatted using <paramref name="format" /> and the current culture's formatting conventions. The "&lt;" and "&gt;" characters are used to begin and end the string, and the current culture's <see cref="NumberFormatInfo.NumberGroupSeparator" /> property followed by a space is used to separate each element.</remarks>
    /// <related type="Article" href="/dotnet/standard/base-types/standard-numeric-format-strings">Standard Numeric Format Strings</related>
    /// <related type="Article" href="/dotnet/standard/base-types/custom-numeric-format-strings">Custom Numeric Format Strings</related>
    public readonly string ToString(string? format)
    {
        return ToString(format, CultureInfo.CurrentCulture);
    }

    /// <summary>Returns the string representation of the current instance using the specified format string to format individual elements and the specified format provider to define culture-specific formatting.</summary>
    /// <param name="format">A standard or custom numeric format string that defines the format of individual elements.</param>
    /// <param name="formatProvider">A format provider that supplies culture-specific formatting information.</param>
    /// <returns>The string representation of the current instance.</returns>
    /// <remarks>This method returns a string in which each element of the vector is formatted using <paramref name="format" /> and <paramref name="formatProvider" />. The "&lt;" and "&gt;" characters are used to begin and end the string, and the format provider's <see cref="NumberFormatInfo.NumberGroupSeparator" /> property followed by a space is used to separate each element.</remarks>
    /// <related type="Article" href="/dotnet/standard/base-types/custom-numeric-format-strings">Custom Numeric Format Strings</related>
    /// <related type="Article" href="/dotnet/standard/base-types/standard-numeric-format-strings">Standard Numeric Format Strings</related>
    public readonly string ToString(string? format, IFormatProvider? formatProvider)
    {
        string separator = NumberFormatInfo.GetInstance(formatProvider).NumberGroupSeparator;

        return $"<{X.ToString(format, formatProvider)}{separator} {Y.ToString(format, formatProvider)}>";
    }
}
