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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnNouvellePartie_Click(object sender, EventArgs e)
        {
            frmSkyjo partie = new frmSkyjo();
            if(partie.ShowDialog() == DialogResult.Abort)
            {
                this.Close();
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegles_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Un jeu de cartes simple mais subtil et terriblement addictif! On dispose 12 cartes devant soit faces cachées. Chaque joueur à son tour prend la première carte de la pioche ou de la défausse. S’il prend une carte visible de la défausse il doit échanger cette carte avec l’une de ses cartes (cachée ou visible) et la poser face visible. Avec une carte de la pioche il peut la défausser directement, mais doit révéler une de ses cartes. Il est possible de défausser 3 cartes d’un coup si elles sont identiques et dans une même colonne. Lorsqu’un joueur a révélé toutes ses cartes, le tour se termine puis la manche s’arrête. Le jeu se joue en plusieurs manches, l'objectif est de totaliser le moins de point possible!", "Présentation du jeu Skyjo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMenuPrincipal_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.ForeColor = Color.White;
            btn.BackColor = Color.RoyalBlue;
        }

        private void btnMenuPrincipal_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.ForeColor = Color.Black;
            btn.BackColor = Color.WhiteSmoke;
        }

        private void btnParametres_Click(object sender, EventArgs e)
        {
            Parametres param = new Parametres();
            if(param.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("La difficulté a bien été définie à " + param.Difficulty);
            }
        }
    }
}
