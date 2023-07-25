using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaz.Models
{

    //Herencia de Bebida
    class Vino: Bebida, IBebidaAlcoholica
    {
        public int Alcohol {get; set;}
        public void MaxRecomendado()
        {
            Console.WriteLine("El máximo permitido son 3 copas.");

        }

        //Constructor, referencia del valor de su padre
        //Los parámetros por defecto deben situarse al final
        public Vino(int Cantidad, string Nombre ="Vino") 
        :base(Nombre, Cantidad)
        {

        }
    }
}