using System;

namespace Technology
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            SmartPhone newSmartPhone = new SmartPhone("iOS", "AT&T",.33, 2.98, 5.94, "Apple");
            Laptop newLaptop = new Laptop(3, true, .63, 12.11, 8.81, "Huawei");

            newSmartPhone.PrintInfo();
            newLaptop.PrintInfo();

            //Console.WriteLine(newSmartPhone.Height);
            //Console.WriteLine(newSmartPhone.BatteryLevel);
            newSmartPhone.CheckBatteryLevel(0.3);
            newLaptop.CheckBatteryLevel(0.1);


        }
    }
}
