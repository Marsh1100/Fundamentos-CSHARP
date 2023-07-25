using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaz.Models //Grupo al que pertenece la clase
{
    //Se convierte la clase en una Interfaz
    interface IBebidaAlcoholica
    {
         public int Alcohol {get; set;}

         public void MaxRecomendado();
        

    }
}