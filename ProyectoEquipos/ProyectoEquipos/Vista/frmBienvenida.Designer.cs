namespace ProyectoEquipos
{
    partial class frmBienvenida
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
            this.LabBienvenidos = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabBienvenidos
            // 
            this.LabBienvenidos.AutoSize = true;
            this.LabBienvenidos.BackColor = System.Drawing.SystemColors.Highlight;
            this.LabBienvenidos.Font = new System.Drawing.Font("Matura MT Script Capitals", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LabBienvenidos.ForeColor = System.Drawing.Color.SeaShell;
            this.LabBienvenidos.Location = new System.Drawing.Point(280, 176);
            this.LabBienvenidos.Name = "LabBienvenidos";
            this.LabBienvenidos.Size = new System.Drawing.Size(303, 64);
            this.LabBienvenidos.TabIndex = 0;
            this.LabBienvenidos.Text = "Bienvenidos";
            this.LabBienvenidos.Click += new System.EventHandler(this.LabBienvenidos_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnIniciar.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIniciar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnIniciar.Location = new System.Drawing.Point(339, 320);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(183, 65);
            this.btnIniciar.TabIndex = 5;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.LabBienvenidos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabBienvenidos;
        private System.Windows.Forms.Button btnIniciar;
    }
}

