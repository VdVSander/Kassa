namespace PAX_Eetdagen
{
    partial class Aanpassingen
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
            this.lblConfig = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.factuurMakenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aanpassingenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBoxAddItem = new System.Windows.Forms.GroupBox();
            this.cmbBoxArtCat = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.numArtPrice = new System.Windows.Forms.NumericUpDown();
            this.lblArtPrice = new System.Windows.Forms.Label();
            this.lblArtCategory = new System.Windows.Forms.Label();
            this.txtBoxArtName = new System.Windows.Forms.TextBox();
            this.lblArtName = new System.Windows.Forms.Label();
            this.grpBoxEdditItem = new System.Windows.Forms.GroupBox();
            this.txtBoxArtNameChange = new System.Windows.Forms.TextBox();
            this.lblArtNameChange = new System.Windows.Forms.Label();
            this.cmbBoxArtChange = new System.Windows.Forms.ComboBox();
            this.cmbBoxArtCatChange = new System.Windows.Forms.ComboBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.numArtPriceChange = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpBoxItemDelete = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbBoxArtDelete = new System.Windows.Forms.ComboBox();
            this.lblArtDelte = new System.Windows.Forms.Label();
            this.txtBoxCSVPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOpenCSV = new System.Windows.Forms.Button();
            this.datagrdArt = new System.Windows.Forms.DataGridView();
            this.ArtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grpBoxAddItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numArtPrice)).BeginInit();
            this.grpBoxEdditItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numArtPriceChange)).BeginInit();
            this.grpBoxItemDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrdArt)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConfig
            // 
            this.lblConfig.AutoSize = true;
            this.lblConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfig.Location = new System.Drawing.Point(5, 34);
            this.lblConfig.Name = "lblConfig";
            this.lblConfig.Size = new System.Drawing.Size(190, 37);
            this.lblConfig.TabIndex = 3;
            this.lblConfig.Text = "Configuratie";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.factuurMakenToolStripMenuItem,
            this.aanpassingenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(742, 24);
            this.menuStrip1.TabIndex = 5;
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
            this.aanpassingenToolStripMenuItem.Name = "aanpassingenToolStripMenuItem";
            this.aanpassingenToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.aanpassingenToolStripMenuItem.Text = "Aanpassingen";
            // 
            // grpBoxAddItem
            // 
            this.grpBoxAddItem.Controls.Add(this.cmbBoxArtCat);
            this.grpBoxAddItem.Controls.Add(this.btnAdd);
            this.grpBoxAddItem.Controls.Add(this.numArtPrice);
            this.grpBoxAddItem.Controls.Add(this.lblArtPrice);
            this.grpBoxAddItem.Controls.Add(this.lblArtCategory);
            this.grpBoxAddItem.Controls.Add(this.txtBoxArtName);
            this.grpBoxAddItem.Controls.Add(this.lblArtName);
            this.grpBoxAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxAddItem.Location = new System.Drawing.Point(12, 74);
            this.grpBoxAddItem.Name = "grpBoxAddItem";
            this.grpBoxAddItem.Size = new System.Drawing.Size(328, 222);
            this.grpBoxAddItem.TabIndex = 6;
            this.grpBoxAddItem.TabStop = false;
            this.grpBoxAddItem.Text = "Artikel toevoegen";
            // 
            // cmbBoxArtCat
            // 
            this.cmbBoxArtCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxArtCat.FormattingEnabled = true;
            this.cmbBoxArtCat.Items.AddRange(new object[] {
            "Eten",
            "Drank",
            "Andere"});
            this.cmbBoxArtCat.Location = new System.Drawing.Point(108, 75);
            this.cmbBoxArtCat.Name = "cmbBoxArtCat";
            this.cmbBoxArtCat.Size = new System.Drawing.Size(214, 32);
            this.cmbBoxArtCat.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(193, 178);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 38);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Toevoegen";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // numArtPrice
            // 
            this.numArtPrice.DecimalPlaces = 2;
            this.numArtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numArtPrice.Location = new System.Drawing.Point(70, 117);
            this.numArtPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numArtPrice.Name = "numArtPrice";
            this.numArtPrice.Size = new System.Drawing.Size(118, 29);
            this.numArtPrice.TabIndex = 7;
            // 
            // lblArtPrice
            // 
            this.lblArtPrice.AutoSize = true;
            this.lblArtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtPrice.Location = new System.Drawing.Point(6, 119);
            this.lblArtPrice.Name = "lblArtPrice";
            this.lblArtPrice.Size = new System.Drawing.Size(65, 24);
            this.lblArtPrice.TabIndex = 6;
            this.lblArtPrice.Text = "Prijs: €";
            // 
            // lblArtCategory
            // 
            this.lblArtCategory.AutoSize = true;
            this.lblArtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtCategory.Location = new System.Drawing.Point(6, 78);
            this.lblArtCategory.Name = "lblArtCategory";
            this.lblArtCategory.Size = new System.Drawing.Size(96, 24);
            this.lblArtCategory.TabIndex = 4;
            this.lblArtCategory.Text = "Categorie:";
            // 
            // txtBoxArtName
            // 
            this.txtBoxArtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxArtName.Location = new System.Drawing.Point(78, 33);
            this.txtBoxArtName.Name = "txtBoxArtName";
            this.txtBoxArtName.Size = new System.Drawing.Size(244, 29);
            this.txtBoxArtName.TabIndex = 3;
            // 
            // lblArtName
            // 
            this.lblArtName.AutoSize = true;
            this.lblArtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtName.Location = new System.Drawing.Point(6, 36);
            this.lblArtName.Name = "lblArtName";
            this.lblArtName.Size = new System.Drawing.Size(66, 24);
            this.lblArtName.TabIndex = 3;
            this.lblArtName.Text = "Artikel:";
            // 
            // grpBoxEdditItem
            // 
            this.grpBoxEdditItem.Controls.Add(this.txtBoxArtNameChange);
            this.grpBoxEdditItem.Controls.Add(this.lblArtNameChange);
            this.grpBoxEdditItem.Controls.Add(this.cmbBoxArtChange);
            this.grpBoxEdditItem.Controls.Add(this.cmbBoxArtCatChange);
            this.grpBoxEdditItem.Controls.Add(this.btnChange);
            this.grpBoxEdditItem.Controls.Add(this.numArtPriceChange);
            this.grpBoxEdditItem.Controls.Add(this.label1);
            this.grpBoxEdditItem.Controls.Add(this.label2);
            this.grpBoxEdditItem.Controls.Add(this.label3);
            this.grpBoxEdditItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxEdditItem.Location = new System.Drawing.Point(12, 302);
            this.grpBoxEdditItem.Name = "grpBoxEdditItem";
            this.grpBoxEdditItem.Size = new System.Drawing.Size(328, 257);
            this.grpBoxEdditItem.TabIndex = 7;
            this.grpBoxEdditItem.TabStop = false;
            this.grpBoxEdditItem.Text = "Artikel wijzigen";
            // 
            // txtBoxArtNameChange
            // 
            this.txtBoxArtNameChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxArtNameChange.Location = new System.Drawing.Point(78, 83);
            this.txtBoxArtNameChange.Name = "txtBoxArtNameChange";
            this.txtBoxArtNameChange.Size = new System.Drawing.Size(244, 29);
            this.txtBoxArtNameChange.TabIndex = 11;
            // 
            // lblArtNameChange
            // 
            this.lblArtNameChange.AutoSize = true;
            this.lblArtNameChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtNameChange.Location = new System.Drawing.Point(7, 86);
            this.lblArtNameChange.Name = "lblArtNameChange";
            this.lblArtNameChange.Size = new System.Drawing.Size(65, 24);
            this.lblArtNameChange.TabIndex = 10;
            this.lblArtNameChange.Text = "Naam:";
            // 
            // cmbBoxArtChange
            // 
            this.cmbBoxArtChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxArtChange.FormattingEnabled = true;
            this.cmbBoxArtChange.Location = new System.Drawing.Point(78, 36);
            this.cmbBoxArtChange.Name = "cmbBoxArtChange";
            this.cmbBoxArtChange.Size = new System.Drawing.Size(244, 32);
            this.cmbBoxArtChange.TabIndex = 9;
            // 
            // cmbBoxArtCatChange
            // 
            this.cmbBoxArtCatChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxArtCatChange.FormattingEnabled = true;
            this.cmbBoxArtCatChange.Items.AddRange(new object[] {
            "Eten",
            "Drank",
            "Andere"});
            this.cmbBoxArtCatChange.Location = new System.Drawing.Point(108, 123);
            this.cmbBoxArtCatChange.Name = "cmbBoxArtCatChange";
            this.cmbBoxArtCatChange.Size = new System.Drawing.Size(214, 32);
            this.cmbBoxArtCatChange.TabIndex = 8;
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(193, 213);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(129, 38);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "Wijzigen";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // numArtPriceChange
            // 
            this.numArtPriceChange.DecimalPlaces = 2;
            this.numArtPriceChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numArtPriceChange.Location = new System.Drawing.Point(70, 165);
            this.numArtPriceChange.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numArtPriceChange.Name = "numArtPriceChange";
            this.numArtPriceChange.Size = new System.Drawing.Size(118, 29);
            this.numArtPriceChange.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Prijs: €";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Categorie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Artikel:";
            // 
            // grpBoxItemDelete
            // 
            this.grpBoxItemDelete.Controls.Add(this.btnDelete);
            this.grpBoxItemDelete.Controls.Add(this.cmbBoxArtDelete);
            this.grpBoxItemDelete.Controls.Add(this.lblArtDelte);
            this.grpBoxItemDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxItemDelete.Location = new System.Drawing.Point(12, 565);
            this.grpBoxItemDelete.Name = "grpBoxItemDelete";
            this.grpBoxItemDelete.Size = new System.Drawing.Size(328, 135);
            this.grpBoxItemDelete.TabIndex = 8;
            this.grpBoxItemDelete.TabStop = false;
            this.grpBoxItemDelete.Text = "Artikel verwijderen";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(193, 91);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 38);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Verwijderen";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // cmbBoxArtDelete
            // 
            this.cmbBoxArtDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxArtDelete.FormattingEnabled = true;
            this.cmbBoxArtDelete.Location = new System.Drawing.Point(78, 40);
            this.cmbBoxArtDelete.Name = "cmbBoxArtDelete";
            this.cmbBoxArtDelete.Size = new System.Drawing.Size(244, 32);
            this.cmbBoxArtDelete.TabIndex = 11;
            // 
            // lblArtDelte
            // 
            this.lblArtDelte.AutoSize = true;
            this.lblArtDelte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtDelte.Location = new System.Drawing.Point(6, 40);
            this.lblArtDelte.Name = "lblArtDelte";
            this.lblArtDelte.Size = new System.Drawing.Size(66, 24);
            this.lblArtDelte.TabIndex = 10;
            this.lblArtDelte.Text = "Artikel:";
            // 
            // txtBoxCSVPath
            // 
            this.txtBoxCSVPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCSVPath.Location = new System.Drawing.Point(500, 75);
            this.txtBoxCSVPath.Name = "txtBoxCSVPath";
            this.txtBoxCSVPath.ReadOnly = true;
            this.txtBoxCSVPath.Size = new System.Drawing.Size(228, 24);
            this.txtBoxCSVPath.TabIndex = 13;
            this.txtBoxCSVPath.Text = "TXT bestand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(368, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "TXT Bestand:";
            // 
            // btnOpenCSV
            // 
            this.btnOpenCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenCSV.Location = new System.Drawing.Point(615, 110);
            this.btnOpenCSV.Name = "btnOpenCSV";
            this.btnOpenCSV.Size = new System.Drawing.Size(113, 36);
            this.btnOpenCSV.TabIndex = 15;
            this.btnOpenCSV.Text = "Importeer";
            this.btnOpenCSV.UseVisualStyleBackColor = true;
            // 
            // datagrdArt
            // 
            this.datagrdArt.AllowUserToAddRows = false;
            this.datagrdArt.AllowUserToDeleteRows = false;
            this.datagrdArt.AllowUserToOrderColumns = true;
            this.datagrdArt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrdArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrdArt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArtName,
            this.ArtCat,
            this.ArtPrice});
            this.datagrdArt.Location = new System.Drawing.Point(372, 152);
            this.datagrdArt.Name = "datagrdArt";
            this.datagrdArt.ReadOnly = true;
            this.datagrdArt.Size = new System.Drawing.Size(357, 501);
            this.datagrdArt.TabIndex = 16;
            // 
            // ArtName
            // 
            this.ArtName.HeaderText = "Artikel";
            this.ArtName.Name = "ArtName";
            this.ArtName.ReadOnly = true;
            // 
            // ArtCat
            // 
            this.ArtCat.HeaderText = "Categorie";
            this.ArtCat.Name = "ArtCat";
            this.ArtCat.ReadOnly = true;
            // 
            // ArtPrice
            // 
            this.ArtPrice.HeaderText = "Prijs (in €)";
            this.ArtPrice.Name = "ArtPrice";
            this.ArtPrice.ReadOnly = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(615, 659);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 56);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Opslaan";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            // 
            // Aanpassingen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 721);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.datagrdArt);
            this.Controls.Add(this.btnOpenCSV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxCSVPath);
            this.Controls.Add(this.grpBoxItemDelete);
            this.Controls.Add(this.grpBoxEdditItem);
            this.Controls.Add(this.grpBoxAddItem);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblConfig);
            this.Name = "Aanpassingen";
            this.Text = "Aanpassingen";
            this.Load += new System.EventHandler(this.Aanpassingen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpBoxAddItem.ResumeLayout(false);
            this.grpBoxAddItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numArtPrice)).EndInit();
            this.grpBoxEdditItem.ResumeLayout(false);
            this.grpBoxEdditItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numArtPriceChange)).EndInit();
            this.grpBoxItemDelete.ResumeLayout(false);
            this.grpBoxItemDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrdArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblConfig;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem factuurMakenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aanpassingenToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpBoxAddItem;
        private System.Windows.Forms.ComboBox cmbBoxArtCat;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown numArtPrice;
        private System.Windows.Forms.Label lblArtPrice;
        private System.Windows.Forms.Label lblArtCategory;
        private System.Windows.Forms.TextBox txtBoxArtName;
        private System.Windows.Forms.Label lblArtName;
        private System.Windows.Forms.GroupBox grpBoxEdditItem;
        private System.Windows.Forms.TextBox txtBoxArtNameChange;
        private System.Windows.Forms.Label lblArtNameChange;
        private System.Windows.Forms.ComboBox cmbBoxArtChange;
        private System.Windows.Forms.ComboBox cmbBoxArtCatChange;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.NumericUpDown numArtPriceChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpBoxItemDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbBoxArtDelete;
        private System.Windows.Forms.Label lblArtDelte;
        private System.Windows.Forms.TextBox txtBoxCSVPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOpenCSV;
        private System.Windows.Forms.DataGridView datagrdArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtPrice;
        private System.Windows.Forms.Button btnSave;
    }
}