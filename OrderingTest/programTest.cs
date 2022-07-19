using NUnit.Framework;
using Ordering;

namespace OrderingTest
{
    public class ProgramTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("Sonia Maria Wood Dempster", (object)new[] { '4', '1', '2', '3' }, "Dempster Sonia Maria Wood")]
        [TestCase("Sonia Maria Wood Dempster", (object)new[] { '4', '2', '1', '3' }, "Dempster Maria Sonia Wood")]
        [TestCase("Sonia Maria Wood Dempster", (object)new[] { '4', '1', '2', '3' }, "Dempster Sonia Maria Wood")]
        [TestCase("Laruen Ana Eagles Beneke", (object)new[] { '4', '1', '2', '3' }, "Beneke Laruen Ana Eagles")]
        [TestCase("Laruen Ana Eagles Beneke", (object)new[] { '3', '1', '4', '2' }, "Eagles Laruen Beneke Ana")]
        [TestCase("Laruen Ana Eagles Beneke Sonia", (object)new[] { '2', '3', '5', '1', '4' }, "Ana Eagles Sonia Laruen Beneke")]
        public void reorder_Test(string nameList, char[] CharSortOrder, string expected)
        {
            // ACT
            string actual = Ordering.Program.Reorder(nameList, CharSortOrder);

            // ASSERT

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase("Sonia Maria Wood Dempster", (object)new[] { '4', '1', '2', '3' }, "Dempster Sonia Wood Maria")]
        public void reorder_Test_Fail (string nameList, char[] CharSortOrder, string expected)
        {
            // ACT
            string actual = Ordering.Program.Reorder(nameList, CharSortOrder);

            // ASSERT

            Assert.AreNotEqual(expected, actual);
        }
    }
}

