using Fake.DAL.Context;
using Fake.DAL.Entities;
using Fake.DAL.Enums;
using Fake.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Fake.DAL.Repository
{
    public class MealFoodRepository
    {
        FakeContext db = new FakeContext();
        public void AddMealFoods(MealFood mealFood)
        {
            db.MealFoods.Add(mealFood);
            db.SaveChanges();
        }

        public void DeleteMealFood(int mealId,int foodId)
        {
            db.MealFoods.Remove(db.MealFoods.Where(x => x.MealId == mealId && x.FoodId==foodId).First());
            db.SaveChanges();
        }

        public List<MealFood> GetBreakfastMealFoods(int mealId)
        {
            return db.MealFoods.Where(a=> a.MealId==mealId && a.Meal.MealType==MealType.BreakFast).ToList();
        }

        public List<MealFood> GetLunchMealFoods(int mealId)
        {
            return db.MealFoods.Where(a => a.MealId == mealId && a.Meal.MealType == MealType.Lunch).ToList();
        }

        public List<MealFood> GetDinnerMealFoods(int mealId)
        {
            return db.MealFoods.Where(a => a.MealId == mealId && a.Meal.MealType == MealType.Dinner).ToList();
        }

        public List<MealFood> GetSnackMealFoods(int mealId)
        {
            return db.MealFoods.Where(a => a.MealId == mealId && a.Meal.MealType == MealType.Snack).ToList();
        }
        public bool SearchFood(int foodId,int mealId)
        {
            return db.MealFoods.Any(a => a.FoodId == foodId && a.MealId==mealId);
        }
        public List<MealFood> GetAllMealFoodsByMealId(int mealId)
        {
            return db.MealFoods.Where(x => x.MealId == mealId).ToList();
        }
        public double GetTakenTotalCarbonhydrate(User user, DateTime selectedTime)       //////////////////////////////////
        {
            double TotalC = 0;
            var list = db.MealFoods.Where(x => x.Meal.UserId == user.Id && DbFunctions.TruncateTime(x.Meal.CreateDate) == selectedTime).Select(x => new { Totaly = (x.Amount * x.Food.Carbohydrate) }).ToList();
            foreach (var item in list)
            {
                TotalC += item.Totaly;
            }
            return TotalC;
        }
        public double GetTakenTotalProtein(User user, DateTime selectedTime)
        {
            double TotalP = 0;
            var list = db.MealFoods.Where(x => x.Meal.UserId == user.Id && DbFunctions.TruncateTime(x.Meal.CreateDate) == selectedTime).Select(x => new { Totaly = (x.Amount * x.Food.Protein) }).ToList();
            foreach (var item in list)
            {
                TotalP += item.Totaly;
            }
            return TotalP;
        }
        public double GetTakenTotalFat(User user, DateTime selectedTime)
        {
            double TotalF = 0;
            var list = db.MealFoods.Where(x => x.Meal.UserId == user.Id && DbFunctions.TruncateTime(x.Meal.CreateDate) == selectedTime).Select(x => new { Totaly = (x.Amount * x.Food.Fat) }).ToList();
            foreach (var item in list)
            {
                TotalF += item.Totaly;
            }
            return TotalF;
        }
    }
}
