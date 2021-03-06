using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThEShoppe.Shared;

namespace ThEShoppe.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category> {
                new Category { Id = 1, Name = "Drama", Url = "drama", Icon = "camera-slr" },
                new Category { Id = 2, Name = "Comedy", Url = "comedy", Icon = "camera-slr" },
                new Category { Id = 5, Name = "Action", Url = "action", Icon = "camera-slr" },
                new Category { Id = 7, Name = "Romantic", Url = "romantic", Icon = "camera-slr" },
            };
        public async Task<List<Category>> GetCategories()
        {
            return Categories;
        }
    }
}
