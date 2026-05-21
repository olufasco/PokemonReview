using Microsoft.AspNetCore.Authentication.Cookies;
using PokemonReview.Data;
using PokemonReview.Models;

namespace PokemonReview.Repositories
{
    public class PokemonRepository
    {
        private readonly DataContext _context;

        public PokemonRepository(DataContext context) 
        {
            _context = context;
        }

        public ICollection<Pokemon> GetPokemons()
        {
            return _context.Pokemon.OrderBy(p => p.Id).ToList();
        }
    }
}
