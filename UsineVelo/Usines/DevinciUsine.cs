using Shape.Enums;
using Shape.Interfaces;
using UsineVelo.Velos.Devinci;

namespace UsineVelo.Usines
{
    internal class DevinciUsine : UsineAbstraite
    {
        public DevinciUsine()
        {
            Nom = "Devinci";
            Description = "Cycles Devinci is a Canadian bicycle manufacturer established in Chicoutimi, Quebec in 1987. In addition to a full line of road, mountain and hybrid bicycles, it also manufactures the BIXI-brand of bicycle used in bicycle sharing schemes in cities such as Montreal and Toronto.";
        }

        public override IRecette GetTypeVelo(VeloType typeVelo)
        {
            if (typeVelo == VeloType.MONTAGNE)
            {
                return new DoubleDevinci();
            }

            throw new ArgumentException("Le type : " + typeVelo.ToString() + " n'est pas supporté pour l'usine : " + Nom);
        }
    }
}
