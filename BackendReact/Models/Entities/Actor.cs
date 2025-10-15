using BackendReact.Models.Entities;

namespace BackendReact.Models.Entities
{
    public class Actor
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PictureUrl { get; set; }
        public ICollection<MovieActor> MovieActors { get; set; }
    }
}
