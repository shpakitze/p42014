using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary_Vasilyev
{
    class CityCar : Car
    {
        public CityCar() { }
        public CityCar(string name, int maxSp, int currSp)
            : base(name, maxSp, currSp)
        { }

        public override void TurboBoost()
        {
            engState = EngineState.engineDead;
            MessageBox.Show("Yeeeee!");
        }
    }
}
