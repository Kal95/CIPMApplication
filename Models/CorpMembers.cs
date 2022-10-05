using System.ComponentModel.DataAnnotations;

namespace CIPMApplication.Models
{
    public class CorpMembers: Members
    {
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Discipline { get; set; }
        [Required]
        public string YearOfService { get; set; }
    }
}
