// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(400, 400);
            Window.SetTitle("Sunset");
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Draw.FillColor = new Color(238, 175, 97);
            Draw.Rectangle(0, 0, 400, 400);
            if (Input.GetMouseY() <= 100)
            {
                Draw.FillColor = new Color(238, 175, 97);
                Draw.Rectangle(0, 0, 400, 400);
            }
            if (Input.GetMouseY() > 100 && Input.GetMouseY() <= 200)
            {
                Draw.FillColor = new Color(251, 144, 98);
                Draw.Rectangle(0, 0, 400, 400);
            }
            if (Input.GetMouseY() > 200 && Input.GetMouseY() <= 300)
            {
                Draw.FillColor = new Color(238, 93, 108);
                Draw.Rectangle(0, 0, 400, 400);
            }
            if (Input.GetMouseY() > 300 && Input.GetMouseY() <= 400)
            {
                Draw.FillColor = new Color(206, 73, 147);
                Draw.Rectangle(0, 0, 400, 400);
            }
            Draw.FillColor = Color.Yellow;
            Draw.Circle(Input.GetMouseX(), Input.GetMouseY(), 50);
            Draw.FillColor = new Color(106, 13, 131);
            Draw.Rectangle(0, 300, 400, 100);
        }
    }

}
