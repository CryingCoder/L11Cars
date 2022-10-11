using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11Cars
{
    public class UsedCar : Car
    {
        
        public double Mileage { get; set; } 



        //This is a method that is inheriting the base method that exists in the Car class and then adding a new parameter for Mileage
        public UsedCar(string Make, string Model, int Year, decimal Price, double Miles) : base(Make, Model, Year, Price)
        {
            
            Mileage = Miles;

        }


        //This is a method to convert the output of the Car class list to a single line per car
        public override string ToString()
        {

            string toString = $"Make: {Make}\tModel: {Model}\tYear: {Year}\tPrice: ${Price}\tMiles: {Mileage} - USED";
            return toString;

        }
    }
}