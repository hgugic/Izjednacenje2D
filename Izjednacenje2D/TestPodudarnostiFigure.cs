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
    public class TestPodudarnostiFigure
    {
        List<double> dQd = new List<double>();
        double sigmaNulaKvadrat;
        double lambda;
        List<double> dp = new List<double>();
        List<string> theta = new List<string>();


        public TestPodudarnostiFigure(bool prisila, DenseMatrix Qx, List<string> kutevi, double parametarNecentralnosti, double sigmaNulaKvadrat )
        {
            this.sigmaNulaKvadrat = sigmaNulaKvadrat;
            lambda = parametarNecentralnosti;
            theta = kutevi;


           if(!prisila)
            {
                int j = 1;
                int i = 0;
                for (int t = 0; t < kutevi.Count; t++)
                {

                    double[] matrica = new double[] { Qx[i,i], Qx[i,j],
                                                     Qx[j,i],  Qx[j,j]};


                    DenseMatrix Qd = new DenseMatrix(2, 2, matrica);

                    double[] vektor = new double[] { Matematika.Sin(DMS.Parse(kutevi[t])), Matematika.Cos(DMS.Parse(kutevi[t])) };

                    DenseVector d = new DenseVector(vektor);

                    double dp1 = d * Qd.Inverse() * d;

                    dQd.Add(dp1);

                    dp.Add(Math.Sqrt(sigmaNulaKvadrat * lambda / dp1));

                    j = j + 2;
                    i = i + 2;

                }
            }
        }

        public void Test(ListView test, List<string> tocke)
        {
            test.Clear();
            test.Columns.Add("Točka");
            test.Columns.Add("σ²");
            test.Columns.Add("λ");
            test.Columns.Add("θ");
            test.Columns.Add("d^t Qd d");
            test.Columns.Add("dp [mm]");


            for (int i = 0; i < dp.Count; i++)
            {
                ListViewItem item = new ListViewItem(tocke[i]);
                item.SubItems.Add(sigmaNulaKvadrat.ToString());
                item.SubItems.Add(lambda.ToString());
                item.SubItems.Add(theta[i]);
                item.SubItems.Add(dQd[i].ToString());
                item.SubItems.Add(dp[i].ToString());

                test.Items.Add(item);
            }
        }
    }
}
