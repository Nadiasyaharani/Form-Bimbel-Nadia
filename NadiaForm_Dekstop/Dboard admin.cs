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
    public partial class Dboard_admin : Form
    {
        public Dboard_admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Master_data().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Jadwal_Pelajaran().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Registrasi_Bimbel().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Data_Angsuran().Show();
            this.Hide();
        }
    }
}
