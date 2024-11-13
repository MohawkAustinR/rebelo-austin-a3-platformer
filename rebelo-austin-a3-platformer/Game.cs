// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        Player player = new Player();

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("PlatformerWIP");
            Window.SetSize(800, 800);
            player.size = 40;
            player.position = new Vector2(Window.Width / 2 - player.size / 2, Window.Height / 2 - player.size / 2);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.Black);

            player.Move();

            player.DrawPlayer();
        }
    }
}
