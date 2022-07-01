namespace PryTorresBD
{
    partial class Consultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultas));
            this.DGVTabla = new System.Windows.Forms.DataGridView();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.CmbConsulta = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVTabla
            // 
            this.DGVTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTabla.Location = new System.Drawing.Point(12, 82);
            this.DGVTabla.Name = "DGVTabla";
            this.DGVTabla.Size = new System.Drawing.Size(786, 324);
            this.DGVTabla.TabIndex = 0;
            this.DGVTabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVTabla_CellContentClick);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(195, 19);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(121, 38);
            this.BtnConsultar.TabIndex = 1;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // CmbConsulta
            // 
            this.CmbConsulta.FormattingEnabled = true;
            this.CmbConsulta.Items.AddRange(new object[] {
            "Categorias",
            "Clientes",
            "Detalles de pedidios",
            "Empleados",
            "Pedidos",
            "Productos",
            "Proveedores"});
            this.CmbConsulta.Location = new System.Drawing.Point(12, 29);
            this.CmbConsulta.Name = "CmbConsulta";
            this.CmbConsulta.Size = new System.Drawing.Size(177, 21);
            this.CmbConsulta.TabIndex = 3;
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(810, 409);
            this.Controls.Add(this.CmbConsulta);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.DGVTabla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consultas";
            this.Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.DGVTabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVTabla;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.ComboBox CmbConsulta;
    }
}