using System;
using System.Collections.Generic;
using System.Text;

namespace Demostracion.ReglasDeInferencia
{
    public class Tecnologo : Bachiller
    {
        public string Titulo { get; set; }

        public Tecnologo(Bachiller bachiller, string titulo) : base(bachiller, bachiller.Academico, bachiller.Tecnico, bachiller.NombreColegio)
        {
            Titulo = titulo;
        }
    }
}
