using System;
using Arreglos_Listas.Models;


namespace Arreglos_Listas
{
    class Program
    {
        static void Main(string[] args)

        {
            //Los arreglos se le da una longitud inicial
            int[] numeros = new int[10] {1, 2, 3, 4, 5, 6, 7, 8,9,0};

            /*for (int i=0; i<numeros.Length; i++)
            {
                Console.WriteLine("Iteración "+i+" - "+numeros[i]);
            }*/

            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }

            //Cola Queue<int>, ejemplo

            //La lista es una clase de C#
        Console.WriteLine("************************************************");
            List<int> lista = new List<int>() {1,2,3,4,5,6,7,8};
            //Metodos
            lista.Add(9);
            lista.Add(0);

            lista.Remove(2);

            foreach(var numero in lista)
            {
                Console.WriteLine("elemento: "+numero);
            }
            Console.WriteLine("************************************************");
            //Lista de Clases
            List<Cerveza> cervezas = new List<Cerveza>() {new Cerveza(10,"Cerveza Premium")};

            cervezas.Add(new Cerveza(500,"Cerveza Andina"));
             cervezas.Add(new Cerveza(500));

            Cerveza erdinger = new Cerveza(500,"Cerveza de trigo");

            cervezas.Add(erdinger);

            foreach(var ceverza in cervezas)
            {
                Console.WriteLine("Cerveza: " + ceverza.Nombre);
            }


        }
    }
}