namespace PokemonReview.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Gym { get; set; }
        public string? Country { get; set; }
        public PokemonOwner? PokemonOwners { get; set; }
    }
}
