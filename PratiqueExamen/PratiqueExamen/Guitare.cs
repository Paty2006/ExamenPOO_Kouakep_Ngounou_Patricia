using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratiqueExamen
{
    public enum NomsTypeG
    {
        Acoustique,
        Basse,
        Electrique
    }

    public class Guitare : InstrumentACorde
    {
        public NomsTypeG TypeG {  get; set; }

        public Guitare(NomsTypeG typeG) : base("Guitare "+ typeG, new Corde(), 6)
        {
            TypeG = typeG;
        }
    }
}
