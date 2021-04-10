using System;
using System.Collections.Generic;
using System.Text;

namespace Demostracion
{
    public class Proposiciones
    {
        //boolean 1 o 0
        //if, ingles, SI
        //else, ingles, SI NO
        public static bool CalcularDiyuncion(bool proposicionP, bool proposicionQ)
        {
            if (proposicionP == false && proposicionQ == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool CalcularConjuncion(bool proposicionP, bool proposicionQ)
        {
            if (proposicionP == true && proposicionQ == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CalcularNegacion(bool proposicionP)
        {
            return !proposicionP;// ! = ¬
        }

        public static bool CalcularCondicional(bool proposicionImplica, bool proposicionImplicada)// p->Q === ¬P v Q
        {
            return CalcularDiyuncion(CalcularNegacion(proposicionImplica), proposicionImplicada);
        }

        public static bool CalcularBiCondicional(bool proposicionP, bool proposicionQ)
        {
            if (proposicionP == proposicionQ)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*
         *var proposicionP = false;
            var proposicionQ = false;

            var PyQ = CalcularConjuncion(proposicionP, proposicionQ);
            var negacionDePyQ = CalcularNegacion(PyQ);
            var PoQ = CalcularDiyuncion(proposicionP, proposicionQ);
            var QimplicaP = CalcularCondicional(proposicionQ, proposicionP);
            var PoQEquivaleQimplicaP = CalcularBiCondicional(PoQ, QimplicaP);
            var resultado = CalcularCondicional(negacionDePyQ, PoQEquivaleQimplicaP);

            Console.WriteLine("¬(P^Q) => ((PvQ) <=> (Q=>P)): " + (resultado ? "V" : "F"));
         *
         */
    }
}
