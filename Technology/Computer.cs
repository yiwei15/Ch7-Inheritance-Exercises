using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Technology
{
    public class Computer:AbstractEntity
    {
        public double Height{ get; set; }
        public double Width { get; set; }
        public double Length { get; set; }

        //double price;

        //double cpuSpeed;

        public string Brand { get; set; }

        public double BatteryLevel { get; set; }

        readonly double lowBatteryLevel = .1;

        public Computer(double height, double width, double length, string brand): base(){ 
            Height = height;
            Width = width;
            Length = length;
            Brand = brand;
        }

        public double GetDimension()
        {
            double dimension = this.Height * this.Width * this.Length;
            return dimension;
        }

        public bool CheckBatteryLevel(double batteryLevel)
        {
            if (batteryLevel<=lowBatteryLevel)
            {
                //Console.WriteLine(BatteryLevel);
                Console.WriteLine("Low battery!");
                return false;
            }
            else
            {
                Console.WriteLine("Battery Charged: " + batteryLevel);
                return true;
            }
        }

     

        public virtual void PrintInfo()
        {
           //Console.WriteLine("This computer's brand is " + Brand);
        }

        public void PrintId()
        {
            Console.WriteLine(id);
        }

    }
}
