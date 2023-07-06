
namespace ExamenPrimerParcial
{
    partial class activos_fijos
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
            this.bot_buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id_activos = new System.Windows.Forms.TextBox();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.bot_eliminar = new System.Windows.Forms.Button();
            this.bot_modificar = new System.Windows.Forms.Button();
            this.bot_nuevo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bot_volver_menu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_estado = new System.Windows.Forms.ComboBox();
            this.txt_serie = new System.Windows.Forms.TextBox();
            this.txt_partida_presupuestaria = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_rubro = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rt_descripcion = new System.Windows.Forms.RadioButton();
            this.rt_codigo = new System.Windows.Forms.RadioButton();
            this.rt_id = new System.Windows.Forms.RadioButton();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bot_buscar
            // 
            this.bot_buscar.BackColor = System.Drawing.Color.SeaGreen;
            this.bot_buscar.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bot_buscar.Location = new System.Drawing.Point(48, 151);
            this.bot_buscar.Name = "bot_buscar";
            this.bot_buscar.Size = new System.Drawing.Size(123, 29);
            this.bot_buscar.TabIndex = 0;
            this.bot_buscar.Text = "BUSCAR";
            this.bot_buscar.UseVisualStyleBackColor = false;
            this.bot_buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 38.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(203, -8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 66);
            this.label1.TabIndex = 1;
            this.label1.Text = "ACTIVOS FIJOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_id_activos
            // 
            this.txt_id_activos.Location = new System.Drawing.Point(190, 18);
            this.txt_id_activos.Name = "txt_id_activos";
            this.txt_id_activos.Size = new System.Drawing.Size(133, 23);
            this.txt_id_activos.TabIndex = 2;
            this.txt_id_activos.TextChanged += new System.EventHandler(this.txt_id_activos_TextChanged);
            this.txt_id_activos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_activos_KeyPress);
            // 
            // DGV1
            // 
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Location = new System.Drawing.Point(26, 241);
            this.DGV1.Name = "DGV1";
            this.DGV1.RowTemplate.Height = 25;
            this.DGV1.Size = new System.Drawing.Size(539, 197);
            this.DGV1.TabIndex = 3;
            this.DGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bot_eliminar
            // 
            this.bot_eliminar.BackColor = System.Drawing.Color.SeaGreen;
            this.bot_eliminar.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bot_eliminar.Location = new System.Drawing.Point(6, 54);
            this.bot_eliminar.Name = "bot_eliminar";
            this.bot_eliminar.Size = new System.Drawing.Size(123, 29);
            this.bot_eliminar.TabIndex = 4;
            this.bot_eliminar.Text = "ELIMINAR";
            this.bot_eliminar.UseVisualStyleBackColor = false;
            this.bot_eliminar.Click += new System.EventHandler(this.bot_eliminar_Click);
            // 
            // bot_modificar
            // 
            this.bot_modificar.BackColor = System.Drawing.Color.SeaGreen;
            this.bot_modificar.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bot_modificar.Location = new System.Drawing.Point(6, 19);
            this.bot_modificar.Name = "bot_modificar";
            this.bot_modificar.Size = new System.Drawing.Size(123, 29);
            this.bot_modificar.TabIndex = 5;
            this.bot_modificar.Text = "MODIFICAR";
            this.bot_modificar.UseVisualStyleBackColor = false;
            this.bot_modificar.Click += new System.EventHandler(this.bot_modificar_Click);
            // 
            // bot_nuevo
            // 
            this.bot_nuevo.BackColor = System.Drawing.Color.SeaGreen;
            this.bot_nuevo.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bot_nuevo.Location = new System.Drawing.Point(6, 88);
            this.bot_nuevo.Name = "bot_nuevo";
            this.bot_nuevo.Size = new System.Drawing.Size(123, 29);
            this.bot_nuevo.TabIndex = 6;
            this.bot_nuevo.Text = "NUEVO";
            this.bot_nuevo.UseVisualStyleBackColor = false;
            this.bot_nuevo.Click += new System.EventHandler(this.bot_nuevo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID ACTIVOS";
            // 
            // bot_volver_menu
            // 
            this.bot_volver_menu.BackColor = System.Drawing.Color.SeaGreen;
            this.bot_volver_menu.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bot_volver_menu.Location = new System.Drawing.Point(625, 409);
            this.bot_volver_menu.Name = "bot_volver_menu";
            this.bot_volver_menu.Size = new System.Drawing.Size(123, 29);
            this.bot_volver_menu.TabIndex = 8;
            this.bot_volver_menu.Text = "ATRAS";
            this.bot_volver_menu.UseVisualStyleBackColor = false;
            this.bot_volver_menu.Click += new System.EventHandler(this.bot_volver_menu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "PRESUPUESTARIA";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "PARTIDA ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "DESCRIPCION";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_estado);
            this.groupBox1.Controls.Add(this.txt_serie);
            this.groupBox1.Controls.Add(this.txt_partida_presupuestaria);
            this.groupBox1.Controls.Add(this.txt_descripcion);
            this.groupBox1.Controls.Add(this.txt_rubro);
            this.groupBox1.Controls.Add(this.txt_codigo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_id_activos);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 169);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS";
            // 
            // txt_estado
            // 
            this.txt_estado.FormattingEnabled = true;
            this.txt_estado.Items.AddRange(new object[] {
            "Malo",
            "Regular",
            "Bueno"});
            this.txt_estado.Location = new System.Drawing.Point(408, 54);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(131, 23);
            this.txt_estado.TabIndex = 24;
            // 
            // txt_serie
            // 
            this.txt_serie.Location = new System.Drawing.Point(406, 130);
            this.txt_serie.Name = "txt_serie";
            this.txt_serie.Size = new System.Drawing.Size(133, 23);
            this.txt_serie.TabIndex = 23;
            // 
            // txt_partida_presupuestaria
            // 
            this.txt_partida_presupuestaria.Location = new System.Drawing.Point(190, 94);
            this.txt_partida_presupuestaria.Name = "txt_partida_presupuestaria";
            this.txt_partida_presupuestaria.Size = new System.Drawing.Size(133, 23);
            this.txt_partida_presupuestaria.TabIndex = 21;
            this.txt_partida_presupuestaria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_partida_presupuestaria_KeyPress);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(190, 54);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(133, 23);
            this.txt_descripcion.TabIndex = 20;
            // 
            // txt_rubro
            // 
            this.txt_rubro.Location = new System.Drawing.Point(406, 18);
            this.txt_rubro.Name = "txt_rubro";
            this.txt_rubro.Size = new System.Drawing.Size(133, 23);
            this.txt_rubro.TabIndex = 19;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(406, 89);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(133, 23);
            this.txt_codigo.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(329, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 19);
            this.label10.TabIndex = 16;
            this.label10.Text = "SERIE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(329, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "CODIGO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(329, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "RUBRO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(329, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "ESTADO";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.bot_eliminar);
            this.groupBox2.Controls.Add(this.bot_modificar);
            this.groupBox2.Controls.Add(this.bot_nuevo);
            this.groupBox2.Location = new System.Drawing.Point(577, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 117);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FUNCIONES";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(135, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "LIMPIAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rt_descripcion);
            this.groupBox3.Controls.Add(this.rt_codigo);
            this.groupBox3.Controls.Add(this.rt_id);
            this.groupBox3.Controls.Add(this.txt_busqueda);
            this.groupBox3.Controls.Add(this.bot_buscar);
            this.groupBox3.Location = new System.Drawing.Point(577, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 196);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BUSCAR";
            // 
            // rt_descripcion
            // 
            this.rt_descripcion.AutoSize = true;
            this.rt_descripcion.Location = new System.Drawing.Point(26, 52);
            this.rt_descripcion.Name = "rt_descripcion";
            this.rt_descripcion.Size = new System.Drawing.Size(99, 19);
            this.rt_descripcion.TabIndex = 28;
            this.rt_descripcion.TabStop = true;
            this.rt_descripcion.Text = "DESCRIPCION";
            this.rt_descripcion.UseVisualStyleBackColor = true;
            // 
            // rt_codigo
            // 
            this.rt_codigo.AutoSize = true;
            this.rt_codigo.Location = new System.Drawing.Point(26, 77);
            this.rt_codigo.Name = "rt_codigo";
            this.rt_codigo.Size = new System.Drawing.Size(70, 19);
            this.rt_codigo.TabIndex = 27;
            this.rt_codigo.TabStop = true;
            this.rt_codigo.Text = "CODIGO";
            this.rt_codigo.UseVisualStyleBackColor = true;
            // 
            // rt_id
            // 
            this.rt_id.AutoSize = true;
            this.rt_id.Location = new System.Drawing.Point(26, 27);
            this.rt_id.Name = "rt_id";
            this.rt_id.Size = new System.Drawing.Size(86, 19);
            this.rt_id.TabIndex = 26;
            this.rt_id.TabStop = true;
            this.rt_id.Text = "ID ACTIVOS";
            this.rt_id.UseVisualStyleBackColor = true;
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Location = new System.Drawing.Point(38, 122);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(142, 23);
            this.txt_busqueda.TabIndex = 25;
            // 
            // activos_fijos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bot_volver_menu);
            this.Controls.Add(this.DGV1);
            this.Controls.Add(this.label1);
            this.Name = "activos_fijos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activos";
            this.Load += new System.EventHandler(this.activos_fijos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bot_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id_activos;
        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.Button bot_eliminar;
        private System.Windows.Forms.Button bot_modificar;
        private System.Windows.Forms.Button bot_nuevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bot_volver_menu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox txt_estado;
        private System.Windows.Forms.TextBox txt_serie;
        private System.Windows.Forms.TextBox txt_partida_presupuestaria;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_rubro;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rt_descripcion;
        private System.Windows.Forms.RadioButton rt_codigo;
        private System.Windows.Forms.RadioButton rt_id;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.Button button1;
    }
}