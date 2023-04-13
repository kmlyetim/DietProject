using Fake.DAL.Entities;
using Fake.DAL.Enums;
using Fake.DAL.Repository;
using Fake.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fake.Business.Services
{
    public class MealService
    {
        MealRepository mealRepository;

        public MealService()
        {
            mealRepository = new MealRepository();
        }

        public List<Meal> GetMealListFromDate(DateTime selectedDate, User user)
        {
            return mealRepository.GetMealListFromDate(selectedDate,user);
        }

        public void AddMeals(Meal meal)
        {
            mealRepository.AddMeals(meal);
        }

        public void DeleteMeals(int mealId)
        {
            mealRepository.DeleteMeals(mealId);
        }
        public Meal GetMealFromMealId(int mealId)
        {
            return mealRepository.GetMealFromMealId(mealId);
        }
        public void UpdateMeal(Meal mealFood)
        {
            mealRepository.UpdateMeal(mealFood);
        }
        public bool BreakfastMealControl(User user, DateTime selectedDate)
        {
            return mealRepository.BreakfastMealControl(user, selectedDate);
        }

        public bool LunchMealControl(User user, DateTime selectedDate)
        {
            return mealRepository.LunchMealControl(user, selectedDate);
        }

        public bool DinnerMealControl(User user, DateTime selectedDate)
        {
            return mealRepository.DinnerMealControl(user, selectedDate);
        }

        public bool SnackMealControl(User user, DateTime selectedDate)
        {
            return mealRepository.SnackMealControl(user, selectedDate);
        }

        public Meal GetBreakfastListFromUserId(User user, DateTime selectedTime)
        {
            return mealRepository.GetBreakfastListFromUserId(user,selectedTime);
        }

        public Meal GetLunchListFromUserId(User user, DateTime selectedTime)
        {
            return mealRepository.GetLunchListFromUserId(user,selectedTime);
        }

        public Meal GetDinnerListFromUserId(User user, DateTime selectedTime)
        {
            return mealRepository.GetDinnerListFromUserId(user,selectedTime);
        }

        public Meal GetSnackListFromUserId(User user, DateTime selectedTime)
        {
            return mealRepository.GetSnackListFromUserId(user,selectedTime);
        }
        public double UserWeeklyAverageCalory(User user)
        {
            return mealRepository.UserWeeklyAverageCalory(user);
        }
        public double UserMonthlyAverageCalory(User user)
        {
            return mealRepository.UserMonthlyAverageCalory(user);
        }
        public double WeeklyAverageCalory()
        {
            return mealRepository.WeeklyAverageCalory();
        }
        public double MonthlyAverageCalory()
        {
            return mealRepository.MonthlyAverageCalory();
        }
        public string MostConsumedFoodForBreakfast(User user)
        {
            return mealRepository.MostConsumedFoodForBreakfast(user);
        }
        public string MostConsumedFoodForLunch(User user)
        {
            return mealRepository.MostConsumedFoodForLunch(user);
        }
        public string MostConsumedFoodForDinner(User user)
        {
            return mealRepository.MostConsumedFoodForDinner(user);
        }
        public string MostConsumedFoodForSnack(User user)
        {
            return mealRepository.MostConsumedFoodForSnack(user);
        }
        public int ShowBreakfastAddedItems(User user, DateTime selectedDate)
        {
            return mealRepository.ShowBreakfastAddedItems(user, selectedDate);
        }
        public int ShowLunchAddedItems(User user, DateTime selectedDate)
        {
            return mealRepository.ShowLunchAddedItems(user, selectedDate);
        }
        public int ShowDinnerAddedItems(User user, DateTime selectedDate)
        {
            return mealRepository.ShowDinnerAddedItems(user, selectedDate);
        }
        public int ShowSnackAddedItems(User user, DateTime selectedDate)
        {
            return mealRepository.ShowSnackAddedItems(user, selectedDate);
        }
        public double ShowDailyTotalCalory(User user, DateTime selectedTime)
        {
            return mealRepository.ShowDailyTotalCalory(user, selectedTime);
        }
    }
}
