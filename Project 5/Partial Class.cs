using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_5
{
    public partial class Ship
    {
        public override string ToString()
        {
            return $"Тип:{this.GetType()} Цвет: {colour} Макс скорость: {MaxSpeed} Мин скорость: {MinSpeed}";
        }
    }
}
