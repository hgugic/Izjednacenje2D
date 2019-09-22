using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Geodezija;
using Microsoft.Office.Interop.Excel;
using System.Globalization;


namespace Izjednacenje2D
{
    public class Excel
    {
 

        public void CSV(ListView Lv1, ListView lv2, ListView lv3, ListView lv4)
        {
            //declare new SaveFileDialog + set it's initial properties
            SaveFileDialog sfd = new SaveFileDialog
            {
                Title = "Choose file to save to",
                FileName = "example.txt",
                Filter = "CSV (*.txt)|*.txt",
                FilterIndex = 0,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };

            //show the dialog + display the results in a msgbox unless cancelled

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                string[] headers = Lv1.Columns
                           .OfType<ColumnHeader>()
                           .Select(header => header.Text.Trim())
                           .ToArray();

                string[][] items = Lv1.Items
                            .OfType<ListViewItem>()
                            .Select(lvi => lvi.SubItems
                                .OfType<ListViewItem.ListViewSubItem>()
                                .Select(si => si.Text).ToArray()).ToArray();

                string table = string.Join(",", headers) + Environment.NewLine;
                foreach (string[] a in items)
                {
                    //a = a_loopVariable;
                    table += string.Join(",", a) + Environment.NewLine;
                }

 
                table = table.TrimEnd('\r', '\n');
                System.IO.File.WriteAllText(sfd.FileName, table);
            }
        }

        public void CSV2(ListView Lv1, ListView lv2, ListView lv3, ListView lv4)
        {
            //declare new SaveFileDialog + set it's initial properties
            SaveFileDialog sfd = new SaveFileDialog
            {
                Title = "Choose file to save to",
                FileName = "example.txt",
                Filter = "CSV (*.txt)|*.txt",
                FilterIndex = 0,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };

            //show the dialog + display the results in a msgbox unless cancelled

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                string[] headers = Lv1.Columns
                           .OfType<ColumnHeader>()
                           .Select(header => header.Text.Trim())
                           .ToArray();

                string[][] items = Lv1.Items
                            .OfType<ListViewItem>()
                            .Select(lvi => lvi.SubItems
                                .OfType<ListViewItem.ListViewSubItem>()
                                .Select(si => si.Text).ToArray()).ToArray();

                string table = string.Join(",", headers) + Environment.NewLine;
                foreach (string[] a in items)
                {
                    //a = a_loopVariable;
                    table += string.Join(",", a) + Environment.NewLine;
                }
                table +=  Environment.NewLine;



                string[] headers2 = lv2.Columns
           .OfType<ColumnHeader>()
           .Select(header => header.Text.Trim())
           .ToArray();

                string[][] items2 = lv2.Items
                            .OfType<ListViewItem>()
                            .Select(lvi => lvi.SubItems
                                .OfType<ListViewItem.ListViewSubItem>()
                                .Select(si => si.Text).ToArray()).ToArray();

                table = string.Join(",", headers2) + Environment.NewLine;
                foreach (string[] a in items2)
                {
                    //a = a_loopVariable;
                    table += string.Join(",", a) + Environment.NewLine;
                }
                table += Environment.NewLine;

                string[] headers3 = lv3.Columns
.OfType<ColumnHeader>()
.Select(header => header.Text.Trim())
.ToArray();

                string[][] items3= lv3.Items
                            .OfType<ListViewItem>()
                            .Select(lvi => lvi.SubItems
                                .OfType<ListViewItem.ListViewSubItem>()
                                .Select(si => si.Text).ToArray()).ToArray();

                table = string.Join(",", headers3) + Environment.NewLine;
                foreach (string[] a in items3)
                {
                    //a = a_loopVariable;
                    table += string.Join(",", a) + Environment.NewLine;
                }
                table += Environment.NewLine;





                string[] headers4 = lv4.Columns
.OfType<ColumnHeader>()
.Select(header => header.Text.Trim())
.ToArray();

                string[][] items4 = lv4.Items
                            .OfType<ListViewItem>()
                            .Select(lvi => lvi.SubItems
                                .OfType<ListViewItem.ListViewSubItem>()
                                .Select(si => si.Text).ToArray()).ToArray();

                table = string.Join(",", headers4) + Environment.NewLine;
                foreach (string[] a in items4)
                {
                    //a = a_loopVariable;
                    table += string.Join(",", a) + Environment.NewLine;
                }
                table += Environment.NewLine;




                table = table.TrimEnd('\r', '\n');
                System.IO.File.WriteAllText(sfd.FileName, table);
            }
        }


        Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();

        string vrstaIzjednacenja;
        int n, u, f, d;

        public Excel(string vrstaIzjednacenja, int n, int u, int d, int f)
        {
            this.vrstaIzjednacenja = vrstaIzjednacenja;
            this.n = n;
            this.u = u;
            this.f = f;
            this.d = d;
            app.Visible = true;
        }

        #region ListView To Excel

        public void ListViewToExcel(Worksheet ws, int red, int stupac, ListView lv, out int redPovrat, out int stupacPovrat)
        {

            redPovrat = red;
            stupacPovrat = stupac;

            foreach (ColumnHeader header in lv.Columns)
            {
                ws.Cells[red, stupac] = header.Text;
                ws.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                stupac++;
            }
            red++;
            stupac = stupacPovrat;

            foreach (ListViewItem lvi in lv.Items)
            {
                foreach (ListViewItem.ListViewSubItem lvs in lvi.SubItems)
                {
                    try
                    {
                        ws.Cells[red, stupac] = Convert.ToDouble(lvs.Text);
                        ws.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Aqua);
                        stupac++;
                    }
                    catch (Exception)
                    {
                        ws.Cells[red, stupac] = lvs.Text;
                        ws.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                        stupac++;
                    }

                }
                red++;
                stupac = stupacPovrat;
            }

            redPovrat = red;
        }

        public void TockeListViewToExcel(Worksheet ws, int red, int stupac, ListView lv, out int redPovrat, out int stupacPovrat)
        {

            redPovrat = red;
            stupacPovrat = stupac;

            foreach (ColumnHeader header in lv.Columns)
            {
                ws.Cells[red, stupac] = header.Text;
                ws.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                stupac++;
            }
            red++;
            stupac = stupacPovrat;

            foreach (ListViewItem lvi in lv.Items)
            {
                if (lvi.Checked)
                {
                    ws.Cells[red, stupac] = "DA";
                    ws.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Gold);
                    stupac++;
                }
                else
                {
                    ws.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.NavajoWhite);
                    stupac++;
                }

                foreach (ListViewItem.ListViewSubItem lvs in lvi.SubItems)
                {
                    if (lvs.Text != "")
                    {
                        try
                        {
                            ws.Cells[red, stupac] = Convert.ToDouble((lvs.Text));
                            ws.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Aqua);
                            stupac++;
                        }
                        catch (Exception)
                        {
                            ws.Cells[red, stupac] = lvs.Text;
                            ws.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                            stupac++;
                        }
                    }

                }
                red++;
                stupac = stupacPovrat;
            }

            redPovrat = red;
        }

        public void MjerenjaListViewToExcel(Worksheet ws, int red, int stupac, ListView lv, out int redPovrat, out int stupacPovrat)
        {

            redPovrat = red;
            stupacPovrat = stupac;

            foreach (ColumnHeader header in lv.Columns)
            {
                ws.Cells[red, stupac] = header.Text;
                ws.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                stupac++;
            }
            red++;
            stupac = stupacPovrat;

            foreach (ListViewItem lvi in lv.Items)
            {
                foreach (ListViewItem.ListViewSubItem lvs in lvi.SubItems)
                {
                    try
                    {
                        if (lvs.Text == "OK" || lvs.Text == "GRESKA" || lvs.Text == "-")
                        {
                            if (lvs.Text == "OK")
                            {
                                ws.Cells[red, stupac] = "OK";
                                ws.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LimeGreen);
                            }
                            else if (lvs.Text == "GRESKA")
                            {
                                ws.Cells[red, stupac] = "GRESKA";
                                ws.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.IndianRed);
                            }
                            else
                            {
                                ws.Cells[red, stupac] = "Sistem test/error";
                                ws.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightCoral);
                            }
                            stupac++;
                        }
                        else
                        {
                            ws.Cells[red, stupac] = Convert.ToDouble(lvs.Text);
                            ws.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Aqua);
                            stupac++;
                        }

                    }
                    catch (Exception)
                    {
                        ws.Cells[red, stupac] = lvs.Text;
                        ws.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                        stupac++;
                    }

                }
                red++;
                stupac = stupacPovrat;
            }

            redPovrat = red;
        }

        public void OcjenaFunkcijaListViewToExcel(Worksheet ws, int red, int stupac, ListView lv, out int redPovrat, out int stupacPovrat)
        {

            redPovrat = red;
            stupacPovrat = stupac;

            foreach (ColumnHeader header in lv.Columns)
            {
                ws.Cells[red, stupac] = header.Text;
                ws.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                stupac++;
            }
            red++;
            stupac = stupacPovrat;

            foreach (ListViewItem lvi in lv.Items)
            {
                foreach (ListViewItem.ListViewSubItem lvs in lvi.SubItems)
                {
                    try
                    {
                        if (lvs.Text == "DA" || lvs.Text == "-NE-")
                        {
                            if (lvs.Text == "DA")
                            {
                                ws.Cells[red, stupac] = "DA";
                                ws.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LimeGreen);
                            }
                            else if (lvs.Text == "-NE-")
                            {
                                ws.Cells[red, stupac] = "-NE-";
                                ws.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.IndianRed);
                            }
                            else
                            {
                                ws.Cells[red, stupac] = "Sistem test/error";
                                ws.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightCoral);
                            }
                            stupac++;
                        }
                        else
                        {
                            ws.Cells[red, stupac] = Convert.ToDouble(lvs.Text);
                            ws.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Aqua);
                            stupac++;
                        }

                    }
                    catch (Exception)
                    {
                        ws.Cells[red, stupac] = lvs.Text;
                        ws.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                        stupac++;
                    }

                }
                red++;
                stupac = stupacPovrat;
            }

            redPovrat = red;
        }

        #endregion ListView To Excel

        public void TabControlTabPageListViewToExcel(Worksheet ws, int red, int stupac, TabControl tc)
        {


            foreach (TabPage tab in tc.TabPages)
            {

                foreach (Control ctn in tab.Controls)
                {
                    if (ctn is ListView)
                    {
                        red = red + 3;
                        ws.Cells[red, stupac] = "Matrica / Vektor: " + tab.Name;
                        red++;

                        ListViewToExcel(ws, red, stupac, (ListView)ctn, out red, out stupac);
                    }

                }
            }

        }

        public void IzjednacenaMjerenjaTabControlTabPageListViewToExcel(Worksheet ws, int red, int stupac, TabControl tc)
        {


            foreach (TabPage tab in tc.TabPages)
            {

                foreach (Control ctn in tab.Controls)
                {
                    if (ctn is ListView)
                    {
                        if (tab.Name == "tpMjerenja")
                        {
                            red = red + 3;
                            ws.Cells[red, stupac] = "Izjednacena mjerenja";
                            red++;

                            ListViewToExcel(ws, red, stupac, (ListView)ctn, out red, out stupac);
                        }
                        else if(tab.Name == "tpIzjednaceneKoordinate")
                        {
                            red = red + 3;
                            ws.Cells[red, stupac] = "Izjednacene koordinate";
                            red++;

                            ListViewToExcel(ws, red, stupac, (ListView)ctn, out red, out stupac);
                        }

                        else if (tab.Name == "tpElipse")
                        {
                            red = red + 3;
                            ws.Cells[red, stupac] = "Standardne elipse";
                            red++;

                            ListViewToExcel(ws, red, stupac, (ListView)ctn, out red, out stupac);
                        }
                        else 
                        {
                            red = red + 3;
                            ws.Cells[red, stupac] = "Relativne elipse";
                            red++;

                            ListViewToExcel(ws, red, stupac, (ListView)ctn, out red, out stupac);
                        }
                    }

                }
            }

        }


        public void ExportToExcell(ListView tocke, ListView y, ListView x, ListView pravac, ListView kut, ListView duzine, ListView Bazni, ListView azimut, TabControl izjednacenje, ListView ocjenaFunkcija, TabControl VrijednostiNakonIzjednacenja, ListView statistika, ListView figuraTest)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            app.UseSystemSeparators = false;
            app.DecimalSeparator = ci.NumberFormat.NumberDecimalSeparator;
            app.ThousandsSeparator = ci.NumberFormat.NumberGroupSeparator;


            Workbook wb = app.Workbooks.Add(1);

            Worksheet ws1 = (Worksheet)wb.Worksheets[1];
            ws1.Name = "Podaci";

            #region Sheet 1

            #region Verzija

            int red = 1;
            int stupac = 1;

            ws1.Cells[red, stupac] = "Izjednacenje 2D mreze";
            red++;
            ws1.Cells[red, stupac] = "Verzija: 1.0.0.0 ";
            red++;
            ws1.Cells[red, stupac] = "Hrvoje Gugic";
            red++;
            ws1.Cells[red, stupac] = "hgugic86@gmail.com";
            red++;
            ws1.Cells[red, stupac] = "2016-2017";
            red++;

            #endregion Verzija

            #region prekobrojnost

            red = 3;
            stupac = 10;

            ws1.Cells[red, stupac] = vrstaIzjednacenja;
            red++;
            ws1.Cells[red, stupac] = "n:";
            ws1.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
            ws1.Cells[red, stupac + 1] = n;
            ws1.Cells[red, stupac + 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Aqua);
            red++;
            ws1.Cells[red, stupac] = "u:";
            ws1.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
            ws1.Cells[red, stupac + 1] = u;
            ws1.Cells[red, stupac + 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Aqua);
            red++;
            ws1.Cells[red, stupac] = "d:";
            ws1.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
            ws1.Cells[red, stupac + 1] = d;
            ws1.Cells[red, stupac + 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Aqua);
            red++;
            ws1.Cells[red, stupac] = "f:";
            ws1.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
            ws1.Cells[red, stupac + 1] = f;
            ws1.Cells[red, stupac + 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Aqua);
            red++;

            #endregion prekobrojnost

            #region Tocke

            red = 3;
            stupac = 4;

            ListViewToExcel(ws1, red, stupac, tocke, out red, out stupac);

            red = 3;
            stupac = 5;

            TockeListViewToExcel(ws1, red, stupac, y, out red, out stupac);

            red = 3;
            stupac = 7;

            TockeListViewToExcel(ws1, red, stupac, x, out red, out stupac);

            #endregion Tocke

            #region Pravci

            red = red + 3;
            stupac = 4;
            ws1.Cells[red, stupac] = "Pravci";
            red++;
            MjerenjaListViewToExcel(ws1, red, stupac, pravac, out red, out stupac);

            #endregion Pravci

            #region Kut

            red = red + 3;
            stupac = 4;
            ws1.Cells[red, stupac] = "Kutevi";
            red++;
            MjerenjaListViewToExcel(ws1, red, stupac, kut, out red, out stupac);

            #endregion Kut

            #region Duzine

            red = red + 3;
            stupac = 4;
            ws1.Cells[red, stupac] = "Duzine";
            red++;
            MjerenjaListViewToExcel(ws1, red, stupac, duzine, out red, out stupac);

            #endregion Duzine

            #region Bazni Vektor

            red = red + 3;
            stupac = 4;
            ws1.Cells[red, stupac] = "Bazni vektori";
            red++;
            MjerenjaListViewToExcel(ws1, red, stupac, Bazni, out red, out stupac);

            #endregion Bazni Vektor

            #region Azimut

            red = red + 3;
            stupac = 4;

            ws1.Cells[red, stupac++] = "Azimuti";
            ws1.Cells[red, stupac++] = "Orijentirani pravci";
            ws1.Cells[red, stupac++] = "Direkcioni uglovi";
            ws1.Cells[red, stupac++] = "Smjerni kutevi";


            red++;
            stupac = 4;
            MjerenjaListViewToExcel(ws1, red, stupac, azimut, out red, out stupac);

            #endregion Azimut

            ws1.Columns.AutoFit();

            #endregion Sheet 1

            #region Sheet 2 - Matrice

            wb.Sheets.Add(After: wb.Sheets[wb.Sheets.Count]);
            Worksheet ws2 = (Worksheet)wb.Worksheets[wb.Sheets.Count];
            ws2.Name = "Matrice";

            red = 1;
            stupac = 3;

            TabControlTabPageListViewToExcel(ws2, red, stupac, izjednacenje);

            ws2.Columns[3].AutoFit();

            #endregion Sheet 2 - Matrice

            #region Sheet 3 - ocjena funkcija

            wb.Sheets.Add(After: wb.Sheets[wb.Sheets.Count]);
            Worksheet ws3 = (Worksheet)wb.Worksheets[wb.Sheets.Count];
            ws3.Name = "Ocjena funkcija";

            red = 3;
            stupac = 3;

            OcjenaFunkcijaListViewToExcel(ws3, red, stupac, ocjenaFunkcija, out red, out stupac);

            ws3.Columns[3].AutoFit();

            #endregion Sheet 3 - ocjena funkcija
           
            #region Sheet 4 - Itjednacene vrijednosti

            wb.Sheets.Add(After: wb.Sheets[wb.Sheets.Count]);
            Worksheet ws4 = (Worksheet)wb.Worksheets[wb.Sheets.Count];
            ws4.Name = "Izjednacene vrijednosti";

            red = 1;
            stupac = 3;

            IzjednacenaMjerenjaTabControlTabPageListViewToExcel(ws4, red, stupac, VrijednostiNakonIzjednacenja);

            ws4.Columns.AutoFit();

            #endregion Sheet 4 - Itjednacene vrijednosti

            #region Sheet 5 - Statisticka testiranja

            wb.Sheets.Add(After: wb.Sheets[wb.Sheets.Count]);
            Worksheet ws5 = (Worksheet)wb.Worksheets[wb.Sheets.Count];
            ws5.Name = "Statisticka testiranja";

            red = 3;
            stupac = 3;

            OcjenaFunkcijaListViewToExcel(ws5, red, stupac, statistika, out red, out stupac);

            ws5.Columns.AutoFit();

            #endregion Sheet 5 - Statisticka testiranja

            #region Sheet 6 - Test podudarnosti

            wb.Sheets.Add(After: wb.Sheets[wb.Sheets.Count]);
            Worksheet ws6 = (Worksheet)wb.Worksheets[wb.Sheets.Count];
            ws6.Name = "Test podudarnosti (figura)";

            red = 3;
            stupac = 3;

            OcjenaFunkcijaListViewToExcel(ws6, red, stupac, figuraTest, out red, out stupac);

            ws6.Columns.AutoFit();

            #endregion Sheet 6 - Test podudarnosti
        }

    }
}
