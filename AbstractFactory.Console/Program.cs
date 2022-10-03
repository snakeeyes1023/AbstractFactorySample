using Shape.Factories;
using System;
using Shape.Enums;
using Shape.Interfaces;
using UsineVelo.GenerateurUsines;
using UsineVelo.Usines;

class Program
{
    static void Main(string []args)
    {
        UsineAbstraite generateurUsine = GenerateurUsine.GetUsine(VeloMarque.DEVINCI);

        generateurUsine.AfficherInformationUsine();
        IRecette doubleDevinci = generateurUsine.GetTypeVelo(VeloType.MONTAGNE);

        Console.WriteLine();

        doubleDevinci.FabriquerRoue();
    }
}