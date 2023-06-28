using System.Numerics;

namespace Raylib_cs;

public static class Vector2Extensions
{
    public static bool IsAround(this Vector2 origin, Vector2 comparison, float range) => Vector2.Distance(origin, comparison) < range;
    public static bool IsAround(this Vector2 origin, Point comparison, float range) => Vector2.Distance(origin, comparison) < range;
    public static bool IsInside(this Vector2 origin, Rectangle inside) => inside.Contains(origin);
}
