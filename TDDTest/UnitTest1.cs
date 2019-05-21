using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDTest
{
    [TestClass]
    public class RomanNumeralsTesting
    {
        [TestMethod]
        public void Parse()
        {
            Assert.AreEqual(1, Roman.ParseNumeral("I"));
        }
    }

    
    public class Roman
    {
        public static int ParseNumeral(string roman)
        {
            

            return 0;
        }
    }
}
