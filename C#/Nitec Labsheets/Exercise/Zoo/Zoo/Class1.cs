using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Zoo
    {
        private string name;
        private int age;
        private int bmi;


        public Zoo(string _name, int _age, int _bmi)
        {
            this.Name = _name;
            this.Age = _age;
            this.Bmi = _bmi;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int Bmi
        {
            get { return bmi; }
            set { bmi = value; }
        }
    }
}
