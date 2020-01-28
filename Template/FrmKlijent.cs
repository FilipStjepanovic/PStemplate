using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Template
{
    public partial class FrmKlijent : Form
    {
        public FrmKlijent()
        {
            InitializeComponent();
        }

        private void FrmKlijent_Load(object sender, EventArgs e)
        {
            if (Komunikacija.Instance.PoveziSe())
            {

            }
            else
            {
                MessageBox.Show("Nije moguce povezati se sa serverom!");
            }
        }
    }
}
