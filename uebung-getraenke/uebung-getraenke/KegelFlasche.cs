using System;
namespace uebung_getraenke
{
    public class KegelFlasche : Flasche
    {
        public KegelFlasche(double höhe, double durchmesser)
        {
            this.Höhe = höhe;
            this.Durchmesser = durchmesser;
        }

        public void BerechneInhalt()
        {
            Volumen = Volumen + (Durchmesser / 2) * (Durchmesser / 2) * Höhe * Math.PI / 3;
        }
    }
}
