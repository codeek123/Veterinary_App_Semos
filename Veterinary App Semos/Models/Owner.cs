using System.ComponentModel.DataAnnotations;

namespace Veterinary_App_Semos.Models
{
    public class Owner
    {
        [Key]
        public int OwnerId { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Range(18, 100, ErrorMessage = "Age must be between 18 and 100.")]
        public int Age { get; set; }
      //  public List<Pet> Pets { get; set; } = new List<Pet>();

        public string getFirstNameAndLastName() { return $"{Name} {Surname}"; }
    }
}
