using System;
using UsineVelo.GenerateurUsines;
using UsineVelo.Usines;
using UsineVelo.Velos.Double;

class Program
{
    static void Main(string []args)
    {
        UsineAbstraite generateurUsine = GenerateurUsine.GetUsineTrek();

        generateurUsine.AfficherInformationUsine();
     
        Console.WriteLine();

        IDouble recetteDoubleSuspension = generateurUsine.GetRecetteDoubleSupsension();

        recetteDoubleSuspension.FabriquerCadre();
    }
}