using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaz.Models
{

    //Herencia de Bebida
    class Cerveza: Bebida, IBebidaAlcoholica
    {
        public int Alcohol {get; set;}
        public void MaxRecomendado()
        {
            Console.WriteLine("El máximo permitido son 10.");

        }


        //Constructor, referencia del valor de su padre
        //Los parámetros por defecto deben situarse al final
        public Cerveza(int Cantidad, string Nombre ="Cerveza") 
        :base(Nombre, Cantidad)
        {

        }
    }
}