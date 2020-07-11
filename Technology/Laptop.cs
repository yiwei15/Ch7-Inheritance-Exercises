using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Laptop: Computer
    {
        public string color;
        public double weight;
        public bool mouse;

        public Laptop(double weight, bool mouse, double height, double width, double length, string brand) : base(height, width, length, brand)
        {
            this.mouse = mouse;
            this.weight = weight;
        }

        public override void PrintInfo ()
        {
            Console.WriteLine("ID: " + id + "\nThis laptop's weight is " + weight + "km."); 
        }
    }
}
