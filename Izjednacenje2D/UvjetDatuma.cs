using Geodezija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Izjednacenje2D
{
    public enum vrstaIzjednacenja
    {
        minimalniTrag,
        parcijalnimMinimalniTrag,
        klasicanNacin,
        prisila
    }

    public class UvjetDatuma
    {
        public void G(Dictionary<string, TockaDatum> tocke, vrstaIzjednacenja vrsta, bool Rz, bool m, ListView lv)
        {

            switch (vrsta)
            {
                case vrstaIzjednacenja.minimalniTrag:

                    double brojTocaka = 1 / Math.Sqrt(tocke.Count());
                    double x = 0;
                    double y = 0;

                    double g = 0;

                    foreach (KeyValuePair<string, TockaDatum> pair in tocke)
                    {
                        y = pair.Value.Y + y;
                        x = pair.Value.X + x;
                    }

                    foreach (KeyValuePair<string, TockaDatum> pair in tocke)
                    {
                        g = Math.Pow(pair.Value.X-x,2) + Math.Pow(pair.Value.Y-y,2);
                    }

                    g = Math.Sqrt(g);

                    foreach (KeyValuePair<string, TockaDatum> pair in tocke)
                    {
                        ListViewItem itemY = new ListViewItem(brojTocaka.ToString());
                        itemY.SubItems.Add("0");

                        ListViewItem itemX = new ListViewItem("0");
                        itemX.SubItems.Add(brojTocaka.ToString());

                        double e = (pair.Value.X - x) / g;
                        double n = (pair.Value.Y - y) / g;

                        if(Rz)
                        {
                            itemY.SubItems.Add(e.ToString());
                            itemX.SubItems.Add("-"+n.ToString());
                        }
                        if (m)
                        {
                            itemY.SubItems.Add(n.ToString());
                            itemX.SubItems.Add(e.ToString());
                        }

                    }

                    break;
                case vrstaIzjednacenja.parcijalnimMinimalniTrag:

                    double brojTocak = 0;
                    double x1 = 0;
                    double y1 = 0;

                    double g1 = 0;

                    foreach (KeyValuePair<string, TockaDatum> pair in tocke)
                    {
                        if (pair.Value.XDatum && pair.Value.XDatum)
                        {
                            y = pair.Value.Y + y1;
                            x = pair.Value.X + x1;
                            brojTocak++;
                        }
                    }

                    foreach (KeyValuePair<string, TockaDatum> pair in tocke)
                    {
                        if (pair.Value.XDatum && pair.Value.XDatum)
                        {
                            g1 = Math.Pow(pair.Value.X - x1, 2) + Math.Pow(pair.Value.Y - y1, 2);
                        }
                    }
                    brojTocak = 1 / Math.Sqrt(brojTocak);
                    g1 = Math.Sqrt(g1);

                    foreach (KeyValuePair<string, TockaDatum> pair in tocke)
                    {
                        ListViewItem itemY = new ListViewItem(brojTocak.ToString());
                        itemY.SubItems.Add("0");

                        ListViewItem itemX = new ListViewItem("0");
                        itemX.SubItems.Add(brojTocak.ToString());

                        double e = (pair.Value.X - x1) / g1;
                        double n = (pair.Value.Y - y1) / g1;

                        if (Rz)
                        {
                            itemY.SubItems.Add(e.ToString());
                            itemX.SubItems.Add("-" + n.ToString());
                        }
                        if (m)
                        {
                            itemY.SubItems.Add(n.ToString());
                            itemX.SubItems.Add(e.ToString());
                        }

                    }

                    break;
                case vrstaIzjednacenja.klasicanNacin:

                    

                    bool Ty = true;
                    bool Tx = true;

                    foreach (KeyValuePair<string, TockaDatum> pair in tocke)
                    {
                        if (Ty && pair.Value.YDatum)
                        {
                            ListViewItem item = new ListViewItem("1");
                            item.SubItems.Add("0");

                            if(Rz)
                                item.SubItems.Add("0");
                            if(m)
                                item.SubItems.Add("0");

                            lv.Items.Add(item);
                        }
                    }

                        break;
                case vrstaIzjednacenja.prisila:
                    break;
                default:
                    break;
            }
        }
    }
}
