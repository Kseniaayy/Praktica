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
    public partial class Poisc_pacienta : Form
    {
        public Poisc_pacienta()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Registracia_pacienta ff = new Registracia_pacienta();
            ff.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Glavnay ff = new Glavnay();
            ff.Show();
            this.Hide();
        }
    }
}
