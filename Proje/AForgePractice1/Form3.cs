using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AForgePractice1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void ledYakmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 ledyakma = new Form1();
            ledyakma.ShowDialog();
        }

        private void canlıNesneTakibiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 nesnetakip = new Form2();
            nesnetakip.ShowDialog();
        }
    }
}
