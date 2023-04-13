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
    internal class FoodConfiguration : EntityTypeConfiguration<Food>
    {
        public FoodConfiguration()
        {
            //Key

            HasKey(x => x.Id);

            //PropertyArrangement

            Property(x => x.Name).IsRequired().HasMaxLength(50);
            Property(x => x.Protein).IsRequired();
            Property(x => x.Carbohydrate).IsRequired();
            Property(x => x.Fat).IsRequired();
            Property(x => x.Calory).IsRequired();
            Property(x => x.PortionType).IsRequired();
            Property(x => x.CategoryId).IsRequired();
            Property(x => x.Picture).IsOptional();

            //Connections

            HasRequired(x=> x.Category).WithMany(x=> x.Foods).HasForeignKey(x=>x.CategoryId);
        }
    }
}
