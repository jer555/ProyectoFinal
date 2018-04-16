using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio3 /*Programa que permite ingresar 8 números y nos muestre la suma y el promedio de dichos números */
{
    class Program
    {
        static void Main(string[] args) /*Jeremias Solano 14-SIST-1-017 Seccion 0908*/
        {
            int suma, cant, valor, promedio;
            string linea;
            suma = 0;
            cant = 0;
            do
            {
                Console.Write("Ingrese un nimero (0 para finalizar):");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                if (valor != 0)
                {
                    suma = suma + valor;
                    cant++;
                }
            } while (valor != 0);
            if (cant != 0)
            {
                promedio = suma / cant;
                Console.Write("Jeremias Solano 14-SIST-1-017, El promedio de los valores ingresados es:");
                Console.Write(promedio);
            }
            else
            {
                Console.Write("Jeremias Solano 14-SIST-1-017, No se ingresaron valores ");
            }
            Console.ReadLine();
        }
    }
}