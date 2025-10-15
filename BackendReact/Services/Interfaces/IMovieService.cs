using BackendReact.Models.DTOs.Movie;

namespace BackendReact.Services.Interfaces
{
    public interface IMovieService
    {
        Task<IEnumerable<MovieCatalogResponseDto>> GetMoviesCatalogWithMetadata();
        Task<MovieResponseDto> GetMovieWithMetadata(int movieId);
    }
}
