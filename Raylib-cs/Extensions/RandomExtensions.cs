using System;
using System.Numerics;

namespace Raylib_cs;

public static class RandomExtensions
{
    public static bool Percentage(this Random random, int percentage) => random.Next(1, 100) > percentage;
    public static bool Percentage(this Random random, float percentage) => random.NextSingle() > percentage;
    public static Vector2 NextVector(this Random random, int min, int max) => new(random.Next(min, max), random.Next(min, max));
}
