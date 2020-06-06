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
            return 0;
        }
    }

    [TestFixture]
    public class DescendingOrder_Test
    {
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
    }

}
