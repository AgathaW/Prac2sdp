using NUnit.Framework;

namespace Oware.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ResetHouseTest()
        {
            //Arrange: 
            House thehouse = new House(0,0);
            //Act:
            thehouse.ResetHouse();
            //Assert: 
            Assert.AreEqual(4, thehouse.GetCount(),"Resetting House")
        }
    }
}