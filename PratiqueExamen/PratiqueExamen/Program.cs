namespace PratiqueExamen
{/*
    Kouakep Ngounou Patricia

    Description: Faire progresser un musicien
  */
    internal class Program
    {
        static void Main(string[] args)
        {
            Musicien musicien = new Musicien();
            Simulateur simulateur = new Simulateur(musicien);

            simulateur.LancerMenu();
        }
    }
}
