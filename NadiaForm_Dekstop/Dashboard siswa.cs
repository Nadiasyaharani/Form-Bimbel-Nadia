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
    public partial class Dashboard_siswa : Form
    {
        public Dashboard_siswa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Angsuran_Siswa().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Jadwal_Pelajaran_Siswa().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }
    }
}
