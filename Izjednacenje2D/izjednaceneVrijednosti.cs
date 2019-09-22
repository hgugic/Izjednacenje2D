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
    public class izjednaceneVrijednosti
    {
        PosrednoIzjednacenje mnk;

        public izjednaceneVrijednosti(PosrednoIzjednacenje mnk)
        {
            this.mnk = mnk;
            //this.sigmaNulaKvadrat = sigmaNulaKvadrat;
        }

        private string IzjednacenoMjerenje(string mjerenje, double popravka)
        {
            return (double.Parse(mjerenje) + popravka / 1000).ToString();
        }

        private string IzjednacenoMjerenjeKutno(string mjerenje, string popravka)
        {
            DMS Mjereno = DMS.Parse(mjerenje);
            Seconds v = Seconds.Parse(popravka);

            DMS izjednaceno = Mjereno + v;

            double izmjereno = izjednaceno.ToRad().ToDouble();

            if (izmjereno > 2 * Math.PI)
                izmjereno = izmjereno - 2 * Math.PI;
            else if(izmjereno <0)
                izmjereno = izmjereno + 2 * Math.PI;



            return (new Rad(izmjereno)).ToDMS().ToString();
        }

        public void lvMjerenja(ListView lv, ListView pravac, ListView kut, ListView duzina, ListView bazni, ListView azimut, double sigmaNulaKvadrat)
        {
            lv.Clear();

            lv.Columns.Add("Mjerenje");
            lv.Columns.Add("Izmjereno");
            lv.Columns.Add("Popravka [mm/\"]");
            lv.Columns.Add("Izjednaceno mjerenje");
            lv.Columns.Add("Qî[i,i]");
            lv.Columns.Add("√Qî[i,i]");
            lv.Columns.Add("σ² Qî[i,i]");
            lv.Columns.Add("σ √Qî[i,i] (st. dev)");
            lv.Columns.Add("s² Qî[i,i]");
            lv.Columns.Add("s √Qî[i,i] (st. dev)");

            int i = 0;

            #region pravac

            foreach (ListViewItem p in pravac.Items)
            {
                string stajaliste = p.SubItems[1].Text;
                string vizura = p.SubItems[2].Text;

                ListViewItem item = new ListViewItem("Pravac: " + stajaliste + "-" + vizura);
                item.SubItems.Add(p.SubItems[3].Text);
                item.SubItems.Add(mnk.v[i].ToString());
                item.SubItems.Add(IzjednacenoMjerenjeKutno(p.SubItems[3].Text, mnk.v[i].ToString()));

                item.SubItems.Add(mnk.Qlcap[i, i].ToString());
                item.SubItems.Add((Math.Sqrt(mnk.Qlcap[i, i]).ToString()));


                item.SubItems.Add((sigmaNulaKvadrat * mnk.Qlcap[i, i]).ToString());
                item.SubItems.Add((Math.Sqrt(sigmaNulaKvadrat * mnk.Qlcap[i, i]).ToString()));

                item.SubItems.Add((mnk.sKvadrat * mnk.Qlcap[i, i]).ToString());
                item.SubItems.Add((Math.Sqrt(mnk.sKvadrat * mnk.Qlcap[i, i]).ToString()));

                i++;

                lv.Items.Add(item);
            }

            #endregion pravac

            #region kut

            foreach (ListViewItem p in kut.Items)
            {
                string stajaliste = p.SubItems[1].Text;
                string Od = p.SubItems[2].Text;
                string Do = p.SubItems[3].Text;

                ListViewItem item = new ListViewItem("Kut: " + stajaliste + "-" + Od + "-" + Do);
                item.SubItems.Add(p.SubItems[4].Text);
                item.SubItems.Add(mnk.v[i].ToString());
                item.SubItems.Add(IzjednacenoMjerenjeKutno(p.SubItems[4].Text, mnk.v[i].ToString()));

                item.SubItems.Add(mnk.Qlcap[i, i].ToString());
                item.SubItems.Add((Math.Sqrt(mnk.Qlcap[i, i]).ToString()));


                item.SubItems.Add((sigmaNulaKvadrat * mnk.Qlcap[i, i]).ToString());
                item.SubItems.Add((Math.Sqrt(sigmaNulaKvadrat * mnk.Qlcap[i, i]).ToString()));

                item.SubItems.Add((mnk.sKvadrat * mnk.Qlcap[i, i]).ToString());
                item.SubItems.Add((Math.Sqrt(mnk.sKvadrat * mnk.Qlcap[i, i]).ToString()));

                i++;

                lv.Items.Add(item);
            }

            #endregion kut

            #region duzina

            foreach (ListViewItem p in duzina.Items)
            {
                string stajaliste = p.SubItems[1].Text;
                string vizura = p.SubItems[2].Text;

                ListViewItem item = new ListViewItem("Duzina: " + stajaliste + "-" + vizura);
                item.SubItems.Add(p.SubItems[3].Text);
                item.SubItems.Add(mnk.v[i].ToString());
                item.SubItems.Add(IzjednacenoMjerenje(p.SubItems[3].Text, (double)mnk.v[i]));

                item.SubItems.Add(mnk.Qlcap[i, i].ToString());
                item.SubItems.Add((Math.Sqrt(mnk.Qlcap[i, i]).ToString()));


                item.SubItems.Add((sigmaNulaKvadrat * mnk.Qlcap[i, i]).ToString());
                item.SubItems.Add((Math.Sqrt(sigmaNulaKvadrat * mnk.Qlcap[i, i]).ToString()));

                item.SubItems.Add((mnk.sKvadrat * mnk.Qlcap[i, i]).ToString());
                item.SubItems.Add((Math.Sqrt(mnk.sKvadrat * mnk.Qlcap[i, i]).ToString()));

                i++;

                lv.Items.Add(item);
            }

            #endregion duzina

            #region bazni vektor

            foreach (ListViewItem p in bazni.Items)
            {
                string stajaliste = p.SubItems[1].Text;
                string vizura = p.SubItems[2].Text;

                ListViewItem item = new ListViewItem("Baz. Vek. Y: " + stajaliste + "-" + vizura);
                item.SubItems.Add(p.SubItems[3].Text);
                item.SubItems.Add(mnk.v[i].ToString());
                item.SubItems.Add(IzjednacenoMjerenje(p.SubItems[3].Text, mnk.v[i]));

                item.SubItems.Add(mnk.Qlcap[i, i].ToString());
                item.SubItems.Add((Math.Sqrt(mnk.Qlcap[i, i]).ToString()));


                item.SubItems.Add((sigmaNulaKvadrat * mnk.Qlcap[i, i]).ToString());
                item.SubItems.Add((Math.Sqrt(sigmaNulaKvadrat * mnk.Qlcap[i, i]).ToString()));

                item.SubItems.Add((mnk.sKvadrat * mnk.Qlcap[i, i]).ToString());
                item.SubItems.Add((Math.Sqrt(mnk.sKvadrat * mnk.Qlcap[i, i]).ToString()));

                i++;

                lv.Items.Add(item);


                ListViewItem itemX = new ListViewItem("Baz. Vek. X: " + stajaliste + "-" + vizura);
                itemX.SubItems.Add(p.SubItems[6].Text);
                itemX.SubItems.Add(mnk.v[i].ToString());
                itemX.SubItems.Add(IzjednacenoMjerenje(p.SubItems[6].Text, mnk.v[i]));

                itemX.SubItems.Add(mnk.Qlcap[i, i].ToString());
                itemX.SubItems.Add((Math.Sqrt(mnk.Qlcap[i, i]).ToString()));


                itemX.SubItems.Add((sigmaNulaKvadrat * mnk.Qlcap[i, i]).ToString());
                itemX.SubItems.Add((Math.Sqrt(sigmaNulaKvadrat * mnk.Qlcap[i, i]).ToString()));

                itemX.SubItems.Add((mnk.sKvadrat * mnk.Qlcap[i, i]).ToString());
                itemX.SubItems.Add((Math.Sqrt(mnk.sKvadrat * mnk.Qlcap[i, i]).ToString()));

                i++;

                lv.Items.Add(itemX);
            }

            #endregion bazni vektor

            #region azimut

            foreach (ListViewItem p in azimut.Items)
            {
                string stajaliste = p.SubItems[1].Text;
                string vizura = p.SubItems[2].Text;

                ListViewItem item = new ListViewItem("Pravac: " + stajaliste + "-" + vizura);
                item.SubItems.Add(p.SubItems[3].Text);
                item.SubItems.Add(mnk.v[i].ToString());
                item.SubItems.Add(IzjednacenoMjerenjeKutno(p.SubItems[3].Text, mnk.v[i].ToString()));

                item.SubItems.Add(mnk.Qlcap[i, i].ToString());
                item.SubItems.Add((Math.Sqrt(mnk.Qlcap[i, i]).ToString()));


                item.SubItems.Add((sigmaNulaKvadrat * mnk.Qlcap[i, i]).ToString());
                item.SubItems.Add((Math.Sqrt(sigmaNulaKvadrat * mnk.Qlcap[i, i]).ToString()));

                item.SubItems.Add((mnk.sKvadrat * mnk.Qlcap[i, i]).ToString());
                item.SubItems.Add((Math.Sqrt(mnk.sKvadrat * mnk.Qlcap[i, i]).ToString()));

                i++;

                lv.Items.Add(item);
            }

            #endregion azimut
        }

        public void IzjednaceneTocke(ListView lv, ListView tocke, ListView Y, ListView X, double sigmaNulaKvadrat, bool prisila)
        {
            lv.Clear();

            lv.Columns.Add("Tocka [koordinata]");
            lv.Columns.Add("Koordinata");
            lv.Columns.Add("Popravka [mm]");
            lv.Columns.Add("Izjednacena koordinata");
            lv.Columns.Add("Qx[i,i]");
            lv.Columns.Add("√Qx[i,i]");
            lv.Columns.Add("σ² Qx[i,i]");
            lv.Columns.Add("σ √Qx[i,i] (st. dev)");
            lv.Columns.Add("s² Qx[i,i]");
            lv.Columns.Add("s √Qx[i,i] (st. dev)");

            DenseVector Qdiag =(DenseVector) mnk.Qx.Diagonal();

            int i = 0;
            foreach (ListViewItem tocka in tocke.Items)
            {
                if (!prisila)
                {
                    #region Y

                    ListViewItem item = new ListViewItem("Y" + tocka.SubItems[0].Text);
                    item.SubItems.Add(Y.Items[tocka.Index].SubItems[0].Text);
                    item.SubItems.Add(mnk.x[i].ToString());
                    item.SubItems.Add(IzjednacenoMjerenje(Y.Items[tocka.Index].SubItems[0].Text, mnk.x[i]).ToString());

                    item.SubItems.Add(mnk.Qx[i, i].ToString());
                    item.SubItems.Add((Math.Sqrt(mnk.Qx[i, i]).ToString()));


                    item.SubItems.Add((sigmaNulaKvadrat * mnk.Qx[i, i]).ToString());
                    item.SubItems.Add((Math.Sqrt(sigmaNulaKvadrat * mnk.Qx[i, i]).ToString()));

                    item.SubItems.Add((mnk.sKvadrat * mnk.Qx[i, i]).ToString());
                    item.SubItems.Add((Math.Sqrt(mnk.sKvadrat * mnk.Qx[i, i]).ToString()));

                    i++;
                  
                    lv.Items.Add(item);

                    #endregion Y

                    #region X

                    ListViewItem itemX = new ListViewItem("X" + tocka.SubItems[0].Text);
                    itemX.SubItems.Add(X.Items[tocka.Index].SubItems[0].Text);
                    itemX.SubItems.Add(mnk.x[i].ToString());
                    itemX.SubItems.Add(IzjednacenoMjerenje(X.Items[tocka.Index].SubItems[0].Text, mnk.x[i]).ToString());

                    itemX.SubItems.Add(mnk.Qx[i, i].ToString());
                    itemX.SubItems.Add((Math.Sqrt(mnk.Qx[i, i]).ToString()));


                    itemX.SubItems.Add((sigmaNulaKvadrat * mnk.Qx[i, i]).ToString());
                    itemX.SubItems.Add((Math.Sqrt(sigmaNulaKvadrat * mnk.Qx[i, i]).ToString()));

                    itemX.SubItems.Add((mnk.sKvadrat * mnk.Qx[i, i]).ToString());
                    itemX.SubItems.Add((Math.Sqrt(mnk.sKvadrat * mnk.Qx[i, i]).ToString()));

                    i++;

                    lv.Items.Add(itemX);

                    #endregion X
                }
                else
                {

                    if (!Y.Items[tocka.Index].Checked)
                    {
                        #region Y

                        ListViewItem item = new ListViewItem("Y" + tocka.SubItems[0].Text);
                        item.SubItems.Add(Y.Items[tocka.Index].SubItems[0].Text);
                        item.SubItems.Add(mnk.x[i].ToString());
                        item.SubItems.Add(IzjednacenoMjerenje(Y.Items[tocka.Index].SubItems[0].Text, mnk.x[i]).ToString());

                        item.SubItems.Add(mnk.Qx[i, i].ToString());
                        item.SubItems.Add((Math.Sqrt(mnk.Qx[i, i]).ToString()));


                        item.SubItems.Add((sigmaNulaKvadrat * mnk.Qx[i, i]).ToString());
                        item.SubItems.Add((Math.Sqrt(sigmaNulaKvadrat * mnk.Qx[i, i]).ToString()));

                        item.SubItems.Add((mnk.sKvadrat * mnk.Qx[i, i]).ToString());
                        item.SubItems.Add((Math.Sqrt(mnk.sKvadrat * mnk.Qx[i, i]).ToString()));

                        i++;

                        lv.Items.Add(item);

                        #endregion Y
                    }

                    if (!X.Items[tocka.Index].Checked)
                    {
                        #region X

                        ListViewItem itemX = new ListViewItem("X" + tocka.SubItems[0].Text);
                        itemX.SubItems.Add(X.Items[tocka.Index].SubItems[0].Text);
                        itemX.SubItems.Add(mnk.x[i].ToString());
                        itemX.SubItems.Add(IzjednacenoMjerenje(X.Items[tocka.Index].SubItems[0].Text, mnk.x[i]).ToString());

                        itemX.SubItems.Add(mnk.Qx[i, i].ToString());
                        itemX.SubItems.Add((Math.Sqrt(mnk.Qx[i, i]).ToString()));


                        itemX.SubItems.Add((sigmaNulaKvadrat * mnk.Qx[i, i]).ToString());
                        itemX.SubItems.Add((Math.Sqrt(sigmaNulaKvadrat * mnk.Qx[i, i]).ToString()));

                        itemX.SubItems.Add((mnk.sKvadrat * mnk.Qx[i, i]).ToString());
                        itemX.SubItems.Add((Math.Sqrt(mnk.sKvadrat * mnk.Qx[i, i]).ToString()));

                        i++;

                        lv.Items.Add(itemX);

                        #endregion X
                    }
                }
            }
        }
        
    }
}
