using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescendingOrder
{
    public class Kata
    {
        public int DescendingOrder(int num)
        {
            string InputStr = num.ToString();
            int result;
            if (InputStr.Length <= 1)
                result = num;
            else
            {
                int count = InputStr.Length;
                var numchar = string.Empty;
                for(int i = count; i > 0; i--)
                {
                    numchar += InputStr.Substring(i - 1, 1);
                }
                result = int.Parse(numchar);
            }

            return result;
        }
    }

    [TestFixture]
    public class DescendingOrder_Test
    {
        private Kata kata;
        private int result;
        private int expected;
        private int actual;

        [SetUp]
        public void Setup()
        {
            kata = new Kata();
            result = 0;
            expected = 0;
            actual = 0;
        }

        [Test]
        public void Input_0_should_be_0()
        {
            //arrange
            result = kata.DescendingOrder(0);
            //act
            expected = 0;
            actual = result;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Input_12_should_be_21()
        {
            //arrange
            result = kata.DescendingOrder(12);
            //act
            expected = 21;
            actual = result;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Input_1234_should_be_4321()
        {
            //arrange
            result = kata.DescendingOrder(1234);
            //act
            expected = 4321;
            actual = result;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }

}
