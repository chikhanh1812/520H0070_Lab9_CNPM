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

       
    }
}