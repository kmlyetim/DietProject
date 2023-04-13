using Fake.DAL.Entities;
using Fake.DAL.EntityConfigurations;
using Fake.DAL.Enums;
using Fake.DAL.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fake.Entites.Concrete
{
    public class User
    {
        public int Id { get; set; }

        private string _FirstName;

        public string FirstName
        {
            get { return _FirstName; }
            set 
            {
                if (value.Length == 0)
                {
                    throw new Exception("Fist name can not be empty!");
                }
                else if (value.Length > 50)
                {
                    throw new Exception("Fist name can not be more than 50 characters!");
                }
                else
                {
                    _FirstName = value;
                }
            }
        }

        private string _LastName;

        public string LastName
        {
            get { return _LastName; }
            set 
            {
                if (value.Length == 0)
                {
                    throw new Exception("Last name can not be empty!");
                }
                else if (value.Length > 50)
                {
                    throw new Exception("Last name can not be more than 50 characters!");
                }
                else
                {
                    _LastName = value;
                }
            }
        }

        private double _Height;

        public double Height
        {
            get { return _Height; }
            set 
            {
                if (value.ToString() == string.Empty)
                {
                    throw new Exception("Height can not be empty!");
                }
                else
                {
                    _Height = value;
                }
            }
        }

        private double _Weight;

        public double Weight
        {
            get { return _Weight; }
            set 
            {
                if (value.ToString() == string.Empty)
                {
                    throw new Exception("Weight can not be empty!");
                }
                else
                {
                    _Weight = value;
                }
            }
        }

        public double DailyCaloryNeeded { get; set; }
        public Activites ActivityState { get; set; }

        public double BMI { get; set; }

        private string _Email;

        public string Email
        {
            get { return _Email; }
            set 
            {
                if (value == string.Empty)
                {
                    throw new Exception("Email can not be empty!");
                }
                else if (value.Length > 50)
                {
                    throw new Exception("Email can not be more than 50 characters!");
                }
                else if (!value.EndsWith("@fake.com"))
                {
                    throw new Exception("Email has to end with '@fake.com'");
                }
                else
                {
                    _Email = value;
                }
            }
        }

        private string _password; 
        public string Password
        {
            get { return _password; }
            set
            {
                int upperLetterCount = 0;
                int lowerLetterCount = 0;
                int specialCharacterCount = 0;
                char[] passwordControl = value.ToCharArray();
                if (passwordControl.Count() < 8)
                {
                    throw new Exception("Password Size Must Be At Least 8 Characters!");
                }
                else
                {
                    for (int i = 0; i < passwordControl.Count(); i++)
                    {
                        for (int j = 65; j < 91; j++)
                        {
                            if (passwordControl[i] == (Convert.ToChar(j)))
                            {
                                upperLetterCount++;
                            }
                        }
                        for (int k = 97; k < 123; k++)
                        {
                            if (passwordControl[i] == (Convert.ToChar(k)))
                            {
                                lowerLetterCount++;
                            }
                        }
                        if (passwordControl[i] == Convert.ToChar(33) || passwordControl[i] == Convert.ToChar(58) || passwordControl[i] == Convert.ToChar(43) || passwordControl[i] == Convert.ToChar(42))
                        {
                            specialCharacterCount++;
                        }
                    }
                }
                if (upperLetterCount >= 2 && lowerLetterCount >= 2 && specialCharacterCount >= 2)
                {
                    _password = value;
                }
                else
                {
                    throw new Exception("Password Does Not Consist of Required Characters!");
                }
            }
        }

        private DateTime _BirthDate;

        public DateTime BirthDate
        {
            get { return _BirthDate; }
            set 
            {
                if (value.Date.ToString() == string.Empty)
                {
                    throw new Exception("Birthdate can not be empty!");
                }
                else if (value.Date > DateTime.Now.Date)
                {
                    throw new Exception("Date of birth cannot be greater than current time");
                }
                else
                {
                    _BirthDate = value;
                }
            }
        }

        public Gender Gender { get; set; }

        private string _PhoneNumber;

        public string PhoneNumber
        {
            get { return _PhoneNumber; }
            set 
            {
                if (value == string.Empty)
                {
                    throw new Exception("Phone number can not be empty!");
                }
                else
                {
                    _PhoneNumber = value;
                }
            }
        }

       
        public byte[] Picture { get; set; }

        public UserStatus UserStatus { get; set; }

        public virtual List<Meal> Meals { get; set; }

        public virtual List<Message> Inbox { get; set; }

        public virtual List<Message> Sent { get; set; }
    }
}
