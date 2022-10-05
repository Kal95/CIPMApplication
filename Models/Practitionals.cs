using System.ComponentModel.DataAnnotations;

namespace CIPMApplication.Models
{
    public class Practitionals : Members
    {
        [Required]
        public string Discipline { get; set; }
        [Required]
        public string Organisation { get; set; }

        public string Designation { get; set; }
    }
}
