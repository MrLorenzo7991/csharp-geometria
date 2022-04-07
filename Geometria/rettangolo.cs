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
            Console.WriteLine("Area: " + CalcolaArea() + " cm^2 \n");
        }

        public void Disegna()
        {
            Console.WriteLine("Ecco il tuo Rettangolo disegnato: \n");
            string[] top = new string[baseRettangolo];
            string[] lati = new string[baseRettangolo];
            //Costruzione Base
            for (int i = 0; i < top.Length; i++)
            {
                top[i] = "--";
            }
            //Costruzione lati
            lati[0] = "|  ";
            for(int i = 1; i < lati.Length - 1; i++)
            {
                lati[i] = "  ";
            }
            lati[lati.Length - 1] = "  |";


            //disp top
            Console.Write(" ");
            for (int i = 0; i < top.Length; i++)
            {
                Console.Write(top[i]);
            }
            Console.Write("\n");
            //disp lati
            for (int j = 0; j < altezzaRettangolo; j++)
            {
                for (int i = 0; i < lati.Length; i++)
                {
                    Console.Write(lati[i]);
                }
                Console.Write("\n");
            }
            //disp bot
            Console.Write(" ");
            for (int i = 0; i < top.Length; i++)
            {
                Console.Write(top[i]);
            }
            Console.Write("\n");

        }
    }
}


