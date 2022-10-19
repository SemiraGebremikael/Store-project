using System;
namespace Inlämningsuppgift
{
    public class Tshirt : Item
    {
        public string Storlek
        { get; set; }

        public string Material
        { get; set; }

        public Tshirt(string motiv, string storlek, string material, int betyg, int pris)
        {
            this.Motiv = motiv;
            this.Storlek = storlek;
            this.Material = material;
            this.Snittbetyg = betyg;
            this.Pris = pris;
        }

        public Tshirt (Tshirt tshirt)
        {
            this.Motiv = tshirt.Motiv;
            this.Snittbetyg = tshirt.Snittbetyg;
            this.Pris = tshirt.Pris;
            this.Material = tshirt.Material;
            this.Storlek = tshirt.Storlek;
        }
    }

}


