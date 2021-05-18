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
        public void ResetHouse()
        {
            //Arrange: 
            House thehouse = new House(0,0);
            //Act:
            thehouse.ResetHouse();
            //Assert: 
            Assert.AreEqual(4, thehouse.GetCount(),"Resetting House")
        }
        public void AddSeedToScoreHouse()
        {
            
        } 
    }
}