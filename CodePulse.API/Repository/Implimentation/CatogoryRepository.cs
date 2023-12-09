using CodePulse.API.Data;
using CodePulse.API.Model.Domain;
using CodePulse.API.Repository.Interface;

namespace CodePulse.API.Repository.Implimentation
{
    public class CatogoryRepository : ICatogoryRepository
    {
        private readonly ApplicationDbContext dbContext;

        public CatogoryRepository(ApplicationDbContext applicationDbContext)
        {
            this.dbContext = applicationDbContext;
        }
        public async Task<Category> CreateAsync(Category category)
        {
            await dbContext.AddAsync(category);
            await dbContext.SaveChangesAsync();
            return category;
            
        }
    }
}
