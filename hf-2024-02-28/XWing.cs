using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hf_2024_02_28
{
    internal class XWing : LazadoGep, Hiperhajtomu
    {
        public XWing() : base(150, true) { }
        
        public void hiperUgras()
        {
            Random rnd = new Random();
            this.Sebesseg += rnd.NextDouble()*100;
        }

        public override bool elkapjaAVonosugar()
        {
            if (this.MeghibasodhatE && this.Sebesseg < 10000) return true;
            return false;
        }

        public override string? ToString()
        {
            return $"XWing: Sebesség: {this.Sebesseg} : Meghibasodas:  {(this.MeghibasodhatE ? "Meghibásodott":"Nincs meghibásodva")}";
            
        }
    }
}
