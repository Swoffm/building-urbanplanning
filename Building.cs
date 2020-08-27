using System;

namespace Planner
{

    public class Building
    {
        private string _designer;
        private DateTime _dateConstructed;

        private string _address;

        private string _owner;

        public int Stories { get; set; }

        public double Width { get; set; }

        public double Depth { get; set; }

        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }

        public Building(string address)
        {
            _address = address;
        }

        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string owner)
        {
            _owner = owner;
        }

        public void displayInfo()
        {
            Console.WriteLine(_address);
            Console.WriteLine("----------------");
            Console.WriteLine($"Designed by {_owner}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"{Volume} cubic meters of space");

        }


    }


}