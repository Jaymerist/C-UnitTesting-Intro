using Assignment4Part4_MihiriKamiss;
namespace Assignment4Part4_MihiriKamiss_Test
{
    public class BodyMassIndexTest
    {
        [Test,
            TestCase("", "Name cannot be blank"),
            TestCase(" ", "Name cannot be blank")]
        public void Name_BlankName_ThrowsException(string name, string expectedErrorMessage)
        {
            //Arrange
            int defaultNum = 1;
            //Act
            try
            {
                BodyMassIndex currentPerson = new BodyMassIndex(name, defaultNum, defaultNum);
                Assert.Fail("An exception should have been thrown");
            }
            catch (Exception ex)
            {
                //Assert
                StringAssert.Contains(ex.Message, expectedErrorMessage);
            }
        }//end of Name_BlankName_ThrowsException

        [Test,
            TestCase(0, "Weight must be a positive non-zero number"),
            TestCase(-100, "Weight must be a positive non-zero number")]
        public void Weight_NonPositiveWeight_ThrowsException(int weight, string expectedErrorMessage)
        {
            //Arrange
            string defaultName= "name";
            int defaultNum= 1;  
            //Act
            try
            {
                BodyMassIndex currentPerson = new BodyMassIndex(defaultName, weight, defaultNum);
                Assert.Fail("An exception should have been thrown");
            }
            catch (Exception ex)
            {
                //Assert
                StringAssert.Contains(ex.Message, expectedErrorMessage);
            }
        }//end of Name_BlankName_ThrowsException

        [Test,
            TestCase(0, "Height must be a positive non-zero number"),
            TestCase(-100, "Height must be a positive non-zero number")]
        public void Height_NonPositiveHeight_ThrowsException(int height, string expectedErrorMessage)
        {
            //Arrange
            string defaultName= "name";
            int defaultNum= 1;  
            //Act
            try
            {
                BodyMassIndex currentPerson = new BodyMassIndex(defaultName, defaultNum, height);
                Assert.Fail("An exception should have been thrown");
            }
            catch (Exception ex)
            {
                //Assert
                StringAssert.Contains(ex.Message, expectedErrorMessage);
            }
        }//end of Name_BlankName_ThrowsException

        [Test,
            TestCase("Underweight Person1", 90, 60 , 17.6, "underweight"),
            TestCase("Underweight Person2", 120, 75, 15.0, "underweight")]
        public void BmiCategory_UnderWeightCategory_ReturnsBmiAndCategory(string name, int weight, int height, double expectedBmi, string expectedCategory)
        {
            //arrange and act
            BodyMassIndex currentBMI = new BodyMassIndex(name, weight, height);

            //assert
            Assert.AreEqual(expectedBmi, currentBMI.Bmi());
            Assert.AreEqual(expectedCategory, currentBMI.BmiCategory());
            
        }//end of Name_BlankName_ThrowsException

        [Test,
            TestCase("Normal weight Person1", 111, 65, 18.5, "normal"),
            TestCase("Normal weight Person2", 149, 65, 24.8, "normal")]
        public void BmiCategory_NormalWeightCategory_ReturnsBmiAndCategory(string name, int weight, int height, double expectedBmi, string expectedCategory)
        {
            //arrange and act
            BodyMassIndex currentBMI = new BodyMassIndex(name, weight, height);

            //assert
            Assert.AreEqual(expectedBmi, currentBMI.Bmi());
            Assert.AreEqual(expectedCategory, currentBMI.BmiCategory());

        }//end of Name_BlankName_ThrowsException

        [Test,
            TestCase("Overweight Person1", 150, 65, 25.0, "overweight"),
            TestCase("Overweight Person2", 179, 65, 29.8, "overweight")]
        public void BmiCategory_OverWeightCategory_ReturnsBmiAndCategory(string name, int weight, int height, double expectedBmi, string expectedCategory)
        {
            //arrange and act
            BodyMassIndex currentBMI = new BodyMassIndex(name, weight, height);

            //assert
            Assert.AreEqual(expectedBmi, currentBMI.Bmi());
            Assert.AreEqual(expectedCategory, currentBMI.BmiCategory());

        }//end of Name_BlankName_ThrowsException

        [Test,
            TestCase("Obese Person1", 180, 65, 30.0, "obese"),
            TestCase("Obese Person2", 210, 65, 34.9, "obese")]
        public void BmiCategory_ObeseCategory_ReturnsBmiAndCategory(string name, int weight, int height, double expectedBmi, string expectedCategory)
        {
            //arrange and act
            BodyMassIndex currentBMI = new BodyMassIndex(name, weight, height);

            //assert
            Assert.AreEqual(expectedBmi, currentBMI.Bmi());
            Assert.AreEqual(expectedCategory, currentBMI.BmiCategory());

        }//end of Name_BlankName_ThrowsException
    }
}