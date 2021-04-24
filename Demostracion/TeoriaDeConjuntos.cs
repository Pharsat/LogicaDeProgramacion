using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demostracion
{
    // Array -> Arreglo
    // Objetos 
    // Persona: Nombre, Identidad de Genero, Edad
    // Numeros
    // Numero primos, numeros naturales, numeros entre 5 y 10.

    // If si, valida si una condicion se cumple, y entonces ejecuta un flujo.
    public static class TeoriaDeConjuntos
    {
        // AUnidoB = { 1,2,3,4,5,6,7 }

        public static int[] CalcularInterseccion(int[] A, int[] B)
        {
            int[] AIntersectoB = { };

            foreach (int x in A)
            {

                if (B.Contains(x))
                {
                    AIntersectoB = AIntersectoB.Append(x).ToArray();
                }
            }

            return AIntersectoB;
        }

        public static int[] CalcularUnion(int[] A, int[] B)
        {
            // Concat: tome todos los elementos de ambos conjuntos y unalos.
            // Distinct: tome todos los elementos repetidos y muestreme solo uno de ellos.
            int[] AUnionB = A.Concat(B).Distinct().OrderBy(x => x).ToArray();

            return AUnionB;
        }
    }
}
