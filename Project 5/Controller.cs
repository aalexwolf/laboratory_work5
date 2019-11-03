using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_5
{
    class Controller
    {
        public double AverageOfSailboat(Port port)
        {
            double x = 0; double k = 0;
            for (int i=0; i<port.Length; i++)
            {
               if (port.list[i].GetType().ToString() == "Project_5.Sailboat")
                {
                    x = x + port.list[i].length;
                    k++;
                }
            }
            return x / k;
        }
        public double AverageNumberOfSeats(Port port)
        {
            double x = 0; double k = 0;
            for (int i = 0; i < port.Length; i++)
            {
                if (port.list[i].GetType().ToString() == "Project_5.Steamboat")
                {
                    x = x + port.list[i].numberOfSeats;
                    k++;
                }
            }
            return x / k;
        }
        public void YoungerThan35(Port port)
        {
            int k = 1;
            for (int i = 0; i < port.Length; i++)
            {
                if (port.list[i].captain.age < 35)
                {
                   Console.WriteLine($"{k}. Имя: {port.list[i].captain.name}; Возраст: {port.list[i].captain.age}; Корабль: {port.list[i].captain.NameOfTransport}");
                    k++;
                }
            }
        }
    }
}
