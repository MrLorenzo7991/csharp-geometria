using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    internal class Rettangolo
    {
        /*---Attributi---*/
        private int baseRettangolo;
        private int altezzaRettangolo;

        /*---Costruttore---*/
        public Rettangolo(int baseRettangolo, int altezzaRettangolo)
        {
            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;
        }

        /*---Metodi---*/
        public int CalcolaArea()
        {
            int area =  baseRettangolo * altezzaRettangolo;
            return area;
        }

        public int CalcolaPerimetro()
        {
            int perimetro = 2 * (baseRettangolo + altezzaRettangolo);
            return perimetro;
        }

        public void StampaRettangolo()
        {
            Console.WriteLine("---RETTANGOLO X---");
            Console.WriteLine("Base: " + baseRettangolo + " cm");
            Console.WriteLine("Altezza: " + altezzaRettangolo + " cm");
            Console.WriteLine("Perimetro: " + CalcolaPerimetro() + " cm");
            Console.WriteLine("Area: " + CalcolaArea() + " cm^2");
        }
    }
}
