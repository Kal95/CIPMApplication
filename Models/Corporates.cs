using System.ComponentModel.DataAnnotations;

namespace CIPMApplication.Models
{
    public class Corporates: Members
    {
        [Required]
        public string Organisation { get; set; }
        [Required]
        public string Bussiness { get; set; }
        [Required]
        public string RCName { get; set; }
    }
}
