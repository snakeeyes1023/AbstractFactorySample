using Shape.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsineVelo.Velos.Devinci
{
    public class DoubleDevinci : IRecette
    {
        public void FabriquerCadre()
        {
            Console.WriteLine("Je fabrique un cadre qui craque");
        }

        public void FabriquerRoue()
        {
            Console.WriteLine("Je fabrique des roue de devinci");
        }
    }
}
