
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
    public class PetTests
    {
        [TestMethod]
        public void Pet_GetDetails_Should_Include_Name_Age_OwnerId()
        {
            // Arrange
            var pet = new Pet { Name = "Luna", Age = 5, OwnerId = 1 };

            // Act
            var result = pet.GetDetailsForPet();

            // Assert
            Assert.AreEqual("Pet Name: Luna, Age: 5, Owner ID: 1", result);
        }

        [TestMethod]
        public void Pet_Name_IsRequired()
        {
            // Arrange
            var pet = new Pet { Age = 5 };

            // Act
            var validationResults = ValidateModel(pet);

            // Assert
            Assert.IsTrue(validationResults.Any(v => v.MemberNames.Contains("Name")));
        }

       

        [TestMethod]
        public void Pet_Age_AboveLimit_Fails()
        {
            // Arrange
            var pet = new Pet { Name = "Luna", Age = 60 }; 

            // Act
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(pet);
            bool isValid = Validator.TryValidateObject(pet, validationContext, validationResults, true);

            // Assert
            Assert.IsFalse(isValid);
            Assert.AreEqual("Age must be between 0 and 50 years.", validationResults.First().ErrorMessage);
        }

        [TestMethod]
        public void Pet_Age_ShouldNotBeNegative()
        {
            // Arrange
            var pet = new Pet { Name = "Luna", Age = -1 };

            // Act
            var validationResults = ValidateModel(pet);

            // Assert
            Assert.IsTrue(validationResults.Any(v => v.MemberNames.Contains("Age")));
        }


        [TestMethod]
        public void Pet_ShouldBeLinkedToOwner()
        {
            // Arrange
            var owner = new Owner { Name = "Ana", Surname = "Koceva" };
            var pet = new Pet { Name = "Luna", Age = 3, Owner = owner };

            // Act & Assert
            Assert.AreEqual("Ana", pet.Owner.Name);
        }

        [TestMethod]
        public void Pet_CanHaveVaccines()
        {
            // Arrange
            var pet = new Pet { Name = "Luna", Age = 2 };
            var vaccine1 = new Vaccine { Name = "Sinovak" };
            var vaccine2 = new Vaccine { Name = "PetVaccine2" };

            // Act
            pet.Vaccines.Add(vaccine1);
            pet.Vaccines.Add(vaccine2);

            // Assert
            Assert.AreEqual(2, pet.Vaccines.Count);
            Assert.AreEqual("Sinovak", pet.Vaccines[0].Name);
            Assert.AreEqual("PetVaccine2", pet.Vaccines[1].Name);
        }

        [TestMethod]
        public void Pet_GetDetails_ShouldNotBeEmpty()
        {
            // Arrange
            var pet = new Pet { Name = "Luna", Age = 3, OwnerId = 1 };

            // Act
            var result = pet.GetDetailsForPet();

            // Assert
            Assert.IsFalse(string.IsNullOrEmpty(result));
        }



        private static List<ValidationResult> ValidateModel(object model)
        {
            var validationResults = new List<ValidationResult>();
            var context = new ValidationContext(model, null, null);
            Validator.TryValidateObject(model, context, validationResults, true);
            return validationResults;
        }
    }
}
