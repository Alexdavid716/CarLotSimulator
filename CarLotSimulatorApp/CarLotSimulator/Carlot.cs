using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    public class CarLot
    {
        
        public List<Car> Cars { get; }

        
        public CarLot()
        {
            Cars = new List<Car>();
        }

        
        public void AddCar(Car car)
        {
            Cars.Add(car);
        }

        
        public void PrintCarDetails()
        {
            Console.WriteLine("Car details in the Car Lot:");
            foreach (var car in Cars)
            {
                Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model}");
            }
        }
    }
}

