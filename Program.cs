using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEight = new Building("512 8th Avenue");
            FiveOneTwoEight.Depth = 50;
            FiveOneTwoEight.Width = 25;
            FiveOneTwoEight.Stories = 45;
            FiveOneTwoEight.Construct();
            FiveOneTwoEight.Purchase("Steve");
            FiveOneTwoEight.displayInfo();


            City Nashville = new City("Nashville", "Dan Cooper", FiveOneTwoEight);


        }

    }
}
