using PokemonReview.Models;

namespace PokemonReview.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemon();
        Pokemon GetPokemon(int pokeId);
        Pokemon GetPokemon(string name);
        decimal GetPokemonRating(int pokeId);
        bool PokemonExists(int pokeId);
    }
}
