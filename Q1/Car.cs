using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Car
    {
        private string make;

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private int currentSpeed;

        public int CurrentSpeed
        {
            get { return currentSpeed; }
            set { currentSpeed = value; }
        }

        private string engineSize;

        public string EngineSize
        {
            get { return engineSize; }
            set { engineSize = value; }
        }

        public Car(string make, string model, int currentSpeed, string engineSize)
        {
            Make = make;
            Model = model;
            CurrentSpeed = currentSpeed;
            EngineSize = engineSize;
        }

        public void DisplayCarInfo()
        {
            Console.WriteLine($"Make of car : {Make}");
            Console.WriteLine($"Model of car : {Model}");
            Console.WriteLine($"Current speed of car : {CurrentSpeed}");
            Console.WriteLine($"Engine size of car : {EngineSize}");
        }

       public override string ToString()
        {
            return $"Make: {Make}, Model: {Model}, Speed: {CurrentSpeed}, Engine Size: {EngineSize}";
        }

        public void Accelerate()
        {
            while (CurrentSpeed != 100)
            {
                CurrentSpeed += 10;
                Console.WriteLine($"Car is travelling at {CurrentSpeed} km/h");
            }
        }
    }
}
