using System.ComponentModel.DataAnnotations;

namespace CIPMApplication.Models
{
    public class Students : Members
    {
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Discipline { get; set; }
        [Required]
        public string Institution { get; set; }


    }
}
