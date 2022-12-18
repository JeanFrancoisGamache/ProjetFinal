namespace ProjetFinal.Forms
{
    partial class GestionCompte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionCompte));
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnSupprimerCompte = new System.Windows.Forms.Button();
            this.txtNomConnection = new System.Windows.Forms.TextBox();
            this.lblMotDePasse = new System.Windows.Forms.Label();
            this.txtMdpConnection = new System.Windows.Forms.TextBox();
            this.lblNomUtilisateur = new System.Windows.Forms.Label();
            this.btnVoirMdp = new System.Windows.Forms.Button();
            this.txtSolde = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericNbPersonne = new System.Windows.Forms.NumericUpDown();
            this.btnCalculer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnModifierMdp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericNbPersonne)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(290, 18);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(209, 25);
            this.lblTitre.TabIndex = 6;
            this.lblTitre.Text = "Gestion du compte";
            // 
            // btnRetour
            // 
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.Location = new System.Drawing.Point(630, 402);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(158, 36);
            this.btnRetour.TabIndex = 8;
            this.btnRetour.Text = "Retour au menu";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnSupprimerCompte
            // 
            this.btnSupprimerCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerCompte.Location = new System.Drawing.Point(15, 263);
            this.btnSupprimerCompte.Name = "btnSupprimerCompte";
            this.btnSupprimerCompte.Size = new System.Drawing.Size(178, 36);
            this.btnSupprimerCompte.TabIndex = 9;
            this.btnSupprimerCompte.Text = "Supprimer son compte";
            this.btnSupprimerCompte.UseVisualStyleBackColor = true;
            this.btnSupprimerCompte.Click += new System.EventHandler(this.btnSupprimerCompte_Click);
            // 
            // txtNomConnection
            // 
            this.txtNomConnection.Enabled = false;
            this.txtNomConnection.Location = new System.Drawing.Point(15, 117);
            this.txtNomConnection.Name = "txtNomConnection";
            this.txtNomConnection.Size = new System.Drawing.Size(178, 20);
            this.txtNomConnection.TabIndex = 12;
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.Location = new System.Drawing.Point(12, 149);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(71, 13);
            this.lblMotDePasse.TabIndex = 15;
            this.lblMotDePasse.Text = "Mot de passe";
            // 
            // txtMdpConnection
            // 
            this.txtMdpConnection.Location = new System.Drawing.Point(15, 165);
            this.txtMdpConnection.Name = "txtMdpConnection";
            this.txtMdpConnection.Size = new System.Drawing.Size(178, 20);
            this.txtMdpConnection.TabIndex = 13;
            this.txtMdpConnection.UseSystemPasswordChar = true;
            // 
            // lblNomUtilisateur
            // 
            this.lblNomUtilisateur.AutoSize = true;
            this.lblNomUtilisateur.Location = new System.Drawing.Point(12, 101);
            this.lblNomUtilisateur.Name = "lblNomUtilisateur";
            this.lblNomUtilisateur.Size = new System.Drawing.Size(84, 13);
            this.lblNomUtilisateur.TabIndex = 14;
            this.lblNomUtilisateur.Text = "Nom d\'utilisateur";
            // 
            // btnVoirMdp
            // 
            this.btnVoirMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoirMdp.Location = new System.Drawing.Point(213, 160);
            this.btnVoirMdp.Name = "btnVoirMdp";
            this.btnVoirMdp.Size = new System.Drawing.Size(187, 26);
            this.btnVoirMdp.TabIndex = 16;
            this.btnVoirMdp.Text = "Voir mot de passe";
            this.btnVoirMdp.UseVisualStyleBackColor = true;
            this.btnVoirMdp.Click += new System.EventHandler(this.btnVoirMdp_Click);
            // 
            // txtSolde
            // 
            this.txtSolde.Enabled = false;
            this.txtSolde.Location = new System.Drawing.Point(15, 214);
            this.txtSolde.Name = "txtSolde";
            this.txtSolde.Size = new System.Drawing.Size(178, 20);
            this.txtSolde.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Solde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre de personnes";
            // 
            // numericNbPersonne
            // 
            this.numericNbPersonne.Location = new System.Drawing.Point(471, 124);
            this.numericNbPersonne.Name = "numericNbPersonne";
            this.numericNbPersonne.Size = new System.Drawing.Size(120, 20);
            this.numericNbPersonne.TabIndex = 21;
            // 
            // btnCalculer
            // 
            this.btnCalculer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculer.Location = new System.Drawing.Point(597, 118);
            this.btnCalculer.Name = "btnCalculer";
            this.btnCalculer.Size = new System.Drawing.Size(180, 26);
            this.btnCalculer.TabIndex = 22;
            this.btnCalculer.Text = "Calculer";
            this.btnCalculer.UseVisualStyleBackColor = true;
            this.btnCalculer.Click += new System.EventHandler(this.btnCalculer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Gestion du compte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(467, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Calculer prix par personnes";
            // 
            // btnModifierMdp
            // 
            this.btnModifierMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierMdp.Location = new System.Drawing.Point(213, 208);
            this.btnModifierMdp.Name = "btnModifierMdp";
            this.btnModifierMdp.Size = new System.Drawing.Size(187, 26);
            this.btnModifierMdp.TabIndex = 25;
            this.btnModifierMdp.Text = "Modifier Mot de Passe";
            this.btnModifierMdp.UseVisualStyleBackColor = true;
            this.btnModifierMdp.Click += new System.EventHandler(this.btnModifierMdp_Click);
            // 
            // GestionCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModifierMdp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalculer);
            this.Controls.Add(this.numericNbPersonne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSolde);
            this.Controls.Add(this.btnVoirMdp);
            this.Controls.Add(this.txtNomConnection);
            this.Controls.Add(this.lblMotDePasse);
            this.Controls.Add(this.txtMdpConnection);
            this.Controls.Add(this.lblNomUtilisateur);
            this.Controls.Add(this.btnSupprimerCompte);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.lblTitre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestionCompte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GestionCompte";
            this.Load += new System.EventHandler(this.GestionCompte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericNbPersonne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnSupprimerCompte;
        private System.Windows.Forms.TextBox txtNomConnection;
        private System.Windows.Forms.Label lblMotDePasse;
        private System.Windows.Forms.TextBox txtMdpConnection;
        private System.Windows.Forms.Label lblNomUtilisateur;
        private System.Windows.Forms.Button btnVoirMdp;
        private System.Windows.Forms.TextBox txtSolde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericNbPersonne;
        private System.Windows.Forms.Button btnCalculer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnModifierMdp;
    }
}