using System;
namespace uebung_getraenke
{
    public abstract class Flasche
    {
        public double Durchmesser { get; protected set; }

        public double Höhe { get; protected set; }

        public double Volumen { get; protected set; }

        public double Radius { get; protected set; }
    }
}
