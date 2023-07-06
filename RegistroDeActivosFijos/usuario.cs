using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ExamenPrimerParcial
{
    public partial class usuario : Form
    {
        public usuario()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("server=39-SVEN\\EDSON;database=negocio;integrated security=true");
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        public void limpiar_campos()
        {
            //para poder limpiar campos
            txt_id.Clear();
            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_usuario.Clear();
            txt_contraseña.Clear();
            txt_busqueda.Clear();
        }
        public void actualizar_tabla()
        {//actualizacion de la tabla segun la consulta select
            string consulta = "select * from usuario";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            DGV1.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Menu_Principal frmMenu = new Menu_Principal();
            this.Hide();
            frmMenu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            //Para modificar registro en el boton modificar
            conexion.Open();
            if ((txt_id.Text != "") &&
                 (txt_nombre.Text != "") && (txt_apellido.Text != "") &&
                 (txt_usuario.Text != "") && (txt_contraseña.Text != "")                 )
            {
                string consulta = "UPDATE usuario SET id_usuario =" + txt_id.Text + ",nombre ='" + txt_nombre.Text +
                "',apellido='" + txt_apellido.Text + "',usuario='" + txt_usuario.Text + "',contraseña='" + txt_contraseña.Text + "' where id_usuario=" + txt_id.Text + ";";

                SqlCommand comando = new SqlCommand(consulta, conexion);
                int contador;
                contador = comando.ExecuteNonQuery();
                if (contador > 0)
                {
                    MessageBox.Show("El usuario fue modificado en la Base de  Datos");
                }
                else
                {
                    MessageBox.Show("NO PODEMOS MODIFICAR PORQUE EL DATO NO EXISTE");
                }
                actualizar_tabla();
                limpiar_campos();
            }
            else
            {
                MessageBox.Show("FALTAN CAMPOS PARA MODIFICAR ", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            conexion.Close();
        }

        private void bot_eliminar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (txt_id.Text != "")
            {
                string consulta = "delete from usuario where id_usuario=" + txt_id.Text;
                SqlCommand comando = new SqlCommand(consulta, conexion);
                int contador;
                contador = comando.ExecuteNonQuery();
                if (contador > 0)
                {
                    MessageBox.Show("El usuario  fue eliminado con exito");
                }
                else
                {
                    MessageBox.Show("NO PUEDE ELIMINAR, PORQUE EL DATO NO EXISTE");
                }


                actualizar_tabla();
                limpiar_campos();
                conexion.Close();
            }
            else
            {
                MessageBox.Show("DAR EL ID USUARIO QUE DESEA ELIMINAR  ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conexion.Close();
            }
        }

        private void bot_insertar_Click(object sender, EventArgs e)
        {
            if ((txt_id.Text != "") &&
              (txt_nombre.Text != "") && (txt_apellido.Text != "") &&
              (txt_usuario.Text != "") && (txt_contraseña.Text != "") )
            {
                //Para Agregar registro en el boton nuevo
                conexion.Open();
                string consulta = "insert into usuario values(" + txt_id.Text + ",'" + txt_nombre.Text + "','" + txt_apellido.Text +
                 "','" + txt_usuario.Text + "','" + txt_contraseña.Text + "');";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro de usuario agregado a la Base de Datos");
                actualizar_tabla();
                limpiar_campos();
                conexion.Close();
            }
            else
            {
                //mensaje de error al no llenar datos correctamente
                MessageBox.Show("FALTAN CAMPOS POR LLENAR ", "Mensaje de ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bot_limpiar_Click(object sender, EventArgs e)
        {
            limpiar_campos();
        }

        private void usuario_Load(object sender, EventArgs e)
        {
            actualizar_tabla();
        }

        private void bot_buscar_Click(object sender, EventArgs e)
        {
            //boton busqueda  y validacion de datos inresados correctamente
            if (txt_busqueda.Text != "")
            {
                if (rt_nombre.Checked == true || RT_USUARIO.Checked == true )
                {

                    if (rt_nombre.Checked == true)
                    {
                        conexion.Open();
                        string consulta1 = "select  * from usuario where nombre='" + txt_busqueda.Text + "';";


                        SqlCommand comando1 = new SqlCommand(consulta1, conexion);
                        SqlDataReader lector1;
                        lector1 = comando1.ExecuteReader();
                        if (lector1.Read())
                        {
                            txt_id.Text = lector1["id_usuario"].ToString();
                            txt_nombre.Text = lector1["nombre"].ToString();
                            txt_apellido.Text = lector1["apellido"].ToString();
                            txt_usuario.Text = lector1["usuario"].ToString();
                            txt_contraseña.Text = lector1["contraseña"].ToString();
                            }
                        else
                        {
                            MessageBox.Show(" NO EXISTE DATO ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        conexion.Close();
                    }
                    if (RT_USUARIO.Checked == true)
                    {
                        conexion.Open();
                        string consulta2 = "select  * from usuario where usuario='" + txt_busqueda.Text + "';";

                        SqlCommand comando2 = new SqlCommand(consulta2, conexion);
                        SqlDataReader lector2;
                        lector2 = comando2.ExecuteReader();
                        if (lector2.Read())
                        {
                            txt_id.Text = lector2["id_usuario"].ToString();
                            txt_nombre.Text = lector2["nombre"].ToString();
                            txt_apellido.Text = lector2["apellido"].ToString();
                            txt_usuario.Text = lector2["usuario"].ToString();
                            txt_contraseña.Text = lector2["contraseña"].ToString();
                        }
                        else
                        {
                            MessageBox.Show(" NO EXISTE DATO ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        conexion.Close();
                    }

                   
                }
                else
                {
                    MessageBox.Show(" NO ESTA SELECCIONADO UNA OPCION ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("NO HAY DATO DE BUSQUEDA ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Mostrar la informacion con un clic de la grilla a las cajas de          texto
                txt_id.Text = DGV1.SelectedCells[0].Value.ToString();
                txt_nombre.Text = DGV1.SelectedCells[1].Value.ToString();
                txt_apellido.Text = DGV1.SelectedCells[2].Value.ToString();
                txt_usuario.Text = DGV1.SelectedCells[3].Value.ToString();
                txt_contraseña.Text = DGV1.SelectedCells[4].Value.ToString();
             
            }
            catch { }
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("DAR DATOS NUMERICOS PORFAVOR", "DATO NO VALIDO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                e.Handled = true;
                return;
            }
        }
    }
}
