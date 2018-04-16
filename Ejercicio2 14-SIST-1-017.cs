using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Ejercicio2
{
    class program /*Programa que lee los datos de las cuentas corrientes e informa:
a)De cada cuenta: número de cuenta y estado de la cuenta según su saldo, sabiendo que:
Estado de la cuenta 'Acreedor' si el saldo es >0.
           'Deudor' si el saldo es <0.
          'Nulo' si el saldo es =0.
b) La suma total de los saldos acreedores.*/
    {
        static void Main(string[] args) /*Jeremias Solano 14-SIST-1-017 Seccion 0908*/
        {
            int cuenta;
            float saldo, suma;
            string linea;
            suma = 0;
            
            do
            {
                Console.Write("Ingrese número de cuenta: ");
                linea = Console.ReadLine();
                cuenta = int.Parse(linea);
                
                if (cuenta >= 0)
                {
                    Console.Write("Ingrese saldo: ");
                    linea = Console.ReadLine();
                    saldo = float.Parse(linea);
                    
                    if (saldo > 0)
                    {
                        Console.WriteLine("Saldo Acreedor");
                        suma = suma + saldo;
                    }
                    
                    else
                    {
                        if (saldo < 0)
                        {
                            Console.WriteLine("Saldo Deudor");
                        }
                        else
                        {
                            Console.WriteLine("Saldo Nulo");
                        }
                    }
                }
            } while (cuenta >= 0);
            
            Console.Write("Jeremias Solano 14-SIST-1-017, ahora el total de saldos Acreedores:");
            Console.Write(suma);
            
            Console.ReadKey();
        }
    }
}