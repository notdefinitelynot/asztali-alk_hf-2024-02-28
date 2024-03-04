using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hf_2024_02_28
{
    internal class MilleniumFalcon : Urhajo, Hiperhajtomu
    {
        private double tapasztalat;

        public MilleniumFalcon()
        {
            this.tapasztalat = 100;
            
        }

        public void hiperUgras()
        {
            this.tapasztalat += 500;
        }

        public bool legyorsuljaE(Urhajo o)
        {
            return o.milyenGyors() < milyenGyors();
        }

        public double milyenGyors()
        {
            return this.tapasztalat * 2;
        }

        public override string? ToString()
        {
            return $"MilleniumFalcon : Sebesség: {milyenGyors()}";
        }
    }
}
