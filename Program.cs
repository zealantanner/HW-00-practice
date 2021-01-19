using System; 

namespace CS1405_Lab
{   public class Rectangle
    {
        public Rectangle(int Height, int Width, int X, int Y, string newColor)
        {
            this.Height = Height;
            this.Width = Width;
            this.X = X;
            this.Y = Y;
            this.Color = newColor;
            ConsoleColor[] allColors = (ConsoleColor[]) ConsoleColor.GetValues(typeof(ConsoleColor));
            //Console.Foreground.Color = ConsoleColor.ConsoleColor[Green]
            }

        public int Height;
        public int Width;
        public int X;
        public int Y;
        public string Color;

        public string GetSize()
        {
            return $"{ Height } x { Width }";

        }
        public string GetPos()
        {
            return $"({X},{Y})";

        }
        public string GetColor()
        {
            return Color;

        }
        public void SetPos(int X, int Y)
        {
            this.X = X;                                 
            this.Y = Y;
            Console.WriteLine($"Position changed to {this.GetPos()}");
        }

        public void SetSize(int Height, int Width)
        {
            this.Height = Height;                                 
            this.Width = Width;
            Console.WriteLine($"Size changed to {this.GetSize()}");
        }
        public void SetColor(string Color)
        {
            this.Color = Color;
            Console.WriteLine($"Color changed to {this.GetColor()}");
        }
        
        public void Info()
        {

            Console.WriteLine($"--Size: {this.GetSize()}");
            Console.WriteLine($"--Position: {this.GetPos()}");
            Console.WriteLine($"--Color: {this.GetColor()}");
        }
        
    }

    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Rectangle rect1 = new Rectangle(30,40,0,0,"green");

            rect1.SetSize(20,40);

            rect1.SetColor("red");
            Console.ForegroundColor = ConsoleColor.Red;

            rect1.SetPos(10,10);

            rect1.Info();

            Rectangle rect2 = new Rectangle(8,5,3,7,"blue");
            Console.ForegroundColor = ConsoleColor.Blue;

            rect2.SetSize(20,40);

            rect2.SetColor("yellow");
            Console.ForegroundColor = ConsoleColor.Yellow;

            rect2.SetPos(10,10);

            rect2.Info();
        }
    }
}
