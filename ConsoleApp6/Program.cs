using System;

namespace Geometry
{
    abstract class Solid
    {
        public abstract double Volume();
        public abstract double SurfaceArea();
    }

    class Cube : Solid
    {
        private double side;

        public Cube(double side)
        {
            this.side = side;
        }

        public override double Volume()
        {
            return Math.Pow(side, 3);
        }

        public override double SurfaceArea()
        {
            return 6 * Math.Pow(side, 2);
        }

        public override string ToString()
        {
            return "Cube - side: " + side + ", volume: " + Volume() + ", surface area: " + SurfaceArea();
        }
    }

    class Cylinder : Solid
    {
        private double radius;
        private double height;

        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public override double Volume()
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }

        public override double SurfaceArea()
        {
            return 2 * Math.PI * radius * height + 2 * Math.PI * Math.Pow(radius, 2);
        }

        public override string ToString()
        {
            return "Cylinder - radius: " + radius + ", height: " + height + ", volume: " + Volume() + ", surface area: " + SurfaceArea();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solid[] solids = new Solid[2];
            solids[0] = new Cube(5);
            solids[1] = new Cylinder(3, 8);

            foreach (Solid solid in solids)
            {
                Console.WriteLine(solid.ToString());
            }
        }
    }
}