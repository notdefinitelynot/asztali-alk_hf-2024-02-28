using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace hf_2024_02_28
{
    internal class StarWars
    {
        public static void urhajok (string fajlEleres)
        {
            
            if (!File.Exists(fajlEleres))
            {
                Console.WriteLine("File does not exist :{0} ", fajlEleres);
                return;
            }

            string[] szovegFajlbol = File.ReadAllLines(fajlEleres);
            /*foreach (string line in szovegFajlbol)
            {
                Console.WriteLine(line);
            */

            MilleniumFalcon m1 = new MilleniumFalcon();
            XWing x1 = new XWing();

            MilleniumFalcon m2 = new MilleniumFalcon();
            for (int i = 0; i < 20; i++)
            {
                m2.hiperUgras();
            }

            for (int i = 0; i < szovegFajlbol.Length; i++) 
            {
                string[] sub = szovegFajlbol[i].Split(" ");
                
                for (int j = 0; j < sub.Length; j++)
                {
                    if (sub[j] == "XWing")
                    {
                        for (int k = 0; k < Convert.ToInt32(sub[j + 1]); k++)
                        {
                            x1.hiperUgras();
                        }
                    }
                    if (sub[j] == "MilleniumFalcon")
                    {
                        for (int k = 0; k < Convert.ToInt32(sub[j + 1]); k++)
                        {
                            m1.hiperUgras();
                        }
                    }
                }
                
                
            }
            Console.WriteLine(m1);
            Console.WriteLine(x1);



        }

        public static void hangar()
        {
            MilleniumFalcon m1 = new MilleniumFalcon();
            XWing x1 = new XWing();
            XWing x2 = new XWing();

            Console.WriteLine(m1);
            Console.WriteLine(m1.milyenGyors());
            Console.WriteLine(m1.legyorsuljaE(x1));
            m1.hiperUgras();

            Console.WriteLine(x1);
            Console.WriteLine(x1.milyenGyors());
            Console.WriteLine(x1.legyorsuljaE(m1));
            Console.WriteLine(x1.elkapjaAVonosugar()?"Elkapja a vonsugar":"Nem kapja el a vonosugar");
            x1.hiperUgras();

            x2.sebesseg = 12000;
            x2.meghibasodhatE = false;
            Console.WriteLine(x2);
            Console.WriteLine(x2.milyenGyors());
            Console.WriteLine(x2.legyorsuljaE(x1));
            Console.WriteLine(x2.elkapjaAVonosugar() ? "Elkapja a vonsugar" : "Nem kapja el a vonosugar");









        }

        static public void Main(String[] args)
        {

            urhajok("C:/Users/Diak/dev/dnaa/asztali_alk/hf-2024-02-28/asd.txt");
            Console.WriteLine();
            hangar();

            
        }
    }
}
