namespace L11Cars
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            //Adding a Car for testing
            Car c = new Car("Ford","Taurus", 2020, 34000.00m);
            //Only works because the ToString Method in Car class overrides the to string method
            //. Console.WriteLine(c+ "\n");


            List<Car> carsInventory = new List<Car>();
            carsInventory.Add(new Car("Charvo", "Carapice", 2022, 10000000.0m));
            carsInventory.Add(new Car("Fort", "Flocus", 2270, 1.0m));
            carsInventory.Add(new Car("BeemerDubya", "Numbers", 2077, 2000.0m));
            carsInventory.Add(new UsedCar("Fard", "Sharter", 1999, 2200.0m, 200000));
            carsInventory.Add(new UsedCar("Nirsen", "Tree50z", 1980, 6000, 13000));
            carsInventory.Add(new UsedCar("Cherver", "Nerver", 1984, 25, 150));




            //Greeting
            Console.WriteLine("Welcome to Grant Chirpus’ Used Car Emporium!\n");
            //Print Car list
            int index = 0;
            foreach (Car car in carsInventory)
            {
                Console.WriteLine(index + "-" + car);
                Console.WriteLine();
                index++;
            }

            
            
            //Prompt the user to select a car to purchase
            Console.WriteLine("\nPlease select the number to the left of the cars \"Make\" you want to purchase");
            string choice = Console.ReadLine();
            int carChoice = int.Parse(choice);
            


            /*if (carChoice == null)
            {
                Console.WriteLine("Please enter only the number to the left of the car Make you'd like to purchase");
            }*/



            //Remove the car chosen form the list of cars available
            carsInventory.RemoveAt(carChoice);
            Console.WriteLine("\n"+carsInventory[carChoice - 1]+"\n");



            //Print Car list after choosing a car and removing it from list
            index = 0;
            foreach (Car car in carsInventory)
            {
                Console.WriteLine(index + "-" + car);
                index++;
            }



            //Goodbye
            Console.WriteLine("\nExcellent! Our finance department will be in touch shortly.\nHave a great day!");
        }
    }
}