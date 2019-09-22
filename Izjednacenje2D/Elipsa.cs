using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Geodezija.MetodaNajmanjihKvadrata;
using Geodezija;
using MathNet.Numerics.LinearAlgebra.Double;

namespace Izjednacenje2D
{
    public class Elipsa
    {
        PosrednoIzjednacenje mnk;

        public Elipsa(PosrednoIzjednacenje mnk)
        {
            this.mnk = mnk;
        }

        public void elipsa(ListView lv, ListView tocke, ListView Y, ListView X, double sigmaNulaKvadrat, bool prisila)
        {
            int f;
            try
            {
                f = mnk.Ql.RowCount - mnk.Qx.RowCount + mnk.G.ColumnCount;
            }
            catch (Exception)
            {
                f = mnk.Ql.RowCount - mnk.Qx.RowCount;
            }
            

            lv.Clear();

            lv.Columns.Add("Tocka");

            lv.Columns.Add("Qx[yy]");
            lv.Columns.Add("Qx[xx]");
            lv.Columns.Add("Qx[yx]");

            lv.Columns.Add("λ1");
            lv.Columns.Add("λ2");
            lv.Columns.Add("R");

            lv.Columns.Add("a [1σ]");
            lv.Columns.Add("b [1σ]");
            lv.Columns.Add("Θ");
            lv.Columns.Add("a [1.96σ - 95% - 2F(0.05,2," + f.ToString() + ")]");
            lv.Columns.Add("b [1.96σ - 95% - 2F(0.05,2," + f.ToString() + ")]");
            lv.Columns.Add("a [X(0.05,2)]");
            lv.Columns.Add("b [X(0.05,2)]");
            lv.Columns.Add("a [X(0.025,2)]");
            lv.Columns.Add("b [X(0.025,2)]");
            lv.Columns.Add("a [X(0.01,2)]");
            lv.Columns.Add("b [X(0.01,2)]");

            lv.Columns.Add("a [σ 2F(0.05,2," + f.ToString() + ")]");
            lv.Columns.Add("b [σ 2F(0.05,2," + f.ToString() + ")]");
            lv.Columns.Add("a [σ X(0.05,2)]");
            lv.Columns.Add("b [σ X(0.05,2)]");
            lv.Columns.Add("a [σ X(0.025,2)]");
            lv.Columns.Add("b [σ X(0.025,2)]");
            lv.Columns.Add("a [σ X(0.01,2)]");
            lv.Columns.Add("b [σ X(0.01,2)]");

            lv.Columns.Add("a [s 2F(0.05,2," + f.ToString() + ")]");
            lv.Columns.Add("b [s 2F(0.05,2," + f.ToString() + ")]");
            lv.Columns.Add("a [s X(0.05,2)]");
            lv.Columns.Add("b [s X(0.05,2)]");
            lv.Columns.Add("a [s X(0.025,2)]");
            lv.Columns.Add("b [s X(0.025,2)]");
            lv.Columns.Add("a [s X(0.01,2)]");
            lv.Columns.Add("b [s X(0.01,2)]");




            int i = 0;
            foreach (ListViewItem tocka in tocke.Items)
            {
                if (!prisila)
                {
                    ElipsaApsolutna elipsa = new ElipsaApsolutna(mnk.Qx[i+1, i+1], mnk.Qx[i, i], mnk.Qx[i, i + 1]);
                    ElipsaApsolutna elipsa95 = new ElipsaApsolutna(mnk.Qx[i, i], mnk.Qx[i + 1, i + 1], mnk.Qx[i, i + 1], f, 0.05);

                    ListViewItem item = new ListViewItem(tocka.SubItems[0].Text);

                    item.SubItems.Add(mnk.Qx[i, i].ToString());
                    item.SubItems.Add(mnk.Qx[i + 1, i + 1].ToString());
                    item.SubItems.Add(mnk.Qx[i, i + 1].ToString());


                    item.SubItems.Add(elipsa.Lambda1.ToString());
                    item.SubItems.Add((elipsa.Lambda2).ToString());
                    item.SubItems.Add(elipsa.R.ToString());

                    item.SubItems.Add(elipsa.A.ToString());
                    item.SubItems.Add(elipsa.B.ToString());
                    item.SubItems.Add(elipsa.Theta.ToDMS().ToString());

                    //----

                    item.SubItems.Add(elipsa95.A.ToString());
                    item.SubItems.Add(elipsa95.B.ToString());

                    item.SubItems.Add((Math.Sqrt(elipsa.Lambda1 * Distribucije.ChiKvadrat(0.05,2))).ToString());
                    item.SubItems.Add((Math.Sqrt(elipsa.Lambda2 * Distribucije.ChiKvadrat(0.05, 2))).ToString());

                    item.SubItems.Add((Math.Sqrt(elipsa.Lambda1 * Distribucije.ChiKvadrat(0.025, 2))).ToString());
                    item.SubItems.Add((Math.Sqrt(elipsa.Lambda2 * Distribucije.ChiKvadrat(0.025, 2))).ToString());

                    item.SubItems.Add((Math.Sqrt(elipsa.Lambda1 * Distribucije.ChiKvadrat(0.01, 2))).ToString());
                    item.SubItems.Add((Math.Sqrt(elipsa.Lambda2 * Distribucije.ChiKvadrat(0.01, 2))).ToString());

                    //----

                    item.SubItems.Add((Math.Sqrt(sigmaNulaKvadrat) * elipsa95.A).ToString());
                    item.SubItems.Add((Math.Sqrt(sigmaNulaKvadrat) * elipsa95.B).ToString());

                    item.SubItems.Add((Math.Sqrt(sigmaNulaKvadrat*elipsa.Lambda1 * Distribucije.ChiKvadrat(0.05, 2))).ToString());
                    item.SubItems.Add((Math.Sqrt(sigmaNulaKvadrat*elipsa.Lambda2 * Distribucije.ChiKvadrat(0.05, 2))).ToString());

                    item.SubItems.Add((Math.Sqrt(sigmaNulaKvadrat*elipsa.Lambda1 * Distribucije.ChiKvadrat(0.025, 2))).ToString());
                    item.SubItems.Add((Math.Sqrt(sigmaNulaKvadrat*elipsa.Lambda2 * Distribucije.ChiKvadrat(0.025, 2))).ToString());

                    item.SubItems.Add((Math.Sqrt(sigmaNulaKvadrat*elipsa.Lambda1 * Distribucije.ChiKvadrat(0.01, 2))).ToString());
                    item.SubItems.Add((Math.Sqrt(sigmaNulaKvadrat*elipsa.Lambda2 * Distribucije.ChiKvadrat(0.01, 2))).ToString());

                    //----

                    item.SubItems.Add((Math.Sqrt(mnk.sKvadrat) * elipsa95.A).ToString());
                    item.SubItems.Add((Math.Sqrt(mnk.sKvadrat) * elipsa95.B).ToString());

                    item.SubItems.Add((Math.Sqrt(mnk.sKvadrat * elipsa.Lambda1 * Distribucije.ChiKvadrat(0.05, 2))).ToString());
                    item.SubItems.Add((Math.Sqrt(mnk.sKvadrat * elipsa.Lambda2 * Distribucije.ChiKvadrat(0.05, 2))).ToString());

                    item.SubItems.Add((Math.Sqrt(mnk.sKvadrat * elipsa.Lambda1 * Distribucije.ChiKvadrat(0.025, 2))).ToString());
                    item.SubItems.Add((Math.Sqrt(mnk.sKvadrat * elipsa.Lambda2 * Distribucije.ChiKvadrat(0.025, 2))).ToString());

                    item.SubItems.Add((Math.Sqrt(mnk.sKvadrat * elipsa.Lambda1 * Distribucije.ChiKvadrat(0.01, 2))).ToString());
                    item.SubItems.Add((Math.Sqrt(mnk.sKvadrat * elipsa.Lambda2 * Distribucije.ChiKvadrat(0.01, 2))).ToString());



                    lv.Items.Add(item);

                    i = i + 2;
                    
                }
                else
                {
                    if(!Y.Items[tocka.Index].Checked && !X.Items[tocka.Index].Checked)
                    {
                        ElipsaApsolutna elipsa = new ElipsaApsolutna(mnk.Qx[i, i], mnk.Qx[i + 1, i + 1], mnk.Qx[i, i + 1]);
                        //ElipsaApsolutna elipsa = new ElipsaApsolutna(mnk.Qx[i, i], mnk.Qx[i + 1, i + 1], mnk.Qx[i, i + 1], Math.Sqrt(mnk.sKvadrat));
                        ElipsaApsolutna elipsa95 = new ElipsaApsolutna(mnk.Qx[i, i], mnk.Qx[i + 1, i + 1], mnk.Qx[i, i + 1], Math.Sqrt(mnk.sKvadrat), f, 0.05);

                        ListViewItem item = new ListViewItem(tocka.SubItems[0].Text);
                        item.SubItems.Add(mnk.Qx[i, i].ToString());
                        item.SubItems.Add(mnk.Qx[i + 1, i + 1].ToString());
                        item.SubItems.Add(mnk.Qx[i, i + 1].ToString());
                        item.SubItems.Add(elipsa.Lambda1.ToString());
                        item.SubItems.Add(elipsa.Lambda2.ToString());
                        item.SubItems.Add(elipsa.R.ToString());
                        item.SubItems.Add(elipsa.A.ToString());
                        item.SubItems.Add(elipsa.B.ToString());
                        item.SubItems.Add(elipsa.Theta.ToDMS().ToString());
                        item.SubItems.Add(elipsa95.A.ToString());
                        item.SubItems.Add(elipsa95.B.ToString());

                        lv.Items.Add(item);

                        i = i + 2;
                    }
                    else
                    {
                        if (!Y.Items[tocka.Index].Checked)
                            i++;

                        if (!X.Items[tocka.Index].Checked)
                            i++;

                        ListViewItem item = new ListViewItem(tocka.SubItems[0].Text);
                        lv.Items.Add(item);

                    }
                }
                
            }
            

            
        }

        public void relativnaElipsa()
        {

        }
    }
}
