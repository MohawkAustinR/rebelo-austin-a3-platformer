using System;
using System.Numerics;

namespace Game10003;

public class Platforms
{
	public Vector2 position;
	public float size;

    public void DrawPlatform()
    {
        Draw.FillColor = Color.White;
        Draw.Square(position, size);
    }
    public Platforms()
	{
	}
}
