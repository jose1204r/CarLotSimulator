using System;
namespace CarLotSimulator
{
    public class car
    {
        public int Year { get; set; }
        public string Model { get; set; }
        public string make { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public car(int year, string model, string Make, string enginenoise, string honknoise, bool isdriveable)
        {

            year = Year;
            model = Model;
            Make = make;
            enginenoise = EngineNoise;
            honknoise = HonkNoise;
            isdriveable = IsDriveable;

        }

        public car()
        {
        }

        public void makeEngineNoise(string enginenoise)
        {
            Console.WriteLine(enginenoise);
        }

        public void makeHonkNoise(string honkNoise)
        {

            Console.WriteLine(honkNoise);

        }


    }

}

