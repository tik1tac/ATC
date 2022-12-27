using System;
using System.Windows.Forms;

namespace ATC
{
    public partial class Rezult : Form
    {
        public Rezult()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.form1.button1.Enabled = true;
            Program.form1.button2.Enabled = true;
            Program.form1.HiComBut.Enabled = true;
            Program.form1.DX_500But.Enabled = true;
            Program.form1.AllTestsButton.Enabled = true;
            Program.form1.HipassBut.Enabled = true;
            Program.form1.T_76But.Enabled = true;
        }

    }
}
