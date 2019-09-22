using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izjednacenje2D
{
    public class TockaDatum
    {
        string tocka;
        
        public string Tocka
        {
            get
            {
                return tocka;
            }

            set
            {
                tocka = value;
            }
        }

        public double Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public double X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public bool YDatum
        {
            get
            {
                return yDatum;
            }

            set
            {
                yDatum = value;
            }
        }

        public bool XDatum
        {
            get
            {
                return xDatum;
            }

            set
            {
                xDatum = value;
            }
        }

        double y;
        double x;

        bool yDatum;

        bool xDatum;

        public TockaDatum(string tocka, double y, bool yDatum, double x, bool xDatum)
        {
            this.tocka = tocka;
            this.y = y;
            this.yDatum = yDatum;
            this.x = x;
            this.xDatum = xDatum;
        }
    }
}
