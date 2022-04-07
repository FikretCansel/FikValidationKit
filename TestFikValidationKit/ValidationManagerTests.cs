using FikValidation.FikValidation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestFikValidationKit
{
    [TestClass]
    public class ValidationManagerTests
    {
        [TestMethod]
        public void GraterThan_XGraterY_ReturnsTrue()
        {
            //Arrange
            double x = 10;
            double y = 5;
            //Act
            var validationManager = new ValidationManager(new FikValidationErrorMessagesTr());
            var result=validationManager.GraterThan(x, y);
            //Assert
            Assert.IsTrue(result.IsSuccess);

        }
        [TestMethod]
        public void GraterThan_XEqualsY_ReturnsFalse()
        {
            double x = 10;
            double y = 10;

            var validationManager = new ValidationManager(new FikValidationErrorMessagesTr());
            var result = validationManager.GraterThan(x, y);
            Assert.IsFalse(result.IsSuccess);

        }
        [TestMethod]
        public void GraterThan_XSmallerThanY_ReturnsFalse()
        {
            double x = 10;
            double y = 20;

            var validationManager = new ValidationManager(new FikValidationErrorMessagesTr());
            var result = validationManager.GraterThan(x, y);
            Assert.IsFalse(result.IsSuccess);

        }
        [TestMethod]
        public void IsEquals_EqualsDoublesXAndY_ReturnsTrue()
        {
            double x = 10;
            double y = 10;

            var validationManager = new ValidationManager(new FikValidationErrorMessagesTr());
            var result = validationManager.IsEquals(x, y);
            Assert.IsTrue(result.IsSuccess);
        }
        [TestMethod]
        public void IsEquals_NotEqualsDoublesXAndStringY_ReturnsFalse()
        {
            double x = 10;
            string y = "Fikret";

            var validationManager = new ValidationManager(new FikValidationErrorMessagesTr());
            var result = validationManager.IsEquals(x, y);
            Assert.IsFalse(result.IsSuccess);
        }
        [TestMethod]
        public void IsEquals_NotEqualsStringXAndStringY_ReturnsFalse()
        {
            double x = 10;
            string y = "Fikret";

            var validationManager = new ValidationManager(new FikValidationErrorMessagesTr());
            var result = validationManager.IsEquals(x, y);
            Assert.IsFalse(result.IsSuccess);
        }

        [TestMethod]
        public void IsEquals_EqualsStringXAndStringY_ReturnsTrue()
        {
            string x = "Fikret";
            string y = "Fikret";

            var validationManager = new ValidationManager(new FikValidationErrorMessagesTr());
            var result = validationManager.IsEquals(x, y);
            Assert.IsTrue(result.IsSuccess);
        }

        [TestMethod]
        public void NotEmpty_EmptyString_ReturnsFalse()
        {
            string x = "";

            var validationManager = new ValidationManager(new FikValidationErrorMessagesTr());
            var result = validationManager.NotEmpty(x);
            Assert.IsFalse(result.IsSuccess);
        }

        [TestMethod]
        public void NotEmpty_Null_ReturnsFalse()
        {
            string x=null;

            var validationManager = new ValidationManager(new FikValidationErrorMessagesTr());
            var result = validationManager.NotEmpty(x);
            Assert.IsFalse(result.IsSuccess);
        }
        [TestMethod]
        public void NotEmpty_AString_ReturnsTrue()
        {
            string x = "Hello world";

            var validationManager = new ValidationManager(new FikValidationErrorMessagesTr());
            var result = validationManager.NotEmpty(x);
            Assert.IsTrue(result.IsSuccess);
        }



    }
}
