using System;
using EnukeAssignment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UTEnukeAssignement
{
    [TestClass]
    public class MergeSortedArrayUnitTest
    {
        [TestMethod]
        public void Merge_Test()
        {
            //arrange
            int[] inputArray1 = { };
            int[] inputArray2 = { 1, 2, 3, 4, 5, 7 };
            int[] expected = { 1, 2, 3, 4, 5, 7 };
            MergeSortedArrays merger = new MergeSortedArrays(inputArray1, inputArray2);

            //act
            merger.Merge();

            //assert
            CollectionAssert.AreEqual(expected, merger.MergedArray);
        }
    }
}
