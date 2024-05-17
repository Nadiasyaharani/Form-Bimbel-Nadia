using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NadiaForm_Dekstop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Siswa" && textBox2.Text == "2")
            {
                new Dashboard_siswa().Show();
                this.Hide();
            }
            else if (textBox1.Text == "Guru" && textBox2.Text == "1")
            {
                new Dboard_admin().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nama pengguna / kata sandi salah");
            }
        }
    }
}
