using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; 
namespace PRACTICA_11
{
    public partial class frmtext : Form
    {
        public frmtext()
        {
            InitializeComponent();
        }

        private void btntes_Click(object sender, EventArgs e)
        {
            // prueba de conexio a base de datos

            string connectionString = "";
            MySqlConnection conn; 

            try
            {
                connectionString = @"Server=localhost;Database=codigodel;Uid=root;
                                      Pwd=usbw;SSL Mode=None";
                conn = new MySqlConnection(connectionString);
                conn.Open();
                MetroFramework.MetroMessageBox.Show(this, "se establecio conexion",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information); 

            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message,
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
    }
}
