using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demostracion.ReglasDeInferencia
{
    public static class ReglasDeInferencia
    {
        public static void EjecutarEjemplo()
        {
            var victor = new Persona("Victor", 25, "Masculino");

            var olga = new Persona("Olga", 35, "Femenino");

            var jhon = new Persona("Jhon", 20, "Masculino");

            var laura = new Persona("Laura", 32, "Femenino");

            var bachillerVictor = new Bachiller(victor, true, false, "Serafico");

            var lauraBachiller = new Bachiller(laura, true, false, "San Juan Bosco");

            var lauraTecnologa = new Tecnologo(lauraBachiller, "Tecnóloga en desarrollo de software");

            var conjuntoDePersonas = new List<Persona>();

            conjuntoDePersonas.Add(lauraTecnologa);
            conjuntoDePersonas.Add(bachillerVictor);
            conjuntoDePersonas.Add(jhon);
            conjuntoDePersonas.Add(olga);

            //Universal afirmativa para persona
            Console.WriteLine("Todos los elementos son bachiller: " + conjuntoDePersonas.All(persona => persona is Bachiller));

            //Universal negativa para persona
            Console.WriteLine("Todos los elementos no son bachiller: " + conjuntoDePersonas.All(persona => !(persona is Bachiller)));

            //Particular afirmativa para persona
            Console.WriteLine("Al menos un  elemento es bachiller: " + conjuntoDePersonas.Any(persona => persona is Bachiller));

            //Particular negativa para persona
            Console.WriteLine("Al menos un elemento no es bachiller: " + conjuntoDePersonas.Any(persona => !(persona is Bachiller)));
        }
    }
}
