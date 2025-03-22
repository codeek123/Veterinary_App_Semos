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
    public class VaccineTests
    {
        [TestMethod]
        public void Vaccine_Name_ShouldBeRequired()
        {
            // Arrange
            var vaccine1 = new Vaccine { Name = "" };
            var vaccine2 = new Vaccine { Name = null };

            // Act
            var validationResults1 = ValidationHelper.ValidateModel(vaccine1);
            var validationResults2 = ValidationHelper.ValidateModel(vaccine2);

            // Assert
            Assert.IsTrue(validationResults1.Any(v => v.MemberNames.Contains("Name")));
            Assert.IsTrue(validationResults2.Any(v => v.MemberNames.Contains("Name")));
        }


        [TestMethod]
        public void Vaccine_CanHaveMultiplePets()
        {
            // Arrange
            var vaccine = new Vaccine
            {
                Name = "Sinovak",
                Pets = new List<Pet>
        {
            new Pet { Name = "Luna", Age = 3 },
            new Pet { Name = "Milo", Age = 5 }
        }
            };

            // Act & Assert
            Assert.AreEqual(2, vaccine.Pets.Count);
        }

        [TestMethod]
        public void Vaccine_CanBeCreated_WithoutPets()
        {
            // Arrange
            var vaccine = new Vaccine { Name = "Sinovak" };

            // Act & Assert
            Assert.IsNotNull(vaccine);
            Assert.AreEqual("Sinovak", vaccine.Name);
            Assert.AreEqual(0, vaccine.Pets.Count);
        }

       

    }
}