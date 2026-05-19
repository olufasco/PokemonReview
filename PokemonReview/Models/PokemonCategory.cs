namespace PokemonReview.Models
{
    public class PokemonCategory
    {
        public int PokemonId { get; set; }
        public int CategoryId { get; set; }
        public string? Pokemon { get; set; }
        public string? Category { get; set; }
    }
}
