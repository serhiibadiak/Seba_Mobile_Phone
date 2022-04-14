using System;

namespace Seba_Mobile_Lib
{
    public class Battery
    {
        public int Capacity { get; set; }
        public Size Size;
        public string Material { get; set; }
        public void Charging()
        {
            Console.WriteLine("Is Charging");
        }
        public override string ToString()
        {
            return "Battery";
        }
    }
}
