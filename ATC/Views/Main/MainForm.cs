using System;
using System.Windows.Forms;

namespace ATC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Program.form1 = this;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            new AboutProgram().Show();
        }

        private void DX_500But_Click(object sender, EventArgs e)
        {
            if (FIO.Text != "" & N_group.Text != "")
            {
                new DX_500(FIO.Text, N_group.Text).Show();
                IsEnabledF();
                FIO.Text = "";
                N_group.Text = "";
            }
            else
            {
                MessageBox.Show("ПОЖАЛУЙСТА заполните поля ввода");
            }
        }

        private void HiComBut_Click(object sender, EventArgs e)
        {
            IsEnabledT();
            if (FIO.Text != "" & N_group.Text != "")
            {
                new HiCom(FIO.Text, N_group.Text).Show();
                IsEnabledF();
                FIO.Text = "";
                N_group.Text = "";
            }
            else
            {
                MessageBox.Show("ПОЖАЛУЙСТА заполните поля ввода");
            }
        }

        private static void IsEnabledT()
        {
            Program.form1.button1.Enabled = true;
            Program.form1.button2.Enabled = true;
            Program.form1.HiComBut.Enabled = true;
            Program.form1.DX_500But.Enabled = true;
            Program.form1.HipassBut.Enabled = true;
            Program.form1.AllTestsButton.Enabled = true;
            Program.form1.T_76But.Enabled = true;
        }
        private static void IsEnabledF()
        {
            Program.form1.button1.Enabled = false;
            Program.form1.button2.Enabled = false;
            Program.form1.HiComBut.Enabled = false;
            Program.form1.DX_500But.Enabled = false;
            Program.form1.HipassBut.Enabled = false;
            Program.form1.AllTestsButton.Enabled = false;
            Program.form1.T_76But.Enabled = false;
        }
        private void T_76But_Click(object sender, EventArgs e)
        {
            if (FIO.Text != "" & N_group.Text != "")
            {
                new T_76(FIO.Text, N_group.Text).Show();
                IsEnabledF();
                FIO.Text = "";
                N_group.Text = "";
            }
            else
            {
                MessageBox.Show("ПОЖАЛУЙСТА заполните поля ввода");
            }
        }

        private void HipassBut_Click(object sender, EventArgs e)
        {
            if (FIO.Text != "" & N_group.Text != "")
            {
                new HiPass(FIO.Text, N_group.Text).Show();
                IsEnabledF();
                FIO.Text = "";
                N_group.Text = "";
            }
            else
            {
                MessageBox.Show("ПОЖАЛУЙСТА заполните поля ввода");
            }
        }

        private void AllTestsButton_Click(object sender, EventArgs e)
        {
            if (FIO.Text != "" & N_group.Text != "")
            {
                new Alltests(FIO.Text, N_group.Text).Show();
                IsEnabledF();
                FIO.Text = "";
                N_group.Text = "";
            }
            else
            {
                MessageBox.Show("ПОЖАЛУЙСТА заполните поля ввода");
            }
        }


        private void AboutProgram_Click(object sender, EventArgs e)
        {
            new AboutProgram().Show();
            AboutProgram.Enabled = false;
        }
    }
}
