using System;
using System.Numerics;

namespace Game10003;

public class Enemy
{
    public Vector2 position;
    public float size;
    public float leftEdge;
    public float rightEdge;
    public float topEdge;

    public void EnemyMove()
    {

    }
    public void DrawEnemy()
    {
        Draw.FillColor = Color.Green;
        Draw.Square(position, size);
    }

    public void EnemyCollision()
    {
        leftEdge = position.X;
        rightEdge = position.X + size;
        topEdge = position.Y;
    }
}
