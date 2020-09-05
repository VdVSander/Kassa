using System;
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
    public partial class Factuur : Form
    {
        public Factuur()
        {
            InitializeComponent();
        }

        private void Factuur_Load(object sender, EventArgs e)
        {
            foreach(var artikel in Global.Artikels)
            {
                if(artikel.categorie == "Eten")
                {
                    datagrdEten.Rows.Add(artikel.naam, 0, artikel.prijs);
                }
                else if(artikel.categorie == "Drank")
                {
                    datagrdDrank.Rows.Add(artikel.naam, 0, artikel.prijs);
                }
                else
                {
                    datagrdAndere.Rows.Add(artikel.naam, 0, artikel.prijs);
                }
            }
        }

        private void Factuur_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void datagrdEten_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datagrdEten_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(datagrdEten.Columns[e.ColumnIndex].Name == "AantalEten")
            {
                bool item_in_list = false;
                int item_row_index = 0;
                foreach (DataGridViewRow row in datagrdFactuur.Rows)
                {
                    if(row.Cells[0].Value != null)
                    {
                        if (row.Cells[0].Value.ToString() == datagrdEten.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value.ToString())
                        {
                            item_in_list = true;
                            item_row_index = row.Index;
                        }
                    }
                }
                if(item_in_list)
                {
                    datagrdFactuur.Rows[item_row_index].Cells[1].Value = Convert.ToInt32(datagrdEten.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                    CalcTotal();
                }
                else
                {
                    AddToTotal(datagrdEten.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value.ToString(), Convert.ToSingle(datagrdEten.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value), Convert.ToInt32(datagrdEten.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));
                    CalcTotal();
                }
            }
        }

        private void datagrdDrank_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (datagrdDrank.Columns[e.ColumnIndex].Name == "AantalDrank")
            {
                bool item_in_list = false;
                int item_row_index = 0;
                foreach (DataGridViewRow row in datagrdFactuur.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        if (row.Cells[0].Value.ToString() == datagrdDrank.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value.ToString())
                        {
                            item_in_list = true;
                            item_row_index = row.Index;
                        }
                    }
                }
                if (item_in_list)
                {
                    datagrdFactuur.Rows[item_row_index].Cells[1].Value = Convert.ToInt32(datagrdDrank.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                    CalcTotal();
                }
                else
                {
                    AddToTotal(datagrdDrank.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value.ToString(), Convert.ToSingle(datagrdDrank.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value), Convert.ToInt32(datagrdDrank.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));
                    CalcTotal();
                }
            }
        }

        private void datagrdAndere_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (datagrdAndere.Columns[e.ColumnIndex].Name == "AantalAndere")
            {
                bool item_in_list = false;
                int item_row_index = 0;
                foreach (DataGridViewRow row in datagrdFactuur.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        if (row.Cells[0].Value.ToString() == datagrdAndere.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value.ToString())
                        {
                            item_in_list = true;
                            item_row_index = row.Index;
                        }
                    }
                }
                if (item_in_list)
                {
                    datagrdFactuur.Rows[item_row_index].Cells[1].Value = Convert.ToInt32(datagrdAndere.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                    CalcTotal();
                }
                else
                {
                    AddToTotal(datagrdAndere.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value.ToString(), Convert.ToSingle(datagrdAndere.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value), Convert.ToInt32(datagrdAndere.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));
                    CalcTotal();
                }
            }
        }

        private void txtBoxTotaalPrijs_TextChanged(object sender, EventArgs e)
        {
            float terug = (float)numBetaald.Value - Convert.ToSingle(txtBoxTotaalPrijs.Text);
            if(terug > 0)
            {
                txtBoxTerug.Text = terug.ToString();
            }
            else
            {
                txtBoxTerug.Text = "0,00";
            }
        }

        private void numBetaald_ValueChanged(object sender, EventArgs e)
        {
            float terug = (float)numBetaald.Value - Convert.ToSingle(txtBoxTotaalPrijs.Text);
            if (terug > 0)
            {
                txtBoxTerug.Text = Math.Round(terug, 2).ToString();
            }
            else
            {
                txtBoxTerug.Text = "0,00";
            }
        }

        private void btnNieuw_Click(object sender, EventArgs e)
        {
            datagrdFactuur.Rows.Clear();
            foreach(DataGridViewRow row in datagrdEten.Rows)
            {
                row.Cells[1].Value = 0;
            }

            foreach (DataGridViewRow row in datagrdDrank.Rows)
            {
                row.Cells[1].Value = 0;
            }

            foreach (DataGridViewRow row in datagrdAndere.Rows)
            {
                row.Cells[1].Value = 0;
            }

            numBetaald.Value = 0;
            txtBoxTerug.Text = "0,00";
        }

        private void datagrdFactuur_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (datagrdFactuur.Columns[e.ColumnIndex].Name == "AantalTot")
            {
                if(Convert.ToInt32(datagrdFactuur.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) == 0)
                {
                    datagrdFactuur.Rows.RemoveAt(e.RowIndex);
                }
                CalcTotal();
            }
        }

        private void AddToTotal(string name, float priceperpiece, int number)
        {
            datagrdFactuur.Rows.Add(name, number, priceperpiece);
        }

        private void CalcTotal()
        {
            float totaal = 0;
            foreach (DataGridViewRow row in datagrdFactuur.Rows)
            {
                totaal = totaal + Convert.ToInt32(row.Cells[1].Value) * Convert.ToSingle(row.Cells[2].Value);
            }
            txtBoxTotaalPrijs.Text = Convert.ToString(totaal);

        }
    }
}
