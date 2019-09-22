using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra.Double;
using System.Globalization;
using Geodezija;
using Geodezija.MetodaNajmanjihKvadrata;

namespace Izjednacenje2D
{
    public class KlasicanDatum
    {
        public void KoordinataCheckBox(bool koordinata, ListView Tocke, Label stajaliste, Label vizura, ComboBox cmbStajaliste, ComboBox cmbVizura)
        {
            if (koordinata)
            {
                cmbStajaliste.Items.Clear();
                cmbVizura.Items.Clear();

                stajaliste.Text = "Koordinata:";
                vizura.Text = "Točka:";

                cmbStajaliste.Items.Add("Y");
                cmbStajaliste.Items.Add("X");

                foreach (ListViewItem item in Tocke.Items)
                {
                    cmbVizura.Items.Add(item.SubItems[0].Text);
                }

            }
            else
            {
                stajaliste.Text = "Stajalište:";
                vizura.Text = "Vizura:";
            }
        }

        public void BazniVektorCheckBox(bool bazniVektor, ListView Tocke, GroupBox rotacija, GroupBox mjerilo, ComboBox cmbStajaliste, ComboBox cmbVizura)
        {
            if (bazniVektor)
            {
                cmbStajaliste.Items.Clear();
                cmbVizura.Items.Clear();

                mjerilo.Enabled = false;
                mjerilo.Visible = false;
                rotacija.Text = "Rotacija/Mjerilo";

                foreach (ListViewItem item in Tocke.Items)
                {
                    cmbStajaliste.Items.Add(item.SubItems[0].Text);
                }
            }
            else
            {
                mjerilo.Enabled = true;
                mjerilo.Visible = true;
                rotacija.Text = "Rotacija";
            }
        }

        public void AzimutDuzinaCheckBox(bool azimutDuzina, ListView Tocke, GroupBox rotacija, GroupBox mjerilo, ComboBox cmbStajalisteRotacija, ComboBox cmbStajalisteMjerilo)
        {
            if (azimutDuzina)
            {
                cmbStajalisteRotacija.Items.Clear();
                cmbStajalisteMjerilo.Items.Clear();

                rotacija.Text = "Rotacija: Azimut";
                mjerilo.Text = "Mjerilo: Dužina";

                foreach (ListViewItem item in Tocke.Items)
                {
                    cmbStajalisteRotacija.Items.Add(item.SubItems[0].Text);
                    cmbStajalisteMjerilo.Items.Add(item.SubItems[0].Text);
                }
            }
            else
            {
                rotacija.Text = "Rotacija";
                mjerilo.Text = "Mjerilo";
            }
        }


        public void Gtranslacije(ListView G, string y, string x)
        {
            foreach (ListViewItem item in G.Items)
            {
                if (item.SubItems[0].Text == "Y" + y)
                {
                    item.SubItems[1].Text = "1";
                }
                else
                {
                    item.SubItems[1].Text = "0";
                }

                if (item.SubItems[0].Text == "X" + y)
                {
                    item.SubItems[2].Text = "1";
                }
                else
                {
                    item.SubItems[2].Text = "0";
                }
            }

        }

        public void G(ListView G, ListView tocke, ListView y, ListView x, bool azimutDuzina, bool bazniVektor, bool Koordinata, string Rst, string Rvz, string Mst, string Mvz)
        {
            if (Koordinata)
            {
                this.Koordinata(G, Rst, Rvz, Mst, Mvz);
            }
            else if (azimutDuzina)
            {
                AzimutDuzina(G, tocke, y, x, Rst, Rvz, Mst, Mvz);
            }
            else if (bazniVektor)
            {
                BazniVektor(G, tocke, y, x, Rst, Rvz, Mst, Mvz);
            }
        }

        private void Koordinata(ListView G, string Rst, string Rvz, string Mst, string Mvz)
        {
            foreach (ListViewItem item in G.Items)
            {
                if (item.SubItems[0].Text == Rst + Rvz)
                {
                    item.SubItems[3].Text = "1";
                }
                else
                {
                    item.SubItems[3].Text = "0";
                }
                //MessageBox.Show(Mst + Mvz, Rst + Rvz);
                if (item.SubItems[0].Text == Mst + Mvz)
                {
                    item.SubItems[4].Text = "1";
                }
                else
                {
                    item.SubItems[4].Text = "0";
                }
            }
        }

        //dohvati koordinate iz listView-a
        private void Koordinate(ListView lvTocka, ListView lvY, ListView lvX, string tocka, out double y, out double x)
        {
            x = -1;
            y = -1;

            int i = -1;

            foreach (ListViewItem item in lvTocka.Items)
            {
                i++;

                if (item.SubItems[0].Text == tocka)
                {
                    y = Convert.ToDouble(lvY.Items[i].SubItems[0].Text, CultureInfo.InvariantCulture);
                    x = Convert.ToDouble(lvX.Items[i].SubItems[0].Text, CultureInfo.InvariantCulture);
                    break;
                }
            }

            if (x == -1 && y == -1)
            {
                MessageBox.Show("Problem sa točkom " + tocka, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Tocka2D Tocka(ListView lvTocka, ListView lvY, ListView lvX, string tocka)
        {
            double y, x;

            Koordinate(lvTocka, lvY, lvX, tocka, out y, out x);

            return new Tocka2D(y, x);
        }

        private void AzimutDuzina(ListView G, ListView tocke, ListView y, ListView x,  string Rst, string Rvz, string Mst, string Mvz)
        {

            try
            {
                Tocka2D azimutStajaliste = Tocka(tocke, y, x, Rst);
                Tocka2D azimutVizura = Tocka(tocke, y, x, Rvz);

                DerivacijaAzimut azimut = new DerivacijaAzimut(azimutStajaliste, azimutVizura);


                foreach (ListViewItem item in G.Items)
                {
                    if (item.SubItems[0].Text == "Y" + Rst)
                    {
                        item.SubItems[3].Text = (azimut.yStajaliste.ToSeconds().ToDouble() / 1000).ToString();
                    }
                    else if (item.SubItems[0].Text == "X" + Rst)
                        item.SubItems[3].Text = (azimut.xStajaliste.ToSeconds().ToDouble() / 1000).ToString();
                    else if (item.SubItems[0].Text == "Y" + Rvz)
                        item.SubItems[3].Text = (azimut.yVizura.ToSeconds().ToDouble() / 1000).ToString();
                    else if (item.SubItems[0].Text == "X" + Rvz)
                        item.SubItems[3].Text = (azimut.xVizura.ToSeconds().ToDouble() / 1000).ToString();
                    else
                    {
                        item.SubItems[3].Text = "0";
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Nedostatak podataka za rotaciju, ako u mreži nema rotacije zanemarite poruku \n\n" + e.Message + "\n\n" + e.ToString(), "Matrica uvijeta datuma (G)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                foreach (ListViewItem item in G.Items)
                {
                    item.SubItems[3].Text = "0";
                }
            }

            try
            {
                Tocka2D duzinaStajaliste = Tocka(tocke, y, x, Mst);
                Tocka2D duzinaVizura = Tocka(tocke, y, x, Mvz);
                DerivacijaDuzina duzina = new DerivacijaDuzina(duzinaStajaliste, duzinaVizura);

                foreach (ListViewItem item in G.Items)
                {
                    if (item.SubItems[0].Text == "Y" + Rst)
                    {
                        item.SubItems[4].Text = (duzina.yStajaliste).ToString();
                    }
                    else if (item.SubItems[0].Text == "X" + Rst)
                        item.SubItems[4].Text = (duzina.xStajaliste).ToString();
                    else if (item.SubItems[0].Text == "Y" + Rvz)
                        item.SubItems[4].Text = (duzina.yVizura).ToString();
                    else if (item.SubItems[0].Text == "X" + Rvz)
                        item.SubItems[4].Text = (duzina.xVizura).ToString();
                    else
                    {
                        item.SubItems[4].Text = "0";
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Nedostatak podataka za mjerilo, ako u mreži nema rotacije zanemarite poruku \n\n" + e.Message + "\n\n" + e.ToString(), "Matrica uvijeta datuma (G)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                foreach (ListViewItem item in G.Items)
                {
                    item.SubItems[4].Text = "0";
                }
            }

        }

        private void BazniVektor(ListView G, ListView tocke, ListView y, ListView x, string Rst, string Rvz, string Mst, string Mvz)
        {
            foreach (ListViewItem item in G.Items)
            {
                if (item.SubItems[0].Text == "Y" + Rst)
                {
                    item.SubItems[3].Text = "-1";
                    item.SubItems[4].Text = "-1";
                }
                else if (item.SubItems[0].Text == "X" + Rst)
                {
                    item.SubItems[3].Text = "-1";
                    item.SubItems[4].Text = "-1";
                }
                else if (item.SubItems[0].Text == "Y" + Rvz)
                {
                    item.SubItems[3].Text = "1";
                    item.SubItems[4].Text = "1";
                }
                else if(item.SubItems[0].Text == "X" + Rvz)
                {
                    item.SubItems[3].Text = "1";
                    item.SubItems[4].Text = "1";
                }
                else
                {
                    item.SubItems[3].Text = "0";
                    item.SubItems[4].Text = "0";
                }

            }
        }
    }
}
