using Shape.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsineVelo.Usines;

namespace UsineVelo.GenerateurUsines
{
    public class GenerateurUsine
    {
        public static UsineAbstraite GetUsine(VeloMarque marque)
        {
            if (marque == VeloMarque.DEVINCI)
            {
                return new DevinciUsine();
            }
            else if (marque == VeloMarque.TREK)
            {
                return new TrekUsine();
            }

            throw new InvalidEnumArgumentException();
        }
    }
}
