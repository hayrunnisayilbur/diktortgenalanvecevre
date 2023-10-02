using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dikdortgen_alan_ve_cevre
{
    public partial class lblKenar2 : Form
    {
        public lblKenar2()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int kenar1, kenar2, alan, cevre;
            kenar1 = Convert.ToInt32(txtKenar1.Text);
            kenar2 = Convert.ToInt32(txtKenar2.Text);

            alan = kenar1 * kenar2;
            cevre = kenar1 * 2 + kenar2 * 2;
            //cevre = (kenar1 + kenar2) * 2;
            //cevre = kenar1 + kenar1 + kenar2 + kenar2;

            lblAlan.Text = "dikdörtgen alanı :" + alan.ToString();
            lblCevre.Text = "dikdörtgen çevresi :" + cevre.ToString();        }
    }
}
