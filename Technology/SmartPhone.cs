using System;
using System.Collections.Generic;
using System.Text;


namespace Technology
{
    public class SmartPhone: Computer
    {
        public string operatingSystem;  //Android and iOS
        public string carrier; // AT&T, Sprint, T-Mobile and Verizon

        public SmartPhone(string operationSystem, string carrier, double height, double width, double length, string brand): base (height, width, length, brand)
        {
            this.operatingSystem = operatingSystem;
            this.carrier = carrier;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("ID: " + id + "\nThis smartphone's carrier is " + carrier);
        }

    }
}
