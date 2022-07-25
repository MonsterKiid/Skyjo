namespace Skyjo
{
    partial class Parametres
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
            this.grpDifficulte = new System.Windows.Forms.GroupBox();
            this.rdbFacile = new System.Windows.Forms.RadioButton();
            this.rdbDifficile = new System.Windows.Forms.RadioButton();
            this.rdbNormal = new System.Windows.Forms.RadioButton();
            this.btnSauvegarder = new System.Windows.Forms.Button();
            this.grpDifficulte.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDifficulte
            // 
            this.grpDifficulte.Controls.Add(this.rdbNormal);
            this.grpDifficulte.Controls.Add(this.rdbDifficile);
            this.grpDifficulte.Controls.Add(this.rdbFacile);
            this.grpDifficulte.Location = new System.Drawing.Point(23, 20);
            this.grpDifficulte.Name = "grpDifficulte";
            this.grpDifficulte.Size = new System.Drawing.Size(538, 159);
            this.grpDifficulte.TabIndex = 0;
            this.grpDifficulte.TabStop = false;
            this.grpDifficulte.Text = "Difficulté de la partie";
            // 
            // rdbFacile
            // 
            this.rdbFacile.AutoSize = true;
            this.rdbFacile.Location = new System.Drawing.Point(25, 43);
            this.rdbFacile.Name = "rdbFacile";
            this.rdbFacile.Size = new System.Drawing.Size(53, 17);
            this.rdbFacile.TabIndex = 0;
            this.rdbFacile.Tag = "0";
            this.rdbFacile.Text = "Facile";
            this.rdbFacile.UseVisualStyleBackColor = true;
            this.rdbFacile.Click += new System.EventHandler(this.rdb_Click);
            // 
            // rdbDifficile
            // 
            this.rdbDifficile.AutoSize = true;
            this.rdbDifficile.Location = new System.Drawing.Point(25, 111);
            this.rdbDifficile.Name = "rdbDifficile";
            this.rdbDifficile.Size = new System.Drawing.Size(59, 17);
            this.rdbDifficile.TabIndex = 1;
            this.rdbDifficile.Tag = "0";
            this.rdbDifficile.Text = "Difficile";
            this.rdbDifficile.UseVisualStyleBackColor = true;
            this.rdbDifficile.Click += new System.EventHandler(this.rdb_Click);
            // 
            // rdbNormal
            // 
            this.rdbNormal.AutoSize = true;
            this.rdbNormal.Checked = true;
            this.rdbNormal.Location = new System.Drawing.Point(25, 76);
            this.rdbNormal.Name = "rdbNormal";
            this.rdbNormal.Size = new System.Drawing.Size(58, 17);
            this.rdbNormal.TabIndex = 2;
            this.rdbNormal.TabStop = true;
            this.rdbNormal.Tag = "1";
            this.rdbNormal.Text = "Normal";
            this.rdbNormal.UseVisualStyleBackColor = true;
            this.rdbNormal.Click += new System.EventHandler(this.rdb_Click);
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.Location = new System.Drawing.Point(479, 315);
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(82, 23);
            this.btnSauvegarder.TabIndex = 1;
            this.btnSauvegarder.Text = "Sauvegarder";
            this.btnSauvegarder.UseVisualStyleBackColor = true;
            this.btnSauvegarder.Click += new System.EventHandler(this.btnSauvegarder_Click);
            // 
            // Parametres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 350);
            this.Controls.Add(this.btnSauvegarder);
            this.Controls.Add(this.grpDifficulte);
            this.Name = "Parametres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Paramètres";
            this.grpDifficulte.ResumeLayout(false);
            this.grpDifficulte.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDifficulte;
        private System.Windows.Forms.RadioButton rdbNormal;
        private System.Windows.Forms.RadioButton rdbDifficile;
        private System.Windows.Forms.RadioButton rdbFacile;
        private System.Windows.Forms.Button btnSauvegarder;
    }
}