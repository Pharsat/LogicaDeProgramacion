using System;
using System.Collections.Generic;
using System.Text;

namespace Demostracion.ReglasDeInferencia
{
    public class Persona
    {
        public Persona(string nombre, int edad, string genero)
        {
            Nombre = nombre;
            Edad = edad;
            Genero = genero;
        }

        public string Nombre { get; set; }

        public int Edad { get; set; }

        public string Genero { get; set; }
    }
}
