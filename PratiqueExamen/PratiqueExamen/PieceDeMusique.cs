using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratiqueExamen
{
    public enum NomsNiveau
    {
        Facile,
        Moyen,
        Difficile
    }

    public class PieceDeMusique
    {
        public string Nom {  get; set; }
        public NomsNiveau Niveau { get; set; }
        public int QuantiteExperience {  get; set; }
        public int NiveauMinimum { get; set; }
        public int Prix { get; set; }
        static readonly Random rand = new Random();


        public PieceDeMusique(string nom, NomsNiveau niveau)
        {
            
            Nom = nom;
            Niveau = niveau;
            if(Niveau == NomsNiveau.Facile)
            {
                QuantiteExperience = rand.Next(10, 31);
                NiveauMinimum = 1;
                Prix = 200;
            }
            else if(Niveau == NomsNiveau.Moyen)
            {
                QuantiteExperience = rand.Next(60, 81);
                NiveauMinimum = rand.Next(2,4);
                Prix = 400;
            }
            else
            {
                QuantiteExperience = rand.Next(100, 151);
                NiveauMinimum = rand.Next(4,6);
                Prix = 600;
            }
            
        }

        public override string ToString()
        {
            string infoPiece = "";
            infoPiece += $"~{Nom}~\n";
            infoPiece += $"Niveau de difficulté : {Niveau}\n";
            infoPiece += $"Niveau minimum : {NiveauMinimum}\n";
            infoPiece += $"Quantité d'expérience recu : {QuantiteExperience}\n";
            infoPiece += $"Prix : {Prix}\n";

            return infoPiece;
        }
    }
}
