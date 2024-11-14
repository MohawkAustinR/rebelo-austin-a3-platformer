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
    public float bottomEdge;
    public bool isPlayerTouching;


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
        bottomEdge = position.Y + size.Y;
    }
}
