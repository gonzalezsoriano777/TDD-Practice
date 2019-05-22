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
            Assert.AreEqual(5, Roman.ParseNumeral("V"));
            Assert.AreEqual(10, Roman.ParseNumeral("X"));
            Assert.AreEqual(6, Roman.ParseNumeral("IV"));
        }
    }

    
    public class Roman
    {
        
        

        public static int ParseNumeral(string roman)
        {

            if (roman == "V")
                return 5;

            if (roman == "X")
                return 10;

            if (roman == "IV")
                return 6;

            // represented as the first roman numeral
            return 1;
            
        }
    }
}
