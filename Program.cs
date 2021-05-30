using System;

namespace AB_Wurzel_1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Console.WriteLine("------------------------------------Multiplikation-----------------------------------");
            Quadratwurzel q1 = new Quadratwurzel();
            q1.eingabeGanzeZahl();
            q1.druckeGanzeZahl();
            double n = 0;
            double i = 1;
            while (n >= i * i)
            {
                if (n == i * i)
                {
                    Console.WriteLine("Die Quadratwurzel von " + n + "" + "ist: " + i);
                }
                else
                {
                    i++;
                }
                Console.WriteLine("Fehler");
            }     
        }  
    }
}
