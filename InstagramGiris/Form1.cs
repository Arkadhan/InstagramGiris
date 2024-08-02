using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstagramGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbKadi.Text=="hakan" && tbPassword.Text=="1234")
                {
                    Form2 frm2 = new Form2();
                    frm2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Bilgiler hatalı", "Başarısız",MessageBoxButtons.OK,MessageBoxIcon.Stop);

                }

            }
            catch
            {
                MessageBox.Show("Bilgiler hatalı", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
