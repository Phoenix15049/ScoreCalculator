using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AngouriMath;
using AngouriMath.Extensions;
using IronPython;
using System.Runtime.InteropServices;
using System.Linq.Expressions;
using IronPython.Hosting;
using System.IO;
using System.Diagnostics;

namespace myfirstapp
{

    public partial class Form1 : Form
    {
        public List<Panel> listPanel = new List<Panel>();

        public int PageIndex;

        public double[] Scores = new double[10];

        public int[] Vaheds = new int[10];

        

        public Form1()
        {
            
            InitializeComponent();
        
        }


        

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();




        public void Form1_MouseDown(object sender,
        System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        



        private void Form1_Load(object sender, EventArgs e)
        {
            Lang.SelectedItem = Lang.Items[0];

            listPanel.Add(Page1);
            listPanel.Add(Page2);
            listPanel.Add(Page3);
            listPanel[PageIndex].BringToFront();











        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                if (V1.Text != "")
                {
                    Vaheds[0] = Convert.ToInt16(V1.Text);
                }
                else
                {
                    Vaheds[0] = 0;
                }

                //--------------------------------------------------

                if (V2.Text != "")
                {
                    Vaheds[1] = Convert.ToInt16(V2.Text);
                }
                else
                {
                    Vaheds[1] = 0;
                }

                //--------------------------------------------------

                if (V3.Text != "")
                {
                    Vaheds[2] = Convert.ToInt16(V3.Text);
                }
                else
                {
                    Vaheds[2] = 0;
                }

                //--------------------------------------------------

                if (V4.Text != "")
                {
                    Vaheds[3] = Convert.ToInt16(V4.Text);
                }
                else
                {
                    Vaheds[3] = 0;
                }

                //--------------------------------------------------

                if (V5.Text != "")
                {
                    Vaheds[4] = Convert.ToInt16(V5.Text);
                }
                else
                {
                    Vaheds[4] = 0;
                }

                //--------------------------------------------------

                if (V6.Text != "")
                {
                    Vaheds[5] = Convert.ToInt16(V6.Text);
                }
                else
                {
                    Vaheds[5] = 0;
                }

                //--------------------------------------------------

                if (V7.Text != "")
                {
                    Vaheds[6] = Convert.ToInt16(V7.Text);
                }
                else
                {
                    Vaheds[6] = 0;
                }

                //--------------------------------------------------

                if (V8.Text != "")
                {
                    Vaheds[7] = Convert.ToInt16(V8.Text);
                }
                else
                {
                    Vaheds[7] = 0;
                }

                //--------------------------------------------------

                if (V9.Text != "")
                {
                    Vaheds[8] = Convert.ToInt16(V9.Text);
                }
                else
                {
                    Vaheds[8] = 0;
                }

                //--------------------------------------------------

                if (V10.Text != "")
                {
                    Vaheds[9] = Convert.ToInt16(V10.Text);
                }
                else
                {
                    Vaheds[9] = 0;
                }




                //-----------------------------------------------------------------------------------------------



                if (N1.Text != "")
                {
                    Scores[0] = Convert.ToDouble(N1.Text);
                }
                else
                {
                    Scores[0] = 0;
                }

                //--------------------------------------------------

                if (N2.Text != "")
                {
                    Scores[1] = Convert.ToDouble(N2.Text);
                }
                else
                {
                    Scores[1] = 0;
                }

                //--------------------------------------------------

                if (N3.Text != "")
                {
                    Scores[2] = Convert.ToDouble(N3.Text);
                }
                else
                {
                    Scores[2] = 0;
                }

                //--------------------------------------------------

                if (N4.Text != "")
                {
                    Scores[3] = Convert.ToDouble(N4.Text);
                }
                else

                {
                    Scores[3] = 0;
                }

                //--------------------------------------------------

                if (N5.Text != "")
                {
                    Scores[4] = Convert.ToDouble(N5.Text);
                }
                else
                {
                    Scores[4] = 0;
                }

                //--------------------------------------------------

                if (N6.Text != "")
                {
                    Scores[5] = Convert.ToDouble(N6.Text);
                }
                else
                {
                    Scores[5] = 0;
                }

                //--------------------------------------------------

                if (N7.Text != "")
                {
                    Scores[6] = Convert.ToDouble(N7.Text);
                }
                else
                {
                    Scores[6] = 0;
                }

                //--------------------------------------------------

                if (N8.Text != "")
                {
                    Scores[7] = Convert.ToDouble(N8.Text);
                }
                else
                {
                    Scores[7] = 0;
                }

                //--------------------------------------------------

                if (N9.Text != "")
                {
                    Scores[8] = Convert.ToDouble(N9.Text);
                }
                else
                {
                    Scores[8] = 0;
                }

                //--------------------------------------------------

                if (N10.Text != "")
                {
                    Scores[9] = Convert.ToDouble(N10.Text);
                }
                else
                {
                    Scores[9] = 0;
                }

                Double SumN = 0;
                int SumV = 0;
                for (int i = 0; i < 10; i++)
                {
                    SumN += Scores[i] * Vaheds[i];
                    SumV += Vaheds[i];
                }

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(SumV);
                    Console.WriteLine(SumN);
                }

                Double Answer = SumN / SumV;

                Ans.Text = Answer.ToString();
            }
            catch (System.FormatException)
            {
                Ans.Text = "Invalid Input";
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            N1.Text = "";
            N2.Text = "";
            N3.Text = "";
            N4.Text = "";
            N5.Text = "";
            N6.Text = "";
            N7.Text = "";
            N8.Text = "";
            N9.Text = "";
            N10.Text = "";

            V1.Text = "";
            V2.Text = "";
            V3.Text = "";
            V4.Text = "";
            V5.Text = "";
            V6.Text = "";
            V7.Text = "";
            V8.Text = "";
            V9.Text = "";
            V10.Text = "";

            Ans.Text = "";

        }
        private void check_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Test");

            if (Lang.SelectedItem.ToString()=="فارسی - Persian")
            {
                Console.WriteLine("FARS");
                Vahed.Text = "واحد";
                Nomreh.Text = "نمره";
                Clear.Text = "پاکسازی";
                button1.Text = "محاسبه";
                Calcul.Text = "محاسبه";
                CalClear.Text = "پاکسازی";
                EquCleaner.Text = "پاکسازی";
                EquSolver.Text = "محاسبه";
                RootVarLabel.Text = "متغیر اصلی :";
                RootVarLabel.Font = new Font("B Koodak", 13);
                RootVarLabel.RightToLeft = RightToLeft.Yes;

            }
            else if (Lang.SelectedItem.ToString()=="English")
            {
                Console.WriteLine("ENG");
                Vahed.Text = "Units";
                Nomreh.Text = "Scores";
                Clear.Text = "Clear";
                button1.Text = "Calculate";
                Calcul.Text = "Calculate";
                CalClear.Text = "Clear";
                EquCleaner.Text = "Clear";
                EquSolver.Text = "Calculate";
                RootVarLabel.Text = ": Main Variable";
                RootVarLabel.Font = new Font("Arial", 12);
                RootVarLabel.RightToLeft = RightToLeft.No;
            }
        }
        private void Prev_Click(object sender, EventArgs e)
        {
            if (PageIndex>0 )
            {
                listPanel[--PageIndex].BringToFront();
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (PageIndex < listPanel.Count - 1)
            {
                listPanel[++PageIndex].BringToFront();
            }
        }

        private void Calcul_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Expbox.Text);

            //#------------------------ C# Solver :            
            //            try
            //            {
            //                AnsBox.ForeColor = Color.FromArgb(0, 64, 0);
            //                Entity exp = Expbox.Text;
            //                AnsBox.Text = Convert.ToString(exp.EvalNumerical());
            //                Console.WriteLine(IronPython2(Expbox.Text));
            //            }
            //            catch (AngouriMath.Core.Exceptions.UnhandledParseException )
            //            {
            //                AnsBox.ForeColor = Color.Red;
            //                AnsBox.Text = "Invalid expression";
            //            }
            //#------------------------ Python Solver :   
            String CalpyAns = IronPython2(Expbox.Text);
            if(CalpyAns != "")
            {
                AnsBox.ForeColor = Color.FromArgb(0, 64, 0);
                AnsBox.Text = CalpyAns;
            }
            else
            {
                AnsBox.ForeColor = Color.Red;
                AnsBox.Text = "Invalid expression";
            }
            Console.WriteLine(CalpyAns);
        }

        private void Taghsim_Click(object sender, EventArgs e)
        {
            Expbox.Text += "/";
        }

        private void Zarb_Click(object sender, EventArgs e)
        {
            Expbox.Text += "*";
        }

        private void Jam_Click(object sender, EventArgs e)
        {
            Expbox.Text += "+";
        }

        private void Menha_Click(object sender, EventArgs e)
        {
            Expbox.Text += "-";
        }

        private void P_Baz_Click(object sender, EventArgs e)
        {
            Expbox.Text += "(";
        }

        private void P_Bste_Click(object sender, EventArgs e)
        {
            Expbox.Text += ")";
        }

        private void CalClear_Click(object sender, EventArgs e)
        {
            AnsBox.Text = "0";
            Expbox.Text = "";
            AnsBox.ForeColor = Color.FromArgb(0, 64, 0);
        }



        //-------------------------(Runing .exe files and using args of output)-------------------------//



        static void LaunchCommandLineApp()
        {
            // For the example
            const string ex1 = "C:\\";
            const string ex2 = "C:\\Dir";

            // Use ProcessStartInfo class
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "dcm2jpg.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = "-f j -o \"" + ex1 + "\" -z 1.0 -s y " + ex2;

            try
            {
                // Start the process with the info we specified.
                // Call WaitForExit and then the using statement will close.
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch
            {
                // Log error.
            }
        }

        //-------------------------(Runing .exe files and using args of output)-------------------------//








        //-------------------------(Runing .py files and using args of output)-------------------------//

        static String IronPython2(String inp)
        {
            var engine = Python.CreateEngine();

            var script = @"G:\Projects\winapp1\myfirstapp\Resources\1.py";
            var source = engine.CreateScriptSourceFromFile(script);

            var argv = new List<string>();

            argv.Add("");
            argv.Add(inp);

            engine.GetSysModule().SetVariable("argv", argv);

            var eIO = engine.Runtime.IO;

            var errors = new MemoryStream();
            eIO.SetErrorOutput(errors, Encoding.Default);

            var results = new MemoryStream();
            eIO.SetOutput(results, Encoding.Default);

            var scope = engine.CreateScope();
            try
            {
                source.Execute(scope);
            }
            catch (IronPython.Runtime.Exceptions.ImportException )
            {
                Console.WriteLine("Fucked !");
            }
            

            string str(byte[] x) => Encoding.Default.GetString(x);

            return (str(results.ToArray()));
        }


        //-------------------------(Runing .py files and using args of output)-------------------------//







        //-------------------------(Equation Solving With AngouriMath)-------------------------//
        private void EquSolver_Click(object sender, EventArgs e)
        {
            try
            {
                String RootVarText = (RootVarBox.Text);

                RootsBox.ForeColor = Color.FromArgb(0, 64, 0);
                String EquAnswer = EquBox.Text;
                String FEquAnswer = (EquAnswer.Solve(RootVarText).ToString());
                Console.WriteLine(FEquAnswer);
                RootsBox.Text = FEquAnswer;
            } catch (AngouriMath.Core.Exceptions.UnhandledParseException)
            {
                RootsBox.ForeColor = Color.Red;
                Console.WriteLine("INVALID EQUATION!");
                RootsBox.Text = "INVALID EQUATION!";
            }
            catch (AngouriMath.Core.Exceptions.SolveRequiresStatementException)
            {
                RootsBox.ForeColor = Color.Red;
                Console.WriteLine("INVALID EQUATION!");
                RootsBox.Text = "INVALID EQUATION!";
            }
        }

        private void EquCleaner_Click(object sender, EventArgs e)
        {
            AnsBox.ForeColor = Color.FromArgb(0, 64, 0);
            EquBox.Text = "";
            RootsBox.Text = "0";
        }

        
    }
}
