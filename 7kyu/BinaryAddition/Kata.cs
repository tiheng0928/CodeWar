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
            throw new NotImplementedException();
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
    }
}
