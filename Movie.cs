using System.Reflection;

namespace modul10_103022300127
{
    public class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public string Description { get; set; }
        public List<string> Stars { get; set; }

        public Movie(string Title, string Director, string Description, List<string> Star)
        {
            this.Title = Title;
            this.Director = Director;
            this.Description = Description;
            this.Stars = Star;
        }   
    }
}
