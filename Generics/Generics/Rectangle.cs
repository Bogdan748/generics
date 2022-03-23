using System;

namespace CsharpGenerics
{
    public class Rectangle : Shape
    {
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
            
        }
        public int Height { get; }
        public int Width { get; }

        public override double Area 
        {
            get { return Width * Height; }
        }

        public override void Move(int dx, int dy)
        {
            Console.WriteLine($"Moving with {dx}, {dy}");
        }

    }
}
