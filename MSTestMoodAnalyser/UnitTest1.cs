using MoodAnlyserProblem;

namespace MSTestMoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_Mood_Sad_Should_Return_Sad()   //testCase1-Reurn Sad
        {
            string input = "I am in Sad Mood";
            string expected = "SAD";


            Mood moodAnalyzer = new Mood("I am in Sad Mood");

            string actual = moodAnalyzer.AnalyzeMood();


            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Given_Mood_Happy_Should_Return_Happy() //testcase2-Return Happy
        {
            string input = "I am in Any Mood";
            string expected = "HAPPY";


            Mood moodAnalyzer = new Mood("I am in happy Mood");

            string actual = moodAnalyzer.AnalyzeMood();

            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void TestMethodForCustomizedNullException()

        {

            try
            {
                string input = null;
                var analyze = new Mood(input);
            }
            catch (NullReferenceException Exception)
            {
                Assert.AreEqual("Mood can not be Null.", Exception.Message);
            }
        }
        [TestMethod]
        public void TestMethodForCustomizedEmptyException()

        {
            string expected = "Mood should not be empty";
            try
            {

                Mood moodAnalyser = new Mood(string.Empty);
                moodAnalyser.AnalyzeMood();
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }

        }

            //[TestMethod]
            //public void Refactor1()                        //Refactor-Testcase1
            //{
            //    string input = "I am in Sad Mood";
            //    string expected = "SAD";


            //    MoodAnalyser moodAnalyser = new MoodAnalyser();

            //    string actual = moodAnalyser.msg;

            //    Assert.AreEqual(expected, actual);
            //}

            //[TestMethod]
            //public void Refactor2()                            //Refactor-TestCase2
            //{
            //    string input = "I am in Happy Mood";
            //    string expected = "SAD";


            //    MoodAnalyser moodAnalyser = new MoodAnalyser();

            //    string actual = moodAnalyser.msg;

            //    Assert.AreEqual(expected, actual);
            //}



    }
}