using Fake.DAL.Entities;
using Fake.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fake.Business.Services
{
    public class CategoryService
    {
        CategoryRepository categoryRepository;
        public CategoryService()
        {
            categoryRepository = new CategoryRepository();
        }
        public List<Category> GetCategories()
        {
            return categoryRepository.GetCategories();
        }
    }
}
