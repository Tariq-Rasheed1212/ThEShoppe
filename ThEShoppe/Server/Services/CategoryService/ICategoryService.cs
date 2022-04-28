using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThEShoppe.Shared;

namespace ThEShoppe.Server.Services.CategoryService
{
    public interface ICategoryService
    {

        Task<List<Category>> GetCategories();
    }
}
