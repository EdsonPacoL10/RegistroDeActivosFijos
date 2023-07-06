using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenPrimerParcial
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            activos_fijos frmMenu = new activos_fijos();
            this.Hide();
            frmMenu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            usuario frmMenu = new usuario();
            this.Hide();
            frmMenu.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 frmMenu = new Form1();
            this.Hide();
            frmMenu.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GRACIAS POR VISITARNOS HASTA LUEGO :-)", "Salida del sistema", MessageBoxButtons.OK,
              MessageBoxIcon.Exclamation);
            Close();
        }
    }
}
