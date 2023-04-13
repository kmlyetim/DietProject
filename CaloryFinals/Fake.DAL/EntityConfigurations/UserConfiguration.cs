using Fake.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fake.DAL.EntityConfigurations
{
    internal class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            //Key

            HasKey(x => x.Id);

            //PropertyArrangement
            
            Property(x=> x.Password).IsRequired().HasMaxLength(16);
            Property(x=> x.FirstName).IsRequired().HasMaxLength(50);
            Property(x=> x.LastName).IsRequired().HasMaxLength(50);
            HasIndex(x=> x.Email).IsUnique();
            Property(x=> x.Email).IsRequired().HasMaxLength(50);
            Property(x=> x.Height).IsRequired();
            Property(x=> x.Weight).IsRequired();            
            Property(x=> x.Gender).IsRequired();
            Property(x=> x.BirthDate).IsRequired();
            Property(x=> x.ActivityState).IsRequired();
            Property(x=> x.PhoneNumber).IsRequired();
            Property(x=> x.Picture).HasColumnType("image");
            
        }
    }
}
