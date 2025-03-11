using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Регистратура_поликлиники
{
    public partial class Avtorozacia : Form
    {
        public Avtorozacia()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Glavnay ff = new Glavnay();
            ff.Show();
            this.Hide();
        }
    }
}
