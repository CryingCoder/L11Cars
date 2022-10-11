using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11Cars
{

    /// <summary>
    /// Look into the list method of RemoteAt(int index)
    /// Google Overriding toString in C#
    /// </summary>
    
    
    public class Car
    {
        //Car properties
        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public decimal Price { get; set; }



        //Initializing the properties associated with Car class
        public Car()
        {

        }



        //Virtual method that will likely need to be overridden based on if the car is Used or not
        public Car(string Make, string Model, int Year, decimal Price)
        {
            

            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Price = Price;

        }



        //ToString Method to return formatted string with Car detials
        public override string ToString()
        {
            string toString = $"Make: {Make}\tModel: {Model}\tYear: {Year}\tPrice: ${Price}";
            return toString;


        }


    }
}
