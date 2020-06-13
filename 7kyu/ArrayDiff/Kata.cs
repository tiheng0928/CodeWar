using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDiff
{
    public class Kata
    {
        public int[] ArrayDiff(int[] A, int[] B)
        {
            return A.Where(o => B.Contains(o) == false).Select(o => o).ToArray();
        }
    }

    [TestFixture]
    public class ArrayDiffTest
    {

        [Test]
        public void Input_0_and_1_shouldbe_0()
        {
            //arrange
            var kata = new Kata();
            int[] expected;
            int[] actual;
            //act
            actual = kata.ArrayDiff(new int[] { 0 }, new int[] { 1 });
            expected = new int[] { 0 };
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Input_0n1n2n3_and_0n2_shouldbe_1n3()
        {
            //arrange
            var kata = new Kata();
            int[] expected;
            int[] actual;
            //act
            actual = kata.ArrayDiff(new int[] { 0,1,2,3 }, new int[] { 0,2 });
            expected = new int[] { 1,3 };
            //assert
            Assert.AreEqual(expected, actual);
        }

    }
    

}
