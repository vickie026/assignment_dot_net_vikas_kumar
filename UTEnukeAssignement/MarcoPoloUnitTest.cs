using System;
using EnukeAssignment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UTEnukeAssignement
{
    [TestClass]
    public class MarcoPoloUnitTest
    {
        [TestMethod]
        public void MarcoPoloParserTest()
        {
            //arrange
            int limit = 30;
            MarcoPolo marco = new MarcoPolo(limit);
            string expected = "1,2,3,marco,5,6,polo,marco,9,10,11,marco,13,polo,15,marco,17,18,19,marco,polo,22,23,marco,25,26,27,marcopolo,29,30";

            //act
            string actual = marco.Start();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
