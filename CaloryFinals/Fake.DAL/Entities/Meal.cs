using Fake.DAL.Enums;
using Fake.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fake.DAL.Entities
{
    public class Meal
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; } 
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public MealType MealType { get; set; }
        public double TotalCalory { get; set; }
        public virtual List<MealFood> Foods { get; set; }
    }
}
    
