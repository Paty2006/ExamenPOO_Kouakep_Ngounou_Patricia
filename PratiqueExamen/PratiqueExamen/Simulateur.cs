using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PratiqueExamen
{
    public class Simulateur
    {
        public Musicien Musicien { get; set; }

        public Simulateur(Musicien musicien)
        {
            Musicien = musicien;
            Console.Write("BIENVENUE À LA SIMULATION DE VOTRE NOUVELLE CARRIÈRE DE MUSICIEN\nINFO MUSICIEN");
            Console.WriteLine(Musicien.ToString());
            Console.WriteLine("Appuyez sur une touche pour commencer votre aventure");

            InstrumentACorde[] Instruments = new InstrumentACorde[5];
            Instruments[0] = new Guitare(NomsTypeG.Acoustique);
            Instruments[1] = new Guitare(NomsTypeG.Electrique);
            Instruments[2] = new Guitare(NomsTypeG.Basse);
            Instruments[3] = new Violon();
            Instruments[4] = new Violon();

            int indiceMeilleurInstrument = 1;
            for (int i = 1; i < Instruments.Length; i++)
            {
                if (Instruments[i]> Instruments[indiceMeilleurInstrument]) 
                    indiceMeilleurInstrument = i;
            }
            InstrumentACorde MeilleurInstrument = Instruments[indiceMeilleurInstrument];
            Musicien.Instrument = MeilleurInstrument;
            Console.WriteLine(MeilleurInstrument);

        }

        public void LancerMenu()
        {
            Console.WriteLine("Entrez un chiffre entre 1 et 5\n");
            Console.WriteLine("1-Voir le statut du Musicien / Instrument");
            Console.WriteLine("2-Pratiquer");
            Console.WriteLine("3-Réparer son instrument");
            Console.WriteLine("4-Acheter une nouvelle piéece");
            Console.WriteLine("5-Jouer pour un public");

            int choix = Console.ReadKey().KeyChar;
            switch (choix)
            {
                case 1:
                    VoirStatut();
                    break;
                case 2:
                    Pratiquer();
                    break;
                case 3:
                    ReparerInstrument();
                    break;
                case 4:
                    AcheterNouvellePiece();
                    break;
                default:
                    JouerPourUnPublic();
                    break;

            }
        }

        public void VoirStatut()
        {
            Console.WriteLine(Musicien);
        }

        public void Pratiquer()
        {
            int choix;
            do
            {
                Console.WriteLine("Liste des pièces de musique disponibles :\n");
                for (int i = 0; i < Musicien.Pieces.Count; i++)
                    Console.WriteLine("(" + (i + 1) + ")" + Musicien.Pieces[i]);

                Console.WriteLine("Entrer le chiffre correspondant à votre choix");

                choix = Console.ReadKey().KeyChar;
            } while (Musicien.Niveau >= Musicien.Pieces[choix].NiveauMinimum);
            if (Musicien.Instrument.Corde.Durabilite <= 0)
                throw new Exception("La durabilité de la corde a atteint ses limites");
            else
            {
                Musicien.Experience += Musicien.Pieces[choix - 1].QuantiteExperience;
                Musicien.Instrument.BaisserDurabilite();
            }
        }

        public void AcheterNouvellePiece()
        {
            PieceDeMusique[] NouvellesPieces = new PieceDeMusique[3];
            NouvellesPieces[0] = new PieceDeMusique("Esmeralda", NomsNiveau.Facile);
            NouvellesPieces[1] = new PieceDeMusique("Monalisa", NomsNiveau.Moyen);
            NouvellesPieces[2] = new PieceDeMusique("Unravel", NomsNiveau.Difficile);

            for(int i = 0; i < NouvellesPieces.Length; i++) 
            {
                Console.WriteLine("(" + i + ")" + NouvellesPieces[i]);
            }
            Console.WriteLine("entrer le chiffre correspondant à votre choix");

            int choix = Console.ReadKey().KeyChar;
            if (Musicien.Montant >= NouvellesPieces[choix].Prix)
                Musicien.AjouterPiece(NouvellesPieces[choix]);
            else
                Console.WriteLine("Vous n'avez pas assez d'argent");
        }
        public void ReparerInstrument()
        {
            Musicien.Instrument.Corde.Durabilite = Musicien.Instrument.Corde.GetResistance() * 2;
        }

        public void JouerPourUnPublic()
        {
            int choix;
            do
            {
                Console.WriteLine("Liste des pièces de musique disponibles :\n");
                for (int i = 0; i < Musicien.Pieces.Count; i++)
                    Console.WriteLine("(" + (i + 1) + ")" + Musicien.Pieces[i]);

                Console.WriteLine("Entrer le chiffre correspondant à votre choix");

                choix = Console.ReadKey().KeyChar;
            } while (Musicien.Niveau >= Musicien.Pieces[choix].NiveauMinimum);
            if (Musicien.Instrument.Corde.Durabilite <= 0)
                throw new Exception("La durabilité de la corde a atteint ses limites");
            else
            {
                Musicien.Experience += Musicien.Pieces[choix - 1].QuantiteExperience;
                Musicien.Instrument.BaisserDurabilite();
            }
            Musicien.Montant += Musicien.Pieces[choix - 1].Prix;
        }

        public override string ToString()
        {
            return "Ceci est un simulateur";
        }
    }
}
