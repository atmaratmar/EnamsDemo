using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
   
    class Program
    {
        static void Main(string[] args)
        {
            #region 2
            // create list of customers
            #endregion
            Customer[] customers = new Customer[3];
            //cutomers of ziro = new customer and we pass name and gender lets create two more customers  
            customers[0] = new Customer
            {
                Name = "Mursal",
                Gender = Gender.Female
            };
            customers[1] = new Customer
            {
                Name = "Mark",
                Gender = Gender.Male
            };
            customers[2] = new Customer
            {
                Name = "Mike",
                Gender = Gender.Unkown
            };
            #region 4
            // loop 
            #endregion

            foreach (Customer customer in customers)
            {
                Console.WriteLine("Name={0}&& Gender={1}", customer.Name, GetGender(customer.Gender));
                
            }

        }
        public static string GetGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.Unkown:
                    return "Unkown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid data";
            }
        }




    }
    #region 3
    // create our enum
    #endregion
    public enum Gender
    {
        Unkown, Male, Female
    }

    #region 1
    // create a cutomer class
    #endregion
    public class Customer
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }
}
