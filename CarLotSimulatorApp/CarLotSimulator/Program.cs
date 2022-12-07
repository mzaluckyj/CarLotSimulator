using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var lot = new carLot();

            //Create a seperate class file called Car -done
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable -done
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()-done
            //The methods should take one string parameter: the respective noise property-done


            //Now that the Car class is created we can instanciate 3 new cars -done

            var myRam = new Car()
            {
                Year = 2021,
                Make = "Ram",
                Model = "1500",
                EngineNoise = "vroom",
                HonkNoise = "beep",
                IsDriveable = true
            };

            var car2 = new Car()
            {
                Year = 2019,
                Make = "Jeep",
                Model = "Cherokee",
                EngineNoise = "vrum",
                HonkNoise = "bip",
                IsDriveable = true
            };

            var car3 = new Car()
            {
                Year = 1992,
                Make = "GMC",
                Model = "Yukon",
                EngineNoise = "...",
                HonkNoise = "bop",
                IsDriveable = true
            };

            //Set the properties for each of the cars -done
            //Call each of the methods for each car -done
            myRam.MakeEngineNoise("vroom");
            car2.MakeEngineNoise("vrum");
            car3.MakeEngineNoise("...");

            myRam.MakeHonkNoise("beep");
            car2.MakeHonkNoise("bip");
            car3.MakeHonkNoise("bop");
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//
            lot.Cars.Add(myRam);
            lot.Cars.Add(car2);
            lot.Cars.Add(car3);
            //Create a CarLot class -done
            //It should have at least one property: a List of cars -done
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list. -done
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console -done

            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
        }
    }
}
