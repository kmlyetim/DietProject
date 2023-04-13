using Fake.DAL.Context;
using Fake.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fake.DAL.Repository
{
    public class CategoryRepository
    {
        FakeContext db;
        public CategoryRepository()
        {
            db= new FakeContext();
        }
        public List<Category> GetCategories()
        {
            return db.Categories.ToList();
        }
    }
}
