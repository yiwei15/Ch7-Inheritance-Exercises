using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;



namespace TechnologyTests
{
    [TestClass]
    public class TechnologyTests
    {
        Computer testComputer;

        SmartPhone testSmartPhone;

        Laptop testLaptop;

        [TestInitialize]

        public void CreateTestDevices()
        {
            testSmartPhone= new SmartPhone("iOS", "AT&T", .33, 2.98, 5.94, "Apple");
            testLaptop = new Laptop(3, true, .63, 12.11, 8.81, "Huawei");
            testComputer = new Computer(20.8, 8.58, 17.7, "Apple");
        }

        //[TestInitialize]
        //public void CreateTestLaptop()
        //{
        //    testLaptop = new Laptop(3, true, .63, 12.11, 8.81, "Huawei");
        //}

        //[TestInitialize]
        //public void CreateTestComputer()
        //{
        //    testComputer = new Computer(20.8, 8.58, 17.7, "Apple");
        //}


        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(3158.81, testComputer.GetDimension(), .1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(testComputer.CheckBatteryLevel(1));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsFalse(testComputer.CheckBatteryLevel(0.1));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsFalse(testSmartPhone.CheckBatteryLevel(0.1));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.IsTrue(testSmartPhone.CheckBatteryLevel(0.8));
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual(testSmartPhone.GetDimension(), 5.84, .1);
        }

        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual(testLaptop.mouse, true);
        }

        [TestMethod]
        public void TestMethod8()
        {
            Assert.AreEqual(testLaptop.weight, 3, .01);
        }

        [TestMethod]
        public void TestMethod9()
        {
            Assert.IsFalse(testLaptop.CheckBatteryLevel(.01));
        }

    }
}
