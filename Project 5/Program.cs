using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating some objects
            Boat boat = new Boat("red", 1968, "Katalina", 100, 5, 122.87, 55.1, 26.23);
            Ship ship = new Ship("blue", 1973, "Kamel", 80, 2, 104.2, 38.004, 22.01);
            Corvette corv = new Corvette("yellow", 2002, "DeLaney", 88.5, 0, 105.7, 30.1, 18.9);
            Sailboat sailboat = new Sailboat("white", 2009, "McNill", 50.3, 2, 100, 80, 10);
            Steamboat steamboat = new Steamboat("black", 1999, "VanPersie", 66, 6, 102, 44, 12);
            Captain jack = new Captain("Jack", 37, "Kalifornia", "Pearl");

            Printer print = new Printer();
            //Array of Venicle objects
            Vehicle[] objArray = new Vehicle[] { boat, ship, corv, sailboat, steamboat};    //массив из объектов разных классов
            for (int i = 0; i < objArray.Length; i++)
            {
                Console.WriteLine(print.iAmPrinting(objArray[i])+ "\n");
            }


            //Create Port
            Port port = new Port();
            port.AddElement(boat); port.AddElement(ship); port.AddElement(corv); port.AddElement(sailboat);
            Console.WriteLine("Список элементов объекта класса-контейнера:");
            port.PrintElements();
            port.RemoveElement(sailboat);
            Console.WriteLine("Список элементов объекта класса-контейнера после удаления sailboat:");
            port.PrintElements();
            Console.WriteLine(); port.RemoveElement(boat); port.RemoveElement(ship); port.RemoveElement(corv);
            ///////средняя длина всех парусников в порту
            Controller control = new Controller();
            Sailboat sailboat1 = new Sailboat("white", 2009, "McNill", 40.2, 2, 90, 80, 10);
            Sailboat sailboat2 = new Sailboat("black", 2001, "Occoroe", 60.65, 2, 100, 80, 10);
            Sailboat sailboat3 = new Sailboat("yellow", 1991, "Naville", 50.33, 2, 88, 80, 10);
            port.AddElement(sailboat1); port.AddElement(sailboat2); port.AddElement(sailboat3);
            Console.WriteLine($"Средняя длина всех парусников: {control.AverageOfSailboat(port)}м \n");
            port.RemoveElement(sailboat1); port.RemoveElement(sailboat2); port.RemoveElement(sailboat3);
            //среднее кол-во посадочных мест на пароходах в порту
            Steamboat steamboat1 = new Steamboat("white", 2009, "McNill", 40.2, 2, 90, 80, 10); steamboat1.numberOfSeats = 150;
            Steamboat steamboat2 = new Steamboat("black", 2001, "Occoroe", 60.65, 2, 100, 80, 10); steamboat2.numberOfSeats = 220;
            Steamboat steamboat3 = new Steamboat("yellow", 1991, "Naville", 50.33, 2, 88, 80, 10); steamboat3.numberOfSeats = 102;
            port.AddElement(steamboat1); port.AddElement(steamboat2); port.AddElement(steamboat3);
            Console.WriteLine($"Среднее количество посадочных мест на пароходах: {control.AverageNumberOfSeats(port)} \n");
            //все транспортные средства на которых плавают капитаны моложе 35 лет
            Captain nick = new Captain("Nick", 30, "Mogilew", "Elize");
            Captain john = new Captain("John", 40, "Brussel", "Ambrorra");
            Captain dany = new Captain("Daniel", 22, "Monaco", "Toro Rosso");
            steamboat1.captain = nick; steamboat2.captain = john; steamboat3.captain = dany;
            Console.WriteLine($"Капитаны моложе 35 лет:");
            control.YoungerThan35(port);
            Console.ReadKey();
        }
    }
}
