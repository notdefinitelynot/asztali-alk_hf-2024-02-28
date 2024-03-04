using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace hf_2024_02_28
{
    public abstract class LazadoGep : Urhajo
    {
        public double sebesseg;
        public bool meghibasodhatE;

        public double Sebesseg { get => sebesseg; set => sebesseg = value; }
        public bool MeghibasodhatE { get => meghibasodhatE;}
        protected LazadoGep(float sebesseg, bool meghibasodhatE)
        {
            this.sebesseg = sebesseg;
            this.meghibasodhatE = meghibasodhatE;
        }

        public bool legyorsuljaE(Urhajo o)
        {
            if (o is MilleniumFalcon)
            {
                if (o.milyenGyors()*2<this.sebesseg)
                {
                    return true;
                }
                return false;
            }
            else
            {
                if (this.meghibasodhatE == false && o.milyenGyors() < this.sebesseg)
                {
                    return true;
                }
                return false;
            }
        }

        public double milyenGyors()
        {
            return this.sebesseg;
        }

        public abstract bool elkapjaAVonosugar();
        
        public override string? ToString()
        {
            return $"A lazadogep sebessege: {this.sebesseg} (meghibasodhat-e: {(this.MeghibasodhatE ? "Meghibásodott" : "Nincs meghibásodva")})";
        }

        
    }

}
