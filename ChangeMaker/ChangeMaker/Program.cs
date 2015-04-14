using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling the function with $4.19.  
            //Notice that when using the decimal format you must end numbers with an 'm'
            ChangeAmount(4.19m);
            //calling the function 3 more times to test the function
            ChangeAmount(3.18m);
            ChangeAmount(0.99m);
            ChangeAmount(12.93m);
            Console.ReadKey();
        }
        /// <summary>
        /// Get change in coins
        /// </summary>
        /// <param name="amount">amount to make change of</param>
        /// <returns>The change in coins</returns>
        public static Change ChangeAmount(decimal amount) 
        {
            //this is our object that will hold the data of how many coins of each type to return
            Change amountAsChange = new Change();
            
            //Putting this writeline up top so it holds the ammount before it is changed 
            Console.WriteLine("Amount: $" + amount);
            //checks if amount is greater than or equal to a quarter and adds to counter and takes .25 out of the amount until it is no longer higher 
            while (amount >= .25m)
            {
                amount -= .25m;
                amountAsChange.Quarters++;

            }
            //checks if amount is greater than or equal to a dime and adds to counter and takes .10 out of the amount until it is no longer higher 
            while (amount >= .10m)
            {
                amount -= .10m;
                amountAsChange.Dimes++;
            }
            //checks if amount is greater than or equal to a nickle and adds to counter and takes .05 out of the amount until it is no longer higher             
            while (amount >= .05m)
            {
                amount -= .05m;
                amountAsChange.Nickles++;
            }
            //checks if amount is greater than or equal to a penny and adds to counter and takes .01 out of the amount until it is no longer higher 
            while (amount >= .01m)
            {
                amount -= .01m;
                amountAsChange.Pennies++;
            }
            // All these Write out quarters, dimes, nickles, and pennies

            Console.WriteLine("Quarters: " + amountAsChange.Quarters);
            Console.WriteLine("Dimes: " + amountAsChange.Dimes);
            Console.WriteLine("Nickles: " + amountAsChange.Nickles);
            Console.WriteLine("Pennies: " + amountAsChange.Pennies);

            //return our Change Object
            return amountAsChange;
        }

        /// <summary>
        /// Example using the Change class to store data
        /// </summary>
        public static Change Example(decimal amount)
        {
            //creating a new object of our class Change
            Change amountAsChange = new Change();
            
            //increasing the number of quarters
            amountAsChange.Quarters++;
            amountAsChange.Quarters += 1;
            amountAsChange.Quarters = amountAsChange.Quarters + 1;


            //outputting to the console
            Console.WriteLine("Quarters: " + amountAsChange.Quarters);

            //returning the object
            return amountAsChange;
        }

    }

    public class Change
    {
        /// <summary>
        /// This is property to hold the number of Quarters to be returned as change
        /// </summary>
        public int Quarters { get; set; }

        /// <summary>
        /// This is property to hold the number of Dimes to be returned as change
        /// </summary>
        public int Dimes { get; set; }

        /// <summary>
        /// This is property to hold the number of Nickles to be returned as change
        /// </summary>
        public int Nickles { get; set; }

        /// <summary>
        /// This is property to hold the number of Pennies to be returned as change
        /// </summary>public int Nickles { get; set; }
        public int Pennies { get; set; }

        /// <summary>
        /// This is a constructor, it initializes a new instance of the class (called an object).  This sets it's default values.
        /// </summary>
        public Change()
        {
            this.Quarters = 0;
            this.Dimes = 0;
            this.Nickles = 0;
            this.Pennies = 0;
        }
    }
}
