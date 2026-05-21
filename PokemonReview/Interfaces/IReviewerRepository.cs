using PokemonReview.Models;

namespace PokemonReview.Interfaces
{
    public interface IReviewerRepository
    {
        ICollection<Reviewer> GetReviewers();
    }
}
