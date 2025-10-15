using BackendReact.Models.DTOs.Genre;
using BackendReact.Models.Entities;

namespace BackendReact.Services.Interfaces
{
    public interface IGenreService
    {
        Task<IEnumerable<GenreResponseDto>> GetAllGenresAsync();
        Task<GenreResponseDto> GetGenreByIdAsync(int id);
        Task AddGenreAsync(GenreCreateDto dto);
        Task UpdateGenreAsync(GenreUpdateDto dto);
        Task DeleteGenreAsync(int id);
    }
}
