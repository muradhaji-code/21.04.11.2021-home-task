using _21._04._11._2021_home_task.Classes;
using System;

namespace _21._04._11._2021_home_task
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //DeathStar instance = new DeathStar();
            //instance.FireLaser();
            #endregion

            #region Task2
            string carModel = Console.ReadLine();
            Car instance = new Car();
            instance.Drive();
            #endregion

            #region Task 3
            Dog mydog = new Dog();
            mydog.SetName("Husky");
            Console.WriteLine(mydog.GetName());
            mydog.Eat();
            #endregion
        }
    }
}
