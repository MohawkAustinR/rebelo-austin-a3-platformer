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
        Platform[] platforms = new Platform[10 ];
        Enemy enemy = new Enemy();

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("PlatformerWIP");
            Window.SetSize(800, 600);
            player.size = 20;
            player.position = new Vector2(Window.Width / 2 - player.size / 2, Window.Height / 2 - player.size / 2);

            for (int i = 0; i < platforms.Length; i++)
            {
                platforms[i] = new Platform();
                platforms[i].isPlayerTouching = false;
            }
                
            platforms[0].size = new Vector2(150, 50);
            platforms[1].size = new Vector2(50, 20);
            platforms[2].size = new Vector2(50, 20);
            platforms[3].size = new Vector2(50, 20);
            platforms[4].size = new Vector2(50, 20);
            platforms[5].size = new Vector2(100, 400);
            platforms[6].size = new Vector2(50, 20);
            platforms[7].size = new Vector2(50, 20);
            platforms[8].size = new Vector2(100, 400);
            platforms[9].size = new Vector2(100, 50);

            platforms[0].position = new Vector2(0, Window.Height - platforms[0].size.Y);
            platforms[1].position = new Vector2(platforms[0].size.X + 40, Window.Height - platforms[0].size.Y);
            platforms[2].position = new Vector2(platforms[1].position.X + platforms[2].size.X + 20, Window.Height - 200);
            platforms[3].position = new Vector2(0, Window.Height - platforms[0].size.Y);
            platforms[4].position = new Vector2(0, Window.Height - platforms[0].size.Y);
            platforms[5].position = new Vector2(0, Window.Height - platforms[0].size.Y);
            platforms[6].position = new Vector2(0, Window.Height - platforms[0].size.Y);
            platforms[7].position = new Vector2(0, Window.Height - platforms[0].size.Y);
            platforms[8].position = new Vector2(0, Window.Height - platforms[0].size.Y);
            platforms[9].position = new Vector2(0, Window.Height - platforms[0].size.Y);

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
                player.PlayerCollision(platforms[i]);
                for (int j = 0; j < platforms.Length; j++)
                {
                    if (platforms[j].isPlayerTouching)
                    {
                        player.isPlayerTouchingPlatform = true;
                        break;
                    }
                    else
                    {
                        player.isPlayerTouchingPlatform = false;
                    }
                }
            }
            player.DrawPlayer();


        }
    }
}
