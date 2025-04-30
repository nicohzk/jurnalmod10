using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace modul10_103022300127.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private static readonly List<Movie> Movies = new List<Movie>
        {
            new Movie("The Shawshank Redemption", "Frank Darabont", "A banker convicted of uxoricide forms a friendship over a quarter century with a hardened convict, while maintaining his innocence and trying to remain hopeful through simple compassion.", new List<string> { "Tim Robbins", "Morgan Freeman" }),
            new Movie("The Godfather", "Francis Ford Coppola", "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.", new List<string> { "Marlon brando", "AI Pacino" }),
            new Movie("The Dark Knight", "Christopher Nolan", "When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.", new List<string> { "Christian Bale", "Heath Ledger" })
        };

        [HttpGet]   
        public IActionResult Getmovie()
        {
            return Ok(Movies);
        }
        [HttpGet("{id}")]
        public IActionResult GetMovieById(int id)
        {
            if ( id < 0 || id >= Movies.Count)
            {
                return NotFound();
            }
            return Ok(Movies[id]);
        }

        [HttpPost]
        public void Post([FromBody] Movie value)
        {
            Movies.Add(value); 
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteMovie(int id)
        {
            if (id < 0 || id >= Movies.Count)
            {
                return NotFound(); 
            }
            Movies.RemoveAt(id); 
            return NoContent();
        }

    }
}
