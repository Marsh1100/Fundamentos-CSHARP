using System;
using Clases_Objetos.Models;

namespace Clases_Objetos
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Bebida bebida = new Bebida("Pepsi",1000);
            bebida.Beberse(200);
            Console.Write(bebida.Cantidad+"\n");

           /* Cerveza cerveza = new Cerveza(800, "Cerveza Red");
            cerveza.Beberse(100);
            Console.Write(cerveza.Cantidad);*/

        }
    }

}