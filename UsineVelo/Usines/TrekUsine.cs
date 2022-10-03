using Shape.Enums;
using Shape.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsineVelo.Velos.Devinci;
using UsineVelo.Velos.Trek;

namespace UsineVelo.Usines
{
    public class TrekUsine : UsineAbstraite
    {
        public TrekUsine()
        {
            Nom = "Trek";
            Description = "Trek started in a small Wisconsin barn in 1976, but our founders always saw something bigger. Forty-four years later, we're on a mission to ...";
        }

        public override IRecette GetTypeVelo(VeloType typeVelo)
        {
            if (typeVelo == VeloType.MONTAGNE)
            {
                return new DoubleTrek();
            }

            throw new ArgumentException("Le type : " + typeVelo.ToString() + " n'est pas supporté");
        }
    }
}
