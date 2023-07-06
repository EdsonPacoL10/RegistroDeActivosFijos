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
    public partial class activos_fijos : Form
    {
        public activos_fijos()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("server=39-SVEN\\EDSON;database=negocio;integrated security=true");

        public void limpiar_campos()
        {
            //para poder limpiar campos
            txt_id_activos.Clear();
            txt_descripcion.Clear();
            txt_partida_presupuestaria.Clear();
            txt_codigo.Clear();
            txt_serie.Clear();
            txt_rubro.Clear();
            txt_busqueda.Clear();

        }
        public void actualizar_tabla()
        {//actualizacion de la tabla segun la consulta select
            string consulta = "select * from activos_fijos";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            DGV1.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //boton busqueda  y validacion de datos inresados correctamente
            if (txt_busqueda.Text != "")
            {
                if (rt_codigo.Checked == true || rt_descripcion.Checked == true || rt_id.Checked == true )
                {

                    if (rt_codigo.Checked == true)
                    {
                        conexion.Open();
                        string consulta1 = "select  * from activos_fijos where codigo='" + txt_busqueda.Text + "';";

                       
                        SqlCommand comando1 = new SqlCommand(consulta1, conexion);
                        SqlDataReader lector1;
                        lector1 = comando1.ExecuteReader();
                        if (lector1.Read())
                        {
                            txt_id_activos.Text = lector1["id_activos"].ToString();
                            txt_descripcion.Text = lector1["descripcion"].ToString();
                            txt_partida_presupuestaria.Text = lector1["partida_presupuestaria"].ToString();
                            txt_rubro.Text = lector1["rubro"].ToString();
                            txt_estado.Text = lector1["estado"].ToString();
                            txt_codigo.Text = lector1["codigo"].ToString();
                            txt_serie.Text = lector1["serie"].ToString();
                        }
                        else
                        {
                            MessageBox.Show(" NO EXISTE DATO ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        conexion.Close();
                    }
                    if (rt_descripcion.Checked == true)
                    {
                        conexion.Open();
                        string consulta2 = "select  * from activos_fijos where descripcion='" + txt_busqueda.Text + "';";

                               SqlCommand comando2 = new SqlCommand(consulta2, conexion);
                        SqlDataReader lector2;
                        lector2 = comando2.ExecuteReader();
                        if (lector2.Read())
                        {
                            txt_id_activos.Text = lector2["id_activos"].ToString();
                            txt_descripcion.Text = lector2["descripcion"].ToString();
                            txt_partida_presupuestaria.Text = lector2["partida_presupuestaria"].ToString();
                            txt_rubro.Text = lector2["rubro"].ToString();
                            txt_estado.Text = lector2["estado"].ToString();
                            txt_codigo.Text = lector2["codigo"].ToString();
                            txt_serie.Text = lector2["serie"].ToString();
                        }
                        else
                        {
                            MessageBox.Show(" NO EXISTE DATO ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        conexion.Close();
                    }

                    if (rt_id.Checked == true)
                    {
                        conexion.Open();
                        string consulta3 = "select  * from activos_fijos where id_activos=" + txt_busqueda.Text + ";";

                        
                        SqlCommand comando3 = new SqlCommand(consulta3, conexion);
                        SqlDataReader lector3;
                        lector3 = comando3.ExecuteReader();
                        if (lector3.Read())
                        {
                            txt_id_activos.Text = lector3["id_activos"].ToString();
                            txt_descripcion.Text = lector3["descripcion"].ToString();
                            txt_partida_presupuestaria.Text = lector3["partida_presupuestaria"].ToString();
                            txt_rubro.Text = lector3["rubro"].ToString();
                            txt_estado.Text = lector3["estado"].ToString();
                            txt_codigo.Text = lector3["codigo"].ToString();
                            txt_serie.Text = lector3["serie"].ToString();
                         
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Mostrar la informacion con un clic de la grilla a las cajas de          texto
                txt_id_activos.Text = DGV1.SelectedCells[0].Value.ToString();
                txt_descripcion.Text = DGV1.SelectedCells[1].Value.ToString();
                txt_partida_presupuestaria.Text = DGV1.SelectedCells[2].Value.ToString();
                txt_rubro.Text = DGV1.SelectedCells[3].Value.ToString();
                txt_estado.Text = DGV1.SelectedCells[4].Value.ToString();
                txt_codigo.Text = DGV1.SelectedCells[5].Value.ToString();
                txt_serie.Text = DGV1.SelectedCells[6].Value.ToString();
              
            }
            catch { }
        }

        private void bot_modificar_Click(object sender, EventArgs e)
        {
            
            //Para modificar registro en el boton modificar
            conexion.Open();
            if ((txt_id_activos.Text != "") &&
                 (txt_descripcion.Text != "") && (txt_partida_presupuestaria.Text != "") &&
                 (txt_estado.Text != "") && (txt_rubro.Text != "") &&
                 (txt_codigo.Text != "") && (txt_serie.Text != ""))
            {
                string consulta = "UPDATE activos_fijos SET id_activos =" + txt_id_activos.Text + ",descripcion ='" + txt_descripcion.Text +
                "',partida_presupuestaria=" + txt_partida_presupuestaria.Text + ",rubro='" + txt_rubro.Text + "',estado='" + txt_estado.Text +
                "',codigo='" + txt_codigo.Text + "',serie='" + txt_serie.Text+ "' where id_activos=" + txt_id_activos.Text + ";";

                SqlCommand comando = new SqlCommand(consulta, conexion);
                int contador;
                contador = comando.ExecuteNonQuery();
                if (contador > 0)
                {
                    MessageBox.Show("Registro del activo fijo :  " + txt_descripcion.Text + " modificado en la Base de  Datos");
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
            if (txt_id_activos.Text != "")
            {
                string consulta = "delete from activos_fijos where id_activos=" + txt_id_activos.Text;
                SqlCommand comando = new SqlCommand(consulta, conexion);
                int contador;
                contador = comando.ExecuteNonQuery();
                if (contador > 0)
                {
                    MessageBox.Show("El activo fijo  fue eliminado con exito");
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
                MessageBox.Show("DAR EL ID QUE DESEA ELIMINAR QUE DESEA ELIMINAR ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conexion.Close();
            }
        }

        private void bot_nuevo_Click(object sender, EventArgs e)
        {
            if ((txt_id_activos.Text != "") &&
                 (txt_descripcion.Text != "") && (txt_partida_presupuestaria.Text != "") &&
                 (txt_estado.Text != "") && (txt_rubro.Text != "") &&
                 (txt_codigo.Text != "") && (txt_serie.Text != ""))
            {
                //Para Agregar registro en el boton nuevo
                conexion.Open();
                string consulta = "insert into activos_fijos values(" + txt_id_activos.Text + ",'" + txt_descripcion.Text + "'," + txt_partida_presupuestaria.Text +
                 ",'" + txt_rubro.Text + "','" + txt_estado.Text + "','" + txt_codigo.Text + "','" + txt_serie.Text + "');";
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

        private void bot_volver_menu_Click(object sender, EventArgs e)
        {
             Menu_Principal frmMenu = new Menu_Principal();
            this.Hide();
            frmMenu.Show();
        }

        private void activos_fijos_Load(object sender, EventArgs e)
        {
            actualizar_tabla();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            limpiar_campos();
        }

        private void txt_id_activos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("DAR DATOS NUMERICOS PORFAVOR", "DATO NO VALIDO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                e.Handled = true;
                return;
            }
        }

        private void txt_partida_presupuestaria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("DAR DATOS NUMERICOS PORFAVOR", "DATO NO VALIDO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                e.Handled = true;
                return;
            }
        }

        private void txt_id_activos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
