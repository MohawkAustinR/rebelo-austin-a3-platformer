using System;
using System.Numerics;

namespace Game10003;

public class Player
{
    public Vector2 position;
    public float size;
    public float speed = 200;

    public Vector2 velocity = new Vector2(0, +10);
    public Vector2 gravity = new Vector2(0, +10);

    public float leftEdge;
    public float rightEdge;
    public float topEdge;
    public float bottomEdge;

    public bool doesOverlapLeft;
    public bool doesOverlapRight;
    public bool doesOverlapTop;
    public bool doesOverlapBottom;
    bool doesOverlap;
    public bool isPlayerTouchingPlatform = false;

    public void DrawPlayer()
    {
        Draw.FillColor = Color.White;
        Draw.Square(position, size);
    }

    public void Move()
    {
        // Apply force to velocity
        if (velocity.Y <= 10)
        {
            velocity += gravity * Time.DeltaTime;
        }
        

        // Jump movement
        if ((Input.IsKeyboardKeyPressed(KeyboardInput.Up) || Input.IsKeyboardKeyPressed(KeyboardInput.W)) && isPlayerTouchingPlatform)
        {
            velocity = -velocity;
            position -= velocity * Time.DeltaTime;
        }
        else
        {
            // Apply velocity to position
            position += velocity;
        }

        if (velocity.Y < 0)
        {
            gravity = new Vector2(0, 20);
        }
        Console.WriteLine(velocity);
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

    public void PlayerCollision(Platform platform)
    {
        // Defines player edges collision
        leftEdge = position.X;
        rightEdge = position.X + size;
        topEdge = position.Y;
        bottomEdge = position.Y + size;

        doesOverlapLeft = leftEdge <= platform.rightEdge;
        doesOverlapRight = rightEdge >= platform.leftEdge;
        doesOverlapTop = bottomEdge >= platform.topEdge;
        doesOverlapBottom = topEdge >= platform.bottomEdge;

        doesOverlap = doesOverlapLeft && doesOverlapRight && doesOverlapTop;



        if (doesOverlap)
        {
            gravity = new Vector2(0, 0);
            position.Y = platform.topEdge - size;
            platform.isPlayerTouching = true;
        }
        else
        {
            gravity = new Vector2(0, 20);
            platform.isPlayerTouching = false;
        }
       
    }
}