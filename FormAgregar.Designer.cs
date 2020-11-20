namespace FormListaReproduccionG4
{
    partial class FormAgregar
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbCancion = new System.Windows.Forms.TextBox();
            this.txtbArtista = new System.Windows.Forms.TextBox();
            this.txtbAlbum = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Canción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Artista";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Álbum";
            // 
            // txtbCancion
            // 
            this.txtbCancion.Location = new System.Drawing.Point(211, 60);
            this.txtbCancion.Name = "txtbCancion";
            this.txtbCancion.Size = new System.Drawing.Size(246, 26);
            this.txtbCancion.TabIndex = 1;
            // 
            // txtbArtista
            // 
            this.txtbArtista.Location = new System.Drawing.Point(211, 122);
            this.txtbArtista.Name = "txtbArtista";
            this.txtbArtista.Size = new System.Drawing.Size(246, 26);
            this.txtbArtista.TabIndex = 1;
            // 
            // txtbAlbum
            // 
            this.txtbAlbum.Location = new System.Drawing.Point(211, 177);
            this.txtbAlbum.Name = "txtbAlbum";
            this.txtbAlbum.Size = new System.Drawing.Size(246, 26);
            this.txtbAlbum.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(543, 103);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(148, 65);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FormAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 271);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtbAlbum);
            this.Controls.Add(this.txtbArtista);
            this.Controls.Add(this.txtbCancion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormAgregar";
            this.Text = "FormAgregar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbCancion;
        private System.Windows.Forms.TextBox txtbArtista;
        private System.Windows.Forms.TextBox txtbAlbum;
        private System.Windows.Forms.Button btnAgregar;
    }
}