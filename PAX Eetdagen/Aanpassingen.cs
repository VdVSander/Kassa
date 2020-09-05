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
    public partial class Aanpassingen : Form
    {
        public Aanpassingen()
        {
            InitializeComponent();
        }

        private void Aanpassingen_Load(object sender, EventArgs e)
        {
            foreach(var artikel in Global.Artikels)
            {
                datagrdArt.Rows.Add(artikel.naam, artikel.categorie, artikel.prijs);
            }
        }
    }
}
