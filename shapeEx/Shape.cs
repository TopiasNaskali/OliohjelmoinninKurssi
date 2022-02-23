using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeExercise
{
    abstract class Shape
    {
        protected string color;
        protected string type;

        public Shape()
        {
            this.color = string.Empty;
            this.type = string.Empty;
        }
        
        public Shape(string color, string type)
        {
            this.color = color;
            this.type = type;
        }

        abstract public double GetArea();
      

        protected virtual string GetInfo()
        {
            return $"Tyyppi {this.type}, väri {this.color}";
        }

        public virtual string GetColor()
        {
            return this.color;
        }
    }
}
