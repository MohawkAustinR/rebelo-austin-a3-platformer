using System;
using System.Numerics;

namespace Game10003;

public class Platforms
{
	public Vector2 position;
	public Vector2 size;
    public float leftEdge;
    public float rightEdge;
    public float topEdge;

    public void DrawPlatform()
    {
        PlatformCollision();
        Draw.FillColor = Color.White;
        Draw.Rectangle(position, size);
    }
    public void PlatformCollision()
	{
        leftEdge = position.X;
        rightEdge = position.Y;
        topEdge = position.Y + size.Y;
    }
}
