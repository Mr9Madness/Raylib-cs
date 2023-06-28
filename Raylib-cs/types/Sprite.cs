namespace Raylib_cs;

public readonly struct Sprite
{
    public Sprite(in Texture2D texture, Rectangle rectangle)
    {
        Texture = texture;
        Rectangle = rectangle;
    }

    public Texture2D Texture { get; init; }
    public Rectangle Rectangle { get; init; }
}
