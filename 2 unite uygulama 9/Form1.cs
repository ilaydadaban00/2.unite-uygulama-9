using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_unite_uygulama_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKontrol_et_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txtSAyi.Text);
            if(sayi  >=50 )
            {
                if (sayi >= 85)
                {
                    label2.Text = "takdir belgesi aldınız:)";
                }else if(sayi >= 70)
                {
                    MessageBox.Show("tesekkur belgesi aldınız:)");
                }
                else
                {
                    MessageBox.Show("düz geçti");
                }
            }
            else
            {
                MessageBox.Show("sınıfta kaldınız");
            }
        }
    }
}
