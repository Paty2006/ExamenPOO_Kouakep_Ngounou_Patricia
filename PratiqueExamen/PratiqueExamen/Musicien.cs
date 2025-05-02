using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratiqueExamen
{
    public class Musicien
    {
        public string Nom {  get; set; }
        public bool PreferenceGuitare { get; set; }
        public int Niveau { get; set; }
        public int Experience { get; set; }
        public int Montant { get; set; }
        public PieceDeMusique Piece {  get; set; }
        public InstrumentACorde Instrument { get; set; }
        public List<PieceDeMusique> Pieces { get; set; }
        public Musicien()
        {
            Nom = "Patricia";
            PreferenceGuitare = true;
            Niveau = 1;
            Experience = 0;
            Montant = 0;
            Pieces = new List<PieceDeMusique>();
            AjouterPiece(new PieceDeMusique("Piece De Musique Actuelle de "+ Nom, NomsNiveau.Facile));

        }

        public void AjouterPiece(PieceDeMusique piece)
        { 
            Pieces.Add(piece);
        }
        public override string ToString()
        {
            string infoMusicien = "";
            infoMusicien = infoMusicien + "Nom : " +  "Préfère :";
            if (PreferenceGuitare)
                infoMusicien += "Guitare\n";
            else
                infoMusicien += "Violon\n";

            infoMusicien = infoMusicien + "Niveau: " + Niveau + "Exp : " + Experience +"\n";

            infoMusicien += "Vous possédez présentement : " + Montant + "$\n";

            if (Instrument != null)
                infoMusicien += "Vous n'avez pas d'instrument\n";
            else
            {
                infoMusicien += Instrument.ToString();
            }
            return infoMusicien;
        }
    }
}
