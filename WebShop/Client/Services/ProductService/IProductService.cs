using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Shared;

namespace WebShop.Client.Services.ProductService
{
    internal interface IProductService
    {
        List<Product> Products { get; set; }
        void LoadProducts();

    }
}