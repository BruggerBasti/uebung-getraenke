using System;
namespace uebung_getraenke
{
    public class ZylinderFlasche : Flasche
    {
        public ZylinderFlasche(double durchmesser, double höhe)
        {
            this.Durchmesser = durchmesser;
            this.Höhe = höhe;
        }

        public void BerechneInhalt()
        {
            Radius = Durchmesser / 2;

            Volumen = Math.PI * Radius * Radius * Höhe;
        }
    }
}
