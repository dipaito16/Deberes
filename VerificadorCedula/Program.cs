using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace taller_55
{
    class Program
    {
        static void Main(string[] args)
        {
            bool VALIDO = false;
            int SUMP = 0;
            int SUMI = 0;
            int ST = 0;
            int P = 0;
            int AUX = 0;
            int DV = 0;
            String cad;
            int[] VEC = new int[10];
            // INGRESO
            for (P = 1; P <= 9; P++)
            {
                Console.Write("POSICIÓN {0} ==>", P);
                cad = Console.ReadLine();
                VEC[P] = int.Parse(cad);
            }
            // SUMATORIA DE PARES
            SUMP = 0;
            SUMI = 0;
            for (P = 2; P <= 8; P += 2)
            {
                SUMP = SUMP + VEC[P];
            }
            // SUMATORIA DE IMPARES
            for (P = 1; P <= 9; P += 2)
            {
                AUX = VEC[P] * 2;
                if (AUX > 9)
                    AUX = AUX - 9;
                SUMI = SUMI + AUX;
            }
            // OBTENCIÓN DE DÍGITO
            ST = SUMP + SUMI;
            DV = 10 - (ST % 10);
            if (DV == 10)
                DV = 0;
            Console.WriteLine("EL DÍGITO VERIFICADOR ES: " + DV);
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
    }
}