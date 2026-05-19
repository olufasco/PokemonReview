namespace PokemonReview.Models
{
    public class Pokemon
    {
        public int Id {  get; set; }
        public string Name { get; set; }  = string.Empty;
        public DateTime BirthDate { get; set; }
        public ICollection <Review> Reviews  { get; set; } = new List<Review>();
        public PokemonOwner? PokemonOwners { get; set; } 
        public PokemonCategory? PokemonCategories { get; set; }
    }
}
