using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            carLot.numberOfCars++;
        }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise {get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }


        public void MakeEngineNoise(string noise)
        {
            Console.WriteLine(noise);
        }

        public void MakeHonkNoise(string honk)
        {
            Console.WriteLine(honk);
        }

        public Car(int Year, String Make, String Model, String EngineNoise, string HonkNoise, bool isDriveable =false)
        {
            Year = Year;
            Make = Make;
            Model = Model;
            EngineNoise = EngineNoise;
            HonkNoise = HonkNoise;
        }


    }
}
