namespace ProjetFinal.Forms
{
    partial class Reservation
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblNumeroChambre = new System.Windows.Forms.Label();
            this.txtNumeroChambre = new System.Windows.Forms.TextBox();
            this.dateTimeDebut = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeRetour = new System.Windows.Forms.DateTimePicker();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(260, 20);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(240, 25);
            this.lblTitre.TabIndex = 24;
            this.lblTitre.Text = "Modifier une chambre";
            // 
            // lblNumeroChambre
            // 
            this.lblNumeroChambre.AutoSize = true;
            this.lblNumeroChambre.Location = new System.Drawing.Point(278, 86);
            this.lblNumeroChambre.Name = "lblNumeroChambre";
            this.lblNumeroChambre.Size = new System.Drawing.Size(103, 13);
            this.lblNumeroChambre.TabIndex = 26;
            this.lblNumeroChambre.Text = "Numéro de chambre";
            // 
            // txtNumeroChambre
            // 
            this.txtNumeroChambre.Enabled = false;
            this.txtNumeroChambre.Location = new System.Drawing.Point(278, 105);
            this.txtNumeroChambre.Name = "txtNumeroChambre";
            this.txtNumeroChambre.Size = new System.Drawing.Size(200, 20);
            this.txtNumeroChambre.TabIndex = 25;
            // 
            // dateTimeDebut
            // 
            this.dateTimeDebut.Location = new System.Drawing.Point(278, 145);
            this.dateTimeDebut.MinDate = new System.DateTime(2022, 12, 17, 0, 0, 0, 0);
            this.dateTimeDebut.Name = "dateTimeDebut";
            this.dateTimeDebut.Size = new System.Drawing.Size(200, 20);
            this.dateTimeDebut.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Date de la réservation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Date de retour";
            // 
            // dateTimeRetour
            // 
            this.dateTimeRetour.Location = new System.Drawing.Point(278, 188);
            this.dateTimeRetour.Name = "dateTimeRetour";
            this.dateTimeRetour.Size = new System.Drawing.Size(200, 20);
            this.dateTimeRetour.TabIndex = 29;
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmer.Location = new System.Drawing.Point(296, 223);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(158, 36);
            this.btnConfirmer.TabIndex = 34;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(630, 393);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(158, 36);
            this.btnAnnuler.TabIndex = 35;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimeRetour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeDebut);
            this.Controls.Add(this.lblNumeroChambre);
            this.Controls.Add(this.txtNumeroChambre);
            this.Controls.Add(this.lblTitre);
            this.Name = "Reservation";
            this.Text = "Modifier";
            this.Load += new System.EventHandler(this.Reservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblNumeroChambre;
        private System.Windows.Forms.TextBox txtNumeroChambre;
        private System.Windows.Forms.DateTimePicker dateTimeDebut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeRetour;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Button btnAnnuler;
    }
}