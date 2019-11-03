using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_5
{
    class Port
    {
        public List<Vehicle> list = new List<Vehicle>();
        public int Length = 0;
        public void AddElement(Vehicle vehicle)
        {
            list.Add(vehicle);
            Length++;
        }
        public void RemoveElement(Vehicle vehicle)
        {
            list.Remove(vehicle);
            Length--;
        }
        public void PrintElements()
        {
            int k = 1;
            foreach (var i in list)
            {
                Console.WriteLine($"{k}. Type: '{i.GetType().ToString()}'; name: '{i.Name}'");
                k++;
            }
        }
    }
}
