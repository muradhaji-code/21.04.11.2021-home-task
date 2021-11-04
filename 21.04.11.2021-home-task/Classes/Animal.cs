using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._04._11._2021_home_task.Classes
{
    public abstract class Animal
    {
        public abstract string GetName();

        public abstract void SetName(string newName);
        public abstract void Eat();
    }
}
