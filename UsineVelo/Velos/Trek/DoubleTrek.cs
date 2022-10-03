using Shape.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsineVelo.Usines;
using UsineVelo.Velos.Devinci;

namespace UsineVelo.Velos.Trek
{
    public class DoubleTrek : IRecette
    {
        private IRecette recetteDevinci = new DoubleDevinci();

        public void FabriquerRoue()
        {
            recetteDevinci.FabriquerRoue();       
        }
        public void FabriquerCadre()
        {
            recetteDevinci.FabriquerCadre();
        }
    }
}
