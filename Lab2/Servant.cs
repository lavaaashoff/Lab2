using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonForm
{
    public sealed class Servant : Person
    {
        private string branch;
        private int servingFor;

        public Servant(string name = "John", string surname = "Doe", int age = 18, string branch = "Army", int servingFor = 0)
            : base(name, surname, age)
        {
            Branch = branch;
            ServingFor = servingFor;
        }

        public override string ToString()
        {
            return base.ToString() + $", Branch: {Branch}, ServingFor: {ServingFor} years";
        }

        public override bool Equals(object obj)
        {
            if (obj is Servant other)
                return Name == other.Name && Age == other.Age && Surname == other.Surname && Branch == other.Branch && ServingFor == other.ServingFor;
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Age, Branch, ServingFor);
        }

        public string Branch
        {
            get { return branch; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Род войск не может быть пустым");
                branch = value;
            }
        }

        public int ServingFor
        {
            get { return servingFor; }
            set 
            {
                if (value < 0 || value > Age - 18)
                    throw new ArgumentOutOfRangeException("Служба не может быть меньше 0, а так же начинаться до 18 лет");
                servingFor = value;
            }
        }

    }
}
