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
    }
}
