using Fake.DAL.Enums;
using Fake.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fake.DAL.Entities
{
    public class Food
    {
        public int Id { get; set; }
        private string _Name;

        public string Name
        {
            get { return _Name; }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("Name can not be empty!");
                }
                else if (value.Length > 50)
                {
                    throw new Exception("Name can not be more than 50 characters!");
                }
                else
                {
                    _Name = value;
                }
            }
        }

        private double _Calory;

        public double Calory
        {
            get { return _Calory; }
            set
            {
                if (value.ToString() == string.Empty)
                {
                    throw new Exception("Calory can not be empty!");
                }
                else
                {
                    _Calory = value;
                }
            }
        }

        public byte[] Picture { get; set; }
        private string _Description;

        public string Description
        {
            get { return _Description; }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("Description can not be empty!");
                }
                else
                {
                    _Description = value;
                }
            }
        }

        private double _Protein;

        public double Protein
        {
            get { return _Protein; }
            set
            {
                if (value.ToString() == string.Empty)
                {
                    throw new Exception("Protein can not be empty!");
                }
                else
                {
                    _Protein = value;
                }
            }
        }

        private double _Carbohydrate;

        public double Carbohydrate
        {
            get { return _Carbohydrate; }
            set
            {
                if (value.ToString() == string.Empty)
                {
                    throw new Exception("Carbohydrate can not be empty!");
                }
                else
                {
                    _Carbohydrate = value;
                }
            }
        }

        private double _Fat;

        public double Fat
        {
            get { return _Fat; }
            set
            {
                if (value.ToString() == string.Empty)
                {
                    throw new Exception("Fat can not be empty!");
                }
                else
                {
                    _Fat = value;
                }
            }
        }

        public Portion PortionType { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<MealFood> Meals { get; set; }
    }
    
    
}
