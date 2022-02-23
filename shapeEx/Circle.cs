using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeExercise
{
    class Circle : Shape
    {
        private double radius;

        public Circle()
        {
            this.radius = 0;
        }

        public Circle(string color, double radius) : base(color, "CIRCLE")
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * this.radius * this.radius;
        }

        public override string GetColor()
        {
            return base.GetColor();
        }
    }
}
