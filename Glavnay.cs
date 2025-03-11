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
    public partial class Glavnay : Form
    {
        public Glavnay()
        {
            InitializeComponent();
        }

        private void Glavnay_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Avtorozacia ff = new Avtorozacia();
            ff.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zapisi_priem ff = new Zapisi_priem();
            ff.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Poisc_pacienta ff = new Poisc_pacienta();
            ff.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Otcet ff = new Otcet();
            ff.Show();
            this.Hide();
        }
    }
}
