using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExercise
{
    class Employee
    {
        public string name;
        public int id;
        public string position;
        public double salary;

        

        public Employee(string name, int id, string position, double salary)
        {
            this.name = name;
            this.id = id;
            this.position = position;
            this.salary = salary;
        }

        public override string ToString()
        {
            return $"{this.name} {this.id} {this.position} {this.salary}";
        }
        public string compare (Employee Employee)
        {
            double max = Math.Max(this.salary, Employee.salary);
            if (this.salary == max)
            {
                return "Employee" + this.name + " has a bigger wage " + this.salary;
            }
            else
            {
                return "Employee" + Employee.name + " has a bigger wage " + Employee.salary;
            }
        }
    }
}
