using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using Interfaz.Models;

//Base para los patrones de diseño
//Organizar código
//Resuelve problemas de multiple herencia
namespace Interfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            var bebidaAlcoholica = new Cerveza(100);
            MostrarRecomendacion(bebidaAlcoholica);

            List<string> hola = new List<string>();
        }
        
        //Interfaces permite tener objetos que comparatan ciertas caracteríticas
        static void MostrarRecomendacion(IBebidaAlcoholica bebida)
        {
            bebida.MaxRecomendado();
        }
    }
}
