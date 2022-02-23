using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeExercise
{
    class Triangle : Shape
    {
        private double lenght;
        private double width;

        public Triangle(string color,double radius, double lenght, double width) : base (color, "TRIANGLE")
        {
            this.lenght = lenght;
            this.width = width;
        }

        public override double GetArea()
        {
            return this.lenght * this.width;
        }

        public override string GetColor()
        {
            return base.GetColor();
        }
    }
}
