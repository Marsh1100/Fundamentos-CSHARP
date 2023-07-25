using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaz.Models //Grupo al que pertenece la clase
{
    class Bebida
    {
        //Modificador de acceso para determinar el alcance (Public)

        //(private) solo puede acceder la misma clase
        //(protected) solo puede accder las clases derivadas de este

        //Si no se pone tiene uno que se llama Internal, pero no puede ser accedido por otro dll... 
        public string Nombre { get; set; }

        public int Cantidad { get; set; }

        //Constructor es un método
        public Bebida(string Nombre, int Cantidad)
        {
            this.Nombre = Nombre;
            this.Cantidad = Cantidad;
        }

        public void Beberse(int CuantoBebio)
        {
            this.Cantidad-=CuantoBebio;
        }
    }
}