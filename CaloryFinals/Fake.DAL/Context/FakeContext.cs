using Fake.DAL.Entities;
using Fake.DAL.EntityConfigurations;
using Fake.DAL.Strategy;
using Fake.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fake.DAL.Context
{
    public class FakeContext:DbContext
    {
        public FakeContext() : base("Server=LAPTOP-E2H70HJH;Database=FakeDatabase;Trusted_Connection=True;")
        {
            Database.SetInitializer(new FakeStrategy());
        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<Meal> Meals { get; set; }
        public virtual DbSet<Category> Categories { get; set; }        

        public virtual DbSet<MealFood> MealFoods { get; set; }
        public virtual DbSet<Message> Messages { get; set; }

        private void FixEfProviderServicesProblem()
        {
            // The Entity Framework provider type 'System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer'
            // for the 'System.Data.SqlClient' ADO.NET provider could not be loaded. 
            // Make sure the provider assembly is available to the running application. 
            // See http://go.microsoft.com/fwlink/?LinkId=260882 for more information.
            var instance = SqlProviderServices.Instance;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {            
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new FoodConfiguration());
            modelBuilder.Configurations.Add(new MealConfiguration());
            modelBuilder.Configurations.Add(new MealFoodConfiguration());
            modelBuilder.Configurations.Add(new CategoryConfiguration());
        }
    }
}
