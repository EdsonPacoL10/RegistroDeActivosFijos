
namespace ExamenPrimerParcial
{
    partial class usuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bot_limpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.bot_eliminar = new System.Windows.Forms.Button();
            this.bot_modificar = new System.Windows.Forms.Button();
            this.bot_insertar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.RT_USUARIO = new System.Windows.Forms.RadioButton();
            this.rt_nombre = new System.Windows.Forms.RadioButton();
            this.bot_buscar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bot_limpiar
            // 
            this.bot_limpiar.BackColor = System.Drawing.Color.MistyRose;
            this.bot_limpiar.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.bot_limpiar.Location = new System.Drawing.Point(6, 108);
            this.bot_limpiar.Name = "bot_limpiar";
            this.bot_limpiar.Size = new System.Drawing.Size(119, 23);
            this.bot_limpiar.TabIndex = 0;
            this.bot_limpiar.Text = "LIMPIAR";
            this.bot_limpiar.UseVisualStyleBackColor = false;
            this.bot_limpiar.Click += new System.EventHandler(this.bot_limpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(194, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "USUARIOS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_contraseña);
            this.groupBox1.Controls.Add(this.txt_usuario);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.txt_apellido);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 174);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS";
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(167, 139);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(154, 23);
            this.txt_contraseña.TabIndex = 12;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(167, 110);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(154, 23);
            this.txt_usuario.TabIndex = 11;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(167, 45);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(154, 23);
            this.txt_nombre.TabIndex = 10;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(167, 79);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(154, 23);
            this.txt_apellido.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(20, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "CONTRASEÑA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(20, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "USUARIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(20, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(20, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "APELLIDO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID USUARIO";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(167, 18);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(154, 23);
            this.txt_id.TabIndex = 3;
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGV1);
            this.groupBox2.Location = new System.Drawing.Point(12, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(515, 191);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TABLA";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // DGV1
            // 
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Location = new System.Drawing.Point(20, 22);
            this.DGV1.Name = "DGV1";
            this.DGV1.RowTemplate.Height = 25;
            this.DGV1.Size = new System.Drawing.Size(484, 150);
            this.DGV1.TabIndex = 6;
            this.DGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV1_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.bot_eliminar);
            this.groupBox3.Controls.Add(this.bot_modificar);
            this.groupBox3.Controls.Add(this.bot_insertar);
            this.groupBox3.Controls.Add(this.bot_limpiar);
            this.groupBox3.Location = new System.Drawing.Point(539, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(131, 191);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BOTONES";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.MistyRose;
            this.button6.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(18, 145);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 26);
            this.button6.TabIndex = 4;
            this.button6.Text = "ATRAS";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // bot_eliminar
            // 
            this.bot_eliminar.BackColor = System.Drawing.Color.MistyRose;
            this.bot_eliminar.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.bot_eliminar.Location = new System.Drawing.Point(6, 50);
            this.bot_eliminar.Name = "bot_eliminar";
            this.bot_eliminar.Size = new System.Drawing.Size(119, 23);
            this.bot_eliminar.TabIndex = 3;
            this.bot_eliminar.Text = "ELIMINAR";
            this.bot_eliminar.UseVisualStyleBackColor = false;
            this.bot_eliminar.Click += new System.EventHandler(this.bot_eliminar_Click);
            // 
            // bot_modificar
            // 
            this.bot_modificar.BackColor = System.Drawing.Color.MistyRose;
            this.bot_modificar.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.bot_modificar.Location = new System.Drawing.Point(6, 21);
            this.bot_modificar.Name = "bot_modificar";
            this.bot_modificar.Size = new System.Drawing.Size(119, 23);
            this.bot_modificar.TabIndex = 2;
            this.bot_modificar.Text = "MODIFICAR";
            this.bot_modificar.UseVisualStyleBackColor = false;
            this.bot_modificar.Click += new System.EventHandler(this.button3_Click);
            // 
            // bot_insertar
            // 
            this.bot_insertar.BackColor = System.Drawing.Color.MistyRose;
            this.bot_insertar.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.bot_insertar.Location = new System.Drawing.Point(6, 79);
            this.bot_insertar.Name = "bot_insertar";
            this.bot_insertar.Size = new System.Drawing.Size(119, 23);
            this.bot_insertar.TabIndex = 1;
            this.bot_insertar.Text = "INSERTAR";
            this.bot_insertar.UseVisualStyleBackColor = false;
            this.bot_insertar.Click += new System.EventHandler(this.bot_insertar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_busqueda);
            this.groupBox4.Controls.Add(this.RT_USUARIO);
            this.groupBox4.Controls.Add(this.rt_nombre);
            this.groupBox4.Controls.Add(this.bot_buscar);
            this.groupBox4.Location = new System.Drawing.Point(380, 67);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(147, 162);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "BUSQUEDA";
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Location = new System.Drawing.Point(6, 15);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(130, 23);
            this.txt_busqueda.TabIndex = 13;
            // 
            // RT_USUARIO
            // 
            this.RT_USUARIO.AutoSize = true;
            this.RT_USUARIO.Location = new System.Drawing.Point(31, 106);
            this.RT_USUARIO.Name = "RT_USUARIO";
            this.RT_USUARIO.Size = new System.Drawing.Size(74, 19);
            this.RT_USUARIO.TabIndex = 6;
            this.RT_USUARIO.TabStop = true;
            this.RT_USUARIO.Text = "USUARIO";
            this.RT_USUARIO.UseVisualStyleBackColor = true;
            // 
            // rt_nombre
            // 
            this.rt_nombre.AutoSize = true;
            this.rt_nombre.Location = new System.Drawing.Point(31, 77);
            this.rt_nombre.Name = "rt_nombre";
            this.rt_nombre.Size = new System.Drawing.Size(74, 19);
            this.rt_nombre.TabIndex = 5;
            this.rt_nombre.TabStop = true;
            this.rt_nombre.Text = "NOMBRE";
            this.rt_nombre.UseVisualStyleBackColor = true;
            // 
            // bot_buscar
            // 
            this.bot_buscar.BackColor = System.Drawing.Color.MistyRose;
            this.bot_buscar.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.bot_buscar.Location = new System.Drawing.Point(18, 43);
            this.bot_buscar.Name = "bot_buscar";
            this.bot_buscar.Size = new System.Drawing.Size(103, 23);
            this.bot_buscar.TabIndex = 4;
            this.bot_buscar.Text = "BUSCAR";
            this.bot_buscar.UseVisualStyleBackColor = false;
            this.bot_buscar.Click += new System.EventHandler(this.bot_buscar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ExamenPrimerParcial.Properties.Resources.Usuario_permisos_mybusinesspos_300x2001;
            this.pictureBox2.Location = new System.Drawing.Point(533, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(148, 151);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "usuario";
            this.Load += new System.EventHandler(this.usuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bot_limpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.Button bot_modificar;
        private System.Windows.Forms.Button bot_insertar;
        private System.Windows.Forms.Button bot_eliminar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.RadioButton RT_USUARIO;
        private System.Windows.Forms.RadioButton rt_nombre;
        private System.Windows.Forms.Button bot_buscar;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}