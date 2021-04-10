using System;

namespace Demostracion
{
    public class Program
    {
        public static string ImprimirRepresentacionExtensivaDeUnConjunto(int[] Conjunto)
        {
            return $" = {{{string.Join(",", Conjunto)}}}";
        }

        static void Main(string[] args)
        {

            int[] A = { 1, 2, 3, 4, 5,233 };

            int[] B = { 6, 7, 8, 9,233 };

            int[] AIntersectoB = TeoriaDeConjuntos.CalcularInterseccion(A, B);

            int[] AUnidoB = TeoriaDeConjuntos.CalcularUnion(A, B);

            Console.WriteLine("A intersecto de B " + ImprimirRepresentacionExtensivaDeUnConjunto(AIntersectoB));
            Console.WriteLine("A unido  B " + ImprimirRepresentacionExtensivaDeUnConjunto(AUnidoB));

            Console.ReadLine();
        }
    }
}
