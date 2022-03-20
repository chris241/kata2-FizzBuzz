using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void Generate_Return1IfNumber1()
        {
            FizzBuzz.FizzBuzz fizzBuzz = new FizzBuzz.FizzBuzz();
            string result = fizzBuzz.Generate(1);
            Assert.AreEqual("1",result);
        }
        [TestMethod]
        public void Generate_Return2IfNumber2()
        {
            FizzBuzz.FizzBuzz fizzBuzz = new FizzBuzz.FizzBuzz();
            string result = fizzBuzz.Generate(2);
            Assert.AreEqual("2", result);
        }
        [TestMethod]
        public void Generate_ReturnFizzIfNumber3()
        {
            FizzBuzz.FizzBuzz fizzBuzz = new FizzBuzz.FizzBuzz();
            string result = fizzBuzz.Generate(3);
            Assert.AreEqual("Fizz", result);
        }
        [TestMethod]
        public void Generate_ReturnFizzIfNumber6()
        {
            FizzBuzz.FizzBuzz fizzBuzz = new FizzBuzz.FizzBuzz();
            string result = fizzBuzz.Generate(6);
            Assert.AreEqual("Fizz", result);
        }
        [TestMethod]
        public void Generate_ReturnBuzzIfNumber5()
        {
            FizzBuzz.FizzBuzz fizzBuzz = new FizzBuzz.FizzBuzz();
            string result = fizzBuzz.Generate(5);
            Assert.AreEqual("Buzz", result);
        }
        [TestMethod]
        public void Generate_ReturnBuzzIfNumber10()
        {
            FizzBuzz.FizzBuzz fizzBuzz = new FizzBuzz.FizzBuzz();
            string result = fizzBuzz.Generate(10);
            Assert.AreEqual("Buzz", result);
        }
        [TestMethod]
        public void Generate_ReturnFizzBuzzIfNumber15()
        {
            FizzBuzz.FizzBuzz fizzBuzz = new FizzBuzz.FizzBuzz();
            string result = fizzBuzz.Generate(15);
            Assert.AreEqual("FizzBuzz", result);
        }
    }
}
