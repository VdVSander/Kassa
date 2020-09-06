namespace PAX_Eetdagen
{
    partial class Applicatie_instellingen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Applicatie_instellingen));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.factuurMakenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aanpassingenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artikelsAanpassenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicatieInstellingenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblConfig = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxLogo = new System.Windows.Forms.TextBox();
            this.btnSelectLogo = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSelectConfig = new System.Windows.Forms.Button();
            this.txtBoxConfig = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.factuurMakenToolStripMenuItem,
            this.aanpassingenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(516, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // factuurMakenToolStripMenuItem
            // 
            this.factuurMakenToolStripMenuItem.Name = "factuurMakenToolStripMenuItem";
            this.factuurMakenToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.factuurMakenToolStripMenuItem.Text = "Factuur maken";
            this.factuurMakenToolStripMenuItem.Click += new System.EventHandler(this.factuurMakenToolStripMenuItem_Click);
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
            // 
            // lblConfig
            // 
            this.lblConfig.AutoSize = true;
            this.lblConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfig.Location = new System.Drawing.Point(12, 24);
            this.lblConfig.Name = "lblConfig";
            this.lblConfig.Size = new System.Drawing.Size(324, 37);
            this.lblConfig.TabIndex = 4;
            this.lblConfig.Text = "Applicatie instellingen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Logo:";
            // 
            // txtBoxLogo
            // 
            this.txtBoxLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLogo.Location = new System.Drawing.Point(84, 137);
            this.txtBoxLogo.Name = "txtBoxLogo";
            this.txtBoxLogo.Size = new System.Drawing.Size(300, 31);
            this.txtBoxLogo.TabIndex = 6;
            // 
            // btnSelectLogo
            // 
            this.btnSelectLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectLogo.Location = new System.Drawing.Point(390, 135);
            this.btnSelectLogo.Name = "btnSelectLogo";
            this.btnSelectLogo.Size = new System.Drawing.Size(114, 33);
            this.btnSelectLogo.TabIndex = 7;
            this.btnSelectLogo.Text = "Selecteer";
            this.btnSelectLogo.UseVisualStyleBackColor = true;
            this.btnSelectLogo.Click += new System.EventHandler(this.btnSelectLogo_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(390, 203);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 33);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Opslaan";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSelectConfig
            // 
            this.btnSelectConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectConfig.Location = new System.Drawing.Point(390, 87);
            this.btnSelectConfig.Name = "btnSelectConfig";
            this.btnSelectConfig.Size = new System.Drawing.Size(114, 33);
            this.btnSelectConfig.TabIndex = 11;
            this.btnSelectConfig.Text = "Selecteer";
            this.btnSelectConfig.UseVisualStyleBackColor = true;
            // 
            // txtBoxConfig
            // 
            this.txtBoxConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxConfig.Location = new System.Drawing.Point(132, 89);
            this.txtBoxConfig.Name = "txtBoxConfig";
            this.txtBoxConfig.Size = new System.Drawing.Size(252, 31);
            this.txtBoxConfig.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Config file:";
            // 
            // Applicatie_instellingen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 247);
            this.Controls.Add(this.btnSelectConfig);
            this.Controls.Add(this.txtBoxConfig);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSelectLogo);
            this.Controls.Add(this.txtBoxLogo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblConfig);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Applicatie_instellingen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Applicatie instellingen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Applicatie_instellingen_FormClosing);
            this.Load += new System.EventHandler(this.Applicatie_instellingen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem factuurMakenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aanpassingenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicatieInstellingenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artikelsAanpassenToolStripMenuItem;
        private System.Windows.Forms.Label lblConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxLogo;
        private System.Windows.Forms.Button btnSelectLogo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSelectConfig;
        private System.Windows.Forms.TextBox txtBoxConfig;
        private System.Windows.Forms.Label label2;
    }
}