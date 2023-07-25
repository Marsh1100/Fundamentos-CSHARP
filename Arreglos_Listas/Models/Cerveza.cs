using System;
using System.Collections.Generic;
using System.Text;

namespace Arreglos_Listas.Models
{

    //Herencia de Bebida
    class Cerveza: Bebida
    {
        //Constructor, referencia del valor de su padre
        //Los parámetros por defecto deben situarse al final
        public Cerveza(int Cantidad, string Nombre ="Cerveza") 
        :base(Nombre, Cantidad)
        {

        }
    }
}