using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratiqueExamen
{
    
    public class Violon : InstrumentACorde
    {
        static readonly Random rand = new Random();
        static  string[] nomsViolon = [ "Violon Guarneri","Violon Amati","Violon Guiseppe","Violon Stradivarius"];
        public Violon() : base( nomsViolon[rand.Next(0,4)], new Corde(), 4)
        { 
        }
    }
}
