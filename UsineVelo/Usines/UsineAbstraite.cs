using Shape.Enums;
using Shape.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsineVelo.Usines
{
    public abstract class UsineAbstraite
    {
        public string Nom { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public abstract IRecette GetTypeVelo(VeloType typeVelo);

        public virtual void AfficherInformationUsine()
        {
            Console.WriteLine($"{Nom} | {Description}");
        }
    }
}
