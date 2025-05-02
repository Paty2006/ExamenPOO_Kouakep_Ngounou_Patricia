using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratiqueExamen
{
    public class Corde
    {
        int Resistance { get; set; }
        public int Durabilite { get; set; }
        static readonly Random rand = new Random();


        public Corde()
        {
            Resistance = rand.Next(1, 11);
            Durabilite = Resistance * 2;
        }

        public int GetResistance() { return Resistance; }  
        public void SetResistance(int resistance) {this.Resistance = resistance;}

        public void BaisserDurabilite()
        {
            Durabilite -= 1;
        }

        public override string ToString()
        {
            string infoCorde = "";
            infoCorde += "Infos Corde :\n";
            infoCorde += "Résisance : " + Resistance + "\n";
            infoCorde += "Durabilité :" + Durabilite + "\n";
            return infoCorde;
        }
    }
}
