using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Izjednacenje2D
{
    public class FormirajAPfG
    {
        public void FormirajA(ListView A, ListView Koordinate, ListView Pravci, ListView Kutevi, ListView Duzine, ListView BazniVektori, ListView Azimuti)
        {
            #region postavke ListView-a

            A.Clear();
            A.Columns.Add("Mjerenje");


            List<string> z = new List<string>();

            //broj nepoznanica orijentacije
            foreach (ListViewItem item in Pravci.Items)
            {
                string pravac = item.SubItems[1].Text;

                if (!z.Contains(pravac))
                {
                    z.Add(pravac);
                }
            }

            int brojNepoznanicaOrijentacije = z.Count;

            foreach (ListViewItem item in Koordinate.Items)
            {
                string tocka = item.SubItems[0].Text;
                bool postoji = false;

                foreach (ColumnHeader header in A.Columns)
                {
                    if (header.Text == ("Y" + tocka))
                    {
                        postoji = true;
                        break;
                    }
                }

                if (postoji == false)
                {
                    A.Columns.Add("Y" + tocka);
                    A.Columns.Add("X" + tocka);
                }

            }


            foreach (string tocka in z)
            {
                A.Columns.Add("Z" + tocka);
            }

            #endregion postavke ListView-a

            #region Pravci

            foreach (ListViewItem item in Pravci.Items)
            {
                string stajaliste = item.SubItems[1].Text;
                string vizura = item.SubItems[2].Text;

                string yStDeriv = item.SubItems[10].Text;
                string xStDeriv = item.SubItems[11].Text;
                string yVzDeriv = item.SubItems[12].Text;
                string xVzDeriv = item.SubItems[13].Text;

                

                ListViewItem ItemForA = new ListViewItem("Pravac: " + stajaliste + "-" + vizura);

                foreach (ColumnHeader header in A.Columns)
                {
                    if (header.Text == "Mjerenje")
                    {
                    }
                    else if (header.Text == ("Y" + stajaliste))
                    {
                        ItemForA.SubItems.Add(yStDeriv);
                    }
                    else if (header.Text == ("X" + stajaliste))
                    {
                        ItemForA.SubItems.Add(xStDeriv);
                    }
                    else if (header.Text == ("Z" + stajaliste))
                    {
                        ItemForA.SubItems.Add("1");
                    }
                    else if (header.Text == ("Y" + vizura))
                    {
                        ItemForA.SubItems.Add(yVzDeriv);
                    }
                    else if (header.Text == ("X" + vizura))
                    {
                        ItemForA.SubItems.Add(xVzDeriv);
                    }
                    else
                    {
                        ItemForA.SubItems.Add("0");
                    }
                }

                A.Items.Add(ItemForA);

            }

            #endregion Pravci

            #region Kutevi

            foreach (ListViewItem item in Kutevi.Items)
            {
                string stajaliste = item.SubItems[1].Text;
                string Od = item.SubItems[2].Text;
                string Do = item.SubItems[3].Text;

                string yStDeriv = item.SubItems[9].Text;
                string xStDeriv = item.SubItems[10].Text;
                string yOdDeriv = item.SubItems[11].Text;
                string xOdDeriv = item.SubItems[12].Text;
                string yDoDeriv = item.SubItems[13].Text;
                string xDoDeriv = item.SubItems[14].Text;

                ListViewItem ItemForA = new ListViewItem("Kut: " + stajaliste + "-" + Od + "-" + Do);

                foreach (ColumnHeader header in A.Columns)
                {
                    if (header.Text == "Mjerenje")
                    {
                    }
                    else if (header.Text == ("Y" + stajaliste))
                    {
                        ItemForA.SubItems.Add(yStDeriv);
                    }
                    else if (header.Text == ("X" + stajaliste))
                    {
                        ItemForA.SubItems.Add(xStDeriv);
                    }
                    else if (header.Text == ("Y" + Od))
                    {
                        ItemForA.SubItems.Add(yOdDeriv);
                    }
                    else if (header.Text == ("X" + Od))
                    {
                        ItemForA.SubItems.Add(xOdDeriv);
                    }
                    else if (header.Text == ("Y" + Do))
                    {
                        ItemForA.SubItems.Add(yDoDeriv);
                    }
                    else if (header.Text == ("X" + Do))
                    {
                        ItemForA.SubItems.Add(xDoDeriv);
                    }
                    else
                    {
                        ItemForA.SubItems.Add("0");
                    }
                }

                A.Items.Add(ItemForA);
            }
            #endregion Kutevi

            #region Duzine

            foreach (ListViewItem item in Duzine.Items)
            {
                string stajaliste = item.SubItems[1].Text;
                string vizura = item.SubItems[2].Text;

                string yStDeriv = item.SubItems[8].Text;
                string xStDeriv = item.SubItems[9].Text;
                string yVzDeriv = item.SubItems[10].Text;
                string xVzDeriv = item.SubItems[11].Text;

                ListViewItem ItemForA = new ListViewItem("Duzina: " + stajaliste + "-" + vizura);

                foreach (ColumnHeader header in A.Columns)
                {
                    if (header.Text == "Mjerenje")
                    {
                    }
                    else if (header.Text == ("Y" + stajaliste))
                    {
                        ItemForA.SubItems.Add(yStDeriv);
                    }
                    else if (header.Text == ("X" + stajaliste))
                    {
                        ItemForA.SubItems.Add(xStDeriv);
                    }
                    else if (header.Text == ("Y" + vizura))
                    {
                        ItemForA.SubItems.Add(yVzDeriv);
                    }
                    else if (header.Text == ("X" + vizura))
                    {
                        ItemForA.SubItems.Add(xVzDeriv);
                    }
                    else
                    {
                        ItemForA.SubItems.Add("0");
                    }
                }

                A.Items.Add(ItemForA);

            }

            #endregion Duzine

            #region Bazni Vektori

            foreach (ListViewItem item in BazniVektori.Items)
            {
                string stajaliste = item.SubItems[1].Text;
                string vizura = item.SubItems[2].Text;


                ListViewItem ItemForA = new ListViewItem("Baz. Vek. Y: " + stajaliste + "-" + vizura);

                foreach (ColumnHeader header in A.Columns)
                {
                    if (header.Text == "Mjerenje")
                    {
                    }
                    else if (header.Text == ("Y" + stajaliste))
                    {
                        ItemForA.SubItems.Add("-1");
                    }
                    else if (header.Text == ("Y" + vizura))
                    {
                        ItemForA.SubItems.Add("1");
                    }
                    else
                    {
                        ItemForA.SubItems.Add("0");
                    }
                }

                A.Items.Add(ItemForA);

                ListViewItem ItemForAx = new ListViewItem("Baz. Vek. X: " + stajaliste + "-" + vizura);

                foreach (ColumnHeader header in A.Columns)
                {
                    if (header.Text == "Mjerenje")
                    {
                    }
                    else if (header.Text == ("X" + stajaliste))
                    {
                        ItemForAx.SubItems.Add("-1");
                    }
                    else if (header.Text == ("X" + vizura))
                    {
                        ItemForAx.SubItems.Add("1");
                    }
                    else
                    {
                        ItemForAx.SubItems.Add("0");
                    }
                }

                A.Items.Add(ItemForAx);

            }

            #endregion Bazni Vektori

            #region Azimuti

            foreach (ListViewItem item in Azimuti.Items)
            {
                string stajaliste = item.SubItems[1].Text;
                string vizura = item.SubItems[2].Text;

                string yStDeriv = item.SubItems[8].Text;
                string xStDeriv = item.SubItems[9].Text;
                string yVzDeriv = item.SubItems[10].Text;
                string xVzDeriv = item.SubItems[11].Text;

                ListViewItem ItemForA = new ListViewItem("Azimut: " + stajaliste + "-" + vizura);

                foreach (ColumnHeader header in A.Columns)
                {
                    if (header.Text == "Mjerenje")
                    {
                    }
                    else if (header.Text == ("Y" + stajaliste))
                    {
                        ItemForA.SubItems.Add(yStDeriv);
                    }
                    else if (header.Text == ("X" + stajaliste))
                    {
                        ItemForA.SubItems.Add(yStDeriv);
                    }
                    else if (header.Text == ("Y" + vizura))
                    {
                        ItemForA.SubItems.Add(yVzDeriv);
                    }
                    else if (header.Text == ("X" + vizura))
                    {
                        ItemForA.SubItems.Add(xVzDeriv);
                    }
                    else
                    {
                        ItemForA.SubItems.Add("0");
                    }
                }
                A.Items.Add(ItemForA);

            }
            #endregion Azimuti
        }

        public void FormirajP(ListView P, ListView Koordinate, ListView Pravci, ListView Kutevi, ListView Duzine, ListView BazniVektori, ListView Azimuti)
        {
            #region postavke ListView-a

            P.Clear();
            P.Columns.Add("Mjerenje");

            int brojMjerenja = Pravci.Items.Count + Kutevi.Items.Count + Duzine.Items.Count + BazniVektori.Items.Count;

            foreach (ListViewItem item in Pravci.Items)
            {
                string mjerenje = "Pravac: " + item.SubItems[1].Text + "-" + item.SubItems[2].Text;
                P.Columns.Add(mjerenje);
            }

            foreach (ListViewItem item in Kutevi.Items)
            {
                string mjerenje = "Kut: " + item.SubItems[1].Text + "-" + item.SubItems[2].Text + "-" + item.SubItems[3].Text;
                P.Columns.Add(mjerenje);
            }

            foreach (ListViewItem item in Duzine.Items)
            {
                string mjerenje = "Duzina: " + item.SubItems[1].Text + "-" + item.SubItems[2].Text;
                P.Columns.Add(mjerenje);
            }

            foreach (ListViewItem item in BazniVektori.Items)
            {
                string mjerenjeY = "Baz. Vek. Y: " + item.SubItems[1].Text + "-" + item.SubItems[2].Text;
                string mjerenjeX = "Baz. Vek. X: " + item.SubItems[1].Text + "-" + item.SubItems[2].Text;
                P.Columns.Add(mjerenjeY);
                P.Columns.Add(mjerenjeX);
            }

            foreach (ListViewItem item in Azimuti.Items)
            {
                string mjerenje = "Azimut: " + item.SubItems[1].Text + "-" + item.SubItems[2].Text;
                P.Columns.Add(mjerenje);
            }

            #endregion postavke ListView-a

            #region Pravci

            foreach (ListViewItem item in Pravci.Items)
            {
                string mjerenje = "Pravac: " + item.SubItems[1].Text + "-" + item.SubItems[2].Text;
                string tezina = item.SubItems[8].Text;


                ListViewItem ItemForP = new ListViewItem(mjerenje);

                foreach (ColumnHeader header in P.Columns)
                {
                    if (header.Text == "Mjerenje")
                    {
                    }
                    else if (header.Text == mjerenje)
                    {
                        ItemForP.SubItems.Add(tezina);
                    }
                    else
                    {
                        ItemForP.SubItems.Add("0");
                    }
                }

                P.Items.Add(ItemForP);

            }

            #endregion Pravci

            #region Kutevi

            foreach (ListViewItem item in Kutevi.Items)
            {
                string mjerenje = "Kut: " + item.SubItems[1].Text + "-" + item.SubItems[2].Text + "-" + item.SubItems[3].Text;
                string tezina = item.SubItems[7].Text;


                ListViewItem ItemForP = new ListViewItem(mjerenje);

                foreach (ColumnHeader header in P.Columns)
                {
                    if (header.Text == "Mjerenje")
                    {
                    }
                    else if (header.Text == mjerenje)
                    {
                        ItemForP.SubItems.Add(tezina);
                    }
                    else
                    {
                        ItemForP.SubItems.Add("0");
                    }
                }

                P.Items.Add(ItemForP);

            }

            #endregion Kutevi

            #region Duzine

            foreach (ListViewItem item in Duzine.Items)
            {
                string mjerenje = "Duzina: " + item.SubItems[1].Text + "-" + item.SubItems[2].Text;
                string tezina = item.SubItems[6].Text;


                ListViewItem ItemForP = new ListViewItem(mjerenje);

                foreach (ColumnHeader header in P.Columns)
                {
                    if (header.Text == "Mjerenje")
                    {
                    }
                    else if (header.Text == mjerenje)
                    {
                        ItemForP.SubItems.Add(tezina);
                    }
                    else
                    {
                        ItemForP.SubItems.Add("0");
                    }
                }

                P.Items.Add(ItemForP);

            }

            #endregion Duzine

            #region Bazni Vektori

            foreach (ListViewItem item in BazniVektori.Items)
            {
                string mjerenjeY = "Baz. Vek. Y: " + item.SubItems[1].Text + "-" + item.SubItems[2].Text;
                string mjerenjeX = "Baz. Vek. X: " + item.SubItems[1].Text + "-" + item.SubItems[2].Text;

                string tezinaY = item.SubItems[9].Text;
                string tezinaYX = item.SubItems[10].Text;
                string tezinaX = item.SubItems[11].Text;


                ListViewItem ItemForP = new ListViewItem(mjerenjeY);

                foreach (ColumnHeader header in P.Columns)
                {
                    if (header.Text == "Mjerenje")
                    {
                    }
                    else if (header.Text == mjerenjeY)
                    {
                        ItemForP.SubItems.Add(tezinaY);
                    }
                    else if (header.Text == mjerenjeX)
                    {
                        ItemForP.SubItems.Add(tezinaYX);
                    }
                    else
                    {
                        ItemForP.SubItems.Add("0");
                    }
                }

                P.Items.Add(ItemForP);

                ListViewItem ItemForPx = new ListViewItem(mjerenjeX);

                foreach (ColumnHeader header in P.Columns)
                {
                    if (header.Text == "Mjerenje")
                    {
                    }
                    else if (header.Text == mjerenjeX)
                    {
                        ItemForPx.SubItems.Add(tezinaX);
                    }
                    else if (header.Text == mjerenjeY)
                    {
                        ItemForPx.SubItems.Add(tezinaYX);
                    }
                    else
                    {
                        ItemForPx.SubItems.Add("0");
                    }
                }

                P.Items.Add(ItemForPx);

            }

            #endregion Bazni Vektori

            #region Azimuti

            foreach (ListViewItem item in Azimuti.Items)
            {
                string mjerenje = "Azimut: " + item.SubItems[0].Text + "-" + item.SubItems[1].Text;
                string tezina = item.SubItems[6].Text;


                ListViewItem ItemForP = new ListViewItem(mjerenje);

                foreach (ColumnHeader header in P.Columns)
                {
                    if (header.Text == "Mjerenje")
                    {
                    }
                    else if (header.Text == mjerenje)
                    {
                        ItemForP.SubItems.Add(tezina);
                    }
                    else
                    {
                        ItemForP.SubItems.Add("0");
                    }
                }

                P.Items.Add(ItemForP);

            }

            #endregion Azimuti
        }

        public void Formirajf(ListView f, ListView Koordinate, ListView Pravci, ListView Kutevi, ListView Duzine, ListView BazniVektori, ListView Azimuti)
        {
            f.Items.Clear();

            #region Pravci

            foreach (ListViewItem item in Pravci.Items)
            {
                string mjerenje = "Pravac: " + item.SubItems[1].Text + "-" + item.SubItems[2].Text;
                string F = item.SubItems[7].Text;

                ListViewItem ItemForf = new ListViewItem(mjerenje);
                ItemForf.SubItems.Add(F);
                f.Items.Add(ItemForf);
            }

            #endregion Pravci

            #region Kutevi

            foreach (ListViewItem item in Kutevi.Items)
            {
                string mjerenje = "Kut: " + item.SubItems[1].Text + "-" + item.SubItems[2].Text + "-" + item.SubItems[3].Text;
                string F = item.SubItems[6].Text;

                ListViewItem ItemForf = new ListViewItem(mjerenje);
                ItemForf.SubItems.Add(F);
                f.Items.Add(ItemForf);
            }

            #endregion Kutevi

            #region Duzine

            foreach (ListViewItem item in Duzine.Items)
            {
                string mjerenje = "Duzina: " + item.SubItems[1].Text + "-" + item.SubItems[2].Text;
                string F = item.SubItems[5].Text;

                ListViewItem ItemForf = new ListViewItem(mjerenje);
                ItemForf.SubItems.Add(F);
                f.Items.Add(ItemForf);
            }

            #endregion Duzine

            #region Bazni Vektori

            foreach (ListViewItem item in BazniVektori.Items)
            {
                string mjerenjeY = "Baz. Vek. Y: " + item.SubItems[1].Text + "-" + item.SubItems[2].Text;
                string mjerenjeX = "Baz. Vek. X: " + item.SubItems[1].Text + "-" + item.SubItems[2].Text;
                string yF = item.SubItems[5].Text;
                string xF = item.SubItems[8].Text;

                ListViewItem ItemForfy = new ListViewItem(mjerenjeY);
                ItemForfy.SubItems.Add(yF);
                f.Items.Add(ItemForfy);

                ListViewItem ItemForfx = new ListViewItem(mjerenjeX);
                ItemForfx.SubItems.Add(xF);
                f.Items.Add(ItemForfx);
            }

            #endregion Bazni Vektori

            #region Azimuti

            foreach (ListViewItem item in Azimuti.Items)
            {
                string mjerenje = "Azimut: " + item.SubItems[1].Text + "-" + item.SubItems[2].Text;
                string F = item.SubItems[5].Text;

                ListViewItem ItemForf = new ListViewItem(mjerenje);
                ItemForf.SubItems.Add(F);
                f.Items.Add(ItemForf);
            }

            #endregion Azimuti
        }

        public void MinimalniTragNaSveTockeMatricaG(bool minTragSveTocke, ListView G, ListView Koordinate, ListView Pravci, ListView Kutevi, ListView Duzine, ListView BazniVektori)
        {
            if (minTragSveTocke == true)
            {
            }

        }

        // ------------------------------
        public void FormirajG(ListView G, ListView Tocke, ListView Y, ListView X, ListView Pravci)
        {
            G.Clear();
            G.Columns.Add("Koordinata");
            G.Columns.Add("Ty [Translacija po y]");
            G.Columns.Add("Tx [Translacija po x]");
            G.Columns.Add("R [Rotacija]");
            G.Columns.Add("m [Mjerilo]");

            List<double> TyTeziste = new List<double>();
            List<double> TxTeziste = new List<double>();
            List<double> Rxy = new List<double>();
            List<double> Mxy = new List<double>();

            #region Ksi i Eta

            double tezisteY = 0;
            double tezisteX = 0;
            int i = 0;

            foreach (ListViewItem item in Y.Items)
            {
                if (item.Checked)
                {
                    tezisteY = tezisteY + Convert.ToDouble(item.SubItems[0].Text);
                    i++;
                }
            }

            int z = 0;

            foreach (ListViewItem item in X.Items)
            {
                if (item.Checked)
                {
                    tezisteX = tezisteX + Convert.ToDouble(item.SubItems[0].Text);
                    z++;
                }
            }

            int brojTocaka = i;
            tezisteY = tezisteY / i;
            tezisteX = tezisteX / z;
            
            double g = 0;

            foreach (ListViewItem item in Y.Items)
            {
                    TyTeziste.Add(Convert.ToDouble(item.SubItems[0].Text) - tezisteY);

            }

            foreach (ListViewItem item in X.Items)
            {
                    TxTeziste.Add(Convert.ToDouble(item.SubItems[0].Text) - tezisteX);

            }

            for (i = 0; i < X.Items.Count; i++)
            {
                    g = g + Math.Pow(Convert.ToDouble(Y.Items[i].SubItems[0].Text) - tezisteY, 2) +
                        Math.Pow(Convert.ToDouble(X.Items[i].SubItems[0].Text) - tezisteX, 2);
            }


            g = Math.Sqrt(g);
            

            List<double> eta = new List<double>();
            List<double> ksi = new List<double>();

            //Y
            foreach (double e in TyTeziste)
            {
                eta.Add(e / g);
            }
            //X
            foreach (double k in TxTeziste)
            {
                ksi.Add(k / g);
            }
            //MessageBox.Show(ksi.Count.ToString(), eta.Count.ToString());

            #endregion Ksi i Eta

            #region Z nepoznati parametar

            Dictionary<string, double> zNepoznatiParametar = new Dictionary<string, double>();

            foreach (ListViewItem item in Pravci.Items)
            {
                if (!zNepoznatiParametar.ContainsKey(item.SubItems[1].Text))
                {
                    zNepoznatiParametar.Add(item.SubItems[1].Text, 0);
                }
            }

            #endregion Z nepoznati parametar

            double TxiTy = 1 / Math.Sqrt(brojTocaka);

            for (int j = 0; j < X.Items.Count; j++)
            {
                ListViewItem lviY = new ListViewItem("Y" + Tocke.Items[j].SubItems[0].Text);
                //
                //

                if (Y.Items[j].Checked)
                {
                    //MessageBox.Show(eta[0].ToString() + " " + g.ToString(), Y.Items[j].Checked.ToString());
                    lviY.SubItems.Add(TxiTy.ToString());
                    lviY.SubItems.Add("0");
                    lviY.SubItems.Add((-ksi[j]).ToString());
                    lviY.SubItems.Add(eta[j].ToString());

                }
                else
                {
                    lviY.SubItems.Add("0");
                    lviY.SubItems.Add("0");
                    lviY.SubItems.Add("0");
                    lviY.SubItems.Add("0");
                }

                G.Items.Add(lviY);

                ListViewItem lviX = new ListViewItem("X" + Tocke.Items[j].SubItems[0].Text);



                if (X.Items[j].Checked)
                {
                    lviX.SubItems.Add("0");
                    lviX.SubItems.Add(TxiTy.ToString());
                    lviX.SubItems.Add(eta[j].ToString());
                    lviX.SubItems.Add(ksi[j].ToString());

                }
                else
                {
                    lviX.SubItems.Add("0");
                    lviX.SubItems.Add("0");
                    lviX.SubItems.Add("0");
                    lviX.SubItems.Add("0");
                }


                G.Items.Add(lviX);

            }

            foreach (KeyValuePair<string, double> pair in zNepoznatiParametar)
            {
                ListViewItem lviZ = new ListViewItem("Z" + pair.Key);
                lviZ.SubItems.Add("0");
                lviZ.SubItems.Add("0");
                lviZ.SubItems.Add("0");
                lviZ.SubItems.Add("0");
                G.Items.Add(lviZ);
            }


        }
        
        #region izbrisi iz stupca-reda

        private void RemoveColumnFormListView(ListView lv, string ColumnName)
        {
            int i = 0;

            foreach (ColumnHeader header in lv.Columns)
            {
                if (header.Text == ColumnName)
                {
                    lv.Columns.Remove(header);
                    break;
                }
                i++;
            }

            ListView listV = new ListView();

            foreach (ListViewItem lvi in lv.Items)
            {
                ListViewItem item = new ListViewItem(lvi.SubItems[0].Text);

                for (int j = 1; j < lvi.SubItems.Count; j++)
                {
                    if (j != i)
                    {
                        item.SubItems.Add(lvi.SubItems[j].Text);
                    }

                }
                lv.Items.Remove(lvi);
                listV.Items.Add(item);

            }

            lv.Items.Clear();

            foreach (ListViewItem item in listV.Items)
            {
                ListViewItem itemClone = new ListViewItem();
                lv.Items.Add((ListViewItem)item.Clone());
            }

            listV.Clear();

        }

        private void RemoveRowFormListView(ListView lv, string FirstSubItemText)
        {
            foreach (ListViewItem lvi in lv.Items)
            {
                if (lvi.SubItems[0].Text == FirstSubItemText)
                    lv.Items.Remove(lvi);
            }
        }

        #endregion izbrisi iz stupca-reda

        public void IzjednacenjePrisila(bool Prisila, ListView A, ListView P, ListView f, ListView G, ListView Tocke, ListView Y, ListView X)
        {
            if (Prisila == true)
            {
                G.Items.Clear();
                int kontrola = 0;

                foreach(ListViewItem item in Y.Items)
                {
                    if (item.Checked)
                        kontrola++;
                }

                foreach (ListViewItem item in X.Items)
                {
                    if (item.Checked)
                        kontrola++;
                }

                if (kontrola < 3)
                {
                    MessageBox.Show("Broj parametara koji čine datum je manji od minimalnog \nMinimalnal broj koordinata je 3 \nBroj unijetih koordinata je " + kontrola.ToString() + "\nIzjednačenje je obustavljeno", "Formiranje matrica za izjednačenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    A.Items.Clear();
                    P.Items.Clear();
                    f.Items.Clear();
                }
                else
                {

                    //izbacivanje koordinata koje cine datum
                    for (int i = 0; i < Tocke.Items.Count; i++)
                    {
                        if(Y.Items[i].Checked)
                            RemoveColumnFormListView(A, "Y" + Tocke.Items[i].SubItems[0].Text);

                        if (X.Items[i].Checked)
                            RemoveColumnFormListView(A, "X" + Tocke.Items[i].SubItems[0].Text);
                    }



                }
            }
        }

        public void KontrolaIzjednacenjePrisila(bool Prisila, ListView A)
        {
            if (Prisila == true)
            {
                List<string> itemsToRemove = new List<string>();

                foreach (ListViewItem item in A.Items)
                {
                    bool izbaci = true;

                    for (int i = 1; i < item.SubItems.Count; i++)
                    {

                        if (item.SubItems[i].Text != "0")
                        {
                            izbaci = false;
                            break;
                        }
                    }

                    if (izbaci == true)
                    {
                        MessageBox.Show("Postoji mjerenje između točaka koje čine datum. \nMjerenje " + item.SubItems[0].Text + " Izbacite jer će utjecati na rezultate izjednačenja", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
        }

        public void FormirajGKlasican(ListView G, ListView Tocke, ListView Y, ListView X, ListView Pravci)
        {
            G.Clear();
            G.Columns.Add("Koordinata");
            G.Columns.Add("Ty [Translacija po y]");
            G.Columns.Add("Tx [Translacija po x]");
            G.Columns.Add("R [Rotacija]");
            G.Columns.Add("m [Mjerilo]");

            bool Ty = true;
            bool Tx = true;
            bool R = true;
            bool m = true;

            for (int i = 0; i < Tocke.Items.Count; i++)
            {
                ListViewItem itemY = new ListViewItem("Y" + Tocke.Items[i].SubItems[0].Text);
                ListViewItem itemX = new ListViewItem("X" + Tocke.Items[i].SubItems[0].Text);


                if (Y.Items[i].Checked)
                {
                    #region uvijeti

                    if (Ty)
                    {

                        itemY.SubItems.Add("1");
                        itemY.SubItems.Add("0");
                        itemY.SubItems.Add("0");
                        itemY.SubItems.Add("0");

                        G.Items.Add(itemY);

                        Ty = false;
                    }
                    else if (Tx)
                    {

                        itemY.SubItems.Add("0");
                        itemY.SubItems.Add("1");
                        itemY.SubItems.Add("0");
                        itemY.SubItems.Add("0");

                        G.Items.Add(itemY);

                        Tx = false;
                    }
                    else if (R)
                    {

                        itemY.SubItems.Add("0");
                        itemY.SubItems.Add("0");
                        itemY.SubItems.Add("1");
                        itemY.SubItems.Add("0");

                        G.Items.Add(itemY);

                        R = false;
                    }
                    else if (m)
                    {
                        itemY.SubItems.Add("0");
                        itemY.SubItems.Add("0");
                        itemY.SubItems.Add("0");
                        itemY.SubItems.Add("1");

                        G.Items.Add(itemY);

                        m = false;
                    }
                    else
                    {
                        itemY.SubItems.Add("0");
                        itemY.SubItems.Add("0");
                        itemY.SubItems.Add("0");
                        itemY.SubItems.Add("0");

                        G.Items.Add(itemY);

                        m = false;
                    }

                    #endregion uvijeti
                }
                else
                {
                    MessageBox.Show("Y-" + Tocke.Items[i].SubItems[0].Text);
                    itemY.SubItems.Add("0");
                    itemY.SubItems.Add("0");
                    itemY.SubItems.Add("0");
                    itemY.SubItems.Add("0");

                    G.Items.Add(itemY);
                }

                if (X.Items[i].Checked)
                {

                    if (Ty)
                    {

                        itemX.SubItems.Add("1");
                        itemX.SubItems.Add("0");
                        itemX.SubItems.Add("0");
                        itemX.SubItems.Add("0");

                        G.Items.Add(itemX);

                        Ty = false;
                    }
                    else if (Tx)
                    {
                        itemX.SubItems.Add("0");
                        itemX.SubItems.Add("1");
                        itemX.SubItems.Add("0");
                        itemX.SubItems.Add("0");

                        G.Items.Add(itemX);

                        Tx = false;
                    }
                    else if (R)
                    {
                        itemX.SubItems.Add("0");
                        itemX.SubItems.Add("0");
                        itemX.SubItems.Add("1");
                        itemX.SubItems.Add("0");

                        G.Items.Add(itemX);

                        R = false;
                    }
                    else if (m)
                    {

                        itemX.SubItems.Add("0");
                        itemX.SubItems.Add("0");
                        itemX.SubItems.Add("0");
                        itemX.SubItems.Add("1");

                        G.Items.Add(itemX);

                        m = false;
                    }
                    else
                    {
                        itemX.SubItems.Add("0");
                        itemX.SubItems.Add("0");
                        itemX.SubItems.Add("0");
                        itemX.SubItems.Add("1");

                        G.Items.Add(itemX);
                    }

                }
                else
                {

                    itemX.SubItems.Add("0");
                    itemX.SubItems.Add("0");
                    itemX.SubItems.Add("0");
                    itemX.SubItems.Add("0");

                    G.Items.Add(itemX);
                }

            }

            #region Z nepoznati parametar

            Dictionary<string, double> zNepoznatiParametar = new Dictionary<string, double>();

            foreach (ListViewItem item in Pravci.Items)
            {
                if (!zNepoznatiParametar.ContainsKey(item.SubItems[1].Text))
                {
                    zNepoznatiParametar.Add(item.SubItems[1].Text, 0);
                }
            }

            foreach (KeyValuePair<string, double> pair in zNepoznatiParametar)
            {
                ListViewItem lviZ = new ListViewItem("Z" + pair.Key);
                lviZ.SubItems.Add("0");
                lviZ.SubItems.Add("0");
                lviZ.SubItems.Add("0");
                lviZ.SubItems.Add("0");
                G.Items.Add(lviZ);
            }

            #endregion Z nepoznati parametar


        }

        public void IzbacivanjeIzG(bool azimut, bool duzina, bool BazniVektor, ListView G)
        {
            //treba izbacit
            bool R = false;
            bool m = false;

            if (azimut)
                R = true;

            if (duzina)
                m = true;

            if(BazniVektor)
            {
                R = true;
                m = true;
            }

            if (m)
                RemoveColumnFormListView(G, "m [Mjerilo]");

            if (R)
                RemoveColumnFormListView(G, "R [Rotacija]");

        }

    }
}
