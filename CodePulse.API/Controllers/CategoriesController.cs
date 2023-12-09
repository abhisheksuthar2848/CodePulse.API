using CodePulse.API.Data;
using CodePulse.API.Model.Domain;
using CodePulse.API.Model.DTO;
using CodePulse.API.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodePulse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICatogoryRepository catogoryRepository;

        public CategoriesController(ICatogoryRepository catogoryRepository)
        {

            this.catogoryRepository = catogoryRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCatogeryRequestDto request)
        {
            var category = new Category
            {
                //id = new Guid(),
                Name = request.Name,
                UrlHandle = request.UrlHandle
            };

            Category result = await catogoryRepository.CreateAsync(category);
            


            var responce = new CategoryDto
            {
                id = result.id,
                Name = result.Name,
                UrlHandle = result.UrlHandle
            };
            return Ok(category);
        }



    }
}
