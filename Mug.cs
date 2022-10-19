using System;
namespace Inlämningsuppgift
{
    public class Mug:Item
    {

        public string Typ
        { get; set; }

        public Mug(string typ, string motiv, int betyg, int pris)
        {
            this.Typ = typ;
            this.Motiv = motiv;
            this.Snittbetyg = betyg;
            this.Pris = pris;
        }

        public Mug(Mug mug)
        {
            this.Motiv = mug.Motiv;
            this.Typ = mug.Typ;
            this.Snittbetyg = mug.Snittbetyg;
            this.Pris = mug.Pris;
        }
    }
}

