using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO.Ports;
using System;

namespace Test_Automation
{
    

    [TestClass]
    public class UnitTest1
    {
          
        [TestMethod]
        public void TestMethod1()
        {
            SerialPort S = new SerialPort("COM4",9600);
            S.Open();
        }
    }
}
