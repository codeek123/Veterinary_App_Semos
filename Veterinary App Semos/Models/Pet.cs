using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Veterinary_App_Semos.Models
{
    public class Pet
    {
        public int PetId { get; set; }

        [Required]
        public string Name { get; set; }
        [Range(0, 50, ErrorMessage = "Age must be between 0 and 50 years.")]
        public int Age { get; set; }

       
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }

        public List<Vaccine> Vaccines { get; set; } = new List<Vaccine>();

        public string GetDetailsForPet()
        {
            return $"Pet Name: {Name}, Age: {Age}, Owner ID: {OwnerId}";
        }

        [NotMapped]
        public List<int> VaccinesNames { get; set; }
    }
}
