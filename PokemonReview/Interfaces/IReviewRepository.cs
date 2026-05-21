using PokemonReview.Models;

namespace PokemonReview.Interfaces
{
    public interface    IReviewRepository
    {
        ICollection<Review> GetReviews();
    }
}
