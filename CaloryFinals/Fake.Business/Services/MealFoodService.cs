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
    public class MealFoodService
    {
        MealFoodRepository mealFoodRepository;

        public MealFoodService()
        {
            mealFoodRepository = new MealFoodRepository();
        }

        public void AddMealFoods(MealFood mealFood)
        {
            mealFoodRepository.AddMealFoods(mealFood);
        }

        public void DeleteMealFoods(int mealId,int foodId)
        {
            mealFoodRepository.DeleteMealFood(mealId,foodId);
        }

        public List<MealFood> GetBreakfastMealFoods(int mealId)
        {
            return mealFoodRepository.GetBreakfastMealFoods(mealId);
        }

        public List<MealFood> GetLunchMealFoods(int mealId)
        {
            return mealFoodRepository.GetLunchMealFoods(mealId);
        }

        public List<MealFood> GetDinnerMealFoods(int mealId)
        {
            return mealFoodRepository.GetDinnerMealFoods(mealId);
        }

        public List<MealFood> GetSnackMealFoods(int mealId)
        {
            return mealFoodRepository.GetSnackMealFoods(mealId);
        }
        public bool SearchFood(int foodId,int mealId)
        {
            return mealFoodRepository.SearchFood(foodId,mealId);
        }
        public List<MealFood> GetAllMealFoodsByMealId(int mealId)
        {
            return mealFoodRepository.GetAllMealFoodsByMealId(mealId);
        }
        public double GetTakenTotalCarbonhydrate(User user, DateTime selectedTime)     //////////////////////////////
        {
            return mealFoodRepository.GetTakenTotalCarbonhydrate(user, selectedTime);
        }
        public double GetTakenTotalProtein(User user, DateTime selectedTime)
        {
            return mealFoodRepository.GetTakenTotalProtein(user, selectedTime);
        }
        public double GetTakenTotalFat(User user, DateTime selectedTime)
        {
            return mealFoodRepository.GetTakenTotalFat(user, selectedTime);
        }
    }
}
