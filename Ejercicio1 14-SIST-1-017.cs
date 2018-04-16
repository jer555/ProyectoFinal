using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejercicio1
{
    class Program /*Programa que permita ingresar n números enteros por el teclado y se puede conocer:
             a) La cantidad de números positivos
             b) La cantidad de números negativos
             c) La cantidad de números pares
             d)La cantidad de números impares*/
    {
        static void Main(string[] args) /*Jeremias Solano 14-SIST-1-017 Seccion 0908*/
        {
            int n,valor,positivos,negativos,pares,impares;
            
            positivos = 0;
            negativos = 0;
            pares = 0;
            impares = 0;
            
            string linea;
            
            Console.Write("Ingrese valor de n: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            
            for(int i=1; i<=n; i++ ) {
                
                Console.Write("Ingrese numero "+i+": ");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                
                if (valor > 0)
                {
                    positivos++;
                }
                else
                {
                    if (valor < 0)
                    {
                        negativos++;
                    }
                }
                if (valor % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    if (valor % 2 != 0)
                    {
                        impares++;
                    }
                }
            }
            Console.WriteLine("Jeremias Solano 14-SIST-1-017, Ahora la cantidad de numeros negativos: "+negativos);
            Console.WriteLine("Jeremias Solano 14-SIST-1-017, Ahora la cantidad de numeros positivos: "+positivos);
            Console.WriteLine("Jeremias Solano 14-SIST-1-017, Ahora la cantidad de numeros pares: "+pares);
            Console.WriteLine("Jeremias Solano 14-SIST-1-017, Ahora la cantidad de numeros impares: "+impares);
            
            Console.ReadKey();
        }
    }
}