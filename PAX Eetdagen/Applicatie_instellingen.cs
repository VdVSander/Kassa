using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAX_Eetdagen
{
    public partial class Applicatie_instellingen : Form
    {
        public Applicatie_instellingen()
        {
            InitializeComponent();
        }

        OpenFileDialog openFileDialog1 = new OpenFileDialog
        {
            Title = "Selecteer png bestand",

            CheckFileExists = true,
            CheckPathExists = true,

            DefaultExt = "png",
            Filter = "png bestanden (*.png)|*.png",
            FilterIndex = 2,
            RestoreDirectory = true,

            ReadOnlyChecked = true,
            ShowReadOnly = true
        };

        private void factuurMakenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factuur frm2 = new Factuur();
            frm2.Show();
            this.Visible = false;
        }

        private void artikelsAanpassenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aanpassingen frm3 = new Aanpassingen();
            frm3.Show();
            this.Visible = false;
        }

        private void btnSelectLogo_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Global.logo_path = openFileDialog1.FileName;
                txtBoxLogo.Text = Global.logo_path;
            }
        }

        private void Applicatie_instellingen_Load(object sender, EventArgs e)
        {
            if (Global.config_path != "")
            {
                txtBoxConfig.Text = Global.config_path;
            }
            if (Global.logo_path != "")
            {
                txtBoxLogo.Text = Global.logo_path;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string file_path = "";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "TXT (*.txt)|*.txt";
            bool fileError = false;
            if ((sfd.ShowDialog() == DialogResult.OK) && (sfd.FileName != ""))
            {
                file_path = sfd.FileName;
                if (File.Exists(sfd.FileName))
                {
                    try
                    {
                        File.Delete(sfd.FileName);
                    }
                    catch (IOException ex)
                    {
                        fileError = true;
                        string msg = "Het was niet mogelijk om de data weg te schrijven." + ex.Message;
                        string title = "Error";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(msg, title, buttons, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
                if (!fileError)
                {
                    try
                    {
                        StreamWriter sw = new StreamWriter(File.Create(file_path));
                        sw.WriteLine(Global.logo_path);
                        sw.Close();
                        string msg = "Data opgeslagen";
                        string title = "Succes";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(msg, title, buttons, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    }
                    catch (Exception ex)
                    {
                        string msg = "Error :" + ex.Message;
                        string title = "Error";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(msg, title, buttons, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }
        }

        private void Applicatie_instellingen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
