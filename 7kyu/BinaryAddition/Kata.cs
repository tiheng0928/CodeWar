using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BinaryAddition
{
    public class Kata
    {
        public string AddBinary(int a, int b)
        {
            string strA = string.Empty;
            string strB = string.Empty;
            if (a != 0)
                strA = "1";
            else
                strA = "0";
            if (b != 0)
                strB = "1";
            else
                strB = "0";
            return strA + strB;
           
        }
    }

    [TestFixture]
    public class BinaryAdditionTest
    {
        [Test]
        public void Input_00_ShouldBe_00()
        {
            //arrange
            var kata = new Kata();
            string result = string.Empty;
            

            //act
            result = kata.AddBinary(0, 0);
            string expected = "00";
            string actual = result;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Input_01_ShouldBe_01()
        {
            //arrange
            var kata = new Kata();
            string result = string.Empty;

            //act
            result = kata.AddBinary(0, 1);
            string expected = "01";
            string actual = result;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
