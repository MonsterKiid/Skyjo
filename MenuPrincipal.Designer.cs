namespace Skyjo
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNouvellePartie = new Skyjo.RoundButton();
            this.btnRegles = new Skyjo.RoundButton();
            this.btnParametres = new Skyjo.RoundButton();
            this.btnQuitter = new Skyjo.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(531, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 485);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnNouvellePartie
            // 
            this.btnNouvellePartie.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNouvellePartie.BorderColor = System.Drawing.Color.Transparent;
            this.btnNouvellePartie.BorderRadius = 20;
            this.btnNouvellePartie.BorderSize = 0;
            this.btnNouvellePartie.FlatAppearance.BorderSize = 0;
            this.btnNouvellePartie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNouvellePartie.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F);
            this.btnNouvellePartie.ForeColor = System.Drawing.Color.Black;
            this.btnNouvellePartie.Location = new System.Drawing.Point(481, 511);
            this.btnNouvellePartie.Name = "btnNouvellePartie";
            this.btnNouvellePartie.Size = new System.Drawing.Size(408, 49);
            this.btnNouvellePartie.TabIndex = 0;
            this.btnNouvellePartie.Text = "Commencer une nouvelle partie";
            this.btnNouvellePartie.TextColor = System.Drawing.Color.Black;
            this.btnNouvellePartie.UseVisualStyleBackColor = false;
            this.btnNouvellePartie.Click += new System.EventHandler(this.btnNouvellePartie_Click);
            this.btnNouvellePartie.MouseLeave += new System.EventHandler(this.btnMenuPrincipal_MouseLeave);
            this.btnNouvellePartie.MouseHover += new System.EventHandler(this.btnMenuPrincipal_MouseHover);
            // 
            // btnRegles
            // 
            this.btnRegles.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegles.BorderColor = System.Drawing.Color.Transparent;
            this.btnRegles.BorderRadius = 20;
            this.btnRegles.BorderSize = 0;
            this.btnRegles.FlatAppearance.BorderSize = 0;
            this.btnRegles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegles.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F);
            this.btnRegles.ForeColor = System.Drawing.Color.Black;
            this.btnRegles.Location = new System.Drawing.Point(481, 574);
            this.btnRegles.Name = "btnRegles";
            this.btnRegles.Size = new System.Drawing.Size(408, 49);
            this.btnRegles.TabIndex = 1;
            this.btnRegles.Text = "Règles du jeu";
            this.btnRegles.TextColor = System.Drawing.Color.Black;
            this.btnRegles.UseVisualStyleBackColor = false;
            this.btnRegles.Click += new System.EventHandler(this.btnRegles_Click);
            this.btnRegles.MouseLeave += new System.EventHandler(this.btnMenuPrincipal_MouseLeave);
            this.btnRegles.MouseHover += new System.EventHandler(this.btnMenuPrincipal_MouseHover);
            // 
            // btnParametres
            // 
            this.btnParametres.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnParametres.BorderColor = System.Drawing.Color.Transparent;
            this.btnParametres.BorderRadius = 20;
            this.btnParametres.BorderSize = 0;
            this.btnParametres.FlatAppearance.BorderSize = 0;
            this.btnParametres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParametres.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F);
            this.btnParametres.ForeColor = System.Drawing.Color.Black;
            this.btnParametres.Location = new System.Drawing.Point(481, 637);
            this.btnParametres.Name = "btnParametres";
            this.btnParametres.Size = new System.Drawing.Size(408, 49);
            this.btnParametres.TabIndex = 2;
            this.btnParametres.Text = "Paramètres";
            this.btnParametres.TextColor = System.Drawing.Color.Black;
            this.btnParametres.UseVisualStyleBackColor = false;
            this.btnParametres.Click += new System.EventHandler(this.btnParametres_Click);
            this.btnParametres.MouseLeave += new System.EventHandler(this.btnMenuPrincipal_MouseLeave);
            this.btnParametres.MouseHover += new System.EventHandler(this.btnMenuPrincipal_MouseHover);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuitter.BorderColor = System.Drawing.Color.Transparent;
            this.btnQuitter.BorderRadius = 20;
            this.btnQuitter.BorderSize = 0;
            this.btnQuitter.FlatAppearance.BorderSize = 0;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F);
            this.btnQuitter.ForeColor = System.Drawing.Color.Black;
            this.btnQuitter.Location = new System.Drawing.Point(481, 700);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(408, 49);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.TextColor = System.Drawing.Color.Black;
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            this.btnQuitter.MouseLeave += new System.EventHandler(this.btnMenuPrincipal_MouseLeave);
            this.btnQuitter.MouseHover += new System.EventHandler(this.btnMenuPrincipal_MouseHover);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1370, 752);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnParametres);
            this.Controls.Add(this.btnRegles);
            this.Controls.Add(this.btnNouvellePartie);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private RoundButton btnNouvellePartie;
        private RoundButton btnRegles;
        private RoundButton btnParametres;
        private RoundButton btnQuitter;
    }
}