using System.ComponentModel.DataAnnotations;

namespace WebApplicationTempleIntegration.Models
{
    public class App
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Department { get; set; }

        [Required]
        public string Doctor { get; set; }

        public string? Message { get; set; }
    }
}
