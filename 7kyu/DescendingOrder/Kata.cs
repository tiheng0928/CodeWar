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
        public static int DescendingOrder(int num)
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
        [Test]
        public void Input_0_should_be_0()
        {
            //arrange
            var result = Kata.DescendingOrder(0);
            //act
            var expected = 0;
            var actual = result;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Input_12_should_be_21()
        {
            //arrange
            var result = Kata.DescendingOrder(12);
            //act
            var expected = 21;
            var actual = result;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }

}
