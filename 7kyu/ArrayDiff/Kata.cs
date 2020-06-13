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
        private Kata kata;
        private int[] expected;
        private int[] actual;
        private int[] inputA;
        private int[] inputB;

        [SetUp]
        public void SetUp()
        {
            kata = new Kata();
        }


        [Test]
        public void Input_0_and_1_shouldbe_0()
        {
            //arrange
            inputA = new int[] { 0 };
            inputB = new int[] { 1 };
            //act
            actual = kata.ArrayDiff(inputA,inputB);
            expected = new int[] { 0 };
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Input_0n1n2n3_and_0n2_shouldbe_1n3()
        {
            //arrange
            inputA = new int[] { 0,1,2,3 };
            inputB = new int[] { 0,2 };
            //act
            actual = kata.ArrayDiff(inputA, inputB);
            expected = new int[] { 1,3 };
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Input_12n14n3n6n9_and_0n9n13n6_shouldbe_12n14n3()
        {
            //arrange
            inputA = new int[] { 12,14,3,6,9 };
            inputB = new int[] { 0,9,13,6 };
            //act
            actual = kata.ArrayDiff(inputA, inputB);
            expected = new int[] { 3,12,14 };
            //assert
            Assert.AreEqual(expected, actual);
        }

    }
    

}
