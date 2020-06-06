using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMyConvert
{
    [TestClass]
    public class UTMyConvert
    {
        /*
         * ------------------------------------------------------------------------------
         * Integer to String Test Cases
         * ------------------------------------------------------------------------------
         */
        [TestMethod]
        public void IntegerToStringPositive()
        {
            string expected = "123";
            int value = 123;

            string result = MyConvert.MyConvert.IntegerToString(value);
            Assert.AreEqual(expected, result, "Positive Integer To String Failed");
        }

        [TestMethod]
        public void IntegerToStringZero()
        {
            string expected = "0";
            int value = 0;

            string result = MyConvert.MyConvert.IntegerToString(value);
            Assert.AreEqual(expected, result, "Zero Integer To String Failed");
        }

        [TestMethod]
        public void IntegerToStringNegative()
        {
            string expected = "-123";
            int value = -123;

            string result = MyConvert.MyConvert.IntegerToString(value);
            Assert.AreEqual(expected, result, "Negative Integer To String Failed");
        }

        /*
         * ------------------------------------------------------------------------------
         * String to Integer with no Exceptions Test Cases
         * ------------------------------------------------------------------------------
         */
        [TestMethod]
        public void StringToIntegerInvalidStart()
        {
            string value = "x12";
            int expected = 0;

            int result = MyConvert.MyConvert.StringToInteger(value);
            Assert.AreEqual(expected, result, "Invalid String To Integer Invalid Start Failed");
        }

        [TestMethod]
        public void StringToIntegerInvalidMiddle()
        {
            string value = "1xy2";
            int expected = 1;

            int result = MyConvert.MyConvert.StringToInteger(value);
            Assert.AreEqual(expected, result, "Invalid String To Integer Invalid Middle Failed");
        }

        [TestMethod]
        public void StringToIntegerInvalidEnd()
        {
            string value = "145xy";
            int expected = 145;

            int result = MyConvert.MyConvert.StringToInteger(value);
            Assert.AreEqual(expected, result, "Invalid String To Integer Invalid End Failed");
        }

        [TestMethod]
        public void StringToIntegerNegative()
        {
            string value = "-145";
            int expected = -145;

            int result = MyConvert.MyConvert.StringToInteger(value);
            Assert.AreEqual(expected, result, "Invalid String To Integer Negative Failed");
        }

        [TestMethod]
        public void StringToIntegerZero()
        {
            string value = "0";
            int expected = 0;

            int result = MyConvert.MyConvert.StringToInteger(value);
            Assert.AreEqual(expected, result, "Invalid String To Integer Zero Failed");
        }

        [TestMethod]
        public void StringToIntegerPositive()
        {
            string value = "145";
            int expected = 145;

            int result = MyConvert.MyConvert.StringToInteger(value);
            Assert.AreEqual(expected, result, "Invalid String To Integer Positive Failed");
        }

        [TestMethod]
        public void StringToIntegerEmpty()
        {
            string value = "";
            int expected = 0;

            int result = MyConvert.MyConvert.StringToInteger(value);
            Assert.AreEqual(expected, result, "Invalid String To Integer Positive Failed");
        }

        /*
         * ------------------------------------------------------------------------------
         * Integer to String Test Cases
         * ------------------------------------------------------------------------------
         */
        [TestMethod]
        public void IsValidLessThan()
        {
            char value = '(';
            bool expected = false;

            bool result = MyConvert.MyConvert.IsValid10(value);
            Assert.AreEqual(expected, result, "IsValid Less Than Failed");
        }

        [TestMethod]
        public void IsValidGreaterThan()
        {
            char value = 'W';
            bool expected = false;

            bool result = MyConvert.MyConvert.IsValid10(value);
            Assert.AreEqual(expected, result, "IsValid Less Than Failed");
        }

        [TestMethod]
        public void IsValidTrue()
        {
            char value = '5';
            bool expected = true;

            bool result = MyConvert.MyConvert.IsValid10(value);
            Assert.AreEqual(expected, result, "IsValid Less Than Failed");
        }

        /*
         * ------------------------------------------------------------------------------
         * String to Integer with Exceptions test cases 
         * ------------------------------------------------------------------------------
         */
        [TestMethod]
        public void StringToIntegerWExpInvalidStart()
        {
            string value = "x12";
            try
            {
                int result = MyConvert.MyConvert.StringToIntegerWithExceptions(value);
                Assert.Fail("StringToIntegerWithExceptions did not throw exception");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(typeof(ArgumentOutOfRangeException), ex.GetType(), "Incorrect exception thrown");

                ArgumentOutOfRangeException oor = (ArgumentOutOfRangeException)ex;
                Assert.AreEqual("value", oor.ParamName, "Incorrect exception value");
            }
        }

        [TestMethod]
        public void StringToIntegerWExpInvalidMiddle()
        {
            string value = "1xy2";

            try
            {
                int result = MyConvert.MyConvert.StringToIntegerWithExceptions(value);
                Assert.Fail("StringToIntegerWithExceptions did not throw exception");

            }
            catch (Exception ex)
            {
                Assert.AreEqual(typeof(ArgumentOutOfRangeException), ex.GetType(), "Incorrect exception thrown");

                ArgumentOutOfRangeException oor = (ArgumentOutOfRangeException)ex;
                Assert.AreEqual("value", oor.ParamName, "Incorrect exception value");
            }
        }

        [TestMethod]
        public void StringToIntegerWExpInvalidEnd()
        {
            string value = "145xy";

            try
            {
                int result = MyConvert.MyConvert.StringToIntegerWithExceptions(value);
                Assert.Fail("StringToIntegerWithExceptions did not throw exception");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(typeof(ArgumentOutOfRangeException), ex.GetType(), "Incorrect exception thrown");

                ArgumentOutOfRangeException oor = (ArgumentOutOfRangeException)ex;
                Assert.AreEqual("value", oor.ParamName, "Incorrect exception value");
            }
        }

        [TestMethod]
        public void StringToIntegerWExpNegative()
        {
            string value = "-145";
            int expected = -145;

            try
            {
                int result = MyConvert.MyConvert.StringToIntegerWithExceptions(value);
                Assert.AreEqual(expected, result, "Invalid String To Integer Negative Failed");
            }
            catch (Exception ex)
            {
                Assert.Fail("Unexpected exception {0}", ex);
            }
        }

        [TestMethod]
        public void StringToIntegerWExpZero()
        {
            string value = "0";
            int expected = 0;

            try
            {
                int result = MyConvert.MyConvert.StringToIntegerWithExceptions(value);
                Assert.AreEqual(expected, result, "Invalid String To Integer Zero Failed");
            }
            catch (Exception ex)
            {
                Assert.Fail("Unexpected exception {0}", ex);
            }
        }

        [TestMethod]
        public void StringToIntegerWExpPositive()
        {
            string value = "145";
            int expected = 145;

            try
            {
                int result = MyConvert.MyConvert.StringToIntegerWithExceptions(value);
                Assert.AreEqual(expected, result, "Invalid String To Integer Positive Failed");
            }
            catch (Exception ex)
            {
                Assert.Fail("Unexpected exception {0}", ex);
            }

        }

        [TestMethod]
        public void StringToIntegerWExpEmpty()
        {
            string value = "";
            int expected = 0;

            try
            {
                int result = MyConvert.MyConvert.StringToIntegerWithExceptions(value);
                Assert.AreEqual(expected, result, "Invalid String To Integer Positive Failed");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(typeof(ArgumentOutOfRangeException), ex.GetType(), "Incorrect exception thrown");

                ArgumentOutOfRangeException oor = (ArgumentOutOfRangeException)ex;
                Assert.AreEqual("value", oor.ParamName, "Incorrect exception value");
            }
        }
    }
}
