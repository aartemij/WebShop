using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Shared;

namespace WebShop.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category>();

        public void LoadCategories()
        {
            Categories = new List<Category> {
                new Category { Id = 1, Name = "Dūmu detektori", Url = "detektori", Icon = "detektors" },
                new Category { Id = 2, Name = "Ugunsaizardzības sistēmas", Url = "sistemas", Icon = "sistemas" },
                new Category { Id = 3, Name = "Ugundrošības pakalpojumi", Url = "pakalpojumi", Icon = "pakalpojumi" },
            };
        }
    }
}
