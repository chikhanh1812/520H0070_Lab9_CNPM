using StudentServiceLib;
namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WhenCoreIs9_TheLetter_ShouldBeA()
        {
            Student s = new Student();
            s.Score = 9;
            char letter = s.getLetterScore();
            Assert.AreEqual('A', letter);
        }
        
        [TestMethod]
        public void WhenCoreIs7_TheLetter_ShouldBeB()
        {
            Student s = new Student();
            s.Score = 7;
            char letter = s.getLetterScore();
            Assert.AreEqual('B', letter);
        }
       
        [TestMethod]
        public void WhenCoreIs5_TheLetter_ShouldBeC()
        {
            Student s = new Student();
            s.Score = 5;
            char letter = s.getLetterScore();
            Assert.AreEqual('C', letter);
        }
        
        [TestMethod]
        public void WhenCoreIs3_5_TheLetter_ShouldBeD()
        {
            Student s = new Student();
            s.Score = 3.5;
            char letter = s.getLetterScore();
            Assert.AreEqual('D', letter);
        }
        
        [TestMethod]
        public void WhenCoreIsSmaller3_5_TheLetter_ShouldBeE()
        {
            Student s = new Student();
            s.Score = 3.4;
            char letter = s.getLetterScore();
            Assert.AreEqual('E', letter);
        }
    }
}
