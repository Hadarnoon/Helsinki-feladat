using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helsinki
{
    internal class Adat
    {
        public int Helyezes { get; set; }
        public int SportoloSzam { get; set; }
        public string SportAg { get; set; }
        public string VersenySzam { get; set; }

        public Adat(string sor)
        {
            var v = sor.Split(' ');
            this.Helyezes = int.Parse(v[0]);
            this.SportoloSzam = int.Parse(v[1]);
            this.SportAg = v[2];
            this.VersenySzam = v[3];
        }

        public override string ToString()
        {
            return $"{Helyezes} {SportoloSzam} {SportAg} {VersenySzam}";
        }
    }
}
