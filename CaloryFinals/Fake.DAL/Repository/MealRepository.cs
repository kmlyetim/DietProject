using Fake.DAL.Context;
using Fake.DAL.Entities;
using Fake.DAL.Enums;
using Fake.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fake.DAL.Repository
{
    public class MealRepository
    {
        FakeContext db = new FakeContext();
        public List<Meal> GetMealListFromDate(DateTime selectedDate, User user)
        {
            return db.Meals.Where(a => a.CreateDate == selectedDate.Date && a.User.Id == user.Id).ToList();
        }
        public Meal GetMealFromMealId(int mealId)
        {
            return db.Meals.Where(a => a.Id == mealId).First();
        }
        public void AddMeals(Meal meal)
        {
            db.Meals.Add(meal);
            db.SaveChanges();
        }

        public void DeleteMeals(int mealId)
        {
            db.Meals.Remove(db.Meals.Where(x=> x.Id==mealId).First());
            db.SaveChanges();
        }
        public void UpdateMeal(Meal mealFood)
        {
            Meal willBeUpdated = GetMealFromMealId(mealFood.Id);
            db.Entry(willBeUpdated).CurrentValues.SetValues(mealFood);
            db.SaveChanges();
        }

        public bool BreakfastMealControl(User user, DateTime selectedDate)
        {
            return db.Meals.Any(a => a.UserId == user.Id && a.CreateDate == selectedDate && a.MealType == MealType.BreakFast);
        }
        public bool LunchMealControl(User user, DateTime selectedDate)
        {
            return db.Meals.Any(a => a.UserId == user.Id && a.CreateDate == selectedDate && a.MealType == MealType.Lunch);
        }
        public bool DinnerMealControl(User user, DateTime selectedDate)
        {
            return db.Meals.Any(a => a.UserId == user.Id && a.CreateDate == selectedDate && a.MealType == MealType.Dinner);
        }
        public bool SnackMealControl(User user, DateTime selectedDate)
        {
            return db.Meals.Any(a => a.UserId == user.Id && a.CreateDate == selectedDate && a.MealType == MealType.Snack);
        }

        public Meal GetBreakfastListFromUserId(User user,DateTime selectedTime)
        {
            return db.Meals.Where(a=> a.UserId == user.Id && a.MealType == MealType.BreakFast && a.CreateDate== selectedTime).First();
        }

        public Meal GetLunchListFromUserId(User user, DateTime selectedTime)
        {
            return db.Meals.Where(a => a.UserId == user.Id && a.MealType == MealType.Lunch && a.CreateDate==selectedTime).First();
        }

        public Meal GetDinnerListFromUserId(User user, DateTime selectedTime)
        {
            return db.Meals.Where(a => a.UserId == user.Id && a.MealType == MealType.Dinner && a.CreateDate == selectedTime).First();
        }

        public Meal GetSnackListFromUserId(User user, DateTime selectedTime)
        {
            return db.Meals.Where(a => a.UserId == user.Id && a.MealType == MealType.Snack && a.CreateDate == selectedTime).First();
        }
        public string MostConsumedFoodForBreakfast(User user)
        {
            string most = string.Empty;
            var list = (from m in db.Meals
                        join mf in db.MealFoods
                        on m.Id equals mf.MealId
                        where m.UserId == user.Id && m.MealType == MealType.BreakFast
                        group mf by new
                        {
                            mf.FoodId,
                            mf.Food.Name,
                        }
            into g
                        orderby g.Count() descending
                        select new
                        {
                            TotalConsumedFood = g.Count(),
                            FoodName = g.Key.Name,
                        }).Take(1).ToList();
            foreach (var item in list)
            {
                most = item.FoodName;
            }
            return most;
        }
        public string MostConsumedFoodForLunch(User user)
        {
            string most = string.Empty;
            var list = (from m in db.Meals
                        join mf in db.MealFoods
                        on m.Id equals mf.MealId
                        where m.UserId == user.Id && m.MealType == MealType.Lunch
                        group mf by new
                        {
                            mf.FoodId,
                            mf.Food.Name,
                        }
            into g
                        orderby g.Count() descending
                        select new
                        {
                            TotalConsumedFood = g.Count(),
                            FoodName = g.Key.Name,
                        }).Take(1).ToList();
            foreach (var item in list)
            {
                most = item.FoodName;
            }
            return most;
        }
        public string MostConsumedFoodForDinner(User user)
        {
            string most = string.Empty;
            var list = (from m in db.Meals
                        join mf in db.MealFoods
                        on m.Id equals mf.MealId
                        where m.UserId == user.Id && m.MealType == MealType.Dinner
                        group mf by new
                        {
                            mf.FoodId,
                            mf.Food.Name,
                        }
            into g
                        orderby g.Count() descending
                        select new
                        {
                            TotalConsumedFood = g.Count(),
                            FoodName = g.Key.Name,
                        }).Take(1).ToList();
            foreach (var item in list)
            {
                most = item.FoodName;
            }
            return most;
        }
        public string MostConsumedFoodForSnack(User user)
        {
            string most = string.Empty;
            var list = (from m in db.Meals
                        join mf in db.MealFoods
                        on m.Id equals mf.MealId
                        where m.UserId == user.Id && m.MealType == MealType.Snack
                        group mf by new
                        {
                            mf.FoodId,
                            mf.Food.Name,
                        }
            into g
                        orderby g.Count() descending
                        select new
                        {
                            TotalConsumedFood = g.Count(),
                            FoodName = g.Key.Name,
                        }).Take(1).ToList();
            foreach (var item in list)
            {
                most = item.FoodName;
            }
            return most;
        }
        public double WeeklyAverageCalory()
        {
            double averageCaloryWeekly = 0;
            DateTime sinceLastWeek = DateTime.Now.AddDays(-7);
            var list = db.Meals.Where(x => DbFunctions.TruncateTime(x.CreateDate) > sinceLastWeek).GroupBy(z => z.CreateDate).Select(x => new { total = x.Sum(c => c.TotalCalory) }).ToList();
            foreach (var item in list)
            {
                averageCaloryWeekly += item.total;
            }
            return averageCaloryWeekly / 7;
        }
        public double MonthlyAverageCalory()
        {
            double averageCaloryMonthly = 0;
            DateTime sinceLastMonth = DateTime.Now.AddDays(-30);
            var list = db.Meals.Where(x => DbFunctions.TruncateTime(x.CreateDate) > sinceLastMonth).GroupBy(z => z.CreateDate).Select(x => new { total = x.Sum(c => c.TotalCalory) }).ToList();
            foreach (var item in list)
            {
                averageCaloryMonthly += item.total;
            }
            return averageCaloryMonthly / 30;
        }
        public double UserWeeklyAverageCalory(User user)
        {
            double averageCaloryWeekly = 0;
            DateTime sinceLastWeek = DateTime.Now.AddDays(-7);
            var list = db.Meals.Where(x => DbFunctions.TruncateTime(x.CreateDate) >= sinceLastWeek && x.UserId == user.Id).GroupBy(z => z.CreateDate).Select(y => new { total = y.Sum(c => c.TotalCalory) }).ToList();
            foreach (var item in list)
            {
                averageCaloryWeekly += item.total;
            }
            return averageCaloryWeekly/7;
        }
        
        public double UserMonthlyAverageCalory(User user)
        {
            double averageCaloryMonthly = 0;
            DateTime sinceLastMonth = DateTime.Now.AddDays(-30);
            var list = db.Meals.Where(x => DbFunctions.TruncateTime(x.CreateDate) >= sinceLastMonth && x.UserId == user.Id).GroupBy(z => z.CreateDate).Select(x => new { total = x.Sum(c => c.TotalCalory) }).ToList();
            foreach (var item in list)
            {
                averageCaloryMonthly += item.total;
            }
            return averageCaloryMonthly/30;
        }
        public int ShowBreakfastAddedItems(User user, DateTime selectedDate)
        {
            int total = 0;
            var list = db.Meals.Where(x => x.UserId == user.Id && x.MealType == MealType.BreakFast && DbFunctions.TruncateTime(x.CreateDate) == selectedDate).Select(x => new { x.CreateDate, Total = x.Foods.Count() }).ToList();
            foreach (var item in list)
            {
                total += item.Total;
            }
            return total;
        }
        public int ShowLunchAddedItems(User user, DateTime selectedDate)
        {
            int total = 0;
            var list = db.Meals.Where(x => x.UserId == user.Id && x.MealType == MealType.Lunch && DbFunctions.TruncateTime(x.CreateDate) == selectedDate).Select(x => new { x.CreateDate, Total = x.Foods.Count() }).ToList();
            foreach (var item in list)
            {
                total += item.Total;
            }
            return total;
        }
        public int ShowDinnerAddedItems(User user, DateTime selectedDate)
        {
            int total = 0;
            var list = db.Meals.Where(x => x.UserId == user.Id && x.MealType == MealType.Dinner && DbFunctions.TruncateTime(x.CreateDate) == selectedDate).Select(x => new { x.CreateDate, Total = x.Foods.Count() }).ToList();
            foreach (var item in list)
            {
                total += item.Total;
            }
            return total;
        }
        public int ShowSnackAddedItems(User user, DateTime selectedDate)
        {
            int total = 0;
            var list = db.Meals.Where(x => x.UserId == user.Id && x.MealType == MealType.Snack && DbFunctions.TruncateTime(x.CreateDate) == selectedDate).Select(x => new { x.CreateDate, Total = x.Foods.Count() }).ToList();
            foreach (var item in list)
            {
                total += item.Total;
            }
            return total;
        }
        public double ShowDailyTotalCalory(User user, DateTime selectedTime)
        {
            return (double)db.Meals.Where(x => DbFunctions.TruncateTime(x.CreateDate) == selectedTime && x.UserId == user.Id).GroupBy(x => x.CreateDate).Select(x => x.Sum(c => c.TotalCalory)).FirstOrDefault();
        }
    }
}
