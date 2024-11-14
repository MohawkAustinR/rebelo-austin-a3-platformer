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
        Platform[] platforms = new Platform[1];
        Enemy enemy = new Enemy();

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("PlatformerWIP");
            Window.SetSize(800, 600);
            player.size = 40;
            player.position = new Vector2(Window.Width / 2 - player.size / 2, Window.Height / 2 - player.size / 2);
            platforms[0] = new Platform();
            platforms[0].size = new Vector2(800, 100);
            platforms[0].position = new Vector2(0, Window.Height - platforms[0].size.Y);
            enemy.size = 40;

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.Black);

            player.Move();

            for (int i = 0; i <platforms.Length; i++)
            {
                platforms[i].DrawPlatform();
                player.PlayerCollision(platforms[i].rightEdge, platforms[i].leftEdge, platforms[i].topEdge);
            }

            player.DrawPlayer();


        }
    }
}
