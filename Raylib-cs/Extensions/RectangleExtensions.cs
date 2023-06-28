using System.Numerics;

namespace Raylib_cs;

public static class RectangleExtensions
{
    public static bool Contains(this Rectangle rectangle, Vector2 comp)
        => comp.X >= rectangle.x && comp.Y >= rectangle.y
        && comp.X <= rectangle.x + rectangle.width && comp.Y <= rectangle.y + rectangle.height;

    public static bool Contains(this Rectangle rectangle, Point comp)
        => comp.X >= rectangle.x && comp.Y >= rectangle.y
        && comp.X <= rectangle.x + rectangle.width && comp.Y <= rectangle.y + rectangle.height;
}
