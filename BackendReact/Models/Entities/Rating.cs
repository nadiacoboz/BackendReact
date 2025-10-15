using BackendReact.Models.Entities;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace BackendReact.Models.Entities
{
    public class Rating
    {
        public int Id { get; set; }
        public int Score { get; set; }//1 to 5
        public string Comment { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

    }
}
