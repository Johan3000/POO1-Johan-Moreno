using System;

namespace TallerConceptosFundamentales
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Johan Esteban Moreno Jimenez
             16/02/2022
            Calcular quincena 
             Calcular el sueldo quincenal, tomando en cuenta los siguientes parámetros:
            • $ 1.050.000 por quincena
            • Bono de 10% de profesionalización a los que tienen título universitario
            • Bono quincenal de transporte de $ 120.000
            • Bono de alimentación de $ 25.000 por día laborado
            Deducciones:
            o 2% Seguro Colectivo
            o 1% Paro Forzoso
            o 2% EPS
            o 2% Caja de compensación*/

            double bSueldoQuincena;
            string cAux;
            int nAux;

            bSueldoQuincena = 0;
            nAux = 0;

            while (nAux<1)
            {
                Console.WriteLine("¿tienes titulo universitario?");
                cAux = Console.ReadLine();

                if (cAux == "si" | cAux == "Si")
                {
                    bSueldoQuincena = 1050000 + 120000 + (25000 * 15) + (1050000 * 0.1);
                    nAux =1;
                }
                else if (cAux == "no" | cAux == "No")
                {
                    bSueldoQuincena = 1050000 + 120000 + (25000 * 15);
                    nAux = 1;
                }
                else
                {
                    Console.WriteLine("Rescuerda escribir si o no ");
                }
            }

            bSueldoQuincena =bSueldoQuincena-(bSueldoQuincena*0.07);

            Console.WriteLine("su quincena es: "+ bSueldoQuincena);
        }
    }
}
