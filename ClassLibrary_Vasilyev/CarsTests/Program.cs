using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_Vasilyev;

namespace CarsTests
{
    class Program
    {
        static void Main(string[] args)
        {
            CityCar cc = new CityCar("Lexus", 285, 60);
            cc.TurboBoost();
            WarCar orc = new WarCar("Dred",10,12);
            orc.TurboBoost();
        }
    }
}
