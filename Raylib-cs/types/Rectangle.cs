using System.Numerics;
using System.Runtime.InteropServices;

namespace Raylib_cs
{
    /// <summary>
    /// Rectangle type
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct Rectangle
    {
        public float x;
        public float y;
        public float width;
        public float height;

        public readonly float Left => x;
        public readonly float Top => y;
        public readonly float Right => x + width;
        public readonly float Bottom => y + height;

        public Rectangle(float x, float y, float width, float height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public Rectangle(Vector2 position, Vector2 boundary)
        {
            this.x = position.X;
            this.y = position.Y;
            this.width = boundary.X;
            this.height = boundary.Y;
        }

        public override string ToString()
        {
            return $"{{X:{x} Y:{y} Width:{width} Height:{height}}}";
        }
    }
}
