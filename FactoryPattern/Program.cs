using System.Buffers.Text;
using System.Reflection.Metadata;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("place an order for a drink, side, or burger");
            var customerOrder = Console.ReadLine();
            IFastFood fastFood = FactoryOrder.Order(customerOrder);
            fastFood.Order();
        }
    }
}

//Fork and Clone the repository - Factory Pattern Exercise Repo to your local computer.
//Instructions for forking and cloning a project can be found HERE.

//Create an Interface named IVehicle that has a stubbed out public void Drive method

//Create 2 new public classes that will conform to IVehicle:
//Examples: Car, Truck, Motorcycle, BigRig,  SUV
//These 2 classes must implement the Drive method

//Create a static order class:
//Add a factoryorder method that will return an Ifastfood based on the item wanted it’s given as a parameter (burger, drink, side):
//Make the method static
//A return type of IFastFood
//1 string parameter

//Call this method in your Main method