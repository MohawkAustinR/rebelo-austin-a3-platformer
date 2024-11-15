using System;
using System.Numerics;

namespace Game10003;

public class Goal
{
    public Vector2 position;
    public float size;
    public float leftEdge;
    public float topEdge;

    bool isPlayerTouchingTop;
    bool isPlayerTouchingLeft;
    bool isPlayerInside;


    public void DrawGoal()
    {
        Draw.FillColor = Color.Green;
        Draw.Square(position, size);
    }

    public bool GoalCollision(Player player)
    {
        leftEdge = position.X;
        topEdge = position.Y;

        isPlayerTouchingTop = player.bottomEdge >= topEdge;
        isPlayerTouchingLeft = player.leftEdge >= leftEdge;
        isPlayerInside = isPlayerTouchingTop && isPlayerTouchingLeft;
        return isPlayerInside;
    }
}
