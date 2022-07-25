namespace Skyjo
{
    partial class frmSkyjo
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSkyjo));
            this.btnNouveauJeu = new System.Windows.Forms.Button();
            this.pnlJeu = new System.Windows.Forms.Panel();
            this.lblPoints = new System.Windows.Forms.Label();
            this.btnEchanger = new System.Windows.Forms.Button();
            this.tasDeCartes = new System.Windows.Forms.PictureBox();
            this.lblPointsAdversaire = new System.Windows.Forms.Label();
            this.lblActions = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lblRecap = new System.Windows.Forms.Label();
            this.btnAffichageJeu = new System.Windows.Forms.Button();
            this.lblJeu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tasDeCartes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNouveauJeu
            // 
            this.btnNouveauJeu.Location = new System.Drawing.Point(1119, 423);
            this.btnNouveauJeu.Name = "btnNouveauJeu";
            this.btnNouveauJeu.Size = new System.Drawing.Size(227, 37);
            this.btnNouveauJeu.TabIndex = 1;
            this.btnNouveauJeu.Text = "Recommencer la partie";
            this.btnNouveauJeu.UseVisualStyleBackColor = true;
            this.btnNouveauJeu.Click += new System.EventHandler(this.btnNouveauJeu_Click);
            // 
            // pnlJeu
            // 
            this.pnlJeu.BackColor = System.Drawing.Color.Transparent;
            this.pnlJeu.Location = new System.Drawing.Point(12, 41);
            this.pnlJeu.Name = "pnlJeu";
            this.pnlJeu.Size = new System.Drawing.Size(843, 628);
            this.pnlJeu.TabIndex = 2;
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(1163, 660);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(181, 20);
            this.lblPoints.TabIndex = 2;
            this.lblPoints.Text = "Total de points : 0 points";
            // 
            // btnEchanger
            // 
            this.btnEchanger.BackColor = System.Drawing.Color.Lime;
            this.btnEchanger.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnEchanger.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnEchanger.Location = new System.Drawing.Point(1119, 373);
            this.btnEchanger.Name = "btnEchanger";
            this.btnEchanger.Size = new System.Drawing.Size(227, 37);
            this.btnEchanger.TabIndex = 0;
            this.btnEchanger.Tag = "0";
            this.btnEchanger.Text = "Echanger une carte avec celle du tas";
            this.btnEchanger.UseVisualStyleBackColor = false;
            this.btnEchanger.Click += new System.EventHandler(this.btnEchanger_Click);
            // 
            // tasDeCartes
            // 
            this.tasDeCartes.BackColor = System.Drawing.Color.Transparent;
            this.tasDeCartes.Location = new System.Drawing.Point(1168, 95);
            this.tasDeCartes.Name = "tasDeCartes";
            this.tasDeCartes.Size = new System.Drawing.Size(190, 190);
            this.tasDeCartes.TabIndex = 3;
            this.tasDeCartes.TabStop = false;
            // 
            // lblPointsAdversaire
            // 
            this.lblPointsAdversaire.AutoSize = true;
            this.lblPointsAdversaire.BackColor = System.Drawing.Color.Transparent;
            this.lblPointsAdversaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblPointsAdversaire.Location = new System.Drawing.Point(1056, 694);
            this.lblPointsAdversaire.Name = "lblPointsAdversaire";
            this.lblPointsAdversaire.Size = new System.Drawing.Size(288, 20);
            this.lblPointsAdversaire.TabIndex = 5;
            this.lblPointsAdversaire.Text = "Total de points (adversaire) : 0 points";
            // 
            // lblActions
            // 
            this.lblActions.AutoSize = true;
            this.lblActions.BackColor = System.Drawing.Color.Transparent;
            this.lblActions.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActions.Location = new System.Drawing.Point(1114, 335);
            this.lblActions.Name = "lblActions";
            this.lblActions.Size = new System.Drawing.Size(232, 25);
            this.lblActions.TabIndex = 6;
            this.lblActions.Text = "Actions disponibles";
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(1119, 471);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(227, 37);
            this.btnMenu.TabIndex = 7;
            this.btnMenu.Text = "Revenir au menu principal";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(1119, 517);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(227, 37);
            this.btnQuitter.TabIndex = 8;
            this.btnQuitter.Text = "Revenir au bureau";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // lblRecap
            // 
            this.lblRecap.AutoSize = true;
            this.lblRecap.BackColor = System.Drawing.Color.Transparent;
            this.lblRecap.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecap.Location = new System.Drawing.Point(1055, 621);
            this.lblRecap.Name = "lblRecap";
            this.lblRecap.Size = new System.Drawing.Size(291, 25);
            this.lblRecap.TabIndex = 9;
            this.lblRecap.Text = "Récapitulatif des scores";
            // 
            // btnAffichageJeu
            // 
            this.btnAffichageJeu.BackColor = System.Drawing.Color.Lime;
            this.btnAffichageJeu.FlatAppearance.BorderSize = 0;
            this.btnAffichageJeu.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAffichageJeu.Location = new System.Drawing.Point(308, 703);
            this.btnAffichageJeu.Name = "btnAffichageJeu";
            this.btnAffichageJeu.Size = new System.Drawing.Size(227, 37);
            this.btnAffichageJeu.TabIndex = 10;
            this.btnAffichageJeu.Tag = "0";
            this.btnAffichageJeu.Text = "Afficher le jeu de l\'adversaire";
            this.btnAffichageJeu.UseVisualStyleBackColor = false;
            this.btnAffichageJeu.Click += new System.EventHandler(this.btnAffichageJeu_Click);
            // 
            // lblJeu
            // 
            this.lblJeu.AutoSize = true;
            this.lblJeu.BackColor = System.Drawing.Color.Transparent;
            this.lblJeu.Font = new System.Drawing.Font("Stencil", 25.75F);
            this.lblJeu.ForeColor = System.Drawing.Color.Black;
            this.lblJeu.Location = new System.Drawing.Point(335, 9);
            this.lblJeu.Name = "lblJeu";
            this.lblJeu.Size = new System.Drawing.Size(200, 42);
            this.lblJeu.TabIndex = 11;
            this.lblJeu.Tag = "0";
            this.lblJeu.Text = "Votre jeu";
            // 
            // frmSkyjo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1370, 752);
            this.Controls.Add(this.lblJeu);
            this.Controls.Add(this.btnAffichageJeu);
            this.Controls.Add(this.lblRecap);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblActions);
            this.Controls.Add(this.lblPointsAdversaire);
            this.Controls.Add(this.btnEchanger);
            this.Controls.Add(this.tasDeCartes);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.pnlJeu);
            this.Controls.Add(this.btnNouveauJeu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSkyjo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skyjo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSkyjo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tasDeCartes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNouveauJeu;
        private System.Windows.Forms.Panel pnlJeu;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.PictureBox tasDeCartes;
        private System.Windows.Forms.Button btnEchanger;
        private System.Windows.Forms.Label lblPointsAdversaire;
        private System.Windows.Forms.Label lblActions;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblRecap;
        private System.Windows.Forms.Button btnAffichageJeu;
        private System.Windows.Forms.Label lblJeu;
    }
}

