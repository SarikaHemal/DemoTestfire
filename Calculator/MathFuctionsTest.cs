using NUnit.Framework;

namespace Calculator
{
    public class Tests
    {
        

        [Test]
        public void AdditionTest()
        {
            MathFunctions math = new MathFunctions();
            int result = math.Addtion(5, 3);
            Console.WriteLine(result);
            Assert.AreEqual(8, result);
        }
        [Test]
        public void SubtractionTest()
        {
            
            MathFunctions math = new MathFunctions();
            int result = math.Subtraction(8, 2);
            Console.WriteLine(result);
            Assert.AreEqual(6, result);
        }
        [Test]
        public void NagitiveNumberAdditionTest()
        {
            MathFunctions math = new MathFunctions();
            int result = math.Addtion(-5, 3);
            Console.WriteLine(result);
            Assert.AreEqual(-2, result);
        }
        [Test]
        public void NagitiveNumberSubtractionTest()
        {

            MathFunctions math = new MathFunctions();
            int result = math.Subtraction(-8, 2);
            Console.WriteLine(result);
            Assert.AreEqual(-10, result);
        }
    }
}