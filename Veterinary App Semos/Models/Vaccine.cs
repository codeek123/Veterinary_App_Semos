using System.ComponentModel.DataAnnotations;

namespace Veterinary_App_Semos.Models
{
    public class Vaccine
    {
        public int VaccineId { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Pet> Pets { get; set; } = new List<Pet>();
    }
}
