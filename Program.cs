/*6) Precargar un arreglo con 10 valores enteros y programar un método de búsqueda en el arreglo
 que permita determinar si un valor ingresado por el usuario existe dentro de dicho arreglo.*/
using System;

namespace TP_8_Ej6_
{
    class Program
    {
        static void Main(string[] args)
        {
        
           int[] arreglonumeros={14, 8, 63, 24, 48, 35, 18, 20};
           int valor;
           Console.Clear();
           

           System.Console.WriteLine("Ingrese un numero: ");
           valor = Convert.ToInt32(Console.ReadLine());
           
           BuscarEnArreglo(arreglonumeros, valor);
        }

        static void BuscarEnArreglo(int[] arreglonumeros, int valor)
        {
            bool encontrado= false;
            for(int i = 0; i< arreglonumeros.Length; i++)
            {
                if (arreglonumeros[i]==valor)
                {
                    encontrado= true;
                }
            }
            if ( encontrado==true)
            {
                Console.WriteLine("El valo fue hallado");
            }
            else
            {
                Console.WriteLine("El valo no fue hallado");
            }


        }



        }
    }

