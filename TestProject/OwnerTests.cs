using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinary_App_Semos.Models;

namespace VeterinaryApp.Tests
{
    [TestClass]
    public class OwnerTests
    {

        [TestMethod]
        public void GetFullName_ShouldReturnCorrectFullName()
        {
            // Arrange
            var owner = new Owner { Name = "Ana", Surname = "Koceva" };

            // Act
            var result = owner.getFirstNameAndLastName();

            // Assert
            Assert.AreEqual("Ana Koceva", result);
        }

        [TestMethod]
        public void Owner_Age_ShouldBeValid()
        {
            // Arrange
            var owner = new Owner { Name = "Marko", Surname = "Markovski", Age = 120 };

            // Act
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(owner);
            bool isValid = Validator.TryValidateObject(owner, validationContext, validationResults, true);

            // Assert
            Assert.IsFalse(isValid);
            Assert.AreEqual("Age must be between 18 and 100.", validationResults.First().ErrorMessage);
        }

        [TestMethod]
        public void Owner_Age_BelowLimit_Fails()
        {
            // Arrange
            var owner = new Owner { Name = "Marko", Surname = "Markovski", Age = 15 };

            // Act
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(owner);
            bool isValid = Validator.TryValidateObject(owner, validationContext, validationResults, true);

            // Assert
            Assert.IsFalse(isValid);
            Assert.AreEqual("Age must be between 18 and 100.", validationResults.First().ErrorMessage);
        }

        [TestMethod]
        public void Owner_Name_IsRequired()
        {
            // Arrange
            var owner = new Owner { Surname = "Markovski", Age = 25 };

            // Act
            var validationResults = ValidationHelper.ValidateModel(owner);

            // Assert
            Assert.IsTrue(validationResults.Any(v => v.MemberNames.Contains("Name")));
        }

        [TestMethod]
        public void Owner_Surname_IsRequired()
        {
            // Arrange
            var owner = new Owner { Name = "Marko", Age = 25 };

            // Act
            var validationResults = ValidationHelper.ValidateModel(owner);

            // Assert
            Assert.IsTrue(validationResults.Any(v => v.MemberNames.Contains("Surname")));
        }

       


    }
}