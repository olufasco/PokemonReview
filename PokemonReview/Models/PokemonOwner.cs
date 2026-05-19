namespace PokemonReview.Models
{
    public class PokemonOwner
    {
        public int PokemonId { get; set; }
        public int OwnerId { get; set; }
        public string? Pokemon { get; set; }
        public string? Owner { get; set; }
    }
}
