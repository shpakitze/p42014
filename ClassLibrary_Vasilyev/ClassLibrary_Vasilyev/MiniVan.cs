using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary_Vasilyev
{
    class MiniVan : Car
    {
        public MiniVan() { }
        public MiniVan(string name, int maxSp, int currSp)
            : base(name, maxSp, currSp)
        { }

        public override void TurboBoost()
        {
            engState = EngineState.engineDead;
            MessageBox.Show("Eak!", "Your engine block exploded!");
        }
    }
}
