using System;
using System.Numerics;

namespace Game10003;

public class Player
{

	public Vector2 position;
	public float size;
    public Vector2 velocity;
    public Vector2 gravity = new Vector2(0, +10);

	public void DrawPlayer()
	{
		Draw.FillColor = Color.White;
		Draw.Square(position, size);
	}

	public void Move()
	{


        // Jump movement
        if (Input.IsKeyboardKeyPressed(KeyboardInput.Up) || Input.IsKeyboardKeyPressed(KeyboardInput.W))
        {
            position.Y -= 10;
        }
        // Calculate that much time's worth of gravitational force
        Vector2 gravityForce = gravity * Time.DeltaTime;
        // Apply force to velocity
        velocity += gravityForce;
        // Apply velocity to position
        position += velocity;

        // Left movement
        if (Input.IsKeyboardKeyDown(KeyboardInput.Left) || Input.IsKeyboardKeyDown(KeyboardInput.A))
        {
            position.X -= 1;
        }

        // Right movement
        if (Input.IsKeyboardKeyDown(KeyboardInput.Right) || Input.IsKeyboardKeyDown(KeyboardInput.D))
        {
            position.X += 1;
        }
    }
}