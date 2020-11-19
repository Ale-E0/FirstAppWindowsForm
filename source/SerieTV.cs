using System;

namespace ColleoniWWF
{
    public class SerieTV
    {
        private string titolo;
        public string Titolo
        {
            get { return this.titolo; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    this.titolo = value;
                }
            }
        }
        private int stagioni; 
        public int Stagioni
        {
            get { return this.stagioni; }
            set { if (value > 0) this.stagioni = value; }
        }
        private int episodi;
        public int Episodi
        {
            get { return this.episodi; }
            set { if (value > 0) this.episodi = value; }
        }
        private string genere;
        public string Genere
        {
            get { return this.genere; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    this.genere = value;
                }
            }
        }
        private string paese;
        public string Paese
        {
            get { return this.paese; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    this.paese = value;
                }
            }
        }
        private string anno;
        public string Anno
        {
            get { return this.anno; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    this.anno = value;
                }
            }
        }
        public string Visualizza()
        {
                    return "Titolo: " + this.Titolo +
                           "\nStagioni: " + this.Stagioni +
                           "\nEpisodi: " + this.Episodi +
                           "\nGenere: " + this.Genere +
                           "\nPaese: " + this.Paese +
                           "\nAnno: " + this.Anno;
        }
    }
}
