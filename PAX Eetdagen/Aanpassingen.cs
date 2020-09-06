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
    public partial class Aanpassingen : Form
    {
        public Aanpassingen()
        {
            InitializeComponent();
        }

        OpenFileDialog openFileDialog1 = new OpenFileDialog
        {
            Title = "Selecteer TXT bestand",

            CheckFileExists = true,
            CheckPathExists = true,

            DefaultExt = "txt",
            Filter = "txt bestanden (*.txt)|*.txt",
            FilterIndex = 2,
            RestoreDirectory = true,

            ReadOnlyChecked = true,
            ShowReadOnly = true
        };

        private void Aanpassingen_Load(object sender, EventArgs e)
        {
            foreach(var artikel in Global.Artikels)
            {
                datagrdArt.Rows.Add(artikel.naam, artikel.categorie, artikel.prijs);
            }
            UpdateComboBoxes();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (datagrdArt.Rows.Count > 0)
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
                            foreach (DataGridViewRow row in datagrdArt.Rows)
                            {
                                sw.WriteLine(row.Cells[0].Value.ToString());
                                sw.WriteLine(row.Cells[1].Value.ToString());
                                sw.WriteLine(Convert.ToSingle(row.Cells[2].Value));
                            }
                            sw.Close();
                            string msg = "Data opgeslagen";
                            string title = "Succes";
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            DialogResult result = MessageBox.Show(msg, title, buttons, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1); ;
                            SaveArticleList();
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
            else
            {
                string msg = "Geen data om te exporteren!";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(msg, title, buttons, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnOpenCSV_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Global.path = openFileDialog1.FileName;
                txtBoxCSVPath.Text = Global.path;
                BindTXT(Global.path);
                SaveArticleList();
                UpdateComboBoxes();
                btnSave.Visible = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Kijk of er een naam werd ingegeven
            string art = txtBoxArtName.Text;
            if (art == "")
            {
                lblArtName.ForeColor = Color.Red;
            }

            //Kijk of er een categorie werd ingegeven
            string cat = cmbBoxArtCat.Text;
            if (cat == "")
            {
                lblArtCategory.ForeColor = Color.Red;
            }

            //Haal de prijs op
            float price = (float)numArtPrice.Value;

            bool match = false;
            foreach (var x in Global.Artikels)
            {
                if (x.naam == art)
                {
                    match = true;
                }
            }

            //Als alles is ingevuld
            if (art != "" && cat != "" && !match)
            {
                //Voeg toe aan de lijst
                Global.Artikels.Add(new Article(art, cat, price));

                //Zet labels terug op zwarte kleur
                lblArtName.ForeColor = Color.Black;
                lblArtCategory.ForeColor = Color.Black;

                //Maak velden leeg
                txtBoxArtName.Text = "";
                cmbBoxArtCat.Text = "";
                numArtPrice.Value = 0;

                cmbBoxArtChange.Items.Add(art);
                cmbBoxArtDelete.Items.Add(art);

                //Herlaad de tabel met nieuwe gegevens
                update_table();

                //Als er minstens één product is weergegeven laat de 'klaar' knop zien
                if (Global.Artikels.Count >= 1)
                {
                    btnSave.Visible = true;
                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string art = cmbBoxArtChange.Text;

            int counter = 0;
            foreach (var x in Global.Artikels)
            {
                if (x.naam == art)
                {
                    Global.Artikels[counter].naam = txtBoxArtNameChange.Text;
                    Global.Artikels[counter].categorie = cmbBoxArtCatChange.Text;
                    Global.Artikels[counter].prijs = (float)numArtPriceChange.Value;
                    update_table();
                }
                counter++;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Global.Artikels.Count > 0)
            {
                string art = cmbBoxArtDelete.Text;

                var destroy = Global.Artikels[0];
                bool match = false;
                foreach (var x in Global.Artikels)
                {
                    if (x.naam == art)
                    {
                        destroy = x;
                        match = true;
                    }
                }
                if (match)
                {
                    string message = "Bent u zeker dat u " + art + " wilt verwijderen?";
                    string title = "Artikel verwijderen";
                    MessageBoxButtons knoppen = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, knoppen, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        Global.Artikels.Remove(destroy);
                        update_table();
                        cmbBoxArtDelete.Text = "";
                    }
                }
            }
        }

        private void datagrdArt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbBoxArtChange.Text = datagrdArt.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtBoxArtNameChange.Text = datagrdArt.Rows[e.RowIndex].Cells[0].Value.ToString();
            cmbBoxArtCatChange.Text = datagrdArt.Rows[e.RowIndex].Cells[1].Value.ToString();
            numArtPriceChange.Value = Convert.ToDecimal(datagrdArt.Rows[e.RowIndex].Cells[2].Value);
        }

        private void BindTXT(string filePath)
        {
            if (datagrdArt.Rows.Count > 0)
            {
                datagrdArt.Rows.Clear();
            }
            string[] lines = System.IO.File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {
                int x = 0;
                string name = "";
                string category = "";
                foreach (string line in lines)
                {
                    if (x == 0)
                    {
                        name = line;
                        x++;
                    }
                    else if (x == 1)
                    {
                        category = line;
                        x++;
                    }
                    else
                    {
                        datagrdArt.Rows.Add(name, category, line);
                        x = 0;
                    }
                }
            }
            else
            {
                string msg = "Error, geen data in bestand.";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(msg, title, buttons, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            Global.path = filePath;
        }

        private void SaveArticleList()
        {
            Global.Artikels.Clear();
            int rows = datagrdArt.RowCount;
            for (int i = 0; i < rows; i++)
            {
                Global.Artikels.Add(new Article(datagrdArt.Rows[i].Cells[0].Value.ToString(), datagrdArt.Rows[i].Cells[1].Value.ToString(), Convert.ToSingle(datagrdArt.Rows[i].Cells[2].Value)));
            }
        }

        private void UpdateComboBoxes()
        {
            foreach (var artikel in Global.Artikels)
            {
                cmbBoxArtChange.Items.Add(artikel.naam);
                cmbBoxArtDelete.Items.Add(artikel.naam);
            }
        }

        //Functie voor het updaten van de tabel
        void update_table()
        {
            datagrdArt.Rows.Clear();

            foreach (var x in Global.Artikels)
            {
                datagrdArt.Rows.Add(x.naam, x.categorie, x.prijs);
            }
        }

        private void cmbBoxArtChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            string art = cmbBoxArtChange.Text;

            int counter = 0;
            bool match = false;
            foreach (var x in Global.Artikels)
            {
                if (x.naam == art)
                {
                    txtBoxArtNameChange.Text = Global.Artikels[counter].naam;
                    cmbBoxArtCatChange.Text = Global.Artikels[counter].categorie;
                    numArtPriceChange.Value = (decimal)Global.Artikels[counter].prijs;
                    match = true;
                }
                counter++;
                if (counter == Global.Artikels.Count - 1 && !match)
                {
                    txtBoxArtNameChange.Text = "Geen resultaat gevonden.";
                }
            }
        }

        private void applicatieInstellingenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Applicatie_instellingen frm4 = new Applicatie_instellingen();
            frm4.Show();
            this.Visible = false;
        }

        private void factuurMakenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factuur frm2 = new Factuur();
            frm2.Show();
            this.Visible = false;
        }

        private void Aanpassingen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
