using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numbers
{
    public partial class Form3 : Form
    {
        int right, wrong = 0;
        string ans;

        string[] coefa = new string[26] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        string coef = "";
        string alg_z = "";

        int rn = -1;

        Form formb = new Form();

        public Form3()
        {
            InitializeComponent();
        }

        private void ShowBackForm()
        {
            formb = new Form();
            formb.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height - 2);
            //formb.BackColor = //FromArgb(255, 79, 254, 27);
            formb.MaximizeBox = false;
            formb.MinimizeBox = false;
            formb.ControlBox = false;
            formb.FormBorderStyle = FormBorderStyle.Fixed3D;
            //formb.Icon = 
            //formb.Icon = Numbers.Properties.Resources.cl_icon;
            formb.SendToBack();

            formb.Click += new EventHandler(formb_Click);
            formb.Show();
        }

        void formb_Click(object sender, EventArgs e)
        {
            formb.BringToFront();
            this.BringToFront();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ShowBackForm();

            //this.Text = "Algebra - " + "by rilobas applications (www.rilobas.app)";
            this.Text = "Learn Algebra";
            txt_inf.Text = "Click Begin, type in the answer, then Press Enter...";

            AcceptButton = btn_s;
        }

        private void btn_s_Click(object sender, EventArgs e)
        {
            if (txt_q.Text != "")
            {
                MarkQuestion();
            }
        }

        private void MarkQuestion()
        {

            //MessageBox.Show(rn.ToString());
            //System.IO.File.AppendAllText(@"C://Users/" + Environment.UserName + "/Desktop/sols.txt", txt_q.Text + " --> " + txt_a.Text + Environment.NewLine);

            if (rn == 0)
            {
                if (txt_a.Text == ans.ToString())
                {
                    //MessageBox.Show("Correct!");
                    right++;
                    System.Media.SystemSounds.Asterisk.Play();
                }
                else
                {
                    wrong++;
                    //MessageBox.Show(ans.ToString());               
                    System.Media.SystemSounds.Beep.Play();
                }
            }
            else
            {
                if (txt_a.Text == ans.ToString())
                {
                    //MessageBox.Show("Correct!");
                    right++;
                    System.Media.SystemSounds.Asterisk.Play();
                }
                else
                {
                    wrong++;
                    //MessageBox.Show(ans.ToString());               
                    System.Media.SystemSounds.Beep.Play();
                }
            }
            btn_gen.PerformClick();
        }

        private void btn_gen_Click(object sender, EventArgs e)
        {
            txt_a.ReadOnly = false;

            progressBar1.Value = 100;
            timer1.Start();

            txt_ca.Text = "";
            txt_a.Text = "";
            double pscore = (double.Parse(right.ToString()) / double.Parse((right + wrong).ToString()) * 100);
            txt_inf.Text = "score: " + right.ToString() + " / " + (right + wrong).ToString() + " (" + Math.Round(pscore, 2) + "%)";


            GetTopic();

            txt_a.Focus();


        }

        private void GetTopic()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);


            rn = rnd.Next(0, 2);


            if (rn == 0)//Algebra
            {
                int n1 = rnd.Next(-20, 11);
                int n2 = rnd.Next(-20, 11);
                ans = (n1 + n2).ToString();

                coef = coefa[rnd.Next(0, 26)];


                string sn1 = n1.ToString();
                string sn2 = n2.ToString();


                if (sn2.Substring(0, 1) == "-")
                {

                }
                else
                {
                    sn2 = "+" + sn2;
                }

                string[] qqs = new string[3] { "?", "??", "???" };
                string qq = qqs[rnd.Next(0, 2)];

                txt_command.Text = "Solve the algebraic equation";
                txt_q.Text = "" + sn1 + coef + "" + sn2 + coef + " = " + qq;

                if (ans == "-1") { ans = "-" + coef; }
                else if (ans == "1") { ans = coef; }
                else if (ans == "0")
                {
                    //ans = ans;
                }
                else { ans = ans + coef; }
            }
            else if (rn == 1)
            {
                algebra();
                //
            }

            //this.Text = ans;

        }

        private void algebra()
        {
            coef = "";

            Random alge = new Random(DateTime.Now.Millisecond);
            int alg_w, alg_x, alg_y = 0;


            alg_w = alge.Next(1, 10);
            alg_x = alge.Next(1, 10);
            alg_y = alge.Next(1, 10);

            alg_z = coefa[alge.Next(0, 26)];


            int q_switch = alge.Next(0, 3);
            switch (q_switch)
            {
                case (0):
                    txt_command.Text = "Solve for " + alg_z + " in the equation";
                    break;
                case (1):
                    txt_command.Text = "Find " + alg_z + " in the equation";
                    break;
                case (2):
                    txt_command.Text = "What is the value of " + alg_z + " in the equation?";
                    break;
            }

            if (DateTime.Now.Millisecond % 3 == 0)
            {
                txt_q.Text = "" + alg_w + alg_z + "=" + alg_w * alg_y + "";
                ans = alg_y.ToString();
            }
            else if (DateTime.Now.Millisecond % 3 == 1)
            {
                int alg_k = (alg_w * alg_y) + (alg_w * alg_x);
                txt_q.Text = "" + alg_w + alg_z + "+" + alg_w * alg_y + "=" + alg_k + "";
                ans = ((((alg_w * alg_y) + (alg_w * alg_x)) - (alg_w * alg_y)) / alg_w).ToString();
            }
            else if (DateTime.Now.Millisecond % 3 == 2)
            {
                int alg_k = (alg_w * alg_y) + (alg_w * alg_x);
                txt_q.Text = "" + alg_w + alg_z + "-" + alg_w * alg_y + "=" + alg_k + "";
                ans = ((((alg_w * alg_y) + (alg_w * alg_x)) + (alg_w * alg_y)) / alg_w).ToString();
            }



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string tu = "Time UP! - ";
            progressBar1.Value = progressBar1.Value - 5;
            if (progressBar1.Value == 0)
            {
                txt_a.ReadOnly = true;
                timer1.Stop();

                if (txt_a.Text == ans.ToString())
                {

                    btn_s_Click(sender, e);
                }
                else
                {
                    if (coef == "")
                    {
                        txt_ca.Text = tu + "The correct value for " + alg_z + " is " + ans.ToString();
                    }
                    else
                    {
                        txt_ca.Text = tu + "The correct answer is " + ans.ToString();
                    }

                    txt_ca.Text += Environment.NewLine + "Press Enter to continue..";
                }


            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.rbapps.app/product-alg.php");
            btn_gen.Focus();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            
            System.Diagnostics.Process.Start("calc.exe");
            btnCalculator.Visible = false;
        }


    }
}
