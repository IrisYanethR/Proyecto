namespace ProyectoEquipos
{
    partial class fmrInicioSesion
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
            this.btnAtras1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.btnIniciarSecion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAtras1
            // 
            this.btnAtras1.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAtras1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnAtras1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAtras1.Location = new System.Drawing.Point(12, 12);
            this.btnAtras1.Name = "btnAtras1";
            this.btnAtras1.Size = new System.Drawing.Size(97, 48);
            this.btnAtras1.TabIndex = 0;
            this.btnAtras1.Text = "Atras";
            this.btnAtras1.UseVisualStyleBackColor = false;
            this.btnAtras1.Click += new System.EventHandler(this.btnAtras1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(110, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ubuntu", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtUsuario.Location = new System.Drawing.Point(241, 162);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(460, 23);
            this.txtUsuario.TabIndex = 3;
            // 
            // textPass
            // 
            this.textPass.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textPass.Location = new System.Drawing.Point(241, 247);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(460, 23);
            this.textPass.TabIndex = 4;
            // 
            // btnIniciarSecion
            // 
            this.btnIniciarSecion.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnIniciarSecion.Font = new System.Drawing.Font("Sitka Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIniciarSecion.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnIniciarSecion.Location = new System.Drawing.Point(273, 347);
            this.btnIniciarSecion.Name = "btnIniciarSecion";
            this.btnIniciarSecion.Size = new System.Drawing.Size(251, 58);
            this.btnIniciarSecion.TabIndex = 5;
            this.btnIniciarSecion.Text = "Iniciar sesion";
            this.btnIniciarSecion.UseVisualStyleBackColor = false;
            this.btnIniciarSecion.Click += new System.EventHandler(this.btnIniciarSecion_Click);
            // 
            // Formulario2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnIniciarSecion);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtras1);
            this.Name = "Formulario2";
            this.Text = "Formulario2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtras1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Button btnIniciarSecion;
    }
}