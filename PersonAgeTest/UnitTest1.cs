using Day10;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PersonAgeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            PersonAge person = new PersonAge();
            int ActualAge = 16;
            int ExpectedAge = person.CheckAge(16);
            Assert.AreEqual(ActualAge, ExpectedAge);
        }
    }
}
