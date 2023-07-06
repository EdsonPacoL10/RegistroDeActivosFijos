
namespace ExamenPrimerParcial
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bot_ingresar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bot_salir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_contraseña);
            this.groupBox1.Controls.Add(this.txt_usuario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 106);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de ingreso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "CONTRASEÑA";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_contraseña.Location = new System.Drawing.Point(148, 64);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.PasswordChar = 'º';
            this.txt_contraseña.Size = new System.Drawing.Size(134, 24);
            this.txt_contraseña.TabIndex = 4;
            this.txt_contraseña.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(151, 27);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(134, 23);
            this.txt_usuario.TabIndex = 4;
            this.txt_usuario.TextChanged += new System.EventHandler(this.txt_usuario_TextChanged);
            this.txt_usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_usuario_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExamenPrimerParcial.Properties.Resources.Usuario_permisos_mybusinesspos_300x200;
            this.pictureBox1.Location = new System.Drawing.Point(300, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // bot_ingresar
            // 
            this.bot_ingresar.BackColor = System.Drawing.Color.IndianRed;
            this.bot_ingresar.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bot_ingresar.Location = new System.Drawing.Point(20, 22);
            this.bot_ingresar.Name = "bot_ingresar";
            this.bot_ingresar.Size = new System.Drawing.Size(105, 34);
            this.bot_ingresar.TabIndex = 5;
            this.bot_ingresar.Text = "INGRESAR";
            this.bot_ingresar.UseVisualStyleBackColor = false;
            this.bot_ingresar.Click += new System.EventHandler(this.bot_ingresar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bot_salir);
            this.groupBox2.Controls.Add(this.bot_ingresar);
            this.groupBox2.Location = new System.Drawing.Point(3, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 62);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Botones";
            // 
            // bot_salir
            // 
            this.bot_salir.BackColor = System.Drawing.Color.IndianRed;
            this.bot_salir.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bot_salir.Location = new System.Drawing.Point(169, 22);
            this.bot_salir.Name = "bot_salir";
            this.bot_salir.Size = new System.Drawing.Size(105, 34);
            this.bot_salir.TabIndex = 6;
            this.bot_salir.Text = "SALIR";
            this.bot_salir.UseVisualStyleBackColor = false;
            this.bot_salir.Click += new System.EventHandler(this.bot_salir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(145, -4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 44);
            this.label3.TabIndex = 6;
            this.label3.Text = "INGRESO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(487, 221);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "INGRESO";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bot_ingresar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bot_salir;
        private System.Windows.Forms.Label label3;
    }
}

