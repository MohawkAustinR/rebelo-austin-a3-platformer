using System;
using System.Numerics;

namespace Game10003;

public class Platform
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
        rightEdge = position.X + size.X;
        topEdge = position.Y;
    }
}
