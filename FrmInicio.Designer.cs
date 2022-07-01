namespace PryTorresBD
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ptbInicio = new System.Windows.Forms.PictureBox();
            this.llblInicio = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(568, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaToolStripMenuItem,
            this.registroToolStripMenuItem,
            this.parametrosToolStripMenuItem});
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.categoriaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("categoriaToolStripMenuItem.Image")));
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.categoriaToolStripMenuItem.Text = "Consultas";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroToolStripMenuItem.Image")));
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.registroToolStripMenuItem.Text = "Registro";
            this.registroToolStripMenuItem.Click += new System.EventHandler(this.registroToolStripMenuItem_Click);
            // 
            // parametrosToolStripMenuItem
            // 
            this.parametrosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("parametrosToolStripMenuItem.Image")));
            this.parametrosToolStripMenuItem.Name = "parametrosToolStripMenuItem";
            this.parametrosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.parametrosToolStripMenuItem.Text = "Consulta de Pedidos";
            this.parametrosToolStripMenuItem.Click += new System.EventHandler(this.parametrosToolStripMenuItem_Click);
            // 
            // ptbInicio
            // 
            this.ptbInicio.BackColor = System.Drawing.Color.Transparent;
            this.ptbInicio.Image = ((System.Drawing.Image)(resources.GetObject("ptbInicio.Image")));
            this.ptbInicio.Location = new System.Drawing.Point(0, 27);
            this.ptbInicio.Name = "ptbInicio";
            this.ptbInicio.Size = new System.Drawing.Size(114, 82);
            this.ptbInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbInicio.TabIndex = 1;
            this.ptbInicio.TabStop = false;
            // 
            // llblInicio
            // 
            this.llblInicio.BackColor = System.Drawing.Color.White;
            this.llblInicio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.llblInicio.DisabledLinkColor = System.Drawing.Color.White;
            this.llblInicio.Location = new System.Drawing.Point(25, 238);
            this.llblInicio.Name = "llblInicio";
            this.llblInicio.Size = new System.Drawing.Size(121, 50);
            this.llblInicio.TabIndex = 2;
            this.llblInicio.TabStop = true;
            this.llblInicio.Text = "BOTON DE CIERRE";
            this.llblInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llblInicio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblInicio_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(568, 308);
            this.Controls.Add(this.llblInicio);
            this.Controls.Add(this.ptbInicio);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametrosToolStripMenuItem;
        private System.Windows.Forms.PictureBox ptbInicio;
        private System.Windows.Forms.LinkLabel llblInicio;
    }
}

