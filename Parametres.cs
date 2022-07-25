using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skyjo
{
    public partial class Parametres : Form
    {
        public Parametres()
        {
            InitializeComponent();
        }

        string difficulte;

        public string Difficulty
        {
            get{
                return difficulte;
            }
            set{
                foreach(RadioButton rdb in grpDifficulte.Controls.OfType<RadioButton>())
                {
                    if (rdb.Checked) difficulte = rdb.Text;
                }
            }
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            difficulte = Difficulty;
            this.DialogResult = DialogResult.OK;
        }

        private void rdb_Click(object sender, EventArgs e)
        {
            foreach (RadioButton rdb in grpDifficulte.Controls.OfType<RadioButton>())
            {
                if (rdb.Checked) difficulte = rdb.Text;
            }
        }
    }
}
