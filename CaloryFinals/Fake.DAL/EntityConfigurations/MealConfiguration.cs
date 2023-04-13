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
    internal class MealConfiguration : EntityTypeConfiguration<Meal>
    {
        public MealConfiguration()
        {
            //Key

            HasKey(x => x.Id);

            //

            Property(x => x.CreateDate).HasColumnType("date");

            //Connections

            HasRequired(x=>x.User).WithMany(x=>x.Meals).HasForeignKey(x=>x.UserId);
                        
        }
    }
}
