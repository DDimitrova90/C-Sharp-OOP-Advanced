namespace _01_Shapes
{
    using System;

    public class Circle : IDrawable
    {
        private int radius;

        public Circle(int radius)
        {
            this.Radius = radius;
        }

        public int Radius
        {
            get { return this.radius; }
            private set { this.radius = value; }
        }

        public void Draw()
        {
            Console.WriteLine(
                new string(' ', this.Radius) + 
                new string('*', 2 * this.Radius + 1) + 
                new string(' ', this.Radius));

            for (int i = 0; i < this.Radius - 1; i++)
            {
                Console.WriteLine(
                    new string(' ', 1 - i) + "**" + 
                    new string(' ', i) + 
                    new string(' ', 2 * this.Radius + 1) + 
                    new string(' ', i) + "**" + 
                    new string(' ', 1 - i));
            }

            Console.WriteLine("*" + new string(' ', 2 * this.Radius + 5) + "*");

            for (int i = 0; i < this.Radius - 1; i++)
            {
                Console.WriteLine(
                    new string(' ', i) + "**" +
                    new string(' ', 1 - i) +
                    new string(' ', 2 * this.Radius + 1) +
                    new string(' ', 1 - i) + "**" +
                    new string(' ', i));
            }

            Console.WriteLine(
               new string(' ', this.Radius) +
               new string('*', 2 * this.Radius + 1) +
               new string(' ', this.Radius));
        }
    }
}
