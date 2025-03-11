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
    public partial class Otcet : Form
    {
        public Otcet()
        {
            InitializeComponent();
        }

        private void Otcet_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Glavnay ff = new Glavnay();
            ff.Show();
            this.Hide();
        }
    }
}
