using System;
using System.Linq;
namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO




            var lot = new CarLot();

            



            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car


            // Installation 1
            var mercedes = new car();
            mercedes.make = "Mercedes Benz ";
            mercedes.Year = 2021;
            mercedes.Model = "AMG GLA 35";
            mercedes.EngineNoise = "room";
            mercedes.HonkNoise = "Beep";
            mercedes.IsDriveable = true;
            lot.cars.Add(mercedes);



            var audi = new car();
            audi.make = "AUDI";
            audi.Year = 2023;
            audi.Model = "S4";
            audi.EngineNoise = "room";
            audi.HonkNoise = "Beep";
            audi.IsDriveable = true;
            lot.cars.Add(audi);


            var bwm = new car();
            bwm.make = "BMW";
            bwm.Year = 2023;
            bwm.Model = "8!";
            bwm.EngineNoise = "room";
            bwm.HonkNoise = "Beep";
            bwm.IsDriveable = true;
            lot.cars.Add(bwm);

            // installation 2
            car josecar = new car()
            {
                make = "Honda",
                Year = 2017,
                Model = "Civic",
                EngineNoise = "vprrrr",
                IsDriveable = false
              

        };
            lot.cars.Add(josecar);
            // installation 3 
            var kevin = new car(2022, "XD", "Lexus", "RB", "Beerrrr", true);
            lot.cars.Add(kevin);


            //Mthods call
            kevin.makeEngineNoise(kevin.EngineNoise);
            kevin.makeHonkNoise(kevin.HonkNoise);

            josecar.makeEngineNoise(josecar.EngineNoise);
            josecar.makeHonkNoise(josecar.HonkNoise);

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            

            // Start Program

            Console.WriteLine("Cars Lot Inventory");
            Console.WriteLine("***************************************************");
            foreach (var item in lot.cars)
            {
                Console.WriteLine($"Year : {item.Year}, Make : {item.make}, Model : {item.Model}");
            }

        }

    }
}
