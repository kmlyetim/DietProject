using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fake.DAL.Entities
{
    public class MealFood
    {
        public int FoodId { get; set; }
        public int MealId { get; set; }
        public int Amount { get; set; }
        public double Calory { get; set; }
        public virtual Food Food { get; set; }
        public virtual Meal Meal { get; set; }
    }
}
