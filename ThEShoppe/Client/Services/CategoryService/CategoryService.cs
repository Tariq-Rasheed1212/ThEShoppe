using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThEShoppe.Shared;

namespace ThEShoppe.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category>

        public void LoadCategories()
        {
            Categories = new List<Category>
            {
                new Category { Id =1, Name = "Drama", Url = "drama", Icon = "drama"},
                new Category { Id =2, Name = "Comedy", Url = "comedy", Icon = "comedy"},
                new Category { Id =5, Name = "Action", Url = "action", Icon = "action"},
                new Category { Id =7, Name = "Romantic", Url = "romantic", Icon = "romantic"},
            };
        }
    }
}
