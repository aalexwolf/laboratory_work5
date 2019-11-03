using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_5 
{
    interface IMovable 
    {
        //method
        bool Move();
        //properties
        string Name { get; set; }
        double MaxSpeed { get; set; }
        double MinSpeed { get; set; }
    }
}
