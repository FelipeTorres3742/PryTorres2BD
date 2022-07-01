namespace PryTorresBD
{
    partial class FrmParametros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParametros));
            this.DGVResult = new System.Windows.Forms.DataGridView();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.DTPFecha = new System.Windows.Forms.DateTimePicker();
            this.DTPFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblFech = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.CmbNom = new System.Windows.Forms.ComboBox();
            this.lblCiud = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblReg = new System.Windows.Forms.Label();
            this.CmbCiu = new System.Windows.Forms.ComboBox();
            this.CmbReg = new System.Windows.Forms.ComboBox();
            this.CmbCod = new System.Windows.Forms.ComboBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.CmbPais = new System.Windows.Forms.ComboBox();
            this.LblCar = new System.Windows.Forms.Label();
            this.NudMin = new System.Windows.Forms.NumericUpDown();
            this.NudMax = new System.Windows.Forms.NumericUpDown();
            this.BtnNom = new System.Windows.Forms.Button();
            this.btnCui = new System.Windows.Forms.Button();
            this.BtnReg = new System.Windows.Forms.Button();
            this.BtnCod = new System.Windows.Forms.Button();
            this.btnPais = new System.Windows.Forms.Button();
            this.BtnCar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMax)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVResult
            // 
            this.DGVResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVResult.Location = new System.Drawing.Point(4, 104);
            this.DGVResult.Name = "DGVResult";
            this.DGVResult.Size = new System.Drawing.Size(910, 293);
            this.DGVResult.TabIndex = 0;
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Location = new System.Drawing.Point(88, 11);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(70, 24);
            this.BtnFiltrar.TabIndex = 1;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // DTPFecha
            // 
            this.DTPFecha.Location = new System.Drawing.Point(4, 40);
            this.DTPFecha.Name = "DTPFecha";
            this.DTPFecha.Size = new System.Drawing.Size(200, 20);
            this.DTPFecha.TabIndex = 2;
            // 
            // DTPFechaFin
            // 
            this.DTPFechaFin.Location = new System.Drawing.Point(4, 78);
            this.DTPFechaFin.Name = "DTPFechaFin";
            this.DTPFechaFin.Size = new System.Drawing.Size(200, 20);
            this.DTPFechaFin.TabIndex = 3;
            // 
            // lblFech
            // 
            this.lblFech.AutoSize = true;
            this.lblFech.Location = new System.Drawing.Point(5, 13);
            this.lblFech.Name = "lblFech";
            this.lblFech.Size = new System.Drawing.Size(77, 13);
            this.lblFech.TabIndex = 4;
            this.lblFech.Text = "Filtro por fecha";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(210, 15);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(95, 13);
            this.lblNom.TabIndex = 5;
            this.lblNom.Text = "Nombre del cliente";
            // 
            // CmbNom
            // 
            this.CmbNom.FormattingEnabled = true;
            this.CmbNom.Location = new System.Drawing.Point(213, 39);
            this.CmbNom.Name = "CmbNom";
            this.CmbNom.Size = new System.Drawing.Size(121, 21);
            this.CmbNom.TabIndex = 7;
            this.CmbNom.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblCiud
            // 
            this.lblCiud.AutoSize = true;
            this.lblCiud.Location = new System.Drawing.Point(362, 15);
            this.lblCiud.Name = "lblCiud";
            this.lblCiud.Size = new System.Drawing.Size(40, 13);
            this.lblCiud.TabIndex = 8;
            this.lblCiud.Text = "Cuidad";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(583, 16);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(72, 13);
            this.lblCod.TabIndex = 9;
            this.lblCod.Text = "Codigo Postal";
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Location = new System.Drawing.Point(475, 15);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(41, 13);
            this.lblReg.TabIndex = 10;
            this.lblReg.Text = "Region";
            // 
            // CmbCiu
            // 
            this.CmbCiu.FormattingEnabled = true;
            this.CmbCiu.Location = new System.Drawing.Point(362, 39);
            this.CmbCiu.Name = "CmbCiu";
            this.CmbCiu.Size = new System.Drawing.Size(98, 21);
            this.CmbCiu.TabIndex = 12;
            // 
            // CmbReg
            // 
            this.CmbReg.FormattingEnabled = true;
            this.CmbReg.Location = new System.Drawing.Point(478, 39);
            this.CmbReg.Name = "CmbReg";
            this.CmbReg.Size = new System.Drawing.Size(99, 21);
            this.CmbReg.TabIndex = 13;
            // 
            // CmbCod
            // 
            this.CmbCod.FormattingEnabled = true;
            this.CmbCod.Location = new System.Drawing.Point(586, 39);
            this.CmbCod.Name = "CmbCod";
            this.CmbCod.Size = new System.Drawing.Size(99, 21);
            this.CmbCod.TabIndex = 15;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(712, 18);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(27, 13);
            this.lblPais.TabIndex = 17;
            this.lblPais.Text = "Pais";
            // 
            // CmbPais
            // 
            this.CmbPais.FormattingEnabled = true;
            this.CmbPais.Location = new System.Drawing.Point(715, 39);
            this.CmbPais.Name = "CmbPais";
            this.CmbPais.Size = new System.Drawing.Size(99, 21);
            this.CmbPais.TabIndex = 19;
            // 
            // LblCar
            // 
            this.LblCar.AutoSize = true;
            this.LblCar.Location = new System.Drawing.Point(818, 18);
            this.LblCar.Name = "LblCar";
            this.LblCar.Size = new System.Drawing.Size(35, 13);
            this.LblCar.TabIndex = 20;
            this.LblCar.Text = "Cargo";
            // 
            // NudMin
            // 
            this.NudMin.Location = new System.Drawing.Point(821, 44);
            this.NudMin.Name = "NudMin";
            this.NudMin.Size = new System.Drawing.Size(55, 20);
            this.NudMin.TabIndex = 22;
            // 
            // NudMax
            // 
            this.NudMax.Location = new System.Drawing.Point(821, 70);
            this.NudMax.Name = "NudMax";
            this.NudMax.Size = new System.Drawing.Size(55, 20);
            this.NudMax.TabIndex = 23;
            // 
            // BtnNom
            // 
            this.BtnNom.Location = new System.Drawing.Point(264, 66);
            this.BtnNom.Name = "BtnNom";
            this.BtnNom.Size = new System.Drawing.Size(70, 24);
            this.BtnNom.TabIndex = 24;
            this.BtnNom.Text = "Filtrar";
            this.BtnNom.UseVisualStyleBackColor = true;
            this.BtnNom.Click += new System.EventHandler(this.BtnNom_Click);
            // 
            // btnCui
            // 
            this.btnCui.Location = new System.Drawing.Point(390, 66);
            this.btnCui.Name = "btnCui";
            this.btnCui.Size = new System.Drawing.Size(70, 24);
            this.btnCui.TabIndex = 25;
            this.btnCui.Text = "Filtrar";
            this.btnCui.UseVisualStyleBackColor = true;
            this.btnCui.Click += new System.EventHandler(this.btnCui_Click);
            // 
            // BtnReg
            // 
            this.BtnReg.Location = new System.Drawing.Point(507, 66);
            this.BtnReg.Name = "BtnReg";
            this.BtnReg.Size = new System.Drawing.Size(70, 24);
            this.BtnReg.TabIndex = 26;
            this.BtnReg.Text = "Filtrar";
            this.BtnReg.UseVisualStyleBackColor = true;
            this.BtnReg.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // BtnCod
            // 
            this.BtnCod.Location = new System.Drawing.Point(615, 66);
            this.BtnCod.Name = "BtnCod";
            this.BtnCod.Size = new System.Drawing.Size(70, 24);
            this.BtnCod.TabIndex = 27;
            this.BtnCod.Text = "Filtrar";
            this.BtnCod.UseVisualStyleBackColor = true;
            this.BtnCod.Click += new System.EventHandler(this.BtnCod_Click);
            // 
            // btnPais
            // 
            this.btnPais.Location = new System.Drawing.Point(744, 66);
            this.btnPais.Name = "btnPais";
            this.btnPais.Size = new System.Drawing.Size(70, 24);
            this.btnPais.TabIndex = 28;
            this.btnPais.Text = "Filtrar";
            this.btnPais.UseVisualStyleBackColor = true;
            this.btnPais.Click += new System.EventHandler(this.btnPais_Click);
            // 
            // BtnCar
            // 
            this.BtnCar.Location = new System.Drawing.Point(859, 15);
            this.BtnCar.Name = "BtnCar";
            this.BtnCar.Size = new System.Drawing.Size(55, 24);
            this.BtnCar.TabIndex = 29;
            this.BtnCar.Text = "Filtrar";
            this.BtnCar.UseVisualStyleBackColor = true;
            this.BtnCar.Click += new System.EventHandler(this.BtnCar_Click);
            // 
            // FrmParametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 398);
            this.Controls.Add(this.BtnCar);
            this.Controls.Add(this.btnPais);
            this.Controls.Add(this.BtnCod);
            this.Controls.Add(this.BtnReg);
            this.Controls.Add(this.btnCui);
            this.Controls.Add(this.BtnNom);
            this.Controls.Add(this.NudMax);
            this.Controls.Add(this.NudMin);
            this.Controls.Add(this.LblCar);
            this.Controls.Add(this.CmbPais);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.CmbCod);
            this.Controls.Add(this.CmbReg);
            this.Controls.Add(this.CmbCiu);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.lblCiud);
            this.Controls.Add(this.CmbNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblFech);
            this.Controls.Add(this.DTPFechaFin);
            this.Controls.Add(this.DTPFecha);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.DGVResult);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmParametros";
            this.Text = "FrmPedidos";
            this.Load += new System.EventHandler(this.FrmParametros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVResult;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.DateTimePicker DTPFecha;
        private System.Windows.Forms.DateTimePicker DTPFechaFin;
        private System.Windows.Forms.Label lblFech;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.ComboBox CmbNom;
        private System.Windows.Forms.Label lblCiud;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.ComboBox CmbCiu;
        private System.Windows.Forms.ComboBox CmbReg;
        private System.Windows.Forms.ComboBox CmbCod;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.ComboBox CmbPais;
        private System.Windows.Forms.Label LblCar;
        private System.Windows.Forms.NumericUpDown NudMin;
        private System.Windows.Forms.NumericUpDown NudMax;
        private System.Windows.Forms.Button BtnNom;
        private System.Windows.Forms.Button btnCui;
        private System.Windows.Forms.Button BtnReg;
        private System.Windows.Forms.Button BtnCod;
        private System.Windows.Forms.Button btnPais;
        private System.Windows.Forms.Button BtnCar;
    }
}