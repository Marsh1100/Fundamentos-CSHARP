using System;

namespace Tipo_de_Datos
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Almacena menos memoria (0,255)
            byte numero = 255;
            //(-128-128)
            sbyte numero2 = -127;
            //Int almacena - y + 
            int numero3 = 100;
            //Números positivos
            uint numero4 = 124;
            //Números muy grandes solo positivos
            ulong numero5 = 100;

            //Datos flotantes, hay que definirselo con la letra al final 
            float numero6 = 189.1f;
            //Mayor alcance 8byte
            double numero7 =143.2d;
            //>> 16 byte
            decimal numero7 =123.7m;

            //Comilla simple
            char caracter = 'A';
            string  caracteres = "Lalalalalaa";

            //
            bool siOno = false;
            //Objeto
            DateTime date = new DateTime.Now();

            //Se inicializa con cero SI NO ESTA "DEFINIDO"
            int ejemplo = new int();
            Console.Write(ejemplo.ToString());

            //Aplica para el resto de variables
            //Ejemplo2 para asiganarle nulo

            char? ejemplo2 =null;
            Console.Write(ejemplo2.ToString());

            //Variable var;
            var nombre = "Margie";
            var limite = 50;

            //Tipo anónimo
            var persona = new {nombre="Margie", apellido="Bocanegra"};

            Console.WriteLine(persona,nombre);
        }
    }
}