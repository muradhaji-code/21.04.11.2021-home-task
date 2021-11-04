using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._04._11._2021_home_task.Classes
{
    class Dog : Animal
    {

        private string _name;

        public override string GetName()
        {
            return this._name;
        }

        public override void SetName(string newName)
        {
            this._name = newName;
        }
        public override void Eat()
        {
            Console.WriteLine("Eating");
        }
    }
}
