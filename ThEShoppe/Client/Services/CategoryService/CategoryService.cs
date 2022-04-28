using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ThEShoppe.Shared;

namespace ThEShoppe.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _http;

        public List<Category> Categories { get; set; } = new List<Category>();

        public CategoryService(HttpClient http)
        {
            _http = http;
        }

        public async Task LoadCategories()
        {
            Categories = await _http.GetFromJsonAsync<List<Category>>("api/Category");
        }
    }
}

//{
//new Category {  new Category { Id = 1, Name = "Drama", Url = "drama", Icon = "camera-slr" },
               // new Category { Id = 2, Name = "Comedy", Url = "comedy", Icon = "camera-slr" },
                //new Category { Id = 5, Name = "Action", Url = "action", Icon = "camera-slr" },
               // new Category { Id = 7, Name = "Romantic", Url = "romantic", Icon = "camera-slr" },
          //  };