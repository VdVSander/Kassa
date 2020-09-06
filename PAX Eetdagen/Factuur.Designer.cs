namespace PAX_Eetdagen
{
    partial class Factuur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factuur));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.factuurMakenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aanpassingenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artikelsAanpassenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicatieInstellingenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datagrdEten = new System.Windows.Forms.DataGridView();
            this.Artikel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AantalEten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PpS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.datagrdFactuur = new System.Windows.Forms.DataGridView();
            this.ArtikelTot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AantalTot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrijsTot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBoxTotaalPrijs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numBetaald = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxTerug = new System.Windows.Forms.TextBox();
            this.btnNieuw = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.datagrdDrank = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AantalDrank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.datagrdAndere = new System.Windows.Forms.DataGridView();
            this.ArtikelAndere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AantalAndere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrdEten)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrdFactuur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBetaald)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrdDrank)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrdAndere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.factuurMakenToolStripMenuItem,
            this.aanpassingenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1649, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // factuurMakenToolStripMenuItem
            // 
            this.factuurMakenToolStripMenuItem.Name = "factuurMakenToolStripMenuItem";
            this.factuurMakenToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.factuurMakenToolStripMenuItem.Text = "Factuur maken";
            // 
            // aanpassingenToolStripMenuItem
            // 
            this.aanpassingenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artikelsAanpassenToolStripMenuItem,
            this.applicatieInstellingenToolStripMenuItem});
            this.aanpassingenToolStripMenuItem.Name = "aanpassingenToolStripMenuItem";
            this.aanpassingenToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.aanpassingenToolStripMenuItem.Text = "Aanpassingen";
            // 
            // artikelsAanpassenToolStripMenuItem
            // 
            this.artikelsAanpassenToolStripMenuItem.Name = "artikelsAanpassenToolStripMenuItem";
            this.artikelsAanpassenToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.artikelsAanpassenToolStripMenuItem.Text = "Artikels aanpassen";
            this.artikelsAanpassenToolStripMenuItem.Click += new System.EventHandler(this.artikelsAanpassenToolStripMenuItem_Click);
            // 
            // applicatieInstellingenToolStripMenuItem
            // 
            this.applicatieInstellingenToolStripMenuItem.Name = "applicatieInstellingenToolStripMenuItem";
            this.applicatieInstellingenToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.applicatieInstellingenToolStripMenuItem.Text = "Applicatie instellingen";
            this.applicatieInstellingenToolStripMenuItem.Click += new System.EventHandler(this.applicatieInstellingenToolStripMenuItem_Click);
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(15, 24);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(232, 37);
            this.lblTitel.TabIndex = 1;
            this.lblTitel.Text = "Factuur maken";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datagrdEten);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 655);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eten";
            // 
            // datagrdEten
            // 
            this.datagrdEten.AllowUserToAddRows = false;
            this.datagrdEten.AllowUserToDeleteRows = false;
            this.datagrdEten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrdEten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrdEten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Artikel,
            this.AantalEten,
            this.PpS});
            this.datagrdEten.Location = new System.Drawing.Point(6, 34);
            this.datagrdEten.Name = "datagrdEten";
            this.datagrdEten.Size = new System.Drawing.Size(377, 614);
            this.datagrdEten.TabIndex = 15;
            this.datagrdEten.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrdEten_CellClick);
            this.datagrdEten.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrdEten_CellValueChanged);
            // 
            // Artikel
            // 
            this.Artikel.HeaderText = "Artikel";
            this.Artikel.Name = "Artikel";
            this.Artikel.ReadOnly = true;
            // 
            // AantalEten
            // 
            this.AantalEten.HeaderText = "Aantal";
            this.AantalEten.Name = "AantalEten";
            // 
            // PpS
            // 
            this.PpS.HeaderText = "€ per stuk";
            this.PpS.Name = "PpS";
            this.PpS.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.datagrdFactuur);
            this.groupBox4.Controls.Add(this.txtBoxTotaalPrijs);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(1243, 124);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(394, 570);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Factuur";
            // 
            // datagrdFactuur
            // 
            this.datagrdFactuur.AllowUserToAddRows = false;
            this.datagrdFactuur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrdFactuur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArtikelTot,
            this.AantalTot,
            this.PrijsTot});
            this.datagrdFactuur.Location = new System.Drawing.Point(6, 34);
            this.datagrdFactuur.Name = "datagrdFactuur";
            this.datagrdFactuur.Size = new System.Drawing.Size(382, 529);
            this.datagrdFactuur.TabIndex = 0;
            this.datagrdFactuur.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrdFactuur_CellValueChanged);
            // 
            // ArtikelTot
            // 
            this.ArtikelTot.HeaderText = "Artikel";
            this.ArtikelTot.Name = "ArtikelTot";
            this.ArtikelTot.ReadOnly = true;
            this.ArtikelTot.Width = 113;
            // 
            // AantalTot
            // 
            this.AantalTot.HeaderText = "Aantal";
            this.AantalTot.Name = "AantalTot";
            this.AantalTot.ReadOnly = true;
            this.AantalTot.Width = 113;
            // 
            // PrijsTot
            // 
            this.PrijsTot.HeaderText = "€ per stuk";
            this.PrijsTot.Name = "PrijsTot";
            this.PrijsTot.ReadOnly = true;
            this.PrijsTot.Width = 113;
            // 
            // txtBoxTotaalPrijs
            // 
            this.txtBoxTotaalPrijs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTotaalPrijs.Location = new System.Drawing.Point(268, 461);
            this.txtBoxTotaalPrijs.Name = "txtBoxTotaalPrijs";
            this.txtBoxTotaalPrijs.ReadOnly = true;
            this.txtBoxTotaalPrijs.Size = new System.Drawing.Size(120, 35);
            this.txtBoxTotaalPrijs.TabIndex = 12;
            this.txtBoxTotaalPrijs.TextChanged += new System.EventHandler(this.txtBoxTotaalPrijs_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(156, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Totaal: €";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 731);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Betaald: €";
            // 
            // numBetaald
            // 
            this.numBetaald.DecimalPlaces = 2;
            this.numBetaald.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBetaald.Location = new System.Drawing.Point(143, 725);
            this.numBetaald.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBetaald.Name = "numBetaald";
            this.numBetaald.Size = new System.Drawing.Size(120, 35);
            this.numBetaald.TabIndex = 8;
            this.numBetaald.ValueChanged += new System.EventHandler(this.numBetaald_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 731);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Terug: €";
            // 
            // txtBoxTerug
            // 
            this.txtBoxTerug.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTerug.Location = new System.Drawing.Point(386, 725);
            this.txtBoxTerug.Name = "txtBoxTerug";
            this.txtBoxTerug.ReadOnly = true;
            this.txtBoxTerug.Size = new System.Drawing.Size(120, 35);
            this.txtBoxTerug.TabIndex = 10;
            // 
            // btnNieuw
            // 
            this.btnNieuw.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNieuw.Location = new System.Drawing.Point(1517, 713);
            this.btnNieuw.Name = "btnNieuw";
            this.btnNieuw.Size = new System.Drawing.Size(120, 47);
            this.btnNieuw.TabIndex = 13;
            this.btnNieuw.Text = "Nieuw\r\n";
            this.btnNieuw.UseVisualStyleBackColor = true;
            this.btnNieuw.Click += new System.EventHandler(this.btnNieuw_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.datagrdDrank);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(422, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 655);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Drank";
            // 
            // datagrdDrank
            // 
            this.datagrdDrank.AllowUserToAddRows = false;
            this.datagrdDrank.AllowUserToDeleteRows = false;
            this.datagrdDrank.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrdDrank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrdDrank.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.AantalDrank,
            this.dataGridViewTextBoxColumn3});
            this.datagrdDrank.Location = new System.Drawing.Point(8, 34);
            this.datagrdDrank.Name = "datagrdDrank";
            this.datagrdDrank.Size = new System.Drawing.Size(377, 614);
            this.datagrdDrank.TabIndex = 15;
            this.datagrdDrank.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrdDrank_CellValueChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Artikel";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // AantalDrank
            // 
            this.AantalDrank.HeaderText = "Aantal";
            this.AantalDrank.Name = "AantalDrank";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "€ per stuk";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.datagrdAndere);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(832, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(391, 655);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Andere";
            // 
            // datagrdAndere
            // 
            this.datagrdAndere.AllowUserToAddRows = false;
            this.datagrdAndere.AllowUserToDeleteRows = false;
            this.datagrdAndere.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrdAndere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrdAndere.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArtikelAndere,
            this.AantalAndere,
            this.dataGridViewTextBoxColumn6});
            this.datagrdAndere.Location = new System.Drawing.Point(6, 34);
            this.datagrdAndere.Name = "datagrdAndere";
            this.datagrdAndere.Size = new System.Drawing.Size(377, 614);
            this.datagrdAndere.TabIndex = 15;
            this.datagrdAndere.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrdAndere_CellValueChanged);
            // 
            // ArtikelAndere
            // 
            this.ArtikelAndere.HeaderText = "Artikel";
            this.ArtikelAndere.Name = "ArtikelAndere";
            this.ArtikelAndere.ReadOnly = true;
            // 
            // AantalAndere
            // 
            this.AantalAndere.HeaderText = "Aantal";
            this.AantalAndere.Name = "AantalAndere";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "€ per stuk";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureLogo.InitialImage")));
            this.pictureLogo.Location = new System.Drawing.Point(1389, 27);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(260, 91);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogo.TabIndex = 17;
            this.pictureLogo.TabStop = false;
            // 
            // Factuur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1649, 772);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnNieuw);
            this.Controls.Add(this.txtBoxTerug);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numBetaald);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Factuur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factuur maken";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Factuur_FormClosing);
            this.Load += new System.EventHandler(this.Factuur_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrdEten)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrdFactuur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBetaald)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrdDrank)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrdAndere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem factuurMakenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aanpassingenToolStripMenuItem;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView datagrdFactuur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numBetaald;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxTerug;
        private System.Windows.Forms.TextBox txtBoxTotaalPrijs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNieuw;
        private System.Windows.Forms.DataGridView datagrdEten;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView datagrdDrank;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView datagrdAndere;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtikelTot;
        private System.Windows.Forms.DataGridViewTextBoxColumn AantalTot;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrijsTot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artikel;
        private System.Windows.Forms.DataGridViewTextBoxColumn AantalEten;
        private System.Windows.Forms.DataGridViewTextBoxColumn PpS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AantalDrank;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtikelAndere;
        private System.Windows.Forms.DataGridViewTextBoxColumn AantalAndere;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ToolStripMenuItem applicatieInstellingenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artikelsAanpassenToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureLogo;
    }
}