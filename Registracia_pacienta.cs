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
    public partial class Registracia_pacienta : Form
    {
        public Registracia_pacienta()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Poisc_pacienta ff = new Poisc_pacienta();
            ff.Show();
            this.Hide();
        }
    }
}
