using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class UpdateDto
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public int Age { get; set; }
    }
}