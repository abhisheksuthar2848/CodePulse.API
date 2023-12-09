using CodePulse.API.Model.Domain;

namespace CodePulse.API.Repository.Interface
{
    public interface ICatogoryRepository
    {
        Task<Category> CreateAsync(Category category);
    }
}
