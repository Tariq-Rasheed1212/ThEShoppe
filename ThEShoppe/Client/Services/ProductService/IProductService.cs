using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThEShoppe.Shared;

namespace ThEShoppe.Client.Services.ProductService
{
    interface IProductService
    {
        List<Product> Products { get; set; }
        void LoadProducts();
    }
}
