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
    public partial class frmSkyjo : Form
    {
        public frmSkyjo()
        {
            InitializeComponent();
        }

        private static int TAILLE_JEU = 12;
        
        private Paquet paquet = new Paquet();
        private Paquet jeu = new Paquet();
        private Paquet jeuAdversaire = new Paquet();
        private Paquet tas = new Paquet();

        private Random rdm = new Random();

        private void genererJeu(Paquet p)
        {
            int index;
            for (int i = 0; i < TAILLE_JEU; i++)
            {
                // Tirage aléatoire d'une carte dans le paquet d'origine
                index = rdm.Next(paquet.getCartes().Count);

                // Obtention de la valeur de la carte à partir de l'index
                int valeur = paquet.getCartes()[index].getValeur();

                // On ajoute la carte dans le jeu du joueur
                p.getCartes().Add(new Carte(valeur, false));

                // On retire la carte du paquet d'origine
                paquet.getCartes().RemoveAt(index);
            }

            foreach (Carte c in p.getCartes())
            {
                c.setVisibility(false);
            }
        }

        private void mettreCarteTas()
        {
            // On prend la première carte du paquet
            Carte carte = new Carte(paquet.getCartes()[0].getValeur(), true);
            paquet.getCartes().RemoveAt(0);

            // On ajoute la carte sur le tas
            tas.getCartes().Add(carte);

            // Propriétés du tas de carte
            tasDeCartes.Tag = 0;
            tasDeCartes.Image = Image.FromFile("img/" + tas.getCartes()[0].getValeur() + ".png");
        }

        private void afficherJeu(Paquet p)
        {
            pnlJeu.Controls.Clear();
            try
            {
                int x = -150;
                int y = 50;

                for (int i = 0; i < p.getCartes().Count; i++)
                {
                    PictureBox picture = new PictureBox();
                    if (p.getCartes()[i].estVisible())
                    {
                        picture.Image = Image.FromFile("img/" + p.getCartes()[i].getValeur() + ".png");
                    }
                    else
                    {
                        picture.Image = Image.FromFile("img/none.png");
                    }
                    picture.Size = new Size(190, 190);
                    picture.Tag = i;
                    x += 200;
                    if (i % 4 == 0 && i != 0)
                    {
                        x = 50;
                        y += 200;
                    }
                    picture.Location = new Point(x, y);
                    picture.Click += Picture_Click;
                    pnlJeu.Controls.Add(picture);

                }
            } catch(IndexOutOfRangeException)
            {
                MessageBox.Show("Une erreur est survenue: le paquet mentionné est vide (" + p + ")", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool estJouable(Paquet p)
        {
            try
            {
                bool res = false;
                for (int i = 0; i < p.getCartes().Count && !res; i++)
                {
                    if (!p.getCartes()[i].estVisible())
                    {
                        res = true;
                    }
                }
                return res;
            } catch(IndexOutOfRangeException)
            {
                MessageBox.Show("Une erreur est survenue: le paquet mentionné est vide (" + p + ")", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // 0 = face cachée
        // 1 = face visible
        private void Picture_Click(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            int index = int.Parse(picture.Tag.ToString());

            if (int.Parse(btnAffichageJeu.Tag.ToString()) == 0)
            {
                if (estJouable(jeu) && estJouable(jeuAdversaire))
                {
                    // Révélation de la carte
                    int valeur = jeu.getCartes()[index].getValeur();
                    int valeurTas = tas.getCartes()[0].getValeur();
                    picture.Image = Image.FromFile("img/" + valeur + ".png");
                    jeu.getCartes()[index].setVisibility(true);

                    // Echange de cartes
                    if (btnEchanger.Tag.ToString() == "1")
                    {
                        MessageBox.Show("Vous avez échangé la carte " + valeur + " avec la carte " + valeurTas);

                        // Echange sur les 12 cartes
                        picture.Image = Image.FromFile("img/" + valeurTas + ".png");
                        jeu.getCartes().RemoveAt(index);
                        jeu.getCartes().Insert(index, tas.getCartes()[0]);
                        jeu.getCartes()[index].setVisibility(true);

                        // Echange sur le tas de carte
                        tasDeCartes.Image = Image.FromFile("img/" + valeur + ".png");
                        tas.getCartes().RemoveAt(0);
                        tas.getCartes().Add(new Carte(valeur, true));

                        // Fin de l'échange
                        annulerEchangeDeCartes();
                    }


                    // Tour de l'adversaire
                    index = rdm.Next(jeuAdversaire.getCartes().Count);
                    if (rdm.Next(0, 2) == 0)
                    {
                        jeuAdversaire.getCartes()[index].setVisibility(true);
                        MessageBox.Show("L'ordinateur a décidé de révéler une de ses cartes (" + jeuAdversaire.getCartes()[index].getValeur() + "), par conséquent la carte sur le tas ne change pas!", "Tour de l'ordinateur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        valeur = jeuAdversaire.getCartes()[index].getValeur();

                        // On annonce le résultat au joueur
                        MessageBox.Show("L'ordinateur a décidé d'échanger une de ses cartes avec celle du tas, la carte du tas va donc changer dès que vous cliquerez sur OK!", "Tour de l'ordinateur", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // On retire la carte du tas & on la remet dans le paquet
                        jeuAdversaire.getCartes().RemoveAt(index);
                        jeuAdversaire.getCartes().Insert(index, tas.getCartes()[0]);
                        jeuAdversaire.getCartes()[index].setVisibility(true);

                        // On met une nouvelle carte sur le tas
                        tasDeCartes.Image = Image.FromFile("img/" + valeur + ".png");
                        tas.getCartes().RemoveAt(0);
                        tas.getCartes().Add(new Carte(valeur, true));
                    }
                    if (!estJouable(jeu) || !estJouable(jeuAdversaire))
                    {
                        if (jeu.getTotalPoints() < jeuAdversaire.getTotalPoints())
                        {
                            MessageBox.Show("Fin de partie, vous avez gagné !", "Fin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (jeu.getTotalPoints() > jeuAdversaire.getTotalPoints())
                        {
                            MessageBox.Show("Fin de partie, l'ordinateur a gagné...", "Fin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Fin de partie, il y a une égalité parfaite !", "Fin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Fin de partie, impossible de continuer à jouer!", "Fin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Vous ne pouvez pas retourner les cartes de votre adversaire!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // On affiche les points
            lblPoints.Text = "Total de points : " + jeu.getPoints() + " points";
            lblPointsAdversaire.Text = "Total de points (adversaire) : " + jeuAdversaire.getPoints() + " points";
        }

        private void frmSkyjo_Load(object sender, EventArgs e)
        {
            /* Remplissage du paquet d'origine
             * 5 cartes -2
             * 15 cartes 0
             * 10 cartes pour chaque autre valeur
             */
            paquet.Remplir();
            paquet.Melanger();

            // Remplissage du jeu du joueur & de l'adversaire
            genererJeu(jeu);
            genererJeu(jeuAdversaire);

            // On met une carte sur le tas
            mettreCarteTas();

            // Affichage du jeu du joueur sur le form
            afficherJeu(jeu);
        }

        private void btnNouveauJeu_Click(object sender, EventArgs e)
        {
            // On efface tout les paquets de cartes
            paquet.getCartes().Clear();
            tas.getCartes().Clear();
            jeu.getCartes().Clear();
            jeuAdversaire.getCartes().Clear();

            // On re-remplit le paquet d'origine & on le mélange
            paquet.Remplir();
            paquet.Melanger();

            // On remet les labels à 0
            lblPoints.Text = "Total de points : 0 points";
            lblPointsAdversaire.Text = "Total de points (adversaire) : 0 points";

            // On remet les boutons à zéro (affichage)
            btnAffichageJeu.BackColor = Color.Lime;
            btnAffichageJeu.ForeColor = Color.DarkGreen;
            btnAffichageJeu.Text = "Afficher le jeu de l'adversaire";
            btnAffichageJeu.Tag = 0;
            lblJeu.Text = "Votre jeu";
            lblJeu.ForeColor = Color.Black;
            lblJeu.Location = new Point(335, 9);

            // On re-génère des jeux pour le joueur et l'adversaire & le tas
            genererJeu(jeu);
            genererJeu(jeuAdversaire);
            mettreCarteTas();
            afficherJeu(jeu);
        }

        /* Explication des tags
         * 0 = Pas d'échange en cours
         * 1 = Echange en cours
         */
        private void btnEchanger_Click(object sender, EventArgs e)
        {
            if(int.Parse(btnEchanger.Tag.ToString()) == 0)
            {
                echangeDeCartes();
                MessageBox.Show("Choisissez une carte à échanger avec celle du tas.", "Echange", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                annulerEchangeDeCartes();
                MessageBox.Show("Vous avez décidé d'annuler votre échange de carte", "Echange", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void echangeDeCartes()
        {
            btnEchanger.Tag = 1;
            btnEchanger.Text = "Annuler l'échange de cartes";
            btnEchanger.BackColor = Color.Tomato;
            btnEchanger.ForeColor = Color.DarkRed;
        }

        private void annulerEchangeDeCartes()
        {
            btnEchanger.Tag = 0;
            btnEchanger.Text = "Echanger une carte avec celle du tas";
            btnEchanger.BackColor = Color.Lime;
            btnEchanger.ForeColor = Color.DarkGreen;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void btnAffichageJeu_Click(object sender, EventArgs e)
        {
            // On affiche le jeu de l'adversaire
            if(int.Parse(btnAffichageJeu.Tag.ToString()) == 0)
            {
                btnAffichageJeu.BackColor = Color.Tomato;
                btnAffichageJeu.ForeColor = Color.DarkRed;
                btnAffichageJeu.Text = "Afficher votre jeu";
                btnAffichageJeu.Tag = 1;
                lblJeu.Text = "Jeu de l'adversaire";
                lblJeu.ForeColor = Color.Tomato;
                lblJeu.Location = new Point(234, 9);
                afficherJeu(jeuAdversaire);
            }
            // On affiche le jeu du joueur
            else
            {
                btnAffichageJeu.BackColor = Color.Lime;
                btnAffichageJeu.ForeColor = Color.DarkGreen;
                btnAffichageJeu.Text = "Afficher le jeu de l'adversaire";
                btnAffichageJeu.Tag = 0;
                lblJeu.Text = "Votre jeu";
                lblJeu.ForeColor = Color.Black;
                lblJeu.Location = new Point(335, 9);
                afficherJeu(jeu);
            }
        }
    }
}
