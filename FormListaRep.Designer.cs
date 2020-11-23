namespace FormListaReproduccionG4
{
    partial class FormListaRep
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstReproducción = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCancion = new System.Windows.Forms.Label();
            this.lbArtista = new System.Windows.Forms.Label();
            this.lbAlbum = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarCancionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.pgbDuracion = new System.Windows.Forms.ProgressBar();
            this.timerTiempoCancion = new System.Windows.Forms.Timer(this.components);
            this.lbTiempoTrans = new System.Windows.Forms.Label();
            this.lbTiempoTotal = new System.Windows.Forms.Label();
            this.reproduccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pausarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siguienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anteriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reproducciónAutomáticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bucleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aleatoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstReproducción
            // 
            this.lstReproducción.FormattingEnabled = true;
            this.lstReproducción.ItemHeight = 20;
            this.lstReproducción.Location = new System.Drawing.Point(41, 100);
            this.lstReproducción.Name = "lstReproducción";
            this.lstReproducción.Size = new System.Drawing.Size(262, 324);
            this.lstReproducción.TabIndex = 0;
            this.lstReproducción.SelectedIndexChanged += new System.EventHandler(this.lstReproducción_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Canción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Artista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Álbum";
            // 
            // lbCancion
            // 
            this.lbCancion.AutoSize = true;
            this.lbCancion.Location = new System.Drawing.Point(533, 112);
            this.lbCancion.Name = "lbCancion";
            this.lbCancion.Size = new System.Drawing.Size(51, 20);
            this.lbCancion.TabIndex = 1;
            this.lbCancion.Text = "label1";
            // 
            // lbArtista
            // 
            this.lbArtista.AutoSize = true;
            this.lbArtista.Location = new System.Drawing.Point(533, 149);
            this.lbArtista.Name = "lbArtista";
            this.lbArtista.Size = new System.Drawing.Size(51, 20);
            this.lbArtista.TabIndex = 1;
            this.lbArtista.Text = "label1";
            // 
            // lbAlbum
            // 
            this.lbAlbum.AutoSize = true;
            this.lbAlbum.Location = new System.Drawing.Point(533, 195);
            this.lbAlbum.Name = "lbAlbum";
            this.lbAlbum.Size = new System.Drawing.Size(51, 20);
            this.lbAlbum.TabIndex = 1;
            this.lbAlbum.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.reproduccionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(956, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarCancionesToolStripMenuItem,
            this.agregarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cargarCancionesToolStripMenuItem
            // 
            this.cargarCancionesToolStripMenuItem.Name = "cargarCancionesToolStripMenuItem";
            this.cargarCancionesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.cargarCancionesToolStripMenuItem.Text = "Cargar canciones";
            this.cargarCancionesToolStripMenuItem.Click += new System.EventHandler(this.cargarCancionesToolStripMenuItem_Click);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Lista Reproducciones";
            // 
            // pgbDuracion
            // 
            this.pgbDuracion.Location = new System.Drawing.Point(424, 299);
            this.pgbDuracion.Name = "pgbDuracion";
            this.pgbDuracion.Size = new System.Drawing.Size(431, 10);
            this.pgbDuracion.TabIndex = 3;
            // 
            // timerTiempoCancion
            // 
            this.timerTiempoCancion.Interval = 1000;
            this.timerTiempoCancion.Tick += new System.EventHandler(this.timerTiempoCancion_Tick);
            // 
            // lbTiempoTrans
            // 
            this.lbTiempoTrans.AutoSize = true;
            this.lbTiempoTrans.Location = new System.Drawing.Point(368, 289);
            this.lbTiempoTrans.Name = "lbTiempoTrans";
            this.lbTiempoTrans.Size = new System.Drawing.Size(38, 20);
            this.lbTiempoTrans.TabIndex = 4;
            this.lbTiempoTrans.Text = "0 [s]";
            // 
            // lbTiempoTotal
            // 
            this.lbTiempoTotal.AutoSize = true;
            this.lbTiempoTotal.Location = new System.Drawing.Point(871, 289);
            this.lbTiempoTotal.Name = "lbTiempoTotal";
            this.lbTiempoTotal.Size = new System.Drawing.Size(38, 20);
            this.lbTiempoTotal.TabIndex = 4;
            this.lbTiempoTotal.Text = "5 [s]";
            // 
            // reproduccionToolStripMenuItem
            // 
            this.reproduccionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.pausarToolStripMenuItem,
            this.siguienteToolStripMenuItem,
            this.anteriorToolStripMenuItem,
            this.toolStripMenuItem1,
            this.reproducciónAutomáticaToolStripMenuItem,
            this.bucleToolStripMenuItem,
            this.aleatoriaToolStripMenuItem});
            this.reproduccionToolStripMenuItem.Name = "reproduccionToolStripMenuItem";
            this.reproduccionToolStripMenuItem.Size = new System.Drawing.Size(137, 29);
            this.reproduccionToolStripMenuItem.Text = "Reproducción";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(319, 34);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // pausarToolStripMenuItem
            // 
            this.pausarToolStripMenuItem.Name = "pausarToolStripMenuItem";
            this.pausarToolStripMenuItem.Size = new System.Drawing.Size(319, 34);
            this.pausarToolStripMenuItem.Text = "Pausar";
            // 
            // siguienteToolStripMenuItem
            // 
            this.siguienteToolStripMenuItem.Name = "siguienteToolStripMenuItem";
            this.siguienteToolStripMenuItem.Size = new System.Drawing.Size(319, 34);
            this.siguienteToolStripMenuItem.Text = "Siguiente";
            // 
            // anteriorToolStripMenuItem
            // 
            this.anteriorToolStripMenuItem.Name = "anteriorToolStripMenuItem";
            this.anteriorToolStripMenuItem.Size = new System.Drawing.Size(319, 34);
            this.anteriorToolStripMenuItem.Text = "Anterior";
            // 
            // reproducciónAutomáticaToolStripMenuItem
            // 
            this.reproducciónAutomáticaToolStripMenuItem.Name = "reproducciónAutomáticaToolStripMenuItem";
            this.reproducciónAutomáticaToolStripMenuItem.Size = new System.Drawing.Size(319, 34);
            this.reproducciónAutomáticaToolStripMenuItem.Text = "Reproducción Automática";
            // 
            // bucleToolStripMenuItem
            // 
            this.bucleToolStripMenuItem.Name = "bucleToolStripMenuItem";
            this.bucleToolStripMenuItem.Size = new System.Drawing.Size(319, 34);
            this.bucleToolStripMenuItem.Text = "Bucle";
            // 
            // aleatoriaToolStripMenuItem
            // 
            this.aleatoriaToolStripMenuItem.Name = "aleatoriaToolStripMenuItem";
            this.aleatoriaToolStripMenuItem.Size = new System.Drawing.Size(319, 34);
            this.aleatoriaToolStripMenuItem.Text = "Aleatoria";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(316, 6);
            // 
            // FormListaRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 541);
            this.Controls.Add(this.lbTiempoTotal);
            this.Controls.Add(this.lbTiempoTrans);
            this.Controls.Add(this.pgbDuracion);
            this.Controls.Add(this.lbAlbum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbArtista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCancion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstReproducción);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormListaRep";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormListaRep_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstReproducción;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCancion;
        private System.Windows.Forms.Label lbArtista;
        private System.Windows.Forms.Label lbAlbum;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarCancionesToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reproduccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pausarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siguienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anteriorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reproducciónAutomáticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bucleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aleatoriaToolStripMenuItem;
        private System.Windows.Forms.ProgressBar pgbDuracion;
        private System.Windows.Forms.Timer timerTiempoCancion;
        private System.Windows.Forms.Label lbTiempoTrans;
        private System.Windows.Forms.Label lbTiempoTotal;
    }
}

