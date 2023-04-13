using Fake.DAL.Entities;
using Fake.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fake.DAL.EntityConfigurations
{
    internal class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            //Key

            HasKey(x => x.Id);

            //ProperyArrangement

            Property(x => x.Description).IsRequired();
            Property(x => x.Name).IsRequired().HasMaxLength(50);
        }
    }
}
