using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratiqueExamen
{
    public abstract class InstrumentACorde
    {
        public string Nom { get; set; }
        public int PrixAchat { get; set; }
        public Corde Corde { get; set; }
        public int NombreCorde { get; set; }
        //to do : à définir le nombre de corde

        public InstrumentACorde(string nom, Corde corde, int nombreCorde)
        {

            Nom = nom;
            Corde = corde;
            PrixAchat =200* Corde.GetResistance();
            NombreCorde = nombreCorde;
        }

        public static bool operator <(InstrumentACorde instrument1, InstrumentACorde instrument2)
        {
            return instrument1.Corde.GetResistance() < instrument2.Corde.GetResistance();

        }

        public static bool operator >(InstrumentACorde instrument1, InstrumentACorde instrument2)
        {
            return instrument1.Corde.GetResistance() > instrument2.Corde.GetResistance();

        }

        public void BaisserDurabilite()
        {
            Corde.BaisserDurabilite();
        }
        public override string ToString()
        {
            string infoInstrument ="";
            infoInstrument += "Infos Instrument : \nNom : " + Nom + "\n";
            infoInstrument += "Prix :" + PrixAchat + "$\n";
            infoInstrument += Corde.ToString();
            return infoInstrument;
        }

    }
}
