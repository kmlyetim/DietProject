using Fake.DAL.Context;
using Fake.DAL.Entities;
using Fake.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fake.DAL.Repository
{
    public class FoodRepository
    {
        FakeContext db;
        public FoodRepository()
        {
            db= new FakeContext();
        }
        public Food GetFoodById(int id)
        {
            return db.Foods.Find(id);
        }
        public void AddFood(Food food)
        {
            db.Foods.Add(food);
            db.SaveChanges();
        }
        public void UpdateFood(Food updatedFoodInfo)
        {
            Food willBeUpdated = GetFoodById(updatedFoodInfo.Id);
            db.Entry(willBeUpdated).CurrentValues.SetValues(updatedFoodInfo);
            db.SaveChanges();
        }
        public void DeleteUser(Food food)
        {
            Food willBeRemovedFood = GetFoodById(food.Id);
            db.Foods.Remove(willBeRemovedFood);
            db.SaveChanges();
        }
        public List<Food> List(string search)
        {
            return db.Foods.Where(x=>x.Name.Contains(search)).ToList();
        }
        public Food GetFoodByName(string name)
        {
            return db.Foods.Where(x => x.Name == name).FirstOrDefault();
        }
    }
}
