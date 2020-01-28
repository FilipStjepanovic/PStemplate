using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FrmServer : Form
    {
        private Server s;
        private Thread nit;
        
        public FrmServer()
        {
            InitializeComponent();
        }

        private void FrmServer_Load(object sender, EventArgs e)
        {
            s = new Server();
           
            if (s.PokreniServer())
            {
                nit = new Thread(s.Osluskuj);
                nit.IsBackground = true;
                nit.Start();
                MessageBox.Show("Server je pokrenut!");
            }
            else
            {
                MessageBox.Show("Server nije pokrenut!");
            }
        }
    }
}
