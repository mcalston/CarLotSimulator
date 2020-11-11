using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.

            var lot = new CarLot();
            

            //Create a seperate class file called Car *DONE*
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //Using Dot Notation

            var milesCar = new Car();
            milesCar.Make = "Nissan";
            milesCar.Model = "Altima";
            milesCar.Year = 2008;
            milesCar.EngineNoise = "vuhroooom";
            milesCar.HonkNoise = "beeep";
            milesCar.IsDrivable = true;

            lot.Cars.Add(milesCar);


            //Object Initializer Syntax
            var timsCar = new Car()
            {
                Year = 2013,
                Make = "Ram",
                Model = "Pickup",
                EngineNoise = "Brammm",
                HonkNoise = "bimmm bimmm",
            };
            // add tims car
            lot.Cars.Add(timsCar);

            var thomasCar = new Car(2011, "Toyota", "Camry", "vroom", "hawnk", true);
            // add thomas car
            lot.Cars.Add(thomasCar);

            //Call methods


            milesCar.MakeEngineNoise();
            thomasCar.MakeEngineNoise();
            timsCar.MakeEngineNoise();

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car *DONE*

            //*************BONUS X 2*************//

            //Create a CarLot class **DONE**
            //It should have at least one property: a List of cars
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model}");
            }
        }
    }
}
