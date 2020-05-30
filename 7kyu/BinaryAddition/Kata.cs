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
            return Convert.ToString(a+b,2);
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
            expected = "0";
            actual = result;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Input_01_ShouldBe_00()
        {
            //arrange

            //act
            result = kata.AddBinary(0, 1);
            expected = "1";
            actual = result;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Input_23_ShouldBe_101()
        {
            //arrange

            //act
            result = kata.AddBinary(2, 3);
            expected = "101";
            actual = result;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Input_10n3_ShouldBe_1101()
        {
            //arrange

            //act
            result = kata.AddBinary(10, 3);
            expected = "1101";
            actual = result;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Input_f10n3_ShouldBe_11111111111111111111111111111001()
        {
            //arrange

            //act
            result = kata.AddBinary(-10, 3);
            expected = "11111111111111111111111111111001";
            actual = result;

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
