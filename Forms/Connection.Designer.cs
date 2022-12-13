namespace ProjetFinal.Forms
{
    partial class Connection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connection));
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnection = new System.Windows.Forms.Button();
            this.txtNomConnection = new System.Windows.Forms.TextBox();
            this.txtMdpConnection = new System.Windows.Forms.TextBox();
            this.lblNomUtilisateur = new System.Windows.Forms.Label();
            this.lblMotDePasse = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxConnection = new System.Windows.Forms.GroupBox();
            this.gbxCreation = new System.Windows.Forms.GroupBox();
            this.btnCreer = new System.Windows.Forms.Button();
            this.txtNomCreer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMdpCreer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxDeconenction = new System.Windows.Forms.GroupBox();
            this.lblDeconnection = new System.Windows.Forms.Label();
            this.btnDeconnection = new System.Windows.Forms.Button();
            this.gbxConnection.SuspendLayout();
            this.gbxCreation.SuspendLayout();
            this.gbxDeconenction.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Se connecter";
            // 
            // btnConnection
            // 
            this.btnConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnection.Location = new System.Drawing.Point(76, 179);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(146, 36);
            this.btnConnection.TabIndex = 7;
            this.btnConnection.Text = "Connection";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // txtNomConnection
            // 
            this.txtNomConnection.Location = new System.Drawing.Point(63, 93);
            this.txtNomConnection.Name = "txtNomConnection";
            this.txtNomConnection.Size = new System.Drawing.Size(178, 20);
            this.txtNomConnection.TabIndex = 8;
            // 
            // txtMdpConnection
            // 
            this.txtMdpConnection.Location = new System.Drawing.Point(63, 141);
            this.txtMdpConnection.Name = "txtMdpConnection";
            this.txtMdpConnection.Size = new System.Drawing.Size(178, 20);
            this.txtMdpConnection.TabIndex = 9;
            this.txtMdpConnection.UseSystemPasswordChar = true;
            // 
            // lblNomUtilisateur
            // 
            this.lblNomUtilisateur.AutoSize = true;
            this.lblNomUtilisateur.Location = new System.Drawing.Point(60, 77);
            this.lblNomUtilisateur.Name = "lblNomUtilisateur";
            this.lblNomUtilisateur.Size = new System.Drawing.Size(84, 13);
            this.lblNomUtilisateur.TabIndex = 10;
            this.lblNomUtilisateur.Text = "Nom d\'utilisateur";
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.Location = new System.Drawing.Point(60, 125);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(71, 13);
            this.lblMotDePasse.TabIndex = 11;
            this.lblMotDePasse.Text = "Mot de passe";
            // 
            // btnRetour
            // 
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.Location = new System.Drawing.Point(614, 388);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(158, 36);
            this.btnRetour.TabIndex = 12;
            this.btnRetour.Text = "Retour au menu";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Créer un compte";
            // 
            // gbxConnection
            // 
            this.gbxConnection.Controls.Add(this.label1);
            this.gbxConnection.Controls.Add(this.btnConnection);
            this.gbxConnection.Controls.Add(this.txtNomConnection);
            this.gbxConnection.Controls.Add(this.lblMotDePasse);
            this.gbxConnection.Controls.Add(this.txtMdpConnection);
            this.gbxConnection.Controls.Add(this.lblNomUtilisateur);
            this.gbxConnection.Location = new System.Drawing.Point(12, 12);
            this.gbxConnection.Name = "gbxConnection";
            this.gbxConnection.Size = new System.Drawing.Size(348, 273);
            this.gbxConnection.TabIndex = 14;
            this.gbxConnection.TabStop = false;
            this.gbxConnection.Text = "Connection";
            // 
            // gbxCreation
            // 
            this.gbxCreation.Controls.Add(this.btnCreer);
            this.gbxCreation.Controls.Add(this.txtNomCreer);
            this.gbxCreation.Controls.Add(this.label3);
            this.gbxCreation.Controls.Add(this.txtMdpCreer);
            this.gbxCreation.Controls.Add(this.label4);
            this.gbxCreation.Controls.Add(this.label2);
            this.gbxCreation.Location = new System.Drawing.Point(428, 12);
            this.gbxCreation.Name = "gbxCreation";
            this.gbxCreation.Size = new System.Drawing.Size(360, 273);
            this.gbxCreation.TabIndex = 15;
            this.gbxCreation.TabStop = false;
            this.gbxCreation.Text = "Créer un compte";
            // 
            // btnCreer
            // 
            this.btnCreer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreer.Location = new System.Drawing.Point(96, 179);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(146, 36);
            this.btnCreer.TabIndex = 14;
            this.btnCreer.Text = "Créer le compte";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // txtNomCreer
            // 
            this.txtNomCreer.Location = new System.Drawing.Point(83, 93);
            this.txtNomCreer.Name = "txtNomCreer";
            this.txtNomCreer.Size = new System.Drawing.Size(178, 20);
            this.txtNomCreer.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mot de passe";
            // 
            // txtMdpCreer
            // 
            this.txtMdpCreer.Location = new System.Drawing.Point(83, 141);
            this.txtMdpCreer.Name = "txtMdpCreer";
            this.txtMdpCreer.Size = new System.Drawing.Size(178, 20);
            this.txtMdpCreer.TabIndex = 16;
            this.txtMdpCreer.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nom d\'utilisateur";
            // 
            // gbxDeconenction
            // 
            this.gbxDeconenction.Controls.Add(this.lblDeconnection);
            this.gbxDeconenction.Controls.Add(this.btnDeconnection);
            this.gbxDeconenction.Location = new System.Drawing.Point(252, 291);
            this.gbxDeconenction.Name = "gbxDeconenction";
            this.gbxDeconenction.Size = new System.Drawing.Size(296, 147);
            this.gbxDeconenction.TabIndex = 16;
            this.gbxDeconenction.TabStop = false;
            this.gbxDeconenction.Text = "Déconnection";
            this.gbxDeconenction.Visible = false;
            // 
            // lblDeconnection
            // 
            this.lblDeconnection.AutoSize = true;
            this.lblDeconnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeconnection.ForeColor = System.Drawing.Color.Red;
            this.lblDeconnection.Location = new System.Drawing.Point(43, 32);
            this.lblDeconnection.Name = "lblDeconnection";
            this.lblDeconnection.Size = new System.Drawing.Size(214, 48);
            this.lblDeconnection.TabIndex = 9;
            this.lblDeconnection.Text = "Vous êtes présentement connecter\r\nVoulez-vous vous déconnecter?\r\n\r\n";
            // 
            // btnDeconnection
            // 
            this.btnDeconnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnection.Location = new System.Drawing.Point(66, 97);
            this.btnDeconnection.Name = "btnDeconnection";
            this.btnDeconnection.Size = new System.Drawing.Size(146, 36);
            this.btnDeconnection.TabIndex = 8;
            this.btnDeconnection.Text = "Déconnection";
            this.btnDeconnection.UseVisualStyleBackColor = true;
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxDeconenction);
            this.Controls.Add(this.gbxCreation);
            this.Controls.Add(this.gbxConnection);
            this.Controls.Add(this.btnRetour);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Connection";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection";
            this.Load += new System.EventHandler(this.Connection_Load);
            this.gbxConnection.ResumeLayout(false);
            this.gbxConnection.PerformLayout();
            this.gbxCreation.ResumeLayout(false);
            this.gbxCreation.PerformLayout();
            this.gbxDeconenction.ResumeLayout(false);
            this.gbxDeconenction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.TextBox txtNomConnection;
        private System.Windows.Forms.TextBox txtMdpConnection;
        private System.Windows.Forms.Label lblNomUtilisateur;
        private System.Windows.Forms.Label lblMotDePasse;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxConnection;
        private System.Windows.Forms.GroupBox gbxCreation;
        private System.Windows.Forms.GroupBox gbxDeconenction;
        private System.Windows.Forms.Button btnDeconnection;
        private System.Windows.Forms.Label lblDeconnection;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.TextBox txtNomCreer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMdpCreer;
        private System.Windows.Forms.Label label4;
    }
}