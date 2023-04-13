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
    public class MealFoodConfiguration : EntityTypeConfiguration<MealFood>
    {
        public MealFoodConfiguration()
        {
            HasKey(xy => new
            {
                xy.FoodId,xy.MealId
            });
            
            Property(x=> x.MealId).IsRequired();
            Property(x=> x.FoodId).IsRequired();
            Property(x=> x.Amount).IsRequired();

            //Connections

            HasRequired(xy=> xy.Food).WithMany(x=> x.Meals).HasForeignKey(x=>x.FoodId);

            HasRequired(xy=> xy.Meal).WithMany(y=> y.Foods).HasForeignKey(y=>y.MealId);
        }
    }
}
