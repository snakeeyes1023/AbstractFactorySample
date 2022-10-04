using UsineVelo.Usines;

namespace UsineVelo.GenerateurUsines
{
    public class GenerateurUsine
    {
        public static UsineAbstraite GetUsineTrek()
        {
            return new UsineTrek();
        }

        public static UsineAbstraite GetUsineDevinci()
        {
            return new UsineDevinci();
        }
    }
}
