using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeExercise
{
    class Rectangle : Shape
    {
        private double lenght;
        private double width;

        public Rectangle(string color, double radius, double lenght, double width): base(color, "RECTANGLE")
        {
            this.lenght = lenght;
            this.width = width;

        }

        public override double GetArea()
        {
            return this.width * this.lenght;
        }

        public override string GetColor()
        {
            return base.GetColor();
        }
    }
}
