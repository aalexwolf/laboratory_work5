using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_5
{  
    enum Mouths : int
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    public abstract class Vehicle : IMovable //Abstract class
    {
        struct About
        {
            public string material;
            public int ageOfVehicle;
            public void PrintInfo()
            {
                Console.WriteLine($"Material: {material}; Age of Vehicle: {ageOfVehicle}");
            }
        }
        public Vehicle(string colour, int year, string name, double maxspeed, double minspeed, double length, double width, double height)
        {
            this.colour = colour;
            this.year = year;
            this.Name = name;
            this.MaxSpeed = maxspeed;
            this.MinSpeed = minspeed;
            this.length = length;
            this.width = width;
            this.height = height;
        }
        public Captain captain;
        public string colour;
        public int year;
        public string Name { get; set; }
        public int numberOfSeats;
        public double MaxSpeed { get; set; }
        public double MinSpeed { get; set; }
        public double length;
        public double width;
        public double height;
        public void getSizes()
        {
            Console.WriteLine($"Длина транспортного средства: {length}мм\nШирина транспортного средства: {width}мм\nВысота транспортного средства: {height}мм ");
        }
        public abstract bool Move();
    }
    public abstract class People
    {
        public int age;
        public string name;
        public string adress;
        public People(string name, int age, string adress)
        {
            this.name = name;
            this.age = age;
            this.adress = adress;
        }
    }
    public partial class Captain : People
    {
        public string NameOfTransport;
        public Captain(string name, int age, string adress, string transportName) : base(name, age, adress)
        {
            this.NameOfTransport = transportName;
        }
    }
    public partial class Ship : Vehicle
    {
        public Ship(string colour, int year, string name, double maxspeed, double minspeed, double length, double width, double height) : base(colour, year, name, maxspeed, minspeed, length, width, height)
        {

        }
        public override int GetHashCode()
        {
            return MaxSpeed.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;

            Ship person = (Ship)obj;
            return (this.Name == person.Name);
        }
        public override bool Move()
        {
            if (this.MaxSpeed != 0)
                return true;
            else return false;
        }
    }
    public class Steamboat : Vehicle
    {
        public Steamboat(string colour, int year, string name, double maxspeed, double minspeed, double length, double width, double height) : base(colour, year, name, maxspeed, minspeed, length, width, height)
        {

        }
        public override string ToString()
        {
            return $"Тип:{this.GetType()} Цвет: {colour} Макс скорость: {MaxSpeed} Мин скорость: {MinSpeed}";
        }
        public override bool Move()
        {
            if (this.MaxSpeed != 0)
                return true;
            else return false;
        }
    }
    public class Sailboat : Vehicle
    {
        public Sailboat(string colour, int year, string name, double maxspeed, double minspeed, double length, double width, double height) : base(colour, year, name, maxspeed, minspeed, length, width, height)
        {

        }
        public override string ToString()
        {
            return $"Тип:{this.GetType()} Цвет: {colour} Макс скорость: {MaxSpeed} Мин скорость: {MinSpeed}";
        }
        public override bool Move()
        {
            if (this.MinSpeed == 0)
                return false;
            else return true;
        }
    }
    public class Corvette : Vehicle
    {
        public Corvette(string colour, int year, string name, double maxspeed, double minspeed, double length, double width, double height) : base(colour, year, name, maxspeed, minspeed, length, width, height)
        {

        }
        public override string ToString()
        {
            return $"Тип:{this.GetType()} Цвет: {colour} Макс скорость: {MaxSpeed} Мин скорость: {MinSpeed}";
        }
        public override bool Move()
        {
            if ((MaxSpeed - MinSpeed) > 0)
                return true;
            else return false;
        }
    }
    sealed public class Boat : Vehicle
    {
        public Boat(string colour, int year, string name, double maxspeed, double minspeed, double length, double width, double height) : base(colour, year, name, maxspeed, minspeed, length, width, height)
        {

        }
        public override string ToString()
        {
            return $"Тип:{this.GetType()} Имя: {Name} Цвет: {colour} Макс скорость: {MaxSpeed} Мин скорость: {MinSpeed}";
        }
        public override bool Move()
        {
            if ((MaxSpeed - MinSpeed) < 0)
                return false;
            else return true;
        }
    }

    //Another class, that show us type of our object
    public class Printer
    {
        public virtual string iAmPrinting(Vehicle obj)
        {
            return obj.GetType().ToString();
        }
    }
}
