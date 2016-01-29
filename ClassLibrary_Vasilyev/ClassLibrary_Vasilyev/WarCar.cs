using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary_Vasilyev
{
    public class WarCar : Car
    {
       
        public WarCar() { }
        public WarCar(string name, int maxSp, int currSp)
            : base(name, maxSp, currSp)
        { }

        public override void TurboBoost()
        {
            Console.WriteLine("DA RED GOEZ FASTA!");
        }
    }
}