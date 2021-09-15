using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Classes
{
    public enum VehicleType { Car, Truck, Motorcycle, Plane, Spaceship }
    public class Vehicle
    {
        //Fields

        //Constructors
        public Vehicle(string make, string model, double mileage, VehicleType type)
        {
            Make = make;
            Model = model;
            Mileage = mileage;
            TypeOfVehicle = type;
        }
        public Vehicle() { }

        //Properties
        //1 access modifier
        //2 Type
        //3 Name 
        //4 Get and Set Methods
        //1    //2    //3   //4
        public string Make { get; set; }

        public string Model { get; set; }

        public double Mileage { get; set; }

        public VehicleType TypeOfVehicle { get; set; }

        //Methods
    }
}
