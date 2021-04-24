using System;
using System.Collections.Generic;
using System.Text;

namespace Demostracion.ReglasDeInferencia
{
    public class Bachiller : Persona
    {
        public Bachiller(Persona persona, bool academico, bool tecnico, string nombreColegio) 
            : base(persona.Nombre, persona.Edad, persona.Genero)
        {
            Academico = academico;
            Tecnico = tecnico;
            NombreColegio = nombreColegio;
        }

        public bool Academico { get; set; }

        public bool Tecnico { get; set; }

        public string NombreColegio { get; set; }
    }
}
