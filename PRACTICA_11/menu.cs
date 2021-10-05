using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA_11
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtext frm = new frmtext();

            // Derfinir el formulario padre 

            frm.MdiParent = this;
            frm.Show(); 
        }

        private void boockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.MdiParent = this;
            frm.Show(); 
            // 
        }
    }
}
