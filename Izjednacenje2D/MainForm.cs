using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Geodezija;
using Geodezija.MetodaNajmanjihKvadrata;
using MathNet.Numerics.LinearAlgebra.Double;

namespace Izjednacenje2D
{
    public enum tockaYX
    {
        T, Y, X
    }

    public enum mjerenje
    {
        azimut, pravac, kut, duzina, bazniVektor
    }

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            lblSigmaNula.Text = "σ";
            lblSigmaNulaKvadrat.Text = "σ²";

            #region Resurources
            rtbPravci2dOpis.SelectedRtf = Properties.Resources.Pravci2D_formule_za_RTB;
            rtbDuzineOpis.SelectedRtf = Properties.Resources.Duzine2D_formule_za_RTB;
            rtbBazniVektoriOpis.SelectedRtf = Properties.Resources.BazniVektori2D_formule_za_RTB;
            rtbAzimuti2dOpis.SelectedRtf = Properties.Resources.Azimuti2D_formule_za_RTB;
            rtbKutOpis.SelectedRtf = Properties.Resources.Kutevi2D_formule_za_RTB;
            #endregion Resurources

            //ispit();
           //test2();
            test6();
        }

        private void test1()
        {
            lvTocka.Items.Add("1");
            lvY.Items.Add("4140.154");
            lvX.Items.Add("4178.108");

            lvTocka.Items.Add("2");
            lvY.Items.Add("4353.714");
            lvX.Items.Add("4160.251");

            lvTocka.Items.Add("3");
            lvY.Items.Add("4443.982");
            lvX.Items.Add("4299.117");

            lvTocka.Items.Add("4");
            lvY.Items.Add("4261.255");
            lvX.Items.Add("4318.096");




        }


        private ListViewItem AddWithTextAndSubItems(string text, params string[] subItems)
        {
            var item = new ListViewItem(text);
            foreach (var subItem in subItems)
            {
                item.SubItems.Add(subItem);
            }
            return item;
        }

        private void test2()
        {

            #region Tocke

            lvTocka.Items.Add("1");
            lvY.Items.Add("1000");
            lvX.Items.Add("1000");

            lvTocka.Items.Add("2");
            lvY.Items.Add("1000.000");
            lvX.Items.Add("1187.840");

            lvTocka.Items.Add("3");
            lvY.Items.Add("1073.890");
            lvX.Items.Add("1148.900");

            lvTocka.Items.Add("4");
            lvY.Items.Add("1082.580");
            lvX.Items.Add("1075.030");

            #endregion Tocke

            #region Pravci

            lvPravac.Items.Add(AddWithTextAndSubItems(
                "test", "1", "2", "0-0-0", "", "", "", "-1.607395171", "1", "", "-1.098088799", "0", "1.098088799", "0"));
            lvPravac.Items.Add(AddWithTextAndSubItems(
                "test", "1", "3", "26-23-30", "", "", "", "1.048461646", "1", "", "-1.111538593", "0.551588896", "1.111538593", "-0.551588896"));
            lvPravac.Items.Add(AddWithTextAndSubItems(
                "test", "1", "4", "47-44-31", "", "", "", "0.558933525", "1", "", "-1.243161381", "1.368256255", "1.243161381", "-1.368256255"));


            lvPravac.Items.Add(AddWithTextAndSubItems(
                "test", "2", "3", "0-0-0", "", "", "", "-2.048193489", "1", "", "1.151361091", "2.184747586", "-1.151361091", "-2.184747586"));
            lvPravac.Items.Add(AddWithTextAndSubItems(
                "test", "2", "4", "26-0-16", "", "", "", "2.26082487", "1", "", "1.190488458", "0.871470054", "-1.190488458", "-0.871470054"));
            lvPravac.Items.Add(AddWithTextAndSubItems(
                "test", "2", "1", "62-12-37", "", "", "", "-0.21263138", "1", "", "1.098088799", "1.34532E-16", "-1.098088799", "-1.34532E-16"));


            lvPravac.Items.Add(AddWithTextAndSubItems(
                "test", "3", "1", "0-0-0", "", "", "", "1.313231726", "1", "", "1.111538593", "-0.551588896", "-1.111538593", "0.551588896"));
            lvPravac.Items.Add(AddWithTextAndSubItems(
                "test", "3", "2", "91-23-49", "", "", "", "0.8218128", "1", "", "-1.151361091", "-2.184747586", "1.151361091", "2.184747586"));
            lvPravac.Items.Add(AddWithTextAndSubItems(
                "test", "3", "4", "326-53-57", "", "", "", "-2.135044526", "1", "", "2.754155564", "0.32399637", "-2.754155564", "-0.32399637"));


            lvPravac.Items.Add(AddWithTextAndSubItems(
                "test", "4", "1", "0-0-0", "", "", "", "-0.116126474", "1", "", "1.243161381", "-1.368256255", "-1.243161381", "1.368256255"));
            lvPravac.Items.Add(AddWithTextAndSubItems(
                "test", "4", "2", "96-3-7", "", "", "", "1.19100108", "1", "", "-1.190488458", "-0.871470054", "1.190488458", "0.871470054"));
            lvPravac.Items.Add(AddWithTextAndSubItems(
                "test", "4", "3", "125-32-54", "", "", "", "-1.074874605", "1", "", "-2.754155564", "-0.32399637", "2.754155564", "0.32399637"));

            #endregion Pravci

            #region Duzine

            lvDuzina.Items.Add(AddWithTextAndSubItems(
                "test", "1", "2", "187.841", "", "-1", "2.777777778", "", "0", "-1", "0", "1"));
            lvDuzina.Items.Add(AddWithTextAndSubItems(
                "test", "1", "3", "166.228", "", "-2.424049727", "2.777777778", "", "-0.444516432", "-0.895770697", "0.444516432", "0.895770697"));
            lvDuzina.Items.Add(AddWithTextAndSubItems(
                "test", "1", "4", "111.57", "", "4.895473847", "2.777777778", "", "-0.740130651", "-0.672463099", "0.740130651", "0.672463099"));


            lvDuzina.Items.Add(AddWithTextAndSubItems(
                "test", "2", "3", "83.522", "", "0.785513894", "2.777777778", "", "-0.884668771", "0.466220083", "0.884668771", "-0.466220083"));
            lvDuzina.Items.Add(AddWithTextAndSubItems(
                "test", "2", "4", "139.805", "", "0.409408935", "2.777777778", "", "-0.590678146", "0.806907261", "0.590678146", "-0.806907261"));
            lvDuzina.Items.Add(AddWithTextAndSubItems(
                "test", "2", "1", "187.843", "", "-3", "2.777777778", "", "-1.22515E-16", "1", "1.22515E-16", "-1"));


            lvDuzina.Items.Add(AddWithTextAndSubItems(
                "test", "3", "1", "166.225", "", "0.575950273", "2.777777778", "", "0.444516432", "0.895770697", "-0.444516432", "-0.895770697"));
            lvDuzina.Items.Add(AddWithTextAndSubItems(
                "test", "3", "2", "83.522", "", "0.785513894", "2.777777778", "", "0.884668771", "-0.466220083", "-0.884668771", "0.466220083"));
            lvDuzina.Items.Add(AddWithTextAndSubItems(
                "test", "3", "4", "74.374", "", "5.385584986", "2.777777778", "", "-0.116833447", "0.993151522", "0.116833447", "-0.993151522"));


            lvDuzina.Items.Add(AddWithTextAndSubItems(
                "test", "4", "1", "111.573", "", "1.895473847", "2.777777778", "", "0.740130651", "0.672463099", "-0.740130651", "-0.672463099"));
            lvDuzina.Items.Add(AddWithTextAndSubItems(
                "test", "4", "2", "139.807", "", "-1.590591065", "2.777777778", "", "0.590678146", "-0.806907261", "-0.590678146", "0.806907261"));
            lvDuzina.Items.Add(AddWithTextAndSubItems(
                "test", "4", "3", "74.395", "", "-15.61441501", "2.777777778", "", "0.116833447", "-0.993151522", "-0.116833447", "0.993151522"));

            #endregion Duzine

            foreach (ListViewItem item in lvY.Items)
            {
                item.Checked = true;
            }

            foreach (ListViewItem item in lvX.Items)
            {
                item.Checked = true;
            }

            tbSigmaNula.Text = "5";
            tbSigmaNulaKvadrat.Text = "25";

        }

        private void test3()
        {
            lvTocka.Items.Add("1");
            lvY.Items.Add("2092.6724");
            lvX.Items.Add("927.8586");

            lvTocka.Items.Add("2");
            lvY.Items.Add("2183.7385");
            lvX.Items.Add("923.444");

            lvTocka.Items.Add("3");
            lvY.Items.Add("2186.3554");
            lvX.Items.Add("989.3402");

            lvTocka.Items.Add("4");
            lvY.Items.Add("2094.7659");
            lvX.Items.Add("991.4318");

        }

        private void test4()
        {
            lvTocka.Items.Add("14");
            lvY.Items.Add("4146.53");
            lvX.Items.Add("4223.33");

            lvTocka.Items.Add("15");
            lvY.Items.Add("4938.9");
            lvX.Items.Add("4965.65");

            lvTocka.Items.Add("16");
            lvY.Items.Add("5834.47");
            lvX.Items.Add("4353.47");

            lvTocka.Items.Add("17");
            lvY.Items.Add("5030.31");
            lvX.Items.Add("3592.03");

        }

        private void test5()
        {
            lvTocka.Items.Add("1");
            lvY.Items.Add("60");
            lvX.Items.Add("20");

            lvTocka.Items.Add("2");
            lvY.Items.Add("20");
            lvX.Items.Add("20");

            lvTocka.Items.Add("3");
            lvY.Items.Add("20");
            lvX.Items.Add("40");

            lvTocka.Items.Add("4");
            lvY.Items.Add("60");
            lvX.Items.Add("40");

        }

        private void ispit()
        {
            lvTocka.Items.Add("1");
            lvY.Items.Add("850");
            lvX.Items.Add("1250");

            lvTocka.Items.Add("2");
            lvY.Items.Add("1100");
            lvX.Items.Add("1500");

            lvTocka.Items.Add("3");
            lvY.Items.Add("1350");
            lvX.Items.Add("1250");

            lvTocka.Items.Add("4");
            lvY.Items.Add("1200");
            lvX.Items.Add("1000");

            lvTocka.Items.Add("5");
            lvY.Items.Add("1000");
            lvX.Items.Add("1000");

            TockeMreza2D();
        }

        private void test6()
        {
            lvTocka.Items.Add("1");
            lvY.Items.Add("1000");
            lvX.Items.Add("1000");


            lvTocka.Items.Add("2");
            lvY.Items.Add("1000");
            lvX.Items.Add("1187.84");

            lvTocka.Items.Add("3");
            lvY.Items.Add("1073.89");
            lvX.Items.Add("1148.9");

            lvTocka.Items.Add("4");
            lvY.Items.Add("1082.58");
            lvX.Items.Add("1075.03");
        }


        private DMS MjerenjeKutaPravcaAzimuta(string d, string m, string s)
        {
            int deg, min;
            double sec;

            int.TryParse(d, out deg);
            int.TryParse(m, out min);

            try
            {
                sec = Convert.ToDouble(s, CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                sec = 0;
            }

            return new DMS(deg, min, sec);
        }

        // koristi se za popunjavanje combo box-a vizure te provjeru da li je vec tocka unesena - ako je unesena sa 
        // stajalista ona se ne unosi
        private void PopunjavanjeComboBoxVizura(ListView zaPretraguDaLiJeUneseno, ComboBox zaPopunit, string stajaliste)
        {
            zaPopunit.Items.Clear();

            foreach (ListViewItem item in lvTocka.Items)
            {
                bool uneseno = false;
                string vizura = item.SubItems[0].Text;

                if (stajaliste != vizura)
                {
                    foreach (ListViewItem lvi in zaPretraguDaLiJeUneseno.Items)
                    {
                        if (lvi.SubItems[1].Text == stajaliste && lvi.SubItems[2].Text == vizura)
                        {
                            uneseno = true;
                            break;
                        }
                    }

                    if (uneseno == false)
                        zaPopunit.Items.Add(vizura);
                }
            }
        }

        private void PopunjavanjeComboBoxDo(ListView zaPretraguDaLiJeUneseno, ComboBox zaPopunit, string stajaliste, string Od)
        {
            zaPopunit.Items.Clear();

            foreach (ListViewItem item in lvTocka.Items)
            {
                zaPopunit.Items.Add(item.SubItems[0].Text);
            }
            zaPopunit.Items.Remove(stajaliste);
            zaPopunit.Items.Remove(Od);

            foreach (ListViewItem item in lvKut.Items)
            {
                if (item.SubItems[1].Text == stajaliste && item.SubItems[2].Text == Od)
                {
                    zaPopunit.Items.Remove(item.SubItems[3].Text);
                }
            }
        }

        //popunjavanje svih listView-a, ComboBox-eva i ostalog za 2D mrezu
        private void TockeMreza2D()
        {
            cmb2DpravciStajaliste.Items.Clear();
            cmb2DkuteviStajaliste.Items.Clear();
            cmb2DkuteviOD.Items.Clear();
            cmb2DduzineStajaliste.Items.Clear();
            cmb2DbazniStajaliste.Items.Clear();
            cmb2DazimutiStajaliste.Items.Clear();

            foreach (ListViewItem item in lvTocka.Items)
            {
                cmb2DpravciStajaliste.Items.Add(item.SubItems[0].Text);
                cmb2DkuteviStajaliste.Items.Add(item.SubItems[0].Text);
                cmb2DkuteviOD.Items.Add(item.SubItems[0].Text);
                cmb2DduzineStajaliste.Items.Add(item.SubItems[0].Text);
                cmb2DbazniStajaliste.Items.Add(item.SubItems[0].Text);
                cmb2DazimutiStajaliste.Items.Add(item.SubItems[0].Text);

            }
        }

        //dohvati koordinate iz listView-a
        private void Koordinate(string tocka, out double y, out double x)
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

        private Tocka2D Tocka(string tocka)
        {
            double y, x;

            Koordinate(tocka, out y, out x);

            return new Tocka2D(y, x);
        }

        private string Tolerancija(double f, string tolerancija)
        {
            double tol = Math.Abs(Convert.ToDouble(tolerancija));
            f = Math.Abs(f);

            if (f > tol)
            {
                MessageBox.Show("Razlika između mjerenja i izračunate vrijednosti iz koordinata veća od tolerancije", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "-GRESKA-";
            }
            else
                return "OK";
        }

        #region Radio Button Vrsta Izjednacenja

        private void rbMinimalniTrag_CheckedChanged(object sender, EventArgs e)
        {
            gbKlasicanNacin.Enabled = false;
            gbKlasicanNacin.Visible = false;
        }

        private void rbParcijalniMinimalniTrag_CheckedChanged(object sender, EventArgs e)
        {
            gbKlasicanNacin.Enabled = false;
            gbKlasicanNacin.Visible = false;
        }

        private void rbKlasicanNacin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKlasicanNacin.Checked)
            {
                DatumKlasican();
                gbKlasicanNacin.Enabled = true;
                gbKlasicanNacin.Visible = true;
            }
            else
            {
                gbKlasicanNacin.Enabled = false;
                gbKlasicanNacin.Visible = false;
            }
        }

        private void rbIzjednacenjePrisila_CheckedChanged(object sender, EventArgs e)
        {
            gbKlasicanNacin.Enabled = false;
            gbKlasicanNacin.Visible = false;
        }

        #endregion Radio Button Vrsta Izjednacenja

        #region Sigma nula


        private void PreracunavanjeTezineZaMjerenja()
        {
            #region Azimut

            foreach (ListViewItem item in lvAzimut.Items)
            {
                if (item.SubItems[7].Text != "")
                {
                    double sigmaMjerenja = Convert.ToDouble(item.SubItems[7].Text);
                    string tezina = (sigmaNulaKvadrat / sigmaMjerenja).ToString();
                    item.SubItems[6].Text = tezina;
                }
            }

            #endregion Azimut

            #region Pravac

            foreach (ListViewItem item in lvPravac.Items)
            {
                if (item.SubItems[9].Text != "")
                {
                    double sigmaMjerenja = Convert.ToDouble(item.SubItems[9].Text);
                    string tezina = (sigmaNulaKvadrat / sigmaMjerenja).ToString();
                    item.SubItems[8].Text = tezina;
                }
            }

            #endregion Pravac

            #region Kut

            foreach (ListViewItem item in lvKut.Items)
            {
                if (item.SubItems[8].Text != "")
                {
                    double sigmaMjerenja = Convert.ToDouble(item.SubItems[8].Text);
                    string tezina = (sigmaNulaKvadrat / sigmaMjerenja).ToString();
                    item.SubItems[7].Text = tezina;
                }
            }

            #endregion Kut

            #region Duzina

            foreach (ListViewItem item in lvDuzina.Items)
            {
                if (item.SubItems[7].Text != "")
                {
                    double sigmaMjerenja = Convert.ToDouble(item.SubItems[7].Text);
                    string tezina = (sigmaNulaKvadrat / sigmaMjerenja).ToString();
                    item.SubItems[6].Text = tezina;
                }
            }

            #endregion Duzina

            #region Bazni

            foreach (ListViewItem item in lvBazniVektor.Items)
            {
                if (item.SubItems[12].Text != "" && item.SubItems[13].Text != "" && item.SubItems[14].Text != "")
                {
                    double y = Convert.ToDouble(item.SubItems[12].Text);
                    double xy = Convert.ToDouble(item.SubItems[13].Text);
                    double x = Convert.ToDouble(item.SubItems[14].Text);

                    VarijancaMjerenja varijanca = new VarijancaMjerenja();
                    DenseMatrix sig = varijanca.KovarijanceKomponentiBaznogVektora2D(x, xy, y);

                    sig = (DenseMatrix)sig.Inverse() * sigmaNulaKvadrat;

                    string Xtezina = (sig[0, 0]).ToString();
                    string XYtezina = (sig[0, 1]).ToString();
                    string Ytezina = (sig[1, 1]).ToString();

                    item.SubItems[11].Text = Xtezina;
                    item.SubItems[10].Text = XYtezina;
                    item.SubItems[9].Text = Ytezina;
                }
            }

            #endregion Bazni

        }

        double sigmaNulaKvadrat = 1;

        private void tbSigmaNula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // samo jedna tocka
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbSigmaNulaKvadrat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // samo jedna tocka
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbSigmaNula_TextChanged(object sender, EventArgs e)
        {
            tbSigmaNula.Text = tbSigmaNula.Text.Replace(',', '.');
            SigmaTextChange(true);
        }

        private void tbSigmaNulaKvadrat_TextChanged(object sender, EventArgs e)
        {
            tbSigmaNulaKvadrat.Text = tbSigmaNulaKvadrat.Text.Replace(',', '.');
            SigmaTextChange(false);
        }

        private void SigmaTextChange(bool so)
        {
            try
            {

                if (so)
                {
                    tbSigmaNulaKvadrat.Text = Math.Pow(Math.Round(Convert.ToDouble(tbSigmaNula.Text, CultureInfo.InvariantCulture), 12), 2).ToString();
                    sigmaNulaKvadrat = Math.Round(Convert.ToDouble(tbSigmaNulaKvadrat.Text, CultureInfo.InvariantCulture), 12);
                    PreracunavanjeTezineZaMjerenja();
                }
                else
                {
                    sigmaNulaKvadrat = Math.Round(Convert.ToDouble(tbSigmaNulaKvadrat.Text, CultureInfo.InvariantCulture), 12);
                    tbSigmaNula.Text = Math.Sqrt(sigmaNulaKvadrat).ToString();
                    PreracunavanjeTezineZaMjerenja();
                }
            }
            catch { }
        }

        #endregion Sigma nula

        #region Velicine u izjednacenju

        private void VelicineUIzjednacenju()
        {
            if (ckbAzimut.Checked)
                pnlAzimut.Enabled = true;
            else
                pnlAzimut.Enabled = false;

            if (ckbPravac.Checked)
                pnlPravac.Enabled = true;
            else
                pnlPravac.Enabled = false;

            if (ckbKut.Checked)
                pnlKut.Enabled = true;
            else
                pnlKut.Enabled = false;

            if (ckbDuzina.Checked)
                pnlDuzina.Enabled = true;
            else
                pnlDuzina.Enabled = false;

            if (ckbBazniVektor.Checked)
                pnlBazniVektor.Enabled = true;
            else
                pnlBazniVektor.Enabled = false;

        }

        private void ckbAzimut_CheckedChanged(object sender, EventArgs e)
        {
            VelicineUIzjednacenju();
        }

        private void ckbPravac_CheckedChanged(object sender, EventArgs e)
        {
            VelicineUIzjednacenju();
        }

        private void ckbKut_CheckedChanged(object sender, EventArgs e)
        {
            VelicineUIzjednacenju();
        }

        private void ckbDuzina_CheckedChanged(object sender, EventArgs e)
        {
            VelicineUIzjednacenju();
        }

        private void ckbBazniVektor_CheckedChanged(object sender, EventArgs e)
        {
            VelicineUIzjednacenju();
        }


        #endregion Velicine u izjednacenju

        #region Tocke

        #region KeyUp Enter Pressed

        private void tbTocka_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tbTocka.Text != "")
            {
                tbY.Focus();
            }
        }

        private void tbY_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tbY.Text != "")
            {
                tbX.Focus();
            }
        }

        private void tbX_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tbY.Text != "" && tbTocka.Text != "" && tbX.Text != "")
                btnDodajTocku.PerformClick();

            else if (e.KeyCode == Keys.Enter && tbY.Text != "")
                tbTocka.Focus();

            else if (e.KeyCode == Keys.Enter && tbY.Text != "")
                tbY.Focus();
        }

        #endregion KeyUp Enter Pressed

        private void izbrisiTockuIzSvihListView(string tocka)
        {
            if (lvAzimut.Items.Count > 0 || lvPravac.Items.Count > 0 || lvKut.Items.Count > 0 || lvDuzina.Items.Count > 0 || lvBazniVektor.Items.Count > 0)
            {
                foreach (ListViewItem item in lvAzimut.Items)
                {
                    if (item.SubItems[1].Text == tocka || item.SubItems[2].Text == tocka)
                        lvAzimut.Items.Remove(item);
                }

                foreach (ListViewItem item in lvPravac.Items)
                {
                    if (item.SubItems[1].Text == tocka || item.SubItems[2].Text == tocka)
                        lvPravac.Items.Remove(item);
                }

                foreach (ListViewItem item in lvKut.Items)
                {
                    if (item.SubItems[1].Text == tocka || item.SubItems[2].Text == tocka)
                        lvKut.Items.Remove(item);
                }

                foreach (ListViewItem item in lvDuzina.Items)
                {
                    if (item.SubItems[1].Text == tocka || item.SubItems[2].Text == tocka)
                        lvDuzina.Items.Remove(item);
                }

                foreach (ListViewItem item in lvBazniVektor.Items)
                {
                    if (item.SubItems[1].Text == tocka || item.SubItems[2].Text == tocka)
                        lvBazniVektor.Items.Remove(item);
                }
            }
        }

        private void brisanjeTocke(int index)
        {
            string brisanje = lvTocka.Items[index].Text;

            izbrisiTockuIzSvihListView(brisanje);

            lvTocka.Items.RemoveAt(index);
            lvY.Items.RemoveAt(index);
            lvX.Items.RemoveAt(index);

        }

        private void urediListView(ListView lv)
        {
            foreach (ColumnHeader column in lv.Columns)
            {
                column.Width = -2;
            }
        }

        tockaYX ListViewKojiJeKliknut = tockaYX.T;

        private void urediSveListView()
        {
            urediListView(lvTocka);
            urediListView(lvY);
            urediListView(lvAzimut);
            urediListView(lvPravac);
            urediListView(lvKut);
            urediListView(lvDuzina);
            urediListView(lvBazniVektor);
        }

        private void tbY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // samo jedna tocka
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // samo jedna tocka
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void KlasicaDatumCmb()
        {
            cmbKlasicanY.Items.Clear();
            cmbKlasicanX.Items.Clear();
            cmbKlasicanRstajaliste.Items.Clear();
            cmbKlasicanMstajaliste.Items.Clear();


            foreach (ListViewItem item in lvTocka.Items)
            {
                cmbKlasicanY.Items.Add(item.SubItems[0].Text);
                cmbKlasicanX.Items.Add(item.SubItems[0].Text);
            }
        }

        private void btnDodajTocku_Click(object sender, EventArgs e)
        {
            bool tockaNijeUnesena = false;
            Tocka2D unesena;

            foreach (ListViewItem item in lvTocka.Items)
            {
                if(item.SubItems[0].Text == tbTocka.Text)
                {
                    tockaNijeUnesena = true;
                    unesena = Tocka(tbTocka.Text);
                    MessageBox.Show("Točka " + tbTocka.Text + " je već unesena. \n\n tbTocka.Text\nY: " + unesena.Y + "\nX: " + unesena.X,  "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (tbTocka.Text == "")
                MessageBox.Show("Niste unijeli točku", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (tbY.Text == "")
                MessageBox.Show("Niste unijeli Y koordinatu točke", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (tbX.Text == "")
                MessageBox.Show("Niste unijeli X koordinatu točke", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!tockaNijeUnesena)
            {
                KlasicaDatumCmb();

                lvTocka.Items.Add(new ListViewItem(tbTocka.Text));
                lvY.Items.Add(new ListViewItem(tbY.Text));
                lvX.Items.Add(new ListViewItem(tbX.Text));

                urediSveListView();

                TockeMreza2D();

                tbTocka.Clear();
                tbY.Clear();
                tbX.Clear();
            }


        }

        #region ListView Tocka Y X Mouse Down

        private void lvTocka_MouseDown(object sender, MouseEventArgs e)
        {
            ListViewKojiJeKliknut = tockaYX.T;

            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        ContextMenu cms = new ContextMenu();
                        cms.MenuItems.Add("Izbriši", new EventHandler(IzbrisiTocku_Click));
                        cms.Show(this, this.PointToClient(Cursor.Position));
                    }
                    break;
            }
        }

        private void lvY_MouseDown(object sender, MouseEventArgs e)
        {
            ListViewKojiJeKliknut = tockaYX.Y;

            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        ContextMenu cms = new ContextMenu();
                        cms.MenuItems.Add("Izbriši", new EventHandler(IzbrisiTocku_Click));
                        cms.Show(this, this.PointToClient(Cursor.Position));
                    }
                    break;
            }
        }

        private void lvX_MouseDown(object sender, MouseEventArgs e)
        {
            ListViewKojiJeKliknut = tockaYX.X;

            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        ContextMenu cms = new ContextMenu();
                        cms.MenuItems.Add("Izbriši", new EventHandler(IzbrisiTocku_Click));
                        cms.Show(this, this.PointToClient(Cursor.Position));
                    }
                    break;
            }
        }

        #endregion ListView Tocka Y X Mouse Down

        private void IzbrisiTocku_Click(object sender, EventArgs e)  //ConText Menu funkcije
        {
            switch (ListViewKojiJeKliknut)
            {
                case tockaYX.T:
                    if (lvTocka.SelectedIndices[0] > -1)
                    {
                        int index = lvTocka.SelectedIndices[0];
                        string tocka = lvTocka.Items[index].Text;

                        string txt = "Da li želite izbrisati točku? \n\n" + tocka + "\nY: " + lvY.Items[index].Text + "\nX: " + lvX.Items[index].Text;

                        DialogResult dialogResult = MessageBox.Show(txt, "Brisanje", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            lvTocka.Items.RemoveAt(index);
                            lvY.Items.RemoveAt(index);
                            lvX.Items.RemoveAt(index);
                            izbrisiTockuIzSvihListView(tocka);
                            TockeMreza2D();
                        }
                    }
                    break;
                case tockaYX.Y:
                    if (lvY.SelectedIndices[0] > -1)
                    {
                        int index = lvY.SelectedIndices[0];
                        string tocka = lvTocka.Items[index].Text;

                        string txt = "Da li želite izbrisati točku? \n\n" + tocka + "\nY: " + lvY.Items[index].Text + "\nX: " + lvX.Items[index].Text;

                        DialogResult dialogResult = MessageBox.Show(txt, "Brisanje", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            lvTocka.Items.RemoveAt(index);
                            lvY.Items.RemoveAt(index);
                            lvX.Items.RemoveAt(index);
                            izbrisiTockuIzSvihListView(tocka);
                            TockeMreza2D();
                        }
                    }
                    break;
                case tockaYX.X:
                    if (lvX.SelectedIndices[0] > -1)
                    {
                        int index = lvX.SelectedIndices[0];
                        string tocka = lvTocka.Items[index].Text;

                        string txt = "Da li želite izbrisati točku? \n\n" + tocka + "\nY: " + lvY.Items[index].Text + "\nX: " + lvX.Items[index].Text;

                        DialogResult dialogResult = MessageBox.Show(txt, "Brisanje", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            lvTocka.Items.RemoveAt(index);
                            lvY.Items.RemoveAt(index);
                            lvX.Items.RemoveAt(index);
                            izbrisiTockuIzSvihListView(tocka);
                            TockeMreza2D();
                        }
                    }
                    break;
            }




        }

        #endregion Tocke

        #region ContexMenu za Mjerenja

        mjerenje listViewIzKojegSeBriseMjerenje;

        private void ContextMenuMjerenja()
        {
            ContextMenu cms = new ContextMenu();
            cms.MenuItems.Add("Izbriši", new EventHandler(IzbrisiMjerenje_Click));
            cms.MenuItems.Add("Pomakni prema gore", new EventHandler(PomakniGore_Click));
            cms.MenuItems.Add("Pomakni prema dolje", new EventHandler(PomakniDolje_Click));
            cms.Show(this, this.PointToClient(Cursor.Position));
        }

        private void IzbrisiMjerenjeIzListView(ListView lv)
        {
            if (lv.SelectedIndices[0] > -1)
            {
                int index = lv.SelectedIndices[0];
                string tocka = lv.Items[index].Text;

                string txt = "Da li želite izbrisati mjerenje " + lv.Items[index].SubItems[1].Text + "-" + lv.Items[index].SubItems[2].Text + "?";

                DialogResult dialogResult = MessageBox.Show(txt, "Brisanje", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    lv.Items.RemoveAt(index);
                    urediListView(lv);
                }
            }
        }

        private void IzbrisiMjerenje_Click(object sender, EventArgs e)
        {
            switch (listViewIzKojegSeBriseMjerenje)
            {
                case mjerenje.azimut:
                    IzbrisiMjerenjeIzListView(lvAzimut);
                    PopunjavanjeComboBoxVizura(lvDuzina, cmb2dAzimutiVizura, cmb2DazimutiStajaliste.Text);
                    break;
                case mjerenje.pravac:
                    IzbrisiMjerenjeIzListView(lvPravac);
                    PopunjavanjeComboBoxVizura(lvDuzina, cmb2dPravciVizura, cmb2DpravciStajaliste.Text);
                    RacunanjeNovihF();
                    TrazenjeGreskeOrijentacijskogKuta();
                    break;
                case mjerenje.kut:
                    IzbrisiMjerenjeIzListView(lvKut);
                    PopunjavanjeComboBoxDo(lvKut, cmb2DkuteviDO, cmb2DkuteviStajaliste.Text, cmb2DkuteviOD.Text);
                    break;
                case mjerenje.duzina:
                    IzbrisiMjerenjeIzListView(lvDuzina);
                    PopunjavanjeComboBoxVizura(lvDuzina, cmb2dDuzineVizura, cmb2DduzineStajaliste.Text);
                    break;
                case mjerenje.bazniVektor:
                    IzbrisiMjerenjeIzListView(lvBazniVektor);
                    PopunjavanjeComboBoxVizura(lvDuzina, cmb2dBazniVizura, cmb2DbazniStajaliste.Text);
                    break;
                default:
                    break;
            }
        }

        private void PomakniGore_Click(object sender, EventArgs e)
        {
            switch (listViewIzKojegSeBriseMjerenje)
            {
                case mjerenje.azimut:
                    MoveListViewItems(lvAzimut, MoveDirection.Up);
                    break;
                case mjerenje.pravac:
                    MoveListViewItems(lvPravac, MoveDirection.Up);
                    break;
                case mjerenje.kut:
                    MoveListViewItems(lvKut, MoveDirection.Up);
                    break;
                case mjerenje.duzina:
                    MoveListViewItems(lvDuzina, MoveDirection.Up);
                    break;
                case mjerenje.bazniVektor:
                    MoveListViewItems(lvBazniVektor, MoveDirection.Up);
                    break;
                default:
                    break;
            }
        }

        private void PomakniDolje_Click(object sender, EventArgs e)
        {
            switch (listViewIzKojegSeBriseMjerenje)
            {
                case mjerenje.azimut:
                    MoveListViewItems(lvAzimut, MoveDirection.Down);
                    break;
                case mjerenje.pravac:
                    MoveListViewItems(lvPravac, MoveDirection.Down);
                    break;
                case mjerenje.kut:
                    MoveListViewItems(lvKut, MoveDirection.Down);
                    break;
                case mjerenje.duzina:
                    MoveListViewItems(lvDuzina, MoveDirection.Down);
                    break;
                case mjerenje.bazniVektor:
                    MoveListViewItems(lvBazniVektor, MoveDirection.Down);
                    break;
                default:
                    break;
            }
        }

        private enum MoveDirection { Up = -1, Down = 1 };

        private static void MoveListViewItems(ListView sender, MoveDirection direction)
        {
            int dir = (int)direction;
            int opp = dir * -1;
            int select = 0;

            bool valid = sender.SelectedItems.Count > 0 &&
                            ((direction == MoveDirection.Down && (sender.SelectedItems[sender.SelectedItems.Count - 1].Index < sender.Items.Count - 1))
                        || (direction == MoveDirection.Up && (sender.SelectedItems[0].Index > 0)));

            if (valid)
            {
                foreach (ListViewItem item in sender.SelectedItems)
                {
                    int index = item.Index + dir;
                    sender.Items.RemoveAt(item.Index);
                    sender.Items.Insert(index, item);

                    select = index;
                }
            }
        }

        #region Mouse Down

        private void lvAzimut_MouseDown(object sender, MouseEventArgs e)
        {
            listViewIzKojegSeBriseMjerenje = mjerenje.azimut;

            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        ContextMenuMjerenja();
                    }
                    break;
            }
        }

        private void lvPravac_MouseDown(object sender, MouseEventArgs e)
        {
            listViewIzKojegSeBriseMjerenje = mjerenje.pravac;

            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        ContextMenuMjerenja();
                    }
                    break;
            }
        }

        private void lvKut_MouseDown(object sender, MouseEventArgs e)
        {
            listViewIzKojegSeBriseMjerenje = mjerenje.kut;

            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        ContextMenuMjerenja();
                    }
                    break;
            }
        }

        private void lvDuzina_MouseDown(object sender, MouseEventArgs e)
        {
            listViewIzKojegSeBriseMjerenje = mjerenje.duzina;

            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        ContextMenuMjerenja();
                    }
                    break;
            }
        }

        private void lvBazniVektor_MouseDown(object sender, MouseEventArgs e)
        {
            listViewIzKojegSeBriseMjerenje = mjerenje.bazniVektor;

            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        ContextMenuMjerenja();
                    }
                    break;
            }
        }

        #endregion Mouse Down

        #endregion ContexMenu za Mjerenja

        #region Duzina

        private bool DuzinaTextBoxProvjera()
        {
            bool provjera = false;

            if (cmb2DduzineStajaliste.Text == "")
            {
                MessageBox.Show("Niste unijeli stajališnu točku", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmb2dDuzineVizura.Text == "")
            {
                MessageBox.Show("Niste unijeli vizurnu točku", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tb2dDuzineMjerenje.Text == "")
            {
                MessageBox.Show("Niste unijeli mjerenje", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tb2dDuzineSigmaMm.Text == "" && tb2dDuzineSigmaPpm.Text == "" && tb2dDuzineTezina.Text == "" && tb2dDuzineSigmaBrojPonavljanja.Text == "")
            {
                MessageBox.Show("Niste unijeli težinu", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tb2dDuzineTolarancija.Text == "")
            {
                MessageBox.Show("Niste unijeli toleranciju odstupanja dužine", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbSigmaNula.Text == "")
            {
                MessageBox.Show("Niste unijeli sigmu nula", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(tb2dDuzineSigmaMm.Text == "" && tb2dDuzineSigmaMm.Enabled)
                MessageBox.Show("Niste unijeli sigma mm", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (tb2dDuzineSigmaPpm.Text == "" && tb2dDuzineSigmaPpm.Enabled)
                MessageBox.Show("Niste unijeli ppm", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (tb2dDuzineSigmaBrojPonavljanja.Text == "" && tb2dDuzineSigmaBrojPonavljanja.Enabled)
                MessageBox.Show("Niste unijeli broj ponavljanja mjerenja", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                provjera = true;

            return provjera;
        }

        private bool VarijancaDuzine(out string sigma, out string tezina)
        {
            if (rb2dDuzineSigma.Checked)
            {
                double duzina = Convert.ToDouble(tb2dDuzineMjerenje.Text, CultureInfo.InvariantCulture);
                double mm = Convert.ToDouble(tb2dDuzineSigmaMm.Text, CultureInfo.InvariantCulture);
                double ppm = Convert.ToDouble(tb2dDuzineSigmaPpm.Text, CultureInfo.InvariantCulture);
                int n = Convert.ToInt32(tb2dDuzineSigmaBrojPonavljanja.Text, CultureInfo.InvariantCulture);

                VarijancaMjerenja varijanca = new VarijancaMjerenja();

                double sig = varijanca.DuzinaElektroOptika(duzina, mm, ppm, n, Duzina.milimetar);

                sigma = sig.ToString();
                tezina = (sigmaNulaKvadrat / sig).ToString();

                return true;
            }
            else
            {
                sigma = "";
                tezina = Convert.ToDouble(tb2dDuzineTezina.Text, CultureInfo.InvariantCulture).ToString();

                return false;
            }
        }

        #region TextBox

        private void tb2dDuzineMjerenje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // samo jedna tocka
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tb2dDuzineSigmaMm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // samo jedna tocka
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tb2dDuzineSigmaPpm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // samo jedna tocka
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tb2dDuzineSigmaBrojPonavljanja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tb2dDuzineTezina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // samo jedna tocka
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tb2dDuzineTolarancija_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }


        #endregion TextBox

        private void btn2dDodajDuzinu_Click(object sender, EventArgs e)
        {
            if (DuzinaTextBoxProvjera())
            {
                Tocka2D stajaliste = Tocka(cmb2DduzineStajaliste.Text);
                Tocka2D vizura = Tocka(cmb2dDuzineVizura.Text);
                stajaliste.SmjerniKut(vizura);
                double duzinaKoordinate = stajaliste.Duzina(vizura);
                double duzinaMjerenje = Convert.ToDouble(tb2dDuzineMjerenje.Text, CultureInfo.InvariantCulture);

                double f = Math.Round((duzinaKoordinate - duzinaMjerenje) * 1000, 3);
                
                DerivacijaDuzina derivacija = new DerivacijaDuzina(stajaliste, vizura);

                string sigma, tezina;
                VarijancaDuzine(out sigma, out tezina);

                ListViewItem item = new ListViewItem(Tolerancija(f, tb2dDuzineTolarancija.Text));
                item.SubItems.Add(cmb2DduzineStajaliste.Text);
                item.SubItems.Add(cmb2dDuzineVizura.Text);
                item.SubItems.Add(duzinaMjerenje.ToString());
                item.SubItems.Add(duzinaKoordinate.ToString());
                item.SubItems.Add(f.ToString());
                item.SubItems.Add(tezina);
                item.SubItems.Add(sigma);
                item.SubItems.Add(derivacija.yStajaliste.ToString());
                item.SubItems.Add(derivacija.xStajaliste.ToString());
                item.SubItems.Add(derivacija.yVizura.ToString());
                item.SubItems.Add(derivacija.xVizura.ToString());

                lvDuzina.Items.Add(item);
                tb2dDuzineMjerenje.Clear();
                PopunjavanjeComboBoxVizura(lvDuzina, cmb2dDuzineVizura, cmb2DduzineStajaliste.Text);
                urediListView(lvDuzina);
            }
        }

        private void cmb2DduzineStajaliste_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopunjavanjeComboBoxVizura(lvDuzina, cmb2dDuzineVizura, cmb2DduzineStajaliste.Text);
        }

        private void rb2dDuzineSigma_CheckedChanged(object sender, EventArgs e)
        {
            if (rb2dDuzineSigma.Checked)
            {
                tb2dDuzineSigmaMm.Enabled = true;
                tb2dDuzineSigmaPpm.Enabled = true;
                tb2dDuzineSigmaBrojPonavljanja.Enabled = true;
                tb2dDuzineTezina.Enabled = false;
            }
            else
            {
                tb2dDuzineSigmaMm.Enabled = false;
                tb2dDuzineSigmaPpm.Enabled = false;
                tb2dDuzineSigmaBrojPonavljanja.Enabled = false;
                tb2dDuzineTezina.Enabled = true;
            }
        }

        #endregion Duzina

        #region Bazni Vekor

        private bool BazniVektorTextBoxProvjera()
        {
            bool provjera = false;

            #region Zastita unosa

            if (cmb2DbazniStajaliste.Text == "")
            {
                MessageBox.Show("Niste unijeli stajališnu točku", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmb2dBazniVizura.Text == "")
            {
                MessageBox.Show("Niste unijeli vizurnu točku", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((tb2dBazniTezinaX.Text == "" || tb2dBazniTezinaY.Text == "" || tb2dBazniTezinaYX.Text == "") && tb2dBazniTezinaY.Enabled)
            {
                MessageBox.Show("Niste unijeli tezinu", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tb2dBazniTolarancija.Text == "")
            {
                MessageBox.Show("Niste unijeli toleranciju odstupanja mjerenja", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tb2dBazniMjerenjeX.Text == "")
            {
                MessageBox.Show("Niste unijeli mjerenje po X", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tb2dBazniMjerenjeY.Text == "")
            {
                MessageBox.Show("Niste unijeli mjerenje po Y", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbSigmaNula.Text == "")
            {
                MessageBox.Show("Niste unijeli sigmu nula", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((tb2dBazniSigmaY2.Text == "" || tb2dBazniSigmaYX.Text == "" || tb2dBazniSigmaX2.Text == "" ) && tb2dBazniSigmaYX.Enabled)
            {
                MessageBox.Show("Niste unijeli tezinu", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            #endregion Zastita unosa

            else
                provjera = true;

            return provjera;
        }

        private bool VarijancaBazniVektor(out string Xsigma, out string XYsigma, out string Ysigma, out string Xtezina, out string XYtezina, out string Ytezina)
        {
            if (rb2dBazniSigma.Checked)
            {
                double x = Convert.ToDouble(tb2dBazniSigmaX2.Text, CultureInfo.InvariantCulture);
                double xy = Convert.ToDouble(tb2dBazniSigmaYX.Text, CultureInfo.InvariantCulture);
                double y = Convert.ToDouble(tb2dBazniSigmaY2.Text, CultureInfo.InvariantCulture);

                Xsigma = x.ToString();
                XYsigma = xy.ToString();
                Ysigma = y.ToString();

                VarijancaMjerenja varijanca = new VarijancaMjerenja();
                DenseMatrix sig = varijanca.KovarijanceKomponentiBaznogVektora2D(x, xy, y);

                sig = (DenseMatrix)sig.Inverse() * sigmaNulaKvadrat;

                Xtezina = (sig[0, 0]).ToString();
                XYtezina = (sig[0, 1]).ToString();
                Ytezina = (sig[1, 1]).ToString();

                return true;
            }
            else
            {
                Xsigma = "";
                XYsigma = "";
                Ysigma = "";

                Xtezina = Convert.ToDouble(tb2dBazniTezinaX.Text, CultureInfo.InvariantCulture).ToString();
                XYtezina = Convert.ToDouble(tb2dBazniTezinaYX.Text, CultureInfo.InvariantCulture).ToString();
                Ytezina = Convert.ToDouble(tb2dBazniTezinaY.Text, CultureInfo.InvariantCulture).ToString();

                return false;
            }
        }

        private void rb2dBazniSigma_CheckedChanged(object sender, EventArgs e)
        {
            if (rb2dBazniSigma.Checked)
            {
                tb2dBazniSigmaY2.Enabled = true;
                tb2dBazniSigmaYX.Enabled = true;
                tb2dBazniSigmaX2.Enabled = true;
                tb2dBazniTezinaX.Enabled = false;
                tb2dBazniTezinaY.Enabled = false;
                tb2dBazniTezinaYX.Enabled = false;
            }
            else
            {
                tb2dBazniSigmaY2.Enabled = false;
                tb2dBazniSigmaYX.Enabled = false;
                tb2dBazniSigmaX2.Enabled = false;
                tb2dBazniTezinaX.Enabled = true;
                tb2dBazniTezinaY.Enabled = true;
                tb2dBazniTezinaYX.Enabled = true;
            }
        }

        private void cmb2DbazniStajaliste_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopunjavanjeComboBoxVizura(lvBazniVektor, cmb2dBazniVizura, cmb2DbazniStajaliste.Text);
        }

        #region Text Box

        private void tb2dBazniMjerenjeY_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && (sender as TextBox).SelectionStart != 0)
            {
                e.Handled = true;
            }

        }

        private void tb2dBazniMjerenjeX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && (sender as TextBox).SelectionStart != 0)
            {
                e.Handled = true;
            }


        }

        private void tb2dBazniSigmaY2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // samo jedna tocka
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tb2dBazniSigmaYX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // samo jedna tocka
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tb2dBazniSigmaX2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // samo jedna tocka
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tb2dBazniTezinaY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // samo jedna tocka
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tb2dBazniTezinaYX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // samo jedna tocka
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tb2dBazniTezinaX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // samo jedna tocka
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tb2dBazniTolarancija_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }


        #endregion Text Box

        private void btn2dDodajBazniVektor_Click(object sender, EventArgs e)
        {
            if (BazniVektorTextBoxProvjera())
            {

                Tocka2D stajaliste = Tocka(cmb2DbazniStajaliste.Text);
                Tocka2D vizura = Tocka(cmb2dBazniVizura.Text);

                double dy = Convert.ToDouble(tb2dBazniMjerenjeY.Text, CultureInfo.InvariantCulture);
                double dx = Convert.ToDouble(tb2dBazniMjerenjeX.Text, CultureInfo.InvariantCulture);


                SlobodanClanBazniVektor slobodanClan = new SlobodanClanBazniVektor(stajaliste, vizura, dx, dy);

                #region Tolerancija

                string tolerancija = "";

                if (Tolerancija(slobodanClan.fx * 1000, tb2dBazniTolarancija.Text) != "OK")
                    tolerancija = "X-Greska";
                else if (Tolerancija(slobodanClan.fy * 1000, tb2dBazniTolarancija.Text) != "OK")
                    tolerancija = "Y-Greska";
                else if (Tolerancija(slobodanClan.fx * 1000, tb2dBazniTolarancija.Text) == "OK" && Tolerancija(slobodanClan.fy * 1000, tb2dBazniTolarancija.Text) == "OK")
                    tolerancija = "OK";
                else
                    tolerancija = "GRESKA";

                #endregion Tolerancija

                #region ListView

                ListViewItem item = new ListViewItem(tolerancija);
                item.SubItems.Add(cmb2DbazniStajaliste.Text);
                item.SubItems.Add(cmb2dBazniVizura.Text);

                item.SubItems.Add(dy.ToString());
                item.SubItems.Add((vizura.Y - stajaliste.Y).ToString());
                item.SubItems.Add((slobodanClan.fy * 1000).ToString());

                item.SubItems.Add(dx.ToString());
                item.SubItems.Add((vizura.X - stajaliste.X).ToString());
                item.SubItems.Add((slobodanClan.fx * 1000).ToString());

                string Xsigma, XYsigma, Ysigma, Xtezina, XYtezina, Ytezina;
                VarijancaBazniVektor(out Xsigma, out XYsigma, out Ysigma, out Xtezina, out XYtezina, out Ytezina);

                item.SubItems.Add(Ytezina);
                item.SubItems.Add(XYtezina);
                item.SubItems.Add(Xtezina);

                item.SubItems.Add(Ysigma);
                item.SubItems.Add(XYsigma);
                item.SubItems.Add(Xsigma);

                lvBazniVektor.Items.Add(item);
                urediListView(lvBazniVektor);

                #endregion ListView

                tb2dBazniMjerenjeX.Clear();
                tb2dBazniMjerenjeY.Clear();
                tb2dBazniSigmaX2.Clear();
                tb2dBazniSigmaY2.Clear();
                tb2dBazniSigmaYX.Clear();

                tb2dBazniTezinaX.Clear();
                tb2dBazniTezinaY.Clear();
                tb2dBazniTezinaYX.Clear();
            }

        }

        #endregion Bazni Vekor

        #region Kut

        private bool KutTextBoxProvjera()
        {
            bool provjera = false;

            #region zastita

            if (cmb2DkuteviStajaliste.Text == "")
            {
                MessageBox.Show("Niste unijeli stajališnu točku", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmb2DkuteviOD.Text == "")
            {
                MessageBox.Show("Niste unijeli prvu vizurnu točku [Od]", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmb2DkuteviDO.Text == "")
            {
                MessageBox.Show("Niste unijeli drugu vizurnu točku [Do]", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (tb2dKuteviStupnjevi.Text == "" && tb2dKuteviMinute.Text == "" && tb2dKuteviSekunde.Text == "")
            {
                MessageBox.Show("Niste unijeli mjerenje", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tb2dKuteviTolerancija.Text == "")
            {
                MessageBox.Show("Niste unijeli toleranciju na grešku unosa kuta", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (tbKutSigmaBrojGirusa.Text == "" && tb2dKuteviSigmaPravac.Text == "" && tb2dKuteviSigmaKut.Text == "" && tbKutTezina.Text == "")
            {
                MessageBox.Show("Niste unijeli težinu mjerenja", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ( tb2dKuteviSigmaKut.Text == "" && tb2dKuteviSigmaKut.Enabled)
                MessageBox.Show("Niste unijeli težinu mjerenja", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (tb2dKuteviSigmaPravac.Text != "" && tbKutSigmaBrojGirusa.Text == "")
            {
                MessageBox.Show("Niste unijeli broj girusa", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbKutSigmaBrojGirusa.Text == "0" && tb2dKuteviSigmaPravac.Text == "0" && tb2dKuteviSigmaKut.Text == "0")
            {
                MessageBox.Show("Težina ne može biti 0", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (tbKutSigmaBrojGirusa.Text == "0")
            {
                MessageBox.Show("Broj girusa ne može biti 0", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbKutSigmaBrojGirusa.Text == "" && tbKutSigmaBrojGirusa.Enabled)
            {
                MessageBox.Show("Niste unijeli broj girusa", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbSigmaNula.Text == "")
            {
                MessageBox.Show("Niste unijeli sigmu nula (Tab Koordinate)", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                provjera = true;
            }

            #endregion zastita


            return provjera;
        }

        #region Radio button

        private void KuteviRadioButton()
        {
            if (rb2dKuteviSigmaPravac.Checked)
            {
                tb2dKuteviSigmaPravac.Enabled = true;
                tb2dKuteviSigmaPravac.Text = "";
                tbKutSigmaBrojGirusa.Enabled = true;
                tbKutSigmaBrojGirusa.Text = "";
                tb2dKuteviSigmaKut.Enabled = false;
                tb2dKuteviSigmaKut.Text = "";
                tbKutTezina.Enabled = false;
                tbKutTezina.Text = "";

            }
            else if (rb2dKuteviSigmaKuta.Checked)
            {
                tb2dKuteviSigmaPravac.Enabled = false;
                tb2dKuteviSigmaPravac.Text = "";
                tbKutSigmaBrojGirusa.Enabled = true;
                tbKutSigmaBrojGirusa.Text = "";
                tb2dKuteviSigmaKut.Enabled = true;
                tb2dKuteviSigmaKut.Text = "";
                tbKutTezina.Enabled = false;
                tbKutTezina.Text = "";
            }
            else
            {
                tb2dKuteviSigmaPravac.Enabled = false;
                tb2dKuteviSigmaPravac.Text = "";
                tbKutSigmaBrojGirusa.Enabled = false;
                tbKutSigmaBrojGirusa.Text = "";
                tb2dKuteviSigmaKut.Enabled = false;
                tb2dKuteviSigmaKut.Text = "";
                tbKutTezina.Enabled = true;
                tbKutTezina.Text = "";
            }
        }

        private void rb2dKuteviSigmaPravac_CheckedChanged(object sender, EventArgs e)
        {
            KuteviRadioButton();
        }

        private void rb2dKuteviSigmaKuta_CheckedChanged(object sender, EventArgs e)
        {
            KuteviRadioButton();
        }

        private void rb2dKuteviTezina_CheckedChanged(object sender, EventArgs e)
        {
            KuteviRadioButton();
        }


        #endregion Radio button

        #region Text Box

        #region Mjerenja Text Box

        #region Stupnjevi

        private void tb2dKuteviStupnjevi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb2dKuteviStupnjevi_TextChanged(object sender, EventArgs e)
        {
            int num = 0;
            int.TryParse(tb2dKuteviStupnjevi.Text, out num);

            if (num > 359)
            {
                DialogResult dialogResult = MessageBox.Show("Stupnjevi prelaze 360 !!! \nZa zadržavanje stupnjeva kliknite - YES \nZa brisanje - NO", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {

                }
                else if (dialogResult == DialogResult.No)
                {
                    tb2dKuteviStupnjevi.Text = "";
                }
            }
            if (tb2dKuteviStupnjevi.Text.Length == 3)
            {
                tb2dKuteviMinute.Focus();
            }

            if (tb2dKuteviStupnjevi.Text.Length == 2 && Convert.ToInt32(tb2dKuteviStupnjevi.Text) > 35)
            {
                tb2dKuteviMinute.Focus();
            }
        }


        #endregion Stupnjevi

        #region Minute

        private void tb2dKuteviMinute_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb2dKuteviMinute_TextChanged(object sender, EventArgs e)
        {
            int num = 0;
            int.TryParse(tb2dKuteviMinute.Text, out num);

            if (num >= 60)
            {
                DialogResult dialogResult = MessageBox.Show("Minute prelaze 60 !!! \nZa preracunavanje minuta kliknite - YES \nZa brisanje - NO", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    while (num >= 60)
                    {
                        num = num - 60;
                    }

                    tb2dKuteviMinute.Text = num.ToString();
                }
                else if (dialogResult == DialogResult.No)
                {
                    tb2dKuteviMinute.Text = "";
                }
            }

            if (tb2dKuteviMinute.Text.Length == 2)
                tb2dKuteviSekunde.Focus();

            if (tb2dKuteviMinute.Text.Length == 1 && Convert.ToInt32(tb2dKuteviMinute.Text) > 6)
            {
                tb2dKuteviSekunde.Focus();
            }
        }


        #endregion Minute

        #region Sekunde

        private void tb2dKuteviSekunde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tb2dKuteviSekunde_TextChanged(object sender, EventArgs e)
        {
            int num = 0;
            int.TryParse(tb2dKuteviSekunde.Text, out num);

            if (num >= 60)
            {
                DialogResult dialogResult = MessageBox.Show("Sekunde prelaze 60 !!! \nZa preračunavanje sekunda kliknite - YES \nZa brisanje - NO", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    while (num >= 60)
                    {
                        num = num - 60;
                    }

                    tb2dKuteviSekunde.Text = num.ToString();
                }
                else if (dialogResult == DialogResult.No)
                {
                    tb2dKuteviSekunde.Text = "";
                }
            }
        }


        #endregion Sekunde

        #endregion Mjerenja Text Box

        private void tb2dKuteviSigmaPravac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tb2dKuteviSigmaBrojGirusa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb2dKuteviSigmaKut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tb2dKuteviTezina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tb2dKuteviTolerancija_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        #endregion Text Box

        #region ComboBox

        private void cmb2DkuteviStajaliste_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb2DkuteviOD.Items.Clear();
            foreach (ListViewItem item in lvTocka.Items)
            {
                cmb2DkuteviOD.Items.Add(item.SubItems[0].Text);
            }
            cmb2DkuteviOD.Items.Remove(cmb2DkuteviStajaliste.Text);
            PopunjavanjeComboBoxDo(lvKut, cmb2DkuteviDO, cmb2DkuteviStajaliste.Text, cmb2DkuteviOD.Text);
        }

        private void cmb2DkuteviOD_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopunjavanjeComboBoxDo(lvKut, cmb2DkuteviDO, cmb2DkuteviStajaliste.Text, cmb2DkuteviOD.Text);
        }


        #endregion ComboBox

        private bool VarijancaKut(out string sigma, out string tezina)
        {
            if (rb2dKuteviSigmaPravac.Checked)
            {
                double sigmaPravac = Convert.ToDouble(tb2dKuteviSigmaPravac.Text, CultureInfo.InvariantCulture);
                int brojGirusa = Convert.ToInt32(tbKutSigmaBrojGirusa.Text, CultureInfo.InvariantCulture);

                VarijancaMjerenja varijanca = new VarijancaMjerenja();

                Seconds sig = varijanca.KutIzPravaca(new Seconds(sigmaPravac), brojGirusa);

                sigma = sig.ToString();
                tezina = (sigmaNulaKvadrat / sig.ToDouble()).ToString();

                return true;
            }
            else if (rb2dKuteviSigmaKuta.Checked)
            {
                double sigmaPravac = Convert.ToDouble(tb2dKuteviSigmaKut.Text, CultureInfo.InvariantCulture);
                int brojGirusa = Convert.ToInt32(tbKutSigmaBrojGirusa.Text, CultureInfo.InvariantCulture);

                VarijancaMjerenja varijanca = new VarijancaMjerenja();

                Seconds sig = varijanca.Kut(new Seconds(sigmaPravac), brojGirusa);

                sigma = sig.ToString();
                tezina = (sigmaNulaKvadrat / sig.ToDouble()).ToString();

                return true;
            }
            else
            {
                sigma = "";
                tezina = Convert.ToDouble(tbKutTezina.Text, CultureInfo.InvariantCulture).ToString();

                return false;
            }
        }

        private void btn2dKuteviDodaj_Click(object sender, EventArgs e)
        {
            if (KutTextBoxProvjera())
            {

                Tocka2D stajaliste = Tocka(cmb2DkuteviStajaliste.Text);
                Tocka2D Od = Tocka(cmb2DkuteviOD.Text);
                Tocka2D Do = Tocka(cmb2DkuteviDO.Text);


                DMS mjerenje = MjerenjeKutaPravcaAzimuta(tb2dKuteviStupnjevi.Text, tb2dKuteviMinute.Text, tb2dKuteviSekunde.Text);

                Rad koordinate = stajaliste.SmjerniKut(Do) - stajaliste.SmjerniKut(Od);
                if (koordinate.ToDouble() < 0)
                    koordinate = koordinate + new Rad(2 * Math.PI);

                SlobodanClanKut slobodanClan = new SlobodanClanKut(stajaliste, Od, Do, mjerenje.ToRad());

                string sigma, tezina;
                VarijancaKut(out sigma, out tezina);

                DerivacijaKut derivacija = new DerivacijaKut(stajaliste, Od, Do);

                #region ListView

                ListViewItem item = new ListViewItem(Tolerancija(slobodanClan.f.ToSeconds().ToDouble(), tb2dKuteviTolerancija.Text));
                item.SubItems.Add(cmb2DkuteviStajaliste.Text);
                item.SubItems.Add(cmb2DkuteviOD.Text);
                item.SubItems.Add(cmb2DkuteviDO.Text);


                item.SubItems.Add(mjerenje.ToString());
                item.SubItems.Add(koordinate.ToDMS().ToString());
                item.SubItems.Add(slobodanClan.f.ToSeconds().ToString());

                item.SubItems.Add(tezina);
                item.SubItems.Add(sigma);

                item.SubItems.Add((derivacija.yStajaliste.ToSeconds().ToDouble() / 1000).ToString());
                item.SubItems.Add((derivacija.xStajaliste.ToSeconds().ToDouble() / 1000).ToString());

                item.SubItems.Add((derivacija.yOd.ToSeconds().ToDouble() / 1000).ToString());
                item.SubItems.Add((derivacija.xOd.ToSeconds().ToDouble() / 1000).ToString());

                item.SubItems.Add((derivacija.yDo.ToSeconds().ToDouble() / 1000).ToString());
                item.SubItems.Add((derivacija.xDo.ToSeconds().ToDouble() / 1000).ToString());

                lvKut.Items.Add(item);

                #endregion ListView

                urediListView(lvKut);
                tb2dKuteviMinute.Clear();
                tb2dKuteviSekunde.Clear();
                tb2dKuteviStupnjevi.Clear();

                PopunjavanjeComboBoxDo(lvKut, cmb2DkuteviDO, cmb2DkuteviStajaliste.Text, cmb2DkuteviOD.Text);
            }

        }


        #endregion Kut

        #region Pravac

        #region Radio Button

        private void rb2dPravciSigma_CheckedChanged(object sender, EventArgs e)
        {
            pravacRadioButton();
        }

        private void rb2dPravciTezina_CheckedChanged(object sender, EventArgs e)
        {
            pravacRadioButton();
        }

        private void pravacRadioButton()
        {
            if (rb2dPravciSigma.Checked)
            {
                tb2dPravciSigma.Enabled = true; 
                tb2dPravciTezina.Enabled = false;
                tb2dPravciSigmaBrojGirusa.Enabled = true;
            }
            else
            {
                tb2dPravciSigma.Enabled = false;
                tb2dPravciTezina.Enabled = true;
                tb2dPravciSigmaBrojGirusa.Enabled = false;
            }
        }

        #endregion Radio Button

        private bool PravacTextBoxProvjera()
        {
            bool provjera = false;

            #region Zastita unosa

            if (cmb2DpravciStajaliste.Text == "")
            {
                MessageBox.Show("Niste unijeli stajališnu točku", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmb2dPravciVizura.Text == "")
            {
                MessageBox.Show("Niste unijeli vizurnu točku", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tb2dPravciMinute.Text == "" && tb2dPravciSekunde.Text == "" && tb2dPravciStupnjevi.Text == "")
            {
                MessageBox.Show("Niste unijeli mjerenje", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tb2dPravciTezina.Text == "" && tb2dPravciSigma.Text == "")
            {
                MessageBox.Show("Niste unijeli težinu mjerenja", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tb2dPravciTezina.Text == "0" || tb2dPravciSigma.Text == "0")
            {
                MessageBox.Show("Težina ne može biti 0", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbSigmaNula.Text == "")
            {
                MessageBox.Show("Niste unijeli sigmu nula (Tab Koordinate)", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tb2dPravciTolarancijaZ.Text == "")
            {
                MessageBox.Show("Niste unijeli toleranciju orijentacijskog kuta", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tb2dPravciSigmaBrojGirusa.Text == "" && tb2dPravciSigma.Text != "")
            {
                MessageBox.Show("Niste unijeli broj girusa", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tb2dPravciSigmaBrojGirusa.Text == "0")
            {
                MessageBox.Show("Broj girusa ne može biti 0", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            #endregion Zastita unosa
            else
            {
                provjera = true;
            }
            return provjera;
        }

        private bool VarijancaPravac(out string sigma, out string tezina)
        {
            if (rb2dPravciSigma.Checked)
            {
                double sigmaPravac = Convert.ToDouble(tb2dPravciSigma.Text, CultureInfo.InvariantCulture);
                int brojGirusa = Convert.ToInt32(tb2dPravciSigmaBrojGirusa.Text, CultureInfo.InvariantCulture);

                VarijancaMjerenja varijanca = new VarijancaMjerenja();

                Seconds sig = varijanca.Pravac(new Seconds(sigmaPravac), brojGirusa);

                sigma = sig.ToString();
                tezina = (sigmaNulaKvadrat / sig.ToDouble()).ToString();

                return true;
            }
            else
            {
                sigma = "";
                tezina = Convert.ToDouble(tb2dPravciTezina.Text, CultureInfo.InvariantCulture).ToString();

                return false;
            }
        }

        private void cmb2DpravciStajaliste_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopunjavanjeComboBoxVizura(lvPravac, cmb2dPravciVizura, cmb2DpravciStajaliste.Text);
        }

        #region Text Box

        #region Mjerenje Text Box

        #region Stupnjevi

        private void tb2dPravciStupnjevi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb2dPravciStupnjevi_TextChanged(object sender, EventArgs e)
        {
            int num = 0;
            int.TryParse(tb2dPravciStupnjevi.Text, out num);

            if (num > 359)
            {
                DialogResult dialogResult = MessageBox.Show("Stupnjevi prelaze 360 !!! \nZa zadržavanje stupnjeva kliknite - YES \nZa brisanje - NO", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {

                }
                else if (dialogResult == DialogResult.No)
                {
                    tb2dPravciStupnjevi.Text = "";
                }
            }

            if (tb2dPravciStupnjevi.Text.Length == 3)
            {
                tb2dPravciMinute.Focus();
            }

            if (tb2dPravciStupnjevi.Text.Length == 2 && Convert.ToInt32(tb2dPravciStupnjevi.Text) > 35)
            {
                tb2dPravciMinute.Focus();
            }
        }

        #endregion Stupnjevi

        #region Minute

        private void tb2dPravciMinute_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb2dPravciMinute_TextChanged(object sender, EventArgs e)
        {
            int num = 0;
            int.TryParse(tb2dPravciMinute.Text, out num);

            if (num >= 60)
            {
                DialogResult dialogResult = MessageBox.Show("Minute prelaze 60 !!! \nZa preracunavanje minuta kliknite - YES \nZa brisanje - NO", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    while (num >= 60)
                    {
                        num = num - 60;
                    }

                    tb2dPravciMinute.Text = num.ToString();
                }
                else if (dialogResult == DialogResult.No)
                {
                    tb2dPravciMinute.Text = "";
                }
            }

            if (tb2dPravciMinute.Text.Length == 2)
                tb2dPravciSekunde.Focus();

            if (tb2dPravciMinute.Text.Length == 1 && Convert.ToInt32(tb2dPravciMinute.Text) > 6)
            {
                tb2dPravciSekunde.Focus();
            }
        }

        #endregion Minute

        #region Sekunde

        private void tb2dPravciSekunde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tb2dPravciSekunde_TextChanged(object sender, EventArgs e)
        {
            int num = 0;
            int.TryParse(tb2dPravciSekunde.Text, out num);

            if (num >= 60)
            {
                DialogResult dialogResult = MessageBox.Show("Sekunde prelaze 60 !!! \nZa preračunavanje sekunda kliknite - YES \nZa brisanje - NO", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    while (num >= 60)
                    {
                        num = num - 60;
                    }

                    tb2dPravciSekunde.Text = num.ToString();
                }
                else if (dialogResult == DialogResult.No)
                {
                    tb2dPravciSekunde.Text = "";
                }
            }
        }

        #endregion Sekunde

        #endregion Mjerenje Text Box

        private void tb2dPravciSigma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tb2dPravciSigmaBrojGirusa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tb2dPravciTezina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tb2dPravciTolarancijaZ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }




        #endregion Text Box

        public DMS OrijentacijskiKut(DMS mjereniPravac, Rad smjerniKut)
        {
            DMS z = mjereniPravac - smjerniKut.ToDMS();

            if (z.ToRad().ToDouble() < 0)
            {
                Rad PI2 = new Rad(2 * Math.PI);
                z = z + PI2.ToDMS();
            }

            return z;
        }

        public DMS OrijenatcijskiPravacSrednji(DMS z, string stajaliste, string tolerancija)
        {
            double tol = Convert.ToDouble(tolerancija, CultureInfo.InvariantCulture);

            List<double> lista = new List<double>();
            List<double> listaKuteva = new List<double>();


            lista.Add(z.ToRad().ToDouble());

            Rad zSrednji = z.ToRad();

            int i = 1;

            foreach (ListViewItem item in lvPravac.Items)
            {
                DMS zMjerenje;
                DMS.TryParse(item.SubItems[5].Text, out zMjerenje);

                if (item.SubItems[1].Text == stajaliste)
                {
                    lista.Add(zMjerenje.ToRad().ToDouble());
                    zSrednji = zSrednji + zMjerenje.ToRad();
                    i++;
                }
            }

            foreach (double kut in lista)
            {
                if ((kut - tol * (Math.PI / (180 * 60 * 60))) < 0)
                    listaKuteva.Add(kut + 2 * Math.PI);
                else
                    listaKuteva.Add(kut);
            }

            double Zs = listaKuteva.Sum() / listaKuteva.Count();

            if (Zs >= 2 * Math.PI)
                Zs = Zs - 2 * Math.PI;

            zSrednji = new Rad(Zs);


            return zSrednji.ToDMS();
        }

        public DMS OrijenatcijskiPravacSrednji(string stajaliste, string tolerancija)
        {
            double tol = Convert.ToDouble(tolerancija, CultureInfo.InvariantCulture);

            List<double> lista = new List<double>();
            List<double> listaKuteva = new List<double>();


            //lista.Add(z.ToRad().ToDouble());

            Rad zSrednji;// = z.ToRad();

            int i = 1;

            foreach (ListViewItem item in lvPravac.Items)
            {
                DMS zMjerenje;
                zMjerenje = DMS.Parse(item.SubItems[5].Text);


                if (item.SubItems[1].Text == stajaliste)
                {
                    lista.Add(zMjerenje.ToRad().ToDouble());
                    //zSrednji = zSrednji + zMjerenje.ToRad();
                    i++;
                }
            }

            foreach (double kut in lista)
            {
                if ((kut - tol * (Math.PI / (180 * 60 * 60))) < 0)
                    listaKuteva.Add(kut + 2 * Math.PI);
                else
                    listaKuteva.Add(kut);
            }

            double Zs = listaKuteva.Sum() / listaKuteva.Count();

            if (Zs >= 2 * Math.PI)
                Zs = Zs - 2 * Math.PI;

            zSrednji = new Rad(Zs);


            return zSrednji.ToDMS();
        }

        public void RacunanjeNovihF()
        {
            Dictionary<string, DMS> stajalista = new Dictionary<string, DMS>();

            foreach (ListViewItem item in lvPravac.Items)
            {
                if (!stajalista.ContainsKey(item.SubItems[1].Text))
                {
                    DMS z = OrijenatcijskiPravacSrednji(item.SubItems[1].Text, tb2dPravciTolarancijaZ.Text);
                    stajalista.Add(item.SubItems[1].Text, z);
                }
            }

            foreach (ListViewItem item in lvPravac.Items)
            {
                Tocka2D stajaliste = Tocka(item.SubItems[1].Text);
                Tocka2D vizura = Tocka(item.SubItems[2].Text);

                DMS mjerenje;
                DMS.TryParse(item.SubItems[3].Text, out mjerenje);
                DMS orijentacija = stajalista[item.SubItems[1].Text];

                SlobodanClanPravac SC = new SlobodanClanPravac(stajaliste, vizura, mjerenje.ToRad(), orijentacija.ToRad());


                if (SC.f.ToDouble() < -2 * Math.PI / 3)
                    SC.f = new Rad(SC.f.ToDouble() + 2 * Math.PI);
                else if (SC.f.ToDouble() > 2 * Math.PI / 3)
                    SC.f = new Rad(SC.f.ToDouble() - 2 * Math.PI);

                item.SubItems[6].Text = orijentacija.ToString();
                item.SubItems[7].Text = SC.f.ToSeconds().ToString();
            }
        }

        private void TrazenjeGreskeOrijentacijskogKuta()
        {
            #region trazenje greske upisa orijentacijskog kuta

            Dictionary<string, double> greska = new Dictionary<string, double>();


            foreach (ListViewItem mogucaGreska in lvPravac.Items)
            {
                if (mogucaGreska.SubItems[0].Text == "-GRESKA-")
                {
                    if (!greska.ContainsKey(mogucaGreska.SubItems[1].Text))
                    {
                        greska.Add(mogucaGreska.SubItems[1].Text, 0);
                    }
                }
            }

            foreach (KeyValuePair<string, double> pair in greska)
            {
                double tolerancija = (new DMS(0, 0, Convert.ToDouble(tb2dPravciTolarancijaZ.Text))).ToRad().ToDouble();
                int da = 0;
                int ne = 0;

                foreach (ListViewItem mogucaGreska in lvPravac.Items)
                {
                    if (mogucaGreska.SubItems[1].Text == pair.Key)
                    {
                        double Z = DMS.Parse(mogucaGreska.SubItems[5].Text).ToRad().ToDouble();

                        foreach (ListViewItem mogucaGreska2 in lvPravac.Items)
                        {
                            if (mogucaGreska2.SubItems[1].Text == pair.Key)
                            {

                                double Z1 = DMS.Parse(mogucaGreska2.SubItems[5].Text).ToRad().ToDouble();

                                if (Math.Abs(Z - Z1) > tolerancija)
                                    da++;
                                else
                                    ne++;
                            }
                        }

                        if (da > ne)
                            mogucaGreska.SubItems[0].Text = "Greška";
                        else if (da < ne)
                            mogucaGreska.SubItems[0].Text = "OK";
                        else
                            mogucaGreska.SubItems[0].Text = "??";

                        da = 0;
                        ne = 0;

                    }
                }

            }

            #endregion trazenje greske upisa orijentacijskog kuta
        }

        private void btn2dDodajPravac_Click(object sender, EventArgs e)
        {
            if (PravacTextBoxProvjera())
            {
                Tocka2D stajaliste = Tocka(cmb2DpravciStajaliste.Text);
                Tocka2D vizura = Tocka(cmb2dPravciVizura.Text);

                DMS mjerenje = MjerenjeKutaPravcaAzimuta(tb2dPravciStupnjevi.Text, tb2dPravciMinute.Text, tb2dPravciSekunde.Text);

                DMS z = OrijentacijskiKut(mjerenje, stajaliste.SmjerniKut(vizura));
                DMS zSrednji = OrijenatcijskiPravacSrednji(z, cmb2DpravciStajaliste.Text, tb2dPravciTolarancijaZ.Text);

                string tezina, sigma;
                VarijancaPravac(out sigma, out tezina);

                SlobodanClanPravac slobodanClan = new SlobodanClanPravac(stajaliste, vizura, mjerenje.ToRad(), zSrednji.ToRad());

                if (slobodanClan.f.ToDouble() < -2 * Math.PI/3)
                    slobodanClan.f =new Rad( slobodanClan.f.ToDouble() + 2 * Math.PI);
                else if (slobodanClan.f.ToDouble() > 2 * Math.PI/3)
                    slobodanClan.f = new Rad(slobodanClan.f.ToDouble() - 2 * Math.PI);

                DerivacijaPravac derivacija = new DerivacijaPravac(stajaliste, vizura);

                #region ListView

                ListViewItem item = new ListViewItem(Tolerancija(slobodanClan.f.ToSeconds().ToDouble(), tb2dPravciTolarancijaZ.Text));
                item.SubItems.Add(cmb2DpravciStajaliste.Text);
                item.SubItems.Add(cmb2dPravciVizura.Text);

                item.SubItems.Add(mjerenje.ToString());
                item.SubItems.Add(stajaliste.SmjerniKut(vizura).ToDMS().ToString());
                item.SubItems.Add(z.ToString());
                item.SubItems.Add(zSrednji.ToString());

                item.SubItems.Add(slobodanClan.f.ToSeconds().ToString());

                item.SubItems.Add(tezina.ToString());
                item.SubItems.Add(sigma.ToString());

                item.SubItems.Add((derivacija.yStajaliste.ToSeconds().ToDouble() / 1000).ToString());
                item.SubItems.Add((derivacija.xStajaliste.ToSeconds().ToDouble() / 1000).ToString());
                item.SubItems.Add((derivacija.yVizura.ToSeconds().ToDouble() / 1000).ToString());
                item.SubItems.Add((derivacija.xVizura.ToSeconds().ToDouble() / 1000).ToString());

                lvPravac.Items.Add(item);
                urediListView(lvPravac);

                #endregion ListView

                RacunanjeNovihF();
                PopunjavanjeComboBoxVizura(lvPravac, cmb2dPravciVizura, cmb2DpravciStajaliste.Text);

                TrazenjeGreskeOrijentacijskogKuta();

                tb2dPravciStupnjevi.Clear();
                tb2dPravciMinute.Clear();
                tb2dPravciSekunde.Clear();
            }
        }

        #endregion Pravac

        #region Azimut

        #region TextBox

        private void tb2dAzimutiStupnjevi_TextChanged(object sender, EventArgs e)
        {
            int num = 0;
            int.TryParse(tb2dAzimutiStupnjevi.Text, out num);

            if (num > 359)
            {
                DialogResult dialogResult = MessageBox.Show("Stupnjevi prelaze 360 !!! \nZa zadržavanje stupnjeva kliknite - YES \nZa brisanje - NO", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {

                }
                else if (dialogResult == DialogResult.No)
                {
                    tb2dAzimutiStupnjevi.Text = "";
                }
            }

            if (tb2dAzimutiStupnjevi.Text.Length == 3)
            {
                tb2dAzimutiMinute.Focus();
            }

            if (tb2dAzimutiStupnjevi.Text.Length == 2 && Convert.ToInt32(tb2dAzimutiStupnjevi.Text)>35)
            {
                tb2dAzimutiMinute.Focus();
            }

        }

        private void tb2dAzimutiMinute_TextChanged(object sender, EventArgs e)
        {
            int num = 0;
            int.TryParse(tb2dAzimutiMinute.Text, out num);

            if (num >= 60)
            {
                DialogResult dialogResult = MessageBox.Show("Minute prelaze 60 !!! \nZa preracunavanje minuta kliknite - YES \nZa brisanje - NO", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    while (num >= 60)
                    {
                        num = num - 60;
                    }

                    tb2dAzimutiMinute.Text = num.ToString();
                }
                else if (dialogResult == DialogResult.No)
                {
                    tb2dAzimutiMinute.Text = "";
                }
            }

            if (tb2dAzimutiMinute.Text.Length == 2)
                tb2dAzimutiSekunde.Focus();

            if (tb2dAzimutiMinute.Text.Length == 1 && Convert.ToInt32(tb2dAzimutiMinute.Text) > 6)
            {
                tb2dAzimutiSekunde.Focus();
            }
        }

        private void tb2dAzimutiSekunde_TextChanged(object sender, EventArgs e)
        {
            int num = 0;
            int.TryParse(tb2dAzimutiSekunde.Text, out num);

            if (num >= 60)
            {
                DialogResult dialogResult = MessageBox.Show("Sekunde prelaze 60 !!! \nZa preračunavanje sekunda kliknite - YES \nZa brisanje - NO", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    while (num >= 60)
                    {
                        num = num - 60;
                    }

                    tb2dAzimutiSekunde.Text = num.ToString();
                }
                else if (dialogResult == DialogResult.No)
                {
                    tb2dAzimutiSekunde.Text = "";
                }
            }
        }

        private void tb2dAzimutiStupnjevi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tb2dAzimutiMinute_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void tb2dAzimutiSekunde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tb2dAzimutSigma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tb2dAzimutBrojTocaka_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tb2dAzimutTezina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tb2dAzimutiTolarancija_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        #endregion TextBox

        private bool VarijancaAzimut(out string sigma, out string tezina)
        {
            if (rb2dAzimutiSigma.Checked)
            {
                double sigmaPravac = Convert.ToDouble(tb2dAzimutSigma.Text, CultureInfo.InvariantCulture);
                //int brojGirusa = Convert.ToInt32(tb2dPravciSigmaBrojGirusa.Text, CultureInfo.InvariantCulture);

                VarijancaMjerenja varijanca = new VarijancaMjerenja();

                Seconds sig = varijanca.Pravac(new Seconds(sigmaPravac), 1);

                sigma = sig.ToString();
                tezina = (sigmaNulaKvadrat / sig.ToDouble()).ToString();

                return true;
            }
            else if (rb2dAzimutiBrojTocaka.Checked)
            {
                double brojTocaka = Convert.ToDouble(tb2dAzimutBrojTocaka.Text, CultureInfo.InvariantCulture);

                double sig = Math.Sqrt((brojTocaka + 1) / brojTocaka);
                sigma = sig.ToString();
                tezina = (sigmaNulaKvadrat / (sig * sig)).ToString();

                return true;
            }
            else
            {
                sigma = "";
                tezina = Convert.ToDouble(tb2dAzimutTezina.Text, CultureInfo.InvariantCulture).ToString();

                return false;
            }
        }

        private void cmb2DazimutiStajaliste_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopunjavanjeComboBoxVizura(lvAzimut, cmb2dAzimutiVizura, cmb2DazimutiStajaliste.Text);
        }

        private bool AzimutTextBoxProvjera()
        {
            bool provjera = false;

            #region zastita

            if (cmb2DazimutiStajaliste.Text == "")
            {
                MessageBox.Show("Niste unijeli stajališnu točku", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmb2dAzimutiVizura.Text == "")
            {
                MessageBox.Show("Niste unijeli vizurnu točku", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tb2dAzimutiStupnjevi.Text == "" && tb2dAzimutiMinute.Text == "" && tb2dAzimutiSekunde.Text == "")
            {
                MessageBox.Show("Niste unijeli mjerenje", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tb2dAzimutSigma.Text == "" && tb2dAzimutBrojTocaka.Text == "" && tb2dAzimutTezina.Text == "")
            {
                MessageBox.Show("Niste unijeli težinu", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tb2dAzimutiTolarancija.Text == "")
            {
                MessageBox.Show("Niste unijeli toleranciju odstupanja azimuta", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbSigmaNula.Text == "")
            {
                MessageBox.Show("Niste unijeli sigmu nula (Tab Koordinate)", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                provjera = true;
            }

            #endregion zastita


            return provjera;
        }

        #region RadioButton

        private void rb2dAzimutiSigma_CheckedChanged(object sender, EventArgs e)
        {
            AzimutTezinaRadioButton();
        }

        private void rb2dAzimutiBrojTocaka_CheckedChanged(object sender, EventArgs e)
        {
            AzimutTezinaRadioButton();
        }

        private void rb2dAzimutiTezina_CheckedChanged(object sender, EventArgs e)
        {
            AzimutTezinaRadioButton();
        }

        private void AzimutTezinaRadioButton()
        {
            if (rb2dAzimutiSigma.Checked)
            {
                tb2dAzimutSigma.Enabled = true;
                tb2dAzimutBrojTocaka.Enabled = false;
                tb2dAzimutTezina.Enabled = false;
            }
            else if (rb2dAzimutiBrojTocaka.Checked)
            {
                tb2dAzimutSigma.Enabled = false;
                tb2dAzimutBrojTocaka.Enabled = true;
                tb2dAzimutTezina.Enabled = false;
            }
            else
            {
                tb2dAzimutSigma.Enabled = false;
                tb2dAzimutBrojTocaka.Enabled = false;
                tb2dAzimutTezina.Enabled = true;
            }
        }

        #endregion RadioButton

        private void btn2dDodajAzimut_Click(object sender, EventArgs e)
        {
            if (AzimutTextBoxProvjera())
            {
                Tocka2D stajaliste = Tocka(cmb2DazimutiStajaliste.Text);
                Tocka2D vizura = Tocka(cmb2dAzimutiVizura.Text);

                DMS mjerenje = MjerenjeKutaPravcaAzimuta(tb2dAzimutiStupnjevi.Text, tb2dAzimutiMinute.Text, tb2dAzimutiSekunde.Text);

                SlobodanClanAzimut slobodanClan = new SlobodanClanAzimut(stajaliste, vizura, mjerenje.ToRad());

                DerivacijaAzimut derivacija = new DerivacijaAzimut(stajaliste, vizura);

                string sigma, tezina;
                VarijancaAzimut(out sigma, out tezina);

                #region ListView

                ListViewItem item = new ListViewItem(Tolerancija(slobodanClan.f.ToSeconds().ToDouble(), tb2dAzimutiTolarancija.Text));
                item.SubItems.Add(cmb2DazimutiStajaliste.Text);
                item.SubItems.Add(cmb2dAzimutiVizura.Text);

                item.SubItems.Add(mjerenje.ToString());
                item.SubItems.Add(stajaliste.SmjerniKut(vizura).ToDMS().ToString());
                item.SubItems.Add(slobodanClan.f.ToSeconds().ToString());

                item.SubItems.Add(tezina);
                item.SubItems.Add(sigma);

                item.SubItems.Add((derivacija.yStajaliste.ToSeconds().ToDouble() / 1000).ToString());
                item.SubItems.Add((derivacija.xStajaliste.ToSeconds().ToDouble() / 1000).ToString());

                item.SubItems.Add((derivacija.yVizura.ToSeconds().ToDouble() / 1000).ToString());
                item.SubItems.Add((derivacija.xVizura.ToSeconds().ToDouble() / 1000).ToString());

                lvAzimut.Items.Add(item);

                #endregion ListView

                urediListView(lvAzimut);

                tb2dAzimutiStupnjevi.Clear();
                tb2dAzimutiMinute.Clear();
                tb2dAzimutiSekunde.Clear();

                PopunjavanjeComboBoxVizura(lvAzimut, cmb2dAzimutiVizura, cmb2DazimutiStajaliste.Text);
            }
        }

        #endregion Azimut

        private void btnFormirajMatrice_Click(object sender, EventArgs e)
        {
            if (lvAzimut.Items.Count == 0)
                ckbAzimut.Checked = false;

            if (lvDuzina.Items.Count == 0)
                ckbDuzina.Checked = false;

            if (lvPravac.Items.Count == 0)
                ckbPravac.Checked = false;

            if (lvBazniVektor.Items.Count == 0)
                ckbBazniVektor.Checked = false;

            if (lvKut.Items.Count == 0)
                ckbKut.Checked = false;


            if (rbMinimalniTrag.Checked)
            {
                foreach(ListViewItem item in lvY.Items)
                {
                    item.Checked = true;
                }

                foreach (ListViewItem item in lvX.Items)
                {
                    item.Checked = true;
                }
            }

            FormirajAPfG apf = new Izjednacenje2D.FormirajAPfG();

            apf.FormirajA(lvA, lvTocka, lvPravac, lvKut, lvDuzina, lvBazniVektor, lvAzimut);
            apf.FormirajP(lvP, lvTocka, lvPravac, lvKut, lvDuzina, lvBazniVektor, lvAzimut);
            apf.Formirajf(lvF, lvTocka, lvPravac, lvKut, lvDuzina, lvBazniVektor, lvAzimut);
            apf.FormirajG(lvG, lvTocka, lvY, lvX, lvPravac);

            if (rbKlasicanNacin.Checked)
            {
                KlasicanDatum datum = new KlasicanDatum();
                datum.Gtranslacije(lvG, cmbKlasicanY.Text, cmbKlasicanX.Text);
                datum.G(lvG, lvTocka, lvY, lvX, ckbKlasicanAzimut.Checked, ckbKlasicanBazniVektor.Checked, ckbKlasicanKoordinata.Checked, cmbKlasicanRstajaliste.Text, cmbKlasicanRvizura.Text, cmbKlasicanMstajaliste.Text, cmbKlasicanMvizura.Text);

            }

            apf.IzbacivanjeIzG(ckbAzimut.Checked, ckbDuzina.Checked, ckbBazniVektor.Checked, lvG);
            apf.IzjednacenjePrisila(rbIzjednacenjePrisila.Checked, lvA, lvP, lvF, lvG, lvTocka, lvY, lvX);
            apf.KontrolaIzjednacenjePrisila(rbIzjednacenjePrisila.Checked, lvA);


            btnIzjednaci.Enabled = true;
        }

        private void Izjednacenje()
        {
            try
            {

                tcIzjednacenje.TabPages.Clear();
                lvOcjenaFunkcija.Items.Clear();

                PosrednoIzjednacenje MNK;
                MatrixVectorAndControl mvc = new MatrixVectorAndControl();


                DenseMatrix A = mvc.ListViewToMatrix(lvA);
                DenseMatrix P = mvc.ListViewToMatrix(lvP);
                DenseVector f = mvc.ListViewToVector(lvF);
                DenseMatrix G;
                DenseMatrix G1 = new DenseMatrix(1,1);

                int d;

                if (lvG.Items.Count == 0)
                {
                    MNK = new PosrednoIzjednacenje(A, P, f);
                    d = 0;
                    
                }
                else
                {
                    G = mvc.ListViewToMatrix(lvG);
                    d = G.ColumnCount;
                    MNK = new PosrednoIzjednacenje(A, P, f, G);
                    G1 = G;
                }

                int fprekobrojnost = Math.Abs(A.ColumnCount - A.RowCount) + d;

                ListView Alv = new ListView();
                mvc.MatrixToTabPage(tcIzjednacenje, "A", Alv, A, mvc.ListViewColumnHeaderToList(lvA), mvc.ListViewColumnHeaderToList(lvP));

                ListView Plv = new ListView();
                mvc.MatrixToTabPage(tcIzjednacenje, "P", Plv, P, mvc.ListViewColumnHeaderToList(lvP), mvc.ListViewColumnHeaderToList(lvP));

                ListView flv = new ListView();
                mvc.VectorToTabPage(tcIzjednacenje, "f", flv, f, "", mvc.ListViewColumnHeaderToList(lvP));


                if (!rbIzjednacenjePrisila.Checked)
                {
                    ListView Glv = new ListView();
                    List<string> HeaderG = new List<string>() { "Tx", "Tx", "R", "m" };
                    mvc.MatrixToTabPage(tcIzjednacenje, "G", Glv, G1, HeaderG, mvc.ListViewColumnHeaderToList(lvA));
                }


                prikaz(MNK);
                ocjenaFunkcija(MNK);

                izjednaceneVrijednosti izjednaceno = new izjednaceneVrijednosti(MNK);
                izjednaceno.lvMjerenja(lvIzjednacenaMjerenja, lvPravac, lvKut, lvDuzina, lvBazniVektor, lvAzimut, Convert.ToDouble(tbSigmaNulaKvadrat.Text, CultureInfo.InvariantCulture));
                izjednaceno.IzjednaceneTocke(lvIzjednaceneKoordinate, lvTocka, lvY, lvX, Convert.ToDouble(tbSigmaNulaKvadrat.Text), rbIzjednacenjePrisila.Checked);

                Elipsa elip = new Elipsa(MNK);
                elip.elipsa(lvElipsa, lvTocka, lvY, lvX, Convert.ToDouble(tbSigmaNulaKvadrat.Text), rbIzjednacenjePrisila.Checked);

                


                double alfa = Convert.ToDouble(tbLokalniAlfa.Text, CultureInfo.InvariantCulture) / 100;
                double beta = Convert.ToDouble(tbLokalniBeta.Text, CultureInfo.InvariantCulture) / 100;
                double alfaGlob = Convert.ToDouble(tbGlobalniAlfa.Text, CultureInfo.InvariantCulture) / 100;


                Statistika test = new Statistika(MNK, Convert.ToDouble(tbSigmaNulaKvadrat.Text, CultureInfo.InvariantCulture), alfa, beta, fprekobrojnost, alfaGlob);

                test.LokalniTest(lvStatistika, lvP);

                tsslGlobalniTest.Text = test.Gtest;
                tsslGlobalniTest.Text = test.Gtest;

                #region Test Podudarnosti

                if (!rbIzjednacenjePrisila.Checked)
                {
                    List<string> theta = new List<string>();

                    foreach (ListViewItem item in lvElipsa.Items)
                    {
                        theta.Add(item.SubItems[9].Text);
                    }

                    List<string> tocke = new List<string>();

                    foreach (ListViewItem item in lvTocka.Items)
                    {
                        tocke.Add(item.SubItems[0].Text);
                    }

                    double lambda = Distribucije.ParametarNecentralnosti(alfa, beta);

                    tpTestPouzdanostiFigure.Text = "Test pouzdanosti figure (α=" + tbLokalniAlfa.Text + "%, β= " + tbLokalniBeta.Text + "%)";

                    TestPodudarnostiFigure testPo = new TestPodudarnostiFigure(rbIzjednacenjePrisila.Checked, MNK.Qx, theta, lambda, sigmaNulaKvadrat);
                    testPo.Test(lvTestPouzdanosti, tocke);
                }
                #endregion Test Podudarnosti

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n\n" + e.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void prikaz(PosrednoIzjednacenje mnk)
        {
            MatrixVectorAndControl mvc = new MatrixVectorAndControl();

            double dd = mnk.N[1, 1];

            StatusStrip(mnk);


            ListView N = new ListView();
            mvc.MatrixToTabPage(tcIzjednacenje, "N", N, mnk.N, mvc.ListViewColumnHeaderToList(lvA), mvc.ListViewColumnHeaderToList(lvA));

            ListView n = new ListView();
            mvc.VectorToTabPage(tcIzjednacenje, "n", n, mnk.n, "n", mvc.ListViewColumnHeaderToList(lvA));

            ListView Qx = new ListView();
            mvc.MatrixToTabPage(tcIzjednacenje, "Qx", Qx, mnk.Qx, mvc.ListViewColumnHeaderToList(lvA), mvc.ListViewColumnHeaderToList(lvA));

            ListView x2d = new ListView();
            mvc.VectorToTabPage(tcIzjednacenje, "x", x2d, mnk.x, "x", mvc.ListViewColumnHeaderToList(lvA));

            ListView v = new ListView();
            mvc.VectorToTabPage(tcIzjednacenje, "v", v, mnk.v, "v", mvc.ListViewColumnHeaderToList(lvP));

            ListView Qlcap = new ListView();
            mvc.MatrixToTabPage(tcIzjednacenje, "Qî", Qlcap, mnk.Qlcap, mvc.ListViewColumnHeaderToList(lvP), mvc.ListViewColumnHeaderToList(lvP));

            ListView Qv = new ListView();
            mvc.MatrixToTabPage(tcIzjednacenje, "Qv", Qv, mnk.Qv, mvc.ListViewColumnHeaderToList(lvP), mvc.ListViewColumnHeaderToList(lvP));

            ListView Ql = new ListView();
            mvc.MatrixToTabPage(tcIzjednacenje, "Ql", Ql, mnk.Ql, mvc.ListViewColumnHeaderToList(lvP), mvc.ListViewColumnHeaderToList(lvP));

            ListView R = new ListView();
            mvc.MatrixToTabPage(tcIzjednacenje, "R", R, mnk.R, mvc.ListViewColumnHeaderToList(lvP), mvc.ListViewColumnHeaderToList(lvP));

            ListView U = new ListView();
            mvc.MatrixToTabPage(tcIzjednacenje, "U", U, mnk.U, mvc.ListViewColumnHeaderToList(lvP), mvc.ListViewColumnHeaderToList(lvP));

            ListView RU = new ListView();
            mvc.MatrixToTabPage(tcIzjednacenje, "R + U = I", RU, mnk.R + mnk.U, mvc.ListViewColumnHeaderToList(lvP), mvc.ListViewColumnHeaderToList(lvP));



        }

        private void StatusStrip(PosrednoIzjednacenje mnk)
        {
            if (rbIzjednacenjePrisila.Checked)
                tsslVrstaIzjednacenja.Text = rbIzjednacenjePrisila.Text;
            if (rbKlasicanNacin.Checked)
                tsslVrstaIzjednacenja.Text = rbKlasicanNacin.Text;
            if (rbMinimalniTrag.Checked)
                tsslVrstaIzjednacenja.Text = rbMinimalniTrag.Text;
            if (rbParcijalniMinimalniTrag.Checked)
                tsslVrstaIzjednacenja.Text = rbParcijalniMinimalniTrag.Text;

            tsslSigmaKvadrat.Text = "    σ²: " + tbSigmaNulaKvadrat.Text;
            tsslSigma.Text = "    σ: " + tbSigmaNula.Text;
            tsslSo2.Text = "    s²: " + mnk.sKvadrat.ToString();
            tsslSo.Text = "    s: " + Math.Sqrt(mnk.sKvadrat).ToString();

            int u = mnk.N.ColumnCount;
            int n = mnk.Ql.ColumnCount;
            int f, d;

            if (lvG.Items.Count > 0)
            {
                d = lvG.Columns.Count - 1;
                f = n - u + d;
            }
            else
            {
                d = 0;
                f = n - u + d;
            }

            tssln.Text = "    n: " + n.ToString();
            tsslu.Text = "    u: " + u.ToString();
            tssld.Text = "    d: " + d.ToString();
            tsslf.Text = "    f: " + f.ToString();

        }

        private void ocjenaFunkcija(PosrednoIzjednacenje mnk)
        {
            #region Mjerenja

            foreach (ListViewItem item in lvA.Items)
            {
                ListViewItem ocjena = new ListViewItem(item.SubItems[0].Text);
                List<double> hLista = new List<double>();

                for (int i = 1; i < item.SubItems.Count; i++)
                {
                    hLista.Add(Convert.ToDouble(item.SubItems[i].Text));
                }

                DenseVector h = new DenseVector(hLista.ToArray());

                OcjenjivostFunkcija funk = new OcjenjivostFunkcija(h, mnk.Qx, mnk.N);

                if (funk.FunkcijaJeOcjeniva)
                    ocjena.SubItems.Add("DA");
                else
                    ocjena.SubItems.Add("-NE-");

                double sigmaNulaKvadrat = Convert.ToDouble(tbSigmaNulaKvadrat.Text, CultureInfo.InvariantCulture);

                ocjena.SubItems.Add(funk.s(sigmaNulaKvadrat).ToString());
                ocjena.SubItems.Add(Math.Sqrt(funk.s(sigmaNulaKvadrat)).ToString());

                lvOcjenaFunkcija.Items.Add(ocjena);

            }

            #endregion Mjerenja

            #region Koordinate

            for (int i = 1; i < lvA.Columns.Count; i++)
            {
                DenseVector h = new DenseVector(lvA.Columns.Count - 1);
                h[i - 1] = 1;

                ListViewItem ocjena = new ListViewItem(lvA.Columns[i].Text);
                OcjenjivostFunkcija funk = new OcjenjivostFunkcija(h, mnk.Qx, mnk.N);

                if (funk.FunkcijaJeOcjeniva)
                    ocjena.SubItems.Add("DA");
                else
                    ocjena.SubItems.Add("-NE-");

                double sigmaNulaKvadrat = Convert.ToDouble(tbSigmaNulaKvadrat.Text, CultureInfo.InvariantCulture);

                ocjena.SubItems.Add(funk.s(sigmaNulaKvadrat).ToString());
                ocjena.SubItems.Add(Math.Sqrt(funk.s(sigmaNulaKvadrat)).ToString());
                lvOcjenaFunkcija.Items.Add(ocjena);
            }

            #endregion Koordinate

            #region Tocke

            foreach (ListViewItem item in lvTocka.Items)
            {
                string stajaliste = item.SubItems[0].Text;
                Tocka2D Stajaliste = Tocka(stajaliste);

                DenseVector h = new DenseVector(lvA.Columns.Count - 1);

                for (int i = 1; i < lvA.Columns.Count; i++)
                {
                    if (lvA.Columns[i].Text == "Y" + stajaliste)
                        h[i - 1] = 1;
                    else if (lvA.Columns[i].Text == "X" + stajaliste)
                        h[i - 1] = 1;
                }

                ListViewItem ocjena = new ListViewItem("Tocka: " + stajaliste);
                OcjenjivostFunkcija funk = new OcjenjivostFunkcija(h, mnk.Qx, mnk.N);

                if (funk.FunkcijaJeOcjeniva)
                    ocjena.SubItems.Add("DA");
                else
                    ocjena.SubItems.Add("-NE-");

                double sigmaNulaKvadrat = Convert.ToDouble(tbSigmaNulaKvadrat.Text, CultureInfo.InvariantCulture);

                ocjena.SubItems.Add(funk.s(sigmaNulaKvadrat).ToString());
                ocjena.SubItems.Add(Math.Sqrt(funk.s(sigmaNulaKvadrat)).ToString());
                lvOcjenaFunkcija.Items.Add(ocjena);
            }

            #endregion Tocke

            #region Kut

            foreach (ListViewItem T1 in lvTocka.Items)
            {
                string stajaliste = T1.SubItems[0].Text;
                Tocka2D Stajaliste = Tocka(stajaliste);


                foreach (ListViewItem T2 in lvTocka.Items)
                {
                    string Od = T2.SubItems[0].Text;
                    Tocka2D OD = Tocka(Od);

                    if (stajaliste != Od)
                    {

                        foreach (ListViewItem T3 in lvTocka.Items)
                        {
                            string Do = T3.SubItems[0].Text;
                            Tocka2D DO = Tocka(Do);

                            if (stajaliste != Do && Do != Od)
                            {
                                DerivacijaKut deriv = new DerivacijaKut(Stajaliste, OD, DO);

                                DenseVector h = new DenseVector(lvA.Columns.Count - 1);

                                for (int i = 1; i < lvA.Columns.Count; i++)
                                {


                                    if (lvA.Columns[i].Text == "Y" + stajaliste)
                                        h[i - 1] = deriv.yStajaliste.ToSeconds().ToDouble() / 1000;
                                    else if (lvA.Columns[i].Text == "X" + stajaliste)
                                        h[i - 1] = deriv.xStajaliste.ToSeconds().ToDouble() / 1000;

                                    else if (lvA.Columns[i].Text == "Y" + Od)
                                        h[i - 1] = deriv.yOd.ToSeconds().ToDouble() / 1000;
                                    else if (lvA.Columns[i].Text == "X" + Od)
                                        h[i - 1] = deriv.xOd.ToSeconds().ToDouble() / 1000;

                                    else if (lvA.Columns[i].Text == "Y" + Do)
                                        h[i - 1] = deriv.yDo.ToSeconds().ToDouble() / 1000;
                                    else if (lvA.Columns[i].Text == "X" + Do)
                                        h[i - 1] = deriv.xDo.ToSeconds().ToDouble() / 1000;

                                }

                                ListViewItem ocjena = new ListViewItem("Kut: " + stajaliste + "-" + Od + "-" + Do);
                                OcjenjivostFunkcija funk = new OcjenjivostFunkcija(h, mnk.Qx, mnk.N);

                                if (funk.FunkcijaJeOcjeniva)
                                    ocjena.SubItems.Add("DA");
                                else
                                    ocjena.SubItems.Add("-NE-");

                                double sigmaNulaKvadrat = Convert.ToDouble(tbSigmaNulaKvadrat.Text, CultureInfo.InvariantCulture);

                                ocjena.SubItems.Add(funk.s(sigmaNulaKvadrat).ToString());
                                ocjena.SubItems.Add(Math.Sqrt(funk.s(sigmaNulaKvadrat)).ToString());
                                lvOcjenaFunkcija.Items.Add(ocjena);
                            }
                        }
                    }
                }
            }
            #endregion Kut

            #region Duzina

            foreach (ListViewItem T1 in lvTocka.Items)
            {
                string stajaliste = T1.SubItems[0].Text;
                Tocka2D Stajaliste = Tocka(stajaliste);


                foreach (ListViewItem T2 in lvTocka.Items)
                {
                    string vizura = T2.SubItems[0].Text;
                    Tocka2D Vizura = Tocka(vizura);

                    if (stajaliste != vizura)
                    {
                        DerivacijaDuzina deriv = new DerivacijaDuzina(Stajaliste, Vizura);

                        DenseVector h = new DenseVector(lvA.Columns.Count - 1);

                        for (int i = 1; i < lvA.Columns.Count; i++)
                        {


                            if (lvA.Columns[i].Text == "Y" + stajaliste)
                                h[i - 1] = deriv.yStajaliste;
                            else if (lvA.Columns[i].Text == "X" + stajaliste)
                                h[i - 1] = deriv.xStajaliste;

                            else if (lvA.Columns[i].Text == "Y" + vizura)
                                h[i - 1] = deriv.yVizura;
                            else if (lvA.Columns[i].Text == "X" + vizura)
                                h[i - 1] = deriv.xVizura;

                        }

                        ListViewItem ocjena = new ListViewItem("Duzina: " + stajaliste + "-" +vizura);
                        OcjenjivostFunkcija funk = new OcjenjivostFunkcija(h, mnk.Qx, mnk.N);

                        if (funk.FunkcijaJeOcjeniva)
                            ocjena.SubItems.Add("DA");
                        else
                            ocjena.SubItems.Add("-NE-");

                        double sigmaNulaKvadrat = Convert.ToDouble(tbSigmaNulaKvadrat.Text, CultureInfo.InvariantCulture);

                        ocjena.SubItems.Add(funk.s(sigmaNulaKvadrat).ToString());
                        ocjena.SubItems.Add(Math.Sqrt(funk.s(sigmaNulaKvadrat)).ToString());
                        lvOcjenaFunkcija.Items.Add(ocjena);
                    }
                }
            }

            #endregion Duzina

            #region Pravac

            foreach (ListViewItem T1 in lvTocka.Items)
            {
                string stajaliste = T1.SubItems[0].Text;
                Tocka2D Stajaliste = Tocka(stajaliste);


                foreach (ListViewItem T2 in lvTocka.Items)
                {
                    string vizura = T2.SubItems[0].Text;
                    Tocka2D Vizura = Tocka(vizura);

                    if (stajaliste != vizura)
                    {

                        foreach (ListViewItem T3 in lvTocka.Items)
                        {
                            string orijentacija = "Z" + T3.SubItems[0].Text;

                            foreach (ColumnHeader header in lvA.Columns)
                            {
                                if (header.Text == orijentacija)
                                {
                                    DerivacijaPravac deriv = new DerivacijaPravac(Stajaliste, Vizura);

                                    DenseVector h = new DenseVector(lvA.Columns.Count - 1);

                                    for (int i = 1; i < lvA.Columns.Count; i++)
                                    {


                                        if (lvA.Columns[i].Text == "Y" + stajaliste)
                                            h[i - 1] = deriv.yStajaliste.ToSeconds().ToDouble() / 1000;
                                        else if (lvA.Columns[i].Text == "X" + stajaliste)
                                            h[i - 1] = deriv.xStajaliste.ToSeconds().ToDouble() / 1000;

                                        else if (lvA.Columns[i].Text == "Y" + vizura)
                                            h[i - 1] = deriv.yVizura.ToSeconds().ToDouble() / 1000;
                                        else if (lvA.Columns[i].Text == "X" + vizura)
                                            h[i - 1] = deriv.xVizura.ToSeconds().ToDouble() / 1000;
                                        else if (lvA.Columns[i].Text == orijentacija)
                                            h[i - 1] = 1;

                                    }

                                    ListViewItem ocjena = new ListViewItem("Pravac: " + stajaliste + "-" + vizura + " orijenatcija na " + orijentacija.Substring(1, orijentacija.Length - 1));
                                    OcjenjivostFunkcija funk = new OcjenjivostFunkcija(h, mnk.Qx, mnk.N);

                                    if (funk.FunkcijaJeOcjeniva)
                                        ocjena.SubItems.Add("DA");
                                    else
                                        ocjena.SubItems.Add("-NE-");

                                    double sigmaNulaKvadrat = Convert.ToDouble(tbSigmaNulaKvadrat.Text, CultureInfo.InvariantCulture);

                                    ocjena.SubItems.Add(funk.s(sigmaNulaKvadrat).ToString());
                                    ocjena.SubItems.Add(Math.Sqrt(funk.s(sigmaNulaKvadrat)).ToString());
                                    lvOcjenaFunkcija.Items.Add(ocjena);
                                }
                            }
                        }
                    }
                }
            }

            #endregion Pravac

            #region Azimut

            foreach (ListViewItem T1 in lvTocka.Items)
            {
                string stajaliste = T1.SubItems[0].Text;
                Tocka2D Stajaliste = Tocka(stajaliste);


                foreach (ListViewItem T2 in lvTocka.Items)
                {
                    string vizura = T2.SubItems[0].Text;
                    Tocka2D Vizura = Tocka(vizura);

                    if (stajaliste != vizura)
                    {
                        DerivacijaAzimut deriv = new DerivacijaAzimut(Stajaliste, Vizura);

                        DenseVector h = new DenseVector(lvA.Columns.Count - 1);

                        for (int i = 1; i < lvA.Columns.Count; i++)
                        {


                            if (lvA.Columns[i].Text == "Y" + stajaliste)
                                h[i - 1] = deriv.yStajaliste.ToSeconds().ToDouble() / 1000;
                            else if (lvA.Columns[i].Text == "X" + stajaliste)
                                h[i - 1] = deriv.xStajaliste.ToSeconds().ToDouble() / 1000;

                            else if (lvA.Columns[i].Text == "Y" + vizura)
                                h[i - 1] = deriv.yVizura.ToSeconds().ToDouble() / 1000;
                            else if (lvA.Columns[i].Text == "X" + vizura)
                                h[i - 1] = deriv.xVizura.ToSeconds().ToDouble() / 1000;

                        }

                        ListViewItem ocjena = new ListViewItem("Azimut: " + stajaliste + "-" + vizura);
                        OcjenjivostFunkcija funk = new OcjenjivostFunkcija(h, mnk.Qx, mnk.N);

                        if (funk.FunkcijaJeOcjeniva)
                            ocjena.SubItems.Add("DA");
                        else
                            ocjena.SubItems.Add("-NE-");

                        double sigmaNulaKvadrat = Convert.ToDouble(tbSigmaNulaKvadrat.Text, CultureInfo.InvariantCulture);

                        ocjena.SubItems.Add(funk.s(sigmaNulaKvadrat).ToString());
                        ocjena.SubItems.Add(Math.Sqrt(funk.s(sigmaNulaKvadrat)).ToString());
                        lvOcjenaFunkcija.Items.Add(ocjena);
                    }
                }
            }

            #endregion Azimut

            #region Bazni Vektor

            foreach (ListViewItem T1 in lvTocka.Items)
            {
                string stajaliste = T1.SubItems[0].Text;
                Tocka2D Stajaliste = Tocka(stajaliste);


                foreach (ListViewItem T2 in lvTocka.Items)
                {
                    string vizura = T2.SubItems[0].Text;
                    Tocka2D Vizura = Tocka(vizura);

                    if (stajaliste != vizura)
                    {
                        DerivacijaBazniVektor deriv = new DerivacijaBazniVektor();

                        DenseVector h = new DenseVector(lvA.Columns.Count - 1);

                        for (int i = 1; i < lvA.Columns.Count; i++)
                        {


                            if (lvA.Columns[i].Text == "Y" + stajaliste)
                                h[i - 1] = deriv.yStajaliste;
                            else if (lvA.Columns[i].Text == "X" + stajaliste)
                                h[i - 1] = deriv.xStajaliste;

                            else if (lvA.Columns[i].Text == "Y" + vizura)
                                h[i - 1] = deriv.yVizura;
                            else if (lvA.Columns[i].Text == "X" + vizura)
                                h[i - 1] = deriv.xVizura;

                        }

                        ListViewItem ocjena = new ListViewItem("Bazni Vektori (Y,X): " + stajaliste + "-" + vizura);
                        OcjenjivostFunkcija funk = new OcjenjivostFunkcija(h, mnk.Qx, mnk.N);

                        if (funk.FunkcijaJeOcjeniva)
                            ocjena.SubItems.Add("DA");
                        else
                            ocjena.SubItems.Add("-NE-");

                        double sigmaNulaKvadrat = Convert.ToDouble(tbSigmaNulaKvadrat.Text, CultureInfo.InvariantCulture);

                        ocjena.SubItems.Add(funk.s(sigmaNulaKvadrat).ToString());
                        ocjena.SubItems.Add(Math.Sqrt(funk.s(sigmaNulaKvadrat)).ToString());
                        lvOcjenaFunkcija.Items.Add(ocjena);
                    }
                }
            }

            #endregion Bazni Vektor

            #region Bazni Vektor Y

            foreach (ListViewItem T1 in lvTocka.Items)
            {
                string stajaliste = T1.SubItems[0].Text;
                Tocka2D Stajaliste = Tocka(stajaliste);


                foreach (ListViewItem T2 in lvTocka.Items)
                {
                    string vizura = T2.SubItems[0].Text;
                    Tocka2D Vizura = Tocka(vizura);

                    if (stajaliste != vizura)
                    {
                        DerivacijaBazniVektor deriv = new DerivacijaBazniVektor();

                        DenseVector h = new DenseVector(lvA.Columns.Count - 1);

                        for (int i = 1; i < lvA.Columns.Count; i++)
                        {


                            if (lvA.Columns[i].Text == "Y" + stajaliste)
                                h[i - 1] = deriv.yStajaliste;


                            else if (lvA.Columns[i].Text == "Y" + vizura)
                                h[i - 1] = deriv.yVizura;


                        }

                        ListViewItem ocjena = new ListViewItem("Bazni Vektor Y: " + stajaliste + "-" + vizura);
                        OcjenjivostFunkcija funk = new OcjenjivostFunkcija(h, mnk.Qx, mnk.N);

                        if (funk.FunkcijaJeOcjeniva)
                            ocjena.SubItems.Add("DA");
                        else
                            ocjena.SubItems.Add("-NE-");

                        double sigmaNulaKvadrat = Convert.ToDouble(tbSigmaNulaKvadrat.Text, CultureInfo.InvariantCulture);

                        ocjena.SubItems.Add(funk.s(sigmaNulaKvadrat).ToString());
                        ocjena.SubItems.Add(Math.Sqrt(funk.s(sigmaNulaKvadrat)).ToString());
                        lvOcjenaFunkcija.Items.Add(ocjena);
                    }
                }
            }

            #endregion Bazni Vektor Y

            #region Bazni Vektor X

            foreach (ListViewItem T1 in lvTocka.Items)
            {
                string stajaliste = T1.SubItems[0].Text;
                Tocka2D Stajaliste = Tocka(stajaliste);


                foreach (ListViewItem T2 in lvTocka.Items)
                {
                    string vizura = T2.SubItems[0].Text;
                    Tocka2D Vizura = Tocka(vizura);

                    if (stajaliste != vizura)
                    {
                        DerivacijaBazniVektor deriv = new DerivacijaBazniVektor();

                        DenseVector h = new DenseVector(lvA.Columns.Count - 1);

                        for (int i = 1; i < lvA.Columns.Count; i++)
                        {


                            if (lvA.Columns[i].Text == "X" + stajaliste)
                                h[i - 1] = deriv.yStajaliste;


                            else if (lvA.Columns[i].Text == "X" + vizura)
                                h[i - 1] = deriv.yVizura;


                        }

                        ListViewItem ocjena = new ListViewItem("Bazni Vektor X: " + stajaliste + "-" + vizura);
                        OcjenjivostFunkcija funk = new OcjenjivostFunkcija(h, mnk.Qx, mnk.N);

                        if (funk.FunkcijaJeOcjeniva)
                            ocjena.SubItems.Add("DA");
                        else
                            ocjena.SubItems.Add("-NE-");

                        double sigmaNulaKvadrat = Convert.ToDouble(tbSigmaNulaKvadrat.Text, CultureInfo.InvariantCulture);

                        ocjena.SubItems.Add(funk.s(sigmaNulaKvadrat).ToString());
                        ocjena.SubItems.Add(Math.Sqrt(funk.s(sigmaNulaKvadrat)).ToString());
                        lvOcjenaFunkcija.Items.Add(ocjena);
                    }
                }
            }

            #endregion Bazni Vektor X

            urediListView(lvOcjenaFunkcija);
        }

        private void btnIzjednaci_Click(object sender, EventArgs e)
        {
            Izjednacenje();
            btnIzjednaci.Enabled = false;
        }

        #region Klasican datum

        private void DatumKlasican()
        {
            KlasicanDatum datum = new KlasicanDatum();

            if(ckbKlasicanAzimut.Checked)
            {
                datum.KoordinataCheckBox(false, lvTocka, lblKlasicanMstajaliste, lblKlasicanMvizura, cmbKlasicanMstajaliste, cmbKlasicanMvizura);
                datum.KoordinataCheckBox(false, lvTocka, lblKlasicanRstajaliste, lblKlasicanRvizura, cmbKlasicanRstajaliste, cmbKlasicanRvizura);
                datum.BazniVektorCheckBox(false, lvTocka, gbKlasicanRotacija, gbKlasicanMjerilo, cmbKlasicanRstajaliste, cmbKlasicanRvizura);

                cmbKlasicanRvizura.Items.Clear();
                cmbKlasicanMvizura.Items.Clear();
                datum.AzimutDuzinaCheckBox(true, lvTocka, gbKlasicanRotacija, gbKlasicanMjerilo, cmbKlasicanMstajaliste, cmbKlasicanRstajaliste);
            }


            if(ckbKlasicanBazniVektor.Checked)
            {
                datum.AzimutDuzinaCheckBox(false, lvTocka, gbKlasicanRotacija, gbKlasicanMjerilo, cmbKlasicanMstajaliste, cmbKlasicanRstajaliste);
                datum.KoordinataCheckBox(false, lvTocka, lblKlasicanRstajaliste, lblKlasicanRvizura, cmbKlasicanRstajaliste, cmbKlasicanRvizura);
                datum.BazniVektorCheckBox(false, lvTocka, gbKlasicanRotacija, gbKlasicanMjerilo, cmbKlasicanRstajaliste, cmbKlasicanRvizura);

                datum.BazniVektorCheckBox(true, lvTocka, gbKlasicanRotacija, gbKlasicanMjerilo, cmbKlasicanRstajaliste, cmbKlasicanRvizura);
            }


            if(ckbKlasicanKoordinata.Checked)
            {
                datum.BazniVektorCheckBox(false, lvTocka, gbKlasicanRotacija, gbKlasicanMjerilo, cmbKlasicanRstajaliste, cmbKlasicanRvizura);
                datum.AzimutDuzinaCheckBox(false, lvTocka, gbKlasicanRotacija, gbKlasicanMjerilo, cmbKlasicanMstajaliste, cmbKlasicanRstajaliste);

                datum.KoordinataCheckBox(true, lvTocka, lblKlasicanMstajaliste, lblKlasicanMvizura, cmbKlasicanMstajaliste, cmbKlasicanMvizura);
                datum.KoordinataCheckBox(true, lvTocka, lblKlasicanRstajaliste, lblKlasicanRvizura, cmbKlasicanRstajaliste, cmbKlasicanRvizura);
            }


            if(!ckbKlasicanKoordinata.Checked && !ckbKlasicanBazniVektor.Checked && !ckbKlasicanDuzina.Checked && !ckbKlasicanAzimut.Checked)
            {
                ckbKlasicanAzimut.Checked = false;
                ckbKlasicanBazniVektor.Checked = false;
                ckbKlasicanKoordinata.Checked = true;
                ckbDuzina.Checked = false;

                datum.KoordinataCheckBox(true, lvTocka, lblKlasicanMstajaliste, lblKlasicanMvizura, cmbKlasicanMstajaliste, cmbKlasicanMvizura);
                datum.KoordinataCheckBox(true, lvTocka, lblKlasicanRstajaliste, lblKlasicanRvizura, cmbKlasicanRstajaliste, cmbKlasicanRvizura);
            }



        }

        private void ckbKlasicanAzimut_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbKlasicanAzimut.Checked)
            {
                ckbKlasicanBazniVektor.Checked = false;
                ckbKlasicanKoordinata.Checked = false;
                ckbKlasicanDuzina.Checked = true;
            }
            else if (ckbKlasicanDuzina.Checked && !ckbKlasicanAzimut.Checked && !ckbKlasicanBazniVektor.Checked && !ckbKlasicanKoordinata.Checked)
                ckbKlasicanAzimut.Checked = true;

            DatumKlasican();
        }

        private void ckbKlasicanDuzina_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbKlasicanDuzina.Checked)
            {
                ckbKlasicanAzimut.Checked = true;
                ckbKlasicanBazniVektor.Checked = false;
                ckbKlasicanKoordinata.Checked = false;
            }
            else if (!ckbKlasicanDuzina.Checked && ckbKlasicanAzimut.Checked && !ckbKlasicanBazniVektor.Checked && !ckbKlasicanKoordinata.Checked)
                ckbKlasicanDuzina.Checked = true;

            DatumKlasican();
        }

        private void ckbKlasicanBazniVektor_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbKlasicanBazniVektor.Checked)
            {
                ckbKlasicanAzimut.Checked = false;
                ckbKlasicanKoordinata.Checked = false;
                ckbKlasicanDuzina.Checked = false;
            }
            else if (!ckbKlasicanDuzina.Checked && !ckbKlasicanAzimut.Checked && !ckbKlasicanBazniVektor.Checked && !ckbKlasicanKoordinata.Checked)
                ckbKlasicanBazniVektor.Checked = true;

            DatumKlasican();
        }

        private void ckbKlasicanKoordinata_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbKlasicanKoordinata.Checked)
            {
                ckbKlasicanAzimut.Checked = false;
                ckbKlasicanBazniVektor.Checked = false;
                ckbKlasicanDuzina.Checked = false;
            }

            DatumKlasican();
        }

        private void cmbKlasicanRstajaliste_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!ckbKlasicanKoordinata.Checked)
            {
                PopunjavanjeComboBoxVizura(new ListView(), cmbKlasicanRvizura, cmbKlasicanRstajaliste.Text);
            }
        }

        private void cmbKlasicanMstajaliste_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopunjavanjeComboBoxVizura(new ListView(), cmbKlasicanMvizura, cmbKlasicanMstajaliste.Text);
        }


        #endregion Klasican datum

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int d, u, f, n;

                int.TryParse(string.Join("", tssln.Text.ToCharArray().Where(Char.IsDigit)), out n);
                int.TryParse(string.Join("", tsslu.Text.ToCharArray().Where(Char.IsDigit)), out u);
                int.TryParse(string.Join("", tssld.Text.ToCharArray().Where(Char.IsDigit)), out d);
                int.TryParse(string.Join("", tsslf.Text.ToCharArray().Where(Char.IsDigit)), out f);

                Excel ex = new Izjednacenje2D.Excel(tsslVrstaIzjednacenja.Text, n, u, d, f);
                ex.ExportToExcell(lvTocka, lvY, lvX, lvPravac, lvKut, lvDuzina, lvBazniVektor, lvAzimut, tcIzjednacenje, lvOcjenaFunkcija, tcIzjednaceneVrijednosti, lvStatistika, lvTestPouzdanosti);

                MessageBox.Show("Excel je uspješno popunjen", "Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška kod popunjavanje excela. \nNemojte dirati excel dok se popunjavaju tablice. \nProvjerite da li imate instaliran excel.\n\n" + ex.Message + "\n\n" + e.ToString(), "Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void tbTocka_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
