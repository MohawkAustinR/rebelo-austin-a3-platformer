using System;
using System.Numerics;

namespace Game10003;

public class Player
{
    public Vector2 position;
    public float size;
    public float speed = 200;

    public Vector2 velocity;
    public Vector2 jumpVelocity = new Vector2(0, 200);
    public Vector2 gravity = new Vector2(0, +10);

    public float leftEdge;
    public float rightEdge;
    public float topEdge;
    public float bottomEdge;

    public bool doesOverlapLeft;
    public bool doesOverlapRight;
    public bool doesOverlapTop;
    public void DrawPlayer()
    {
        Draw.FillColor = Color.White;
        Draw.Square(position, size);
    }

    public void Move()
    {
        // Apply force to velocity
        velocity += gravity * Time.DeltaTime;

        // Jump movement
        if ((Input.IsKeyboardKeyPressed(KeyboardInput.Up) || Input.IsKeyboardKeyPressed(KeyboardInput.W)) && doesOverlapTop)
        {
            velocity = -velocity;
            position -= velocity * Time.DeltaTime;
        }
        else
        {
            // Apply velocity to position
            position += velocity;
        }
        // Left movement
        if (Input.IsKeyboardKeyDown(KeyboardInput.Left) || Input.IsKeyboardKeyDown(KeyboardInput.A))
        {
            position.X -= speed * Time.DeltaTime;
        }

        // Right movement
        if (Input.IsKeyboardKeyDown(KeyboardInput.Right) || Input.IsKeyboardKeyDown(KeyboardInput.D))
        {
            position.X += speed * Time.DeltaTime;
        }

    }

    public void PlayerCollision(float rightEdge2, float leftEdge2, float topEdge2)
    {
        // Defines player edges collision
        leftEdge = position.X;
        rightEdge = position.X + size;
        topEdge = position.Y;
        bottomEdge = position.Y + size;

        doesOverlapLeft = leftEdge <= rightEdge2;
        doesOverlapRight = rightEdge >= leftEdge2;
        doesOverlapTop = bottomEdge >= topEdge2;

        bool doesOverlap = doesOverlapLeft && doesOverlapRight && doesOverlapTop;



        if (doesOverlap)
        {
            gravity = new Vector2(0, 0);
            position.Y = topEdge2 - size;
        }
        else
        {
            gravity = new Vector2(0, 10);
        }
    }
}