
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            using System;
using System.Collections.Generic;

public class Car
        {
            
            public int Year { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
            public string EngineNoise { get; set; }
            public string HonkNoise { get; set; }
            public bool IsDriveable { get; set; }

         
            public void MakeEngineNoise(string engineNoise)
            {
                Console.WriteLine($"Engine Noise: {engineNoise}");
            }

            public void MakeHonkNoise(string honkNoise)
            {
                Console.WriteLine($"Honk Noise: {honkNoise}");
            }
        }
//Now that the Car class is created we can instanciate 3 new cars
//Set the properties for each of the cars
//Call each of the methods for each car

class Program
{
    static void Main(string[] args)
    {
        
        Car car1 = new Car();
        Car car2 = new Car();
        Car car3 = new Car();

       
        car1.Year = 2021;
        car1.Make = "Toyota";
        car1.Model = "Corolla";
        car1.EngineNoise = "Vroom";
        car1.HonkNoise = "Beep";
        car1.IsDriveable = true;

        car2.Year = 2019;
        car2.Make = "Honda";
        car2.Model = "Civic";
        car2.EngineNoise = "Brum";
        car2.HonkNoise = "Honk";
        car2.IsDriveable = true;

        car3.Year = 2020;
        car3.Make = "Ford";
        car3.Model = "Mustang";
        car3.EngineNoise = "Vroom Vroom";
        car3.HonkNoise = "Beep Beep";
        car3.IsDriveable = true;

       
        car1.MakeEngineNoise(car1.EngineNoise);
        car1.MakeHonkNoise(car1.HonkNoise);

        car2.MakeEngineNoise(car2.EngineNoise);
        car2.MakeHonkNoise(car2.HonkNoise);

        car3.MakeEngineNoise(car3.EngineNoise);
        car3.MakeHonkNoise(car3.HonkNoise);
    }
}
//*************BONUS*************//

// Set the properties utilizing the 3 different ways we learned about, one way for each car
class Program2
{
    static void Main(string[] args)
    {
       
        Car car1 = new Car
        {
            Year = 2021,
            Make = "Toyota",
            Model = "Corolla",
            EngineNoise = "Vroom",
            HonkNoise = "Beep",
            IsDriveable = true
        };

      
        Car car2 = new Car(2019, "Honda", "Civic", "Brum", "Honk", true);
        
       
        Car car3 = new Car();
        car3.Year = 2020;
        car3.Make = "Ford";
        car3.Model = "Mustang";
        car3.EngineNoise = "Vroom Vroom";
        car3.HonkNoise = "Beep Beep";
        car3.IsDriveable = true;

      
        car1.MakeEngineNoise(car1.EngineNoise);
        car1.MakeHonkNoise(car1.HonkNoise);

        car2.MakeEngineNoise(car2.EngineNoise);
        car2.MakeHonkNoise(car2.HonkNoise);

        car3.MakeEngineNoise(car3.EngineNoise);
        car3.MakeHonkNoise(car3.HonkNoise);
    }
}
        //*************BONUS X 2*************//

        //Create a CarLot class
        //It should have at least one property: a List of cars
        //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
        //At the end iterate through the list printing each of car's Year, Make, and Model to the console
    class CarLot
{
    
    public List<Car> Cars { get; set; }


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
        foreach (var car in Cars)
        {
            Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model}");
        }
    }
}

class Program3
{
    static void Main(string[] args)
    {
        
        CarLot carLot = new CarLot();

        
        Car car1 = new Car
        {
            Year = 2021,
            Make = "Toyota",
            Model = "Corolla",
            EngineNoise = "Vroom",
            HonkNoise = "Beep",
            IsDriveable = true
        };

       
        Car car2 = new Car(2019, "Honda", "Civic", "Brum", "Honk", true);

        
        Car car3 = new Car();
        car3.Year = 2020;
        car3.Make = "Ford";
        car3.Model = "Mustang";
        car3.EngineNoise = "Vroom Vroom";
        car3.HonkNoise = "Beep Beep";
        car3.IsDriveable = true;

        
        carLot.AddCar(car1);
        carLot.AddCar(car2);
        carLot.AddCar(car3);

       
        carLot.PrintCarDetails();
    }
}

    

