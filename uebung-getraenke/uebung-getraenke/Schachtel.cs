using System;
using System.Collections.Generic;

namespace uebung_getraenke
{
    public class Schachtel
    {
        public double GesamtVolumen { get; set; }

        public List<Flasche> Flaschen { get; set; } = new List<Flasche>();

        public void AddFlasche(Flasche f)
        {
            Flaschen.Add(f);
        }

        public void BerechneFlaschenInhalt()
        {
            foreach (var flasche in Flaschen)
            {
                GesamtVolumen = GesamtVolumen + flasche.Volumen;
            }
        }
    }
}
