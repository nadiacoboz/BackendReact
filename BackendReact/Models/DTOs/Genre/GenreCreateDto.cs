using System.ComponentModel.DataAnnotations;

namespace BackendReact.Models.DTOs.Genre
{
    public class GenreCreateDto
    {
        [Required]
        public string Name { get; set; }

    }
}
