using Fake.DAL.Entities;
using Fake.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fake.Business.Services
{
    public class FoodService
    {
        FoodRepository foodRepository;
        public FoodService()
        {
            foodRepository= new FoodRepository();
        }
        public Food GetFoodById(int id)
        {
            return foodRepository.GetFoodById(id);
        }
        public void AddFood(Food food)
        {
            foodRepository.AddFood(food);
        }
        public void UpdateFood(Food food)
        {
            foodRepository.UpdateFood(food);        
        }
        public void DeleteFood(Food food) 
        {
            foodRepository.DeleteUser(food);
        }
        public List<Food> List(string search) 
        {
            return foodRepository.List(search);
        }
        public Food GetFoodByName(string name)
        {
            return foodRepository.GetFoodByName(name);
        }
    }
}
