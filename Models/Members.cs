using System.ComponentModel.DataAnnotations;

namespace CIPMApplication.Models
{
    public abstract class Members
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }

        [Required]
        public string Email { get; set; }
        [Required]
        public string Street { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public DateTime Created { get; set; }
        [Required]
        public Status Status { get; set; }
    }

    public enum Status
    {
        Active = 101,
        Inactive,
        Suspended

    }


}