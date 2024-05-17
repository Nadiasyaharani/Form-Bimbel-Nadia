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
    public partial class Data_Angsuran : Form
    {
        public Data_Angsuran()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Angsuran_Baru().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Kategori_Angsuran().Show();
            this.Hide();
        }
    }
}
