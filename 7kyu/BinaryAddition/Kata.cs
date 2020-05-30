using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace BinaryAddition
{
    public class Kata
    {
        public string AddBinary(int a, int b)
        {
            string strA = string.Empty;
            string strB = string.Empty;
            strA = a != 0 ? "1" : "0";
            strB = b != 0 ? "1" : "0";
            return strA + strB;
           
        }
    }

    [TestFixture]
    public class BinaryAdditionTest
    {
        Kata kata;
        string result = string.Empty;
        string expected = string.Empty;
        string actual = string.Empty;


        [SetUp]
        public void SetUp()
        {
            kata = new Kata();
            result = string.Empty;
            expected = string.Empty;
            actual = string.Empty;
        }

        [Test]
        public void Input_00_ShouldBe_00()
        {
            //arrange

            //act
            result = kata.AddBinary(0, 0);
            expected = "00";
            actual = result;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Input_01_ShouldBe_01()
        {
            //arrange

            //act
            result = kata.AddBinary(0, 1);
            expected = "01";
            actual = result;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Input_23_ShouldBe_11()
        {
            //arrange

            //act
            result = kata.AddBinary(2, 3);
            expected = "11";
            actual = result;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
