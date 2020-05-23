using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;

namespace SimplexParametrizat
{
    public partial class Result : Form
    {
        public static int czjcj = 1;
        public static double[,] artifmatrix;
        public static double[] artifzjcj;
        public static double[] artifcoefs;

        public static double[] standard;
        public static int[] b = new int[Restrictions.ineq.Length];
        public static double[] p = new double[Restrictions.ineq.Length];
        public static double[] zjcj;
        public static double[] teta = new double[Restrictions.ineq.Length];
        public static double[,] matrix;
        public static double[] solution;
        public static double optimal = 0;
        public static double[] lambda = Restrictions.param;

        public static double[,] parammatrix;
        public static int[] paramb;
        public static double[] paramlambda;

        public static double[,] lbd;
        public static double[] intersection;
        public static int pos;
        public static double rightEdge;
        public static double leftEdge;
        public Result()
        {
            InitializeComponent();
        }

        private void showZjcj()
        {
            resultRtb.Text += "\n";
            for (int i = 0; i < artifzjcj.Length; i++)
                resultRtb.Text += artifzjcj[i] + " ";
        }
        private void showArtifMatrix()
        {
            resultRtb.Text += "\n";
            for (int i = 0; i < artifmatrix.GetLength(0); i++)
            {
                resultRtb.Text += "\n";
                for (int j = 0; j < artifmatrix.GetLength(1); j++)
                    resultRtb.Text += artifmatrix[i, j] + " ";
            }
        }
        private void showFunction()
        {
            resultRtb.Text += "You have requested to solve the following system:\n\n(" + Home.type + ") f (";
            for (int i = 0; i < Variables.coefs.Length; i++)
                if (i + 1 == Variables.coefs.Length)
                    resultRtb.Text += "x" + (i + 1) + ") = ";
                else
                    resultRtb.Text += "x" + (i + 1) + ", ";

            resultRtb.Text += Variables.coefs[0] + "x1 ";
            for (int i = 1; i < Variables.coefs.Length; i++)
            {
                if (Variables.coefs[i] >= 0)
                    resultRtb.Text += "+ ";
                resultRtb.Text += Variables.coefs[i] + "x" + (i + 1) + " ";
            }
        }

        public void showRestrictions()
        {
            resultRtb.Text += "\n \nWith the following restrictions:\n";
            for (int i = 0; i < Restrictions.restcoef.GetLength(0); i++)
            {
                resultRtb.Text += "\n(" + (i + 1) + ") " + Restrictions.restcoef[i, 0] + "x1";
                for (int j = 1; j < Restrictions.restcoef.GetLength(1) - 1; j++)
                {
                    if (Restrictions.restcoef[i, j] >= 0)
                    {
                        resultRtb.Text += " + ";
                        resultRtb.Text += Restrictions.restcoef[i, j] + "x" + (j + 1);
                    }
                    else
                        resultRtb.Text += " - " + Restrictions.restcoef[i, j]*(-1) + "x" + (j + 1);
                }
                resultRtb.Text += " " + Restrictions.ineq[i];
                if (Restrictions.free[i] < 0)
                    resultRtb.Text += " - " + Restrictions.free[i] * (-1);
                else
                    resultRtb.Text += " " + Restrictions.free[i];
                if (Restrictions.param[i] < 0)
                    resultRtb.Text += " - " + Restrictions.param[i] * (-1) + "λ";
                else
                    resultRtb.Text += " + " + Restrictions.param[i] + "λ";
            }
        }

        public void showNonNegRestriction()
        {
            resultRtb.Text += "\n\nAnd the following non-negativity restriction:\n\n";
            for (int i = 0; i < Variables.coefs.Length; i++)
                if (i + 1 == Variables.coefs.Length)
                    resultRtb.Text += "x" + (i + 1) + " >= 0";
                else
                    resultRtb.Text += "x" + (i + 1) + ", ";
        }
        private void showSystem()
        {
            showFunction();
            showRestrictions();
            showNonNegRestriction();
        }

        private void resfillArtifMatrix()
        {
            int count = 1;
            int k = 0;
            bool sw = true;
            for (int i = 0; i < Restrictions.free.Length; i++)
                artifmatrix[i, 0] = Restrictions.free[i];
            for (int i = 0; i < Restrictions.free.Length; i++)
            {
                for (int j = 0; j < artifcoefs.Length; j++)
                    if (j < Restrictions.restcoef.GetLength(1) - 1)
                        artifmatrix[i, j + 1] = Restrictions.restcoef[i, j];
                    else
                    {
                        k++;
                        if ((artifcoefs[j] == 1 || Restrictions.ineq[i] == "<=") && sw == true && k == count)
                        {

                            artifmatrix[i, j + 1] = 1;
                            sw = false;
                        }
                        else
                            artifmatrix[i, j + 1] = 0;
                    }
                count++;
                k = 0;
                sw = true;
            }

        }

        private void fillArtifMatrix()
        {
            //resultRtb.Text += Restrictions.restcoef.GetLength(1).ToString();
            int ccount = 0;
            int acount = 0;
            for(int i=Variables.coefs.Length;i<artifcoefs.Length;i++)
                if (artifcoefs[i] == 0)
                    ccount++;
                else
                    acount++;

            int diflen = artifcoefs.Length - Variables.coefs.Length;
            double[,] cfs = new double[Restrictions.ineq.Length,diflen];
            int kc = 0;
            int ka = 0;

            for (int i = 0; i < Restrictions.free.Length; i++)
                artifmatrix[i, 0] = Restrictions.free[i];
            for (int i = 0; i < Restrictions.ineq.Length; i++)
            {
                if (Restrictions.ineq[i] == "<=")
                {
                    cfs[i, kc] = 1;
                    kc++;
                }
                if (Restrictions.ineq[i] == "=")
                {
                    cfs[i, ka + ccount] = 1;
                    ka++;
                }
                if (Restrictions.ineq[i] == ">=")
                {
                    cfs[i, kc] = -1;
                    kc++;
                    cfs[i, ka + ccount] = 1;
                    ka++;
                }
            }

            for(int i=0;i<Restrictions.free.Length;i++)
                for (int j = 0; j < artifcoefs.Length; j++)
                    if (j < Variables.coefs.Length)
                        artifmatrix[i, j + 1] = Restrictions.restcoef[i, j];
                    else
                        artifmatrix[i, j + 1] = cfs[i, j - Variables.coefs.Length];
            }

        private bool checkZjcj()
        {
            for (int i = 0; i < artifzjcj.Length; i++)
                if (artifzjcj[i] > 0)
                    return true;
            return false;
        }
        private void computeZjcj()
        {
            //for (int i = 0; i < b.Length; i++)
                //resultRtb.Text += "b" + b[i];
            //resultRtb.Text += "\n";
            //resultRtb.Text += "artifzjcj" + artifzjcj.Length + "artifcoefs" + artifcoefs.Length;
            for (int i = 0; i < artifzjcj.Length; i++)
            {
                artifzjcj[i] = 0;
                for (int j = 0; j < Restrictions.free.Length; j++)
                    artifzjcj[i] += artifcoefs[b[j]] * artifmatrix[j, i + 1];
                artifzjcj[i] -= artifcoefs[i];
            }
        }

        private void computeNewMatrix()
        {
            int maxpos = 0;
            double maxval = 0;
            for (int i = 0; i < artifzjcj.Length; i++)
                if (artifzjcj[i] > maxval)
                {
                    maxpos = i;
                    maxval = artifzjcj[i];
                }

            for (int i = 0; i < teta.Length; i++)
                teta[i] = artifmatrix[i, 0] / artifmatrix[i, maxpos + 1];
            double minteta = 0;
            int posteta = 0;
            for (int i = 0; i < teta.Length; i++)
                if (teta[i] > 0)
                {
                    minteta = teta[i];
                    break;
                }
            for (int i = 0; i < teta.Length; i++)
                if (teta[i] < minteta && teta[i] > 0)
                {
                    minteta = teta[i];
                    posteta = i;
                }
            double pivot = artifmatrix[posteta, maxpos + 1];
            for (int i = 0; i < artifmatrix.GetLength(1); i++)
                artifmatrix[posteta, i] /= pivot;
            lambda[posteta] /= pivot;
            for (int i = 0; i < artifmatrix.GetLength(0); i++)
                if (i != posteta && artifmatrix[i,maxpos+1] !=0)
                {
                    pivot = artifmatrix[i, maxpos + 1];
                    //scalar = artifmatrix[i, maxpos + 1] / artifmatrix[posteta, maxpos + 1];
                    for (int j = 0; j < artifmatrix.GetLength(1); j++)
                        artifmatrix[i, j] -= pivot*artifmatrix[posteta,j];
                    lambda[i] -= pivot * lambda[posteta];
                }
            b[posteta] = maxpos;
        }
        private void getArtificialSolution()
        {

            int acount = 0;
            int ccount = 0;
            for (int i = 0; i < Restrictions.ineq.Length; i++)
                if (Restrictions.ineq[i] == "<=")
                    ccount++;
                else if (Restrictions.ineq[i] == "=")
                    acount++;
                else
                {
                    acount++;
                    ccount++;
                }

            int auxac = -1;
            for (int i = 0; i < Restrictions.ineq.Length; i++)
                if (Restrictions.ineq[i] == "<=")
                    b[i] = Variables.coefs.Length + i;
                else
                {
                    auxac++;
                    b[i] = Variables.coefs.Length + ccount + auxac;
                }

            artifcoefs = new double[Variables.coefs.Length + acount + ccount];
            artifmatrix = new double[Restrictions.free.Length, artifcoefs.Length+1];

            for (int i = 0; i < artifcoefs.Length - acount; i++)
                artifcoefs[i] = 0;
            for (int i = artifcoefs.Length - acount; i<artifcoefs.Length; i++)
                artifcoefs[i] = 1;

            //for (int i = 0; i < artifcoefs.Length; i++)
                //resultRtb.Text += artifcoefs[i] + " ";
            //resultRtb.Text += "\n";

            fillArtifMatrix();
            //showArtifMatrix();
            
            //for (int i = 0; i < p.Length; i++)
                //p[i] = Restrictions.free[i];


            artifzjcj = new double[artifcoefs.Length];

            computeZjcj();

            while (checkZjcj() == true)
            {
                computeNewMatrix();
                computeZjcj();
            }
            
        }

        private void showStandardMatrix()
        {
            resultRtb.Text += "\n";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                resultRtb.Text += "\n";
                for (int j = 0; j < matrix.GetLength(1); j++)
                    resultRtb.Text += matrix[i, j] + " ";
            }
        }

        private bool checkStandardZjcj()
        {
            for (int i = 0; i < zjcj.Length; i++)
                if (zjcj[i] > 0)
                    return true;
            return false;
        }
        private void computeStandardZjcj()
        {
            //for (int i = 0; i < b.Length; i++)
                //resultRtb.Text += "b" + b[i];
            //resultRtb.Text += "\n";
            //resultRtb.Text += "zjcj" + zjcj.Length + "coefs" + standard.Length;
            for (int i = 0; i < zjcj.Length; i++)
            {
                zjcj[i] = 0;
                for (int j = 0; j < Restrictions.free.Length; j++)
                    zjcj[i] += standard[b[j]] * matrix[j, i + 1];
                zjcj[i] -= standard[i];
            }
        }

        private void generateStandard()
        {
            int acount = 0;
            for (int i = 0; i < artifcoefs.Length; i++)
                if (artifcoefs[i] == 1)
                    acount++;
            standard = new double[artifcoefs.Length - acount];
            for (int i = 0; i < Variables.coefs.Length; i++)
                standard[i] = Variables.coefs[i];
            for (int i = Variables.coefs.Length; i < standard.Length; i++)
                standard[i] = 0;
            if (Home.type == "max")
            {
                for (int i = 0; i < Variables.coefs.Length; i++)
                    standard[i] = standard[i] * (-1);
                for (int i = Variables.coefs.Length; i < standard.Length; i++)
                    standard[i] = 0;
            }


            //for (int i = 0; i < standard.Length; i++)
                //resultRtb.Text += standard[i] + "s";
        }

        private void computeStandardMatrix()
        {
            int maxpos = 0;
            double maxval = 0;
            for (int i = 0; i < zjcj.Length; i++)
                if (zjcj[i] > maxval)
                {
                    maxpos = i;
                    maxval = zjcj[i];
                }

            for (int i = 0; i < teta.Length; i++)
                teta[i] = matrix[i, 0] / matrix[i, maxpos + 1];
            double minteta = 0;
            int posteta = 0;
            for (int i = 0; i < teta.Length; i++)
                if (teta[i] > 0)
                {
                    minteta = teta[i];
                    break;
                }
            for (int i = 0; i < teta.Length; i++)
                if (teta[i] < minteta && teta[i] > 0)
                {
                    minteta = teta[i];
                    posteta = i;
                }
            double pivot1 = matrix[posteta, maxpos + 1];
            for (int i = 0; i < matrix.GetLength(1); i++)
                matrix[posteta, i] /= pivot1;
            lambda[posteta] /= pivot1;
            for (int i = 0; i < matrix.GetLength(0); i++)
                    if (i != posteta && matrix[i,maxpos+1]!=0)
                    {
                        //scalar = artifmatrix[i, maxpos + 1] / artifmatrix[posteta, maxpos + 1];
                        double pivot2 = matrix[i, maxpos + 1];
                        for (int j = 0; j < matrix.GetLength(1); j++)
                            matrix[i, j] -= pivot2 * matrix[posteta, j];
                        lambda[i] -= pivot2 * lambda[posteta];
                    }
            b[posteta] = maxpos;

        }
        private void getStandardSolution()
        {
            generateStandard();

            matrix = new double[Restrictions.ineq.Length, standard.Length + 1];
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = artifmatrix[i, j];

            zjcj = new double[standard.Length];
            computeStandardZjcj();

            while(checkStandardZjcj() == true)
            {
                computeStandardMatrix();
                computeStandardZjcj();
                //showStandardMatrix();
                czjcj++;
            }

        }

        private void getInitialSolution()
        {
            int ccount = 0;
            for (int i = 0; i < Restrictions.ineq.Length; i++)
                if (Restrictions.ineq[i] != "=")
                    ccount++;
            solution = new double[standard.Length-ccount];
            for (int i = 0; i < b.Length; i++)
                if(b[i]<solution.Length)
                    solution[b[i]] = matrix[i, 0];
            for (int i = 0; i < solution.Length; i++)
                optimal += solution[i] * Variables.coefs[i];
            showInitialSolution();
        }

        private void showInitialSolution()
        {
            resultRtb.Text += "\n\nThe solution to the problem, where λ is 0, is: \n\nX = [";
            for (int i = 0; i < solution.Length; i++)
                if (i < solution.Length - 1)
                    resultRtb.Text += Math.Round(solution[i],0) + ", ";
                else
                    resultRtb.Text += Math.Round(solution[i],0) + "],\n";
            resultRtb.Text += "With an optimal value of " + Math.Round(optimal,0);
        }

        private double[,] lambdaIntervals()
        {
            double[,] sfl = new double[lambda.Length,2];
            for (int i = 0; i < sfl.GetLength(0); i++)
                if (lambda[i] != 0)
                    if (lambda[i] > 0)
                    {
                        sfl[i, 0] = (-1) * matrix[i, 0] / lambda[i];
                        sfl[i, 1] = Int32.MaxValue;
                    }
                    else
                    {
                        sfl[i, 0] = Int32.MinValue;
                        sfl[i,1] = (-1) * matrix[i, 0] / lambda[i];

                    }
            return sfl;
        }

        private double[] getFirstIntersection(double[,] lbd)
        {
            double min = Int32.MinValue;
            double max = Int32.MaxValue;
            double[] interval = new double[2];
            for (int i = 0; i < lbd.GetLength(0); i++)
                if (lbd[i, 0] != 0 || lbd[i, 1] != 0)
                {
                    if (lbd[i, 0] != Int32.MinValue)
                    {
                        if (lbd[i, 0] > min)
                            min = lbd[i, 0];
                    }
                    if (lbd[i, 1] != Int32.MaxValue)
                    {
                        if (lbd[i, 1] < max)
                            max = lbd[i, 1];
                    }
                }
            interval[0] = min;
            interval[1] = max;
            return interval;
        }

        private void showParametricSolution()
        {
            resultRtb.Text += "\n\nFor λ = ";

            if (intersection[0] == Int32.MinValue)
                resultRtb.Text += "(-inf, ";
            else
                resultRtb.Text += "[" + Math.Round(intersection[0],2) + ", ";
            if (intersection[1] == Int32.MaxValue)
                resultRtb.Text += "+inf), ";
            else
                resultRtb.Text += Math.Round(intersection[1],2) + "], ";

            double[] paramopt = new double[2];
            for (int i = 0; i < lambda.Length; i++)
            {
                paramopt[0] += standard[b[i]]*matrix[i, 0];
                paramopt[1] += standard[b[i]]*lambda[i];
            }
            if (Home.type == "min")
            {
                resultRtb.Text += "the optimal value is (min)f = " + Math.Round(paramopt[0], 0) + " ";
                if (paramopt[1] >= 0)
                    resultRtb.Text += "+ " + Math.Round(paramopt[1], 0) + "λ";
                else
                    resultRtb.Text += "- " + Math.Round(paramopt[1] * (-1), 0) + "λ";
            }
            else
            {
                resultRtb.Text += "the optimal value is (max)f = " + Math.Round(paramopt[0], 0) * (-1) + " ";
                if (paramopt[1] < 0)
                    resultRtb.Text += "+ " + Math.Round(paramopt[1], 0) * (-1) + "λ";
                else
                    resultRtb.Text += "- " + Math.Round(paramopt[1], 0) + "λ";
            }
            resultRtb.Text += ", and the components are: X = [";
            int jaux = -1;
            for (int i = 0; i < solution.Length - 1; i++)
            {
                for (int j = 0; j < b.Length; j++)
                    if (b[j] == i)
                        jaux = j;
                if (jaux != -1)
                {
                    resultRtb.Text += Math.Round(solution[i],0) + " ";
                    if (lambda[jaux] > 0)
                        resultRtb.Text += "+ " + Math.Round(lambda[jaux],0) + "λ, ";
                    else
                        resultRtb.Text += "- " + Math.Round(lambda[jaux]*(-1),0) + "λ, ";
                }
                else
                    resultRtb.Text += Math.Round(solution[i],0) + ", ";
                jaux = -1;
            }

            for (int j = 0; j < b.Length; j++)
                if (b[j] == solution.Length-1)
                    jaux = j;
            if (jaux != -1)
            {
                resultRtb.Text += Math.Round(solution[solution.Length-1],0) + " ";
                if (lambda[jaux] > 0)
                    resultRtb.Text += "+ " + Math.Round(lambda[jaux],0) + "λ].";
                else
                    resultRtb.Text += "- " + Math.Round(lambda[jaux]*(-1),0) + "λ].";
            }
            else
                resultRtb.Text += Math.Round(solution[solution.Length-1],0) + "].";

        }

        private void dualAlgorithm(int pos)
        {
            double minzjcj=Int32.MaxValue;
            int poszjcj = 0;
            for(int i=0;i<zjcj.Length;i++)
                if (zjcj[i] / matrix[pos, i + 1] < minzjcj && matrix[pos, i + 1] < 0)
                {
                    minzjcj = zjcj[i] / matrix[pos, i + 1];
                    poszjcj = i;
                }

            double pivot1 = matrix[pos, poszjcj + 1];
            for (int i = 0; i < matrix.GetLength(1); i++)
                matrix[pos, i] /= pivot1;
            lambda[pos] /= pivot1;
            for (int i = 0; i < matrix.GetLength(0); i++)
                if (i != pos && matrix[i, poszjcj + 1] != 0)
                {
                    //scalar = artifmatrix[i, maxpos + 1] / artifmatrix[posteta, maxpos + 1];
                    double pivot2 = matrix[i, poszjcj + 1];
                    for (int j = 0; j < matrix.GetLength(1); j++)
                        matrix[i, j] -= pivot2 * matrix[pos, j];
                    lambda[i] -= pivot2 * lambda[pos];
                }
            lbd = lambdaIntervals();
            intersection = getFirstIntersection(lbd);
            b[pos] = poszjcj;
            for (int i = 0; i < solution.Length; i++)
                solution[i] = 0;
            for (int i = 0; i < b.Length; i++)
                if(b[i]<solution.Length)
                    solution[b[i]] = matrix[i, 0];
            showParametricSolution();



        }
        
        private bool haltLeft(double[] intersection)
        {
            if (intersection[0] == Int32.MinValue)
                return true;

            pos = 0;
            for (int i = 0; i < lambda.Length; i++)
                if (matrix[i, 0] + intersection[0] * lambda[i] == 0)
                    pos = i;
            for (int i = 0; i < zjcj.Length; i++)
                if (matrix[pos, i + 1] < 0)
                    return false;
            return true;
        }
        private void leftParametric()
        {
            if (haltLeft(intersection) == false)
                dualAlgorithm(pos);
            leftEdge = intersection[0];
        }

        private bool haltRight(double[] intersection)
        {
            if (intersection[1] == Int32.MaxValue)
                return true;

            pos = 0;
            for (int i = 0; i < lambda.Length; i++)
                if (matrix[i, 0] + intersection[1] * lambda[i] == 0)
                    pos = i;
            for (int i = 0; i < zjcj.Length; i++)
                if (matrix[pos, i + 1] < 0)
                    return false;
            return true;
        }
        private void rightParametric()
        {
            if(haltRight(intersection) == false)
                    dualAlgorithm(pos);
            rightEdge = intersection[1];                 
        }

        private void showEdges()
        {
            resultRtb.Text += "\n\n";
            if (rightEdge != Int32.MaxValue && leftEdge != Int32.MinValue)
                resultRtb.Text += "For any λ<" + Math.Round(leftEdge,2) + " and λ>" + Math.Round(rightEdge,2) + ", the problem does not have optimal solutions.";
            if (rightEdge == Int32.MaxValue && leftEdge != Int32.MinValue)
                resultRtb.Text += "For any λ<" + Math.Round(leftEdge,2) + ", the problem does not have optimal solutions.";
            if (rightEdge != Int32.MaxValue && leftEdge == Int32.MinValue)
                resultRtb.Text += "For any λ>" + Math.Round(rightEdge,2) + ", the problem does not have optimal solutions.";
        }

        private void showIntervals()
        {
            for (int i = 0; i < lbd.GetLength(0); i++)
            {
                resultRtb.Text += "\n";
                for (int j = 0; j < lbd.GetLength(1); j++)
                    resultRtb.Text += lbd[i, j] + " ";
                
            }
            resultRtb.Text += "\n" + intersection[0] + "\n" + intersection[1];
        }
        private void getParametricSolution()
        {
            lbd = lambdaIntervals();
            intersection = getFirstIntersection(lbd);

            paramb = b;
            parammatrix = matrix;
            paramlambda = lambda;

            //showParametricSolution();
            //showIntervals();
            leftParametric();
            //showIntervals();

            b = paramb;
            matrix = parammatrix;
            lambda = paramlambda;
            lbd = lambdaIntervals();
            intersection = getFirstIntersection(lbd);

            rightParametric();
            showEdges();
        }

        private void getSolution()
        {
            getArtificialSolution();
            getStandardSolution();
            getInitialSolution();
            getParametricSolution();
        }

        private void insertDoc(string p, string s)
        {
            var doc = DocX.Create(p);
            doc.InsertParagraph(s);
            doc.Save();
        }
        private void Result_Load(object sender, EventArgs e)
        {
            resultRtb.Text = "";
            showSystem();
            getSolution();
            insertDoc(@"C:\Users\Serban\Desktop\ParametriX.docx", resultRtb.Text);
        }

        private void res_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainMenu m = new MainMenu();
            m.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Restrictions res = new Restrictions();
            res.Show();
            this.Hide();
        }
    }
}
