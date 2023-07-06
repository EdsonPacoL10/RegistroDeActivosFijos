using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ExamenPrimerParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
     

        SqlConnection conexion = new SqlConnection("server=39-SVEN\\EDSON;database=negocio;integrated security=true");
        //conexion a la base de datos

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Para el usuario solo ingresar letras ", "DATO NO VALIDO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void bot_salir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GRACIAS POR VISITARNOS HASTA LUEGO :-)", "Salida del sistema", MessageBoxButtons.OK,
           MessageBoxIcon.Exclamation); 
            Close();
        }
       int  intentos=0;
        private void bot_ingresar_Click(object sender, EventArgs e)
        {
            conexion.Open();

            if (intentos < 3)
            {

                string consulta = "select * from usuario where usuario='" + txt_usuario.Text + "' and contraseña='"
                    + txt_contraseña.Text + "'";
                //consulta sql
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataReader lector;

                lector = comando.ExecuteReader();
                //validacion de los datos si existen e ingreso al sistema o salida en caso de muchos errores
                if (lector.HasRows == true)
                {
                    MessageBox.Show("BIENVENIDO AL SISTEMA ");
                    Menu_Principal frmMenu = new Menu_Principal();
                    this.Hide();
                    frmMenu.Show();
                }
                else
                {
                    intentos++;
                    MessageBox.Show("LOS DATOS INGRESADOS SON INCORRECTOS");
                    MessageBox.Show("AL TERCER INTENTO FALLIDO EL SISTEMA SE CERRARA !CUIDADO¡", "NUMERO DE INTENTOS : "
                        + intentos, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    conexion.Close();
                }

            }
            else
            {
                intentos = 0;
                MessageBox.Show("MAXIMO DE INTENTOS", "Cierre de sistema");
                Close();
            }
        }
    }
}
