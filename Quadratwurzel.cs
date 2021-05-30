using System;
using System.Collections.Generic;
using System.Text;

namespace AB_Wurzel_1
{
    

    class Quadratwurzel
    {
        public double i;
        public double n;
        private double eD;
        private double eM;

        public Quadratwurzel()
        {
            i = 1;        
        }

        public void eingabeGanzeZahl()
        {
            Console.WriteLine("Bitte geben Sie eine ganze Zahl ein: ");
            n = Convert.ToInt32(Console.ReadLine());
        }
        public void druckeGanzeZahl()
        {
            Console.WriteLine("Ihre Eingabe war: "+n);        
        }
    }
        
}
