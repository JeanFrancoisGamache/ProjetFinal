namespace ProjetFinal.Forms
{
    partial class GestionLocations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionLocations));
            this.tabCtrlLocations = new System.Windows.Forms.TabControl();
            this.tabChambres = new System.Windows.Forms.TabPage();
            this.lblNumeroChambre = new System.Windows.Forms.Label();
            this.txtNumeroChambre = new System.Windows.Forms.TextBox();
            this.rbtnPrix = new System.Windows.Forms.RadioButton();
            this.rbtnAZ = new System.Windows.Forms.RadioButton();
            this.btnTrier = new System.Windows.Forms.Button();
            this.btnChercher = new System.Windows.Forms.Button();
            this.btnLouer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewChambres = new System.Windows.Forms.ListView();
            this.tabActivites = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbHeures = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbActivite = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabLocationClient = new System.Windows.Forms.TabPage();
            this.rbtnVosPrix = new System.Windows.Forms.RadioButton();
            this.rbtnVosAZ = new System.Windows.Forms.RadioButton();
            this.btnTrierVosLocation = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.tabCtrlLocations.SuspendLayout();
            this.tabChambres.SuspendLayout();
            this.tabActivites.SuspendLayout();
            this.tabLocationClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrlLocations
            // 
            this.tabCtrlLocations.Controls.Add(this.tabChambres);
            this.tabCtrlLocations.Controls.Add(this.tabActivites);
            this.tabCtrlLocations.Controls.Add(this.tabLocationClient);
            this.tabCtrlLocations.Location = new System.Drawing.Point(0, 1);
            this.tabCtrlLocations.Name = "tabCtrlLocations";
            this.tabCtrlLocations.SelectedIndex = 0;
            this.tabCtrlLocations.Size = new System.Drawing.Size(803, 454);
            this.tabCtrlLocations.TabIndex = 0;
            // 
            // tabChambres
            // 
            this.tabChambres.Controls.Add(this.lblNumeroChambre);
            this.tabChambres.Controls.Add(this.txtNumeroChambre);
            this.tabChambres.Controls.Add(this.rbtnPrix);
            this.tabChambres.Controls.Add(this.rbtnAZ);
            this.tabChambres.Controls.Add(this.btnTrier);
            this.tabChambres.Controls.Add(this.btnChercher);
            this.tabChambres.Controls.Add(this.btnLouer);
            this.tabChambres.Controls.Add(this.label1);
            this.tabChambres.Controls.Add(this.listViewChambres);
            this.tabChambres.Location = new System.Drawing.Point(4, 22);
            this.tabChambres.Name = "tabChambres";
            this.tabChambres.Padding = new System.Windows.Forms.Padding(3);
            this.tabChambres.Size = new System.Drawing.Size(795, 428);
            this.tabChambres.TabIndex = 0;
            this.tabChambres.Text = "Affichage de toutes les chambres";
            this.tabChambres.UseVisualStyleBackColor = true;
            // 
            // lblNumeroChambre
            // 
            this.lblNumeroChambre.AutoSize = true;
            this.lblNumeroChambre.Location = new System.Drawing.Point(52, 54);
            this.lblNumeroChambre.Name = "lblNumeroChambre";
            this.lblNumeroChambre.Size = new System.Drawing.Size(103, 13);
            this.lblNumeroChambre.TabIndex = 22;
            this.lblNumeroChambre.Text = "Numéro de chambre";
            // 
            // txtNumeroChambre
            // 
            this.txtNumeroChambre.Location = new System.Drawing.Point(52, 73);
            this.txtNumeroChambre.Name = "txtNumeroChambre";
            this.txtNumeroChambre.Size = new System.Drawing.Size(145, 20);
            this.txtNumeroChambre.TabIndex = 21;
            // 
            // rbtnPrix
            // 
            this.rbtnPrix.AutoSize = true;
            this.rbtnPrix.Location = new System.Drawing.Point(496, 86);
            this.rbtnPrix.Name = "rbtnPrix";
            this.rbtnPrix.Size = new System.Drawing.Size(61, 17);
            this.rbtnPrix.TabIndex = 20;
            this.rbtnPrix.Text = "Par Prix";
            this.rbtnPrix.UseVisualStyleBackColor = true;
            // 
            // rbtnAZ
            // 
            this.rbtnAZ.AutoSize = true;
            this.rbtnAZ.Checked = true;
            this.rbtnAZ.Location = new System.Drawing.Point(496, 63);
            this.rbtnAZ.Name = "rbtnAZ";
            this.rbtnAZ.Size = new System.Drawing.Size(51, 17);
            this.rbtnAZ.TabIndex = 19;
            this.rbtnAZ.TabStop = true;
            this.rbtnAZ.Text = "A à Z";
            this.rbtnAZ.UseVisualStyleBackColor = true;
            // 
            // btnTrier
            // 
            this.btnTrier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrier.Location = new System.Drawing.Point(571, 63);
            this.btnTrier.Name = "btnTrier";
            this.btnTrier.Size = new System.Drawing.Size(167, 36);
            this.btnTrier.TabIndex = 18;
            this.btnTrier.Text = "Trier";
            this.btnTrier.UseVisualStyleBackColor = true;
            // 
            // btnChercher
            // 
            this.btnChercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChercher.Location = new System.Drawing.Point(214, 63);
            this.btnChercher.Name = "btnChercher";
            this.btnChercher.Size = new System.Drawing.Size(158, 36);
            this.btnChercher.TabIndex = 17;
            this.btnChercher.Text = "Chercher";
            this.btnChercher.UseVisualStyleBackColor = true;
            // 
            // btnLouer
            // 
            this.btnLouer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLouer.Location = new System.Drawing.Point(55, 380);
            this.btnLouer.Name = "btnLouer";
            this.btnLouer.Size = new System.Drawing.Size(158, 36);
            this.btnLouer.TabIndex = 16;
            this.btnLouer.Text = "Louer";
            this.btnLouer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Affichage des chambres de l\'hôtel";
            // 
            // listViewChambres
            // 
            this.listViewChambres.FullRowSelect = true;
            this.listViewChambres.GridLines = true;
            this.listViewChambres.HideSelection = false;
            this.listViewChambres.Location = new System.Drawing.Point(52, 123);
            this.listViewChambres.Name = "listViewChambres";
            this.listViewChambres.Size = new System.Drawing.Size(694, 251);
            this.listViewChambres.TabIndex = 13;
            this.listViewChambres.UseCompatibleStateImageBehavior = false;
            // 
            // tabActivites
            // 
            this.tabActivites.Controls.Add(this.label3);
            this.tabActivites.Controls.Add(this.cmbHeures);
            this.tabActivites.Controls.Add(this.lblType);
            this.tabActivites.Controls.Add(this.cmbActivite);
            this.tabActivites.Controls.Add(this.label4);
            this.tabActivites.Location = new System.Drawing.Point(4, 22);
            this.tabActivites.Name = "tabActivites";
            this.tabActivites.Size = new System.Drawing.Size(795, 428);
            this.tabActivites.TabIndex = 2;
            this.tabActivites.Text = "Locations d\'activités";
            this.tabActivites.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Heures disponibles";
            // 
            // cmbHeures
            // 
            this.cmbHeures.FormattingEnabled = true;
            this.cmbHeures.Location = new System.Drawing.Point(436, 85);
            this.cmbHeures.Name = "cmbHeures";
            this.cmbHeures.Size = new System.Drawing.Size(205, 21);
            this.cmbHeures.TabIndex = 15;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(99, 66);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(87, 13);
            this.lblType.TabIndex = 14;
            this.lblType.Text = "Type de l\'activité";
            // 
            // cmbActivite
            // 
            this.cmbActivite.FormattingEnabled = true;
            this.cmbActivite.Location = new System.Drawing.Point(99, 85);
            this.cmbActivite.Name = "cmbActivite";
            this.cmbActivite.Size = new System.Drawing.Size(205, 21);
            this.cmbActivite.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(262, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Location d\'activités";
            // 
            // tabLocationClient
            // 
            this.tabLocationClient.Controls.Add(this.btnModifier);
            this.tabLocationClient.Controls.Add(this.rbtnVosPrix);
            this.tabLocationClient.Controls.Add(this.rbtnVosAZ);
            this.tabLocationClient.Controls.Add(this.btnTrierVosLocation);
            this.tabLocationClient.Controls.Add(this.btnAnnuler);
            this.tabLocationClient.Controls.Add(this.label2);
            this.tabLocationClient.Controls.Add(this.listView2);
            this.tabLocationClient.Location = new System.Drawing.Point(4, 22);
            this.tabLocationClient.Name = "tabLocationClient";
            this.tabLocationClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabLocationClient.Size = new System.Drawing.Size(795, 428);
            this.tabLocationClient.TabIndex = 1;
            this.tabLocationClient.Text = "Vos locations";
            this.tabLocationClient.UseVisualStyleBackColor = true;
            // 
            // rbtnVosPrix
            // 
            this.rbtnVosPrix.AutoSize = true;
            this.rbtnVosPrix.Location = new System.Drawing.Point(266, 87);
            this.rbtnVosPrix.Name = "rbtnVosPrix";
            this.rbtnVosPrix.Size = new System.Drawing.Size(61, 17);
            this.rbtnVosPrix.TabIndex = 27;
            this.rbtnVosPrix.Text = "Par Prix";
            this.rbtnVosPrix.UseVisualStyleBackColor = true;
            // 
            // rbtnVosAZ
            // 
            this.rbtnVosAZ.AutoSize = true;
            this.rbtnVosAZ.Checked = true;
            this.rbtnVosAZ.Location = new System.Drawing.Point(266, 64);
            this.rbtnVosAZ.Name = "rbtnVosAZ";
            this.rbtnVosAZ.Size = new System.Drawing.Size(51, 17);
            this.rbtnVosAZ.TabIndex = 26;
            this.rbtnVosAZ.TabStop = true;
            this.rbtnVosAZ.Text = "A à Z";
            this.rbtnVosAZ.UseVisualStyleBackColor = true;
            // 
            // btnTrierVosLocation
            // 
            this.btnTrierVosLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrierVosLocation.Location = new System.Drawing.Point(341, 64);
            this.btnTrierVosLocation.Name = "btnTrierVosLocation";
            this.btnTrierVosLocation.Size = new System.Drawing.Size(167, 36);
            this.btnTrierVosLocation.TabIndex = 25;
            this.btnTrierVosLocation.Text = "Trier";
            this.btnTrierVosLocation.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(50, 383);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(158, 36);
            this.btnAnnuler.TabIndex = 24;
            this.btnAnnuler.Text = "Annuler la location";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Vos locations";
            // 
            // listView2
            // 
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(50, 110);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(694, 251);
            this.listView2.TabIndex = 21;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // btnRetour
            // 
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.Location = new System.Drawing.Point(630, 463);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(158, 36);
            this.btnRetour.TabIndex = 14;
            this.btnRetour.Text = "Retour au menu";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click_1);
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(229, 383);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(158, 36);
            this.btnModifier.TabIndex = 28;
            this.btnModifier.Text = "Modifier la location";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // GestionLocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.tabCtrlLocations);
            this.Controls.Add(this.btnRetour);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestionLocations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des locations";
            this.tabCtrlLocations.ResumeLayout(false);
            this.tabChambres.ResumeLayout(false);
            this.tabChambres.PerformLayout();
            this.tabActivites.ResumeLayout(false);
            this.tabActivites.PerformLayout();
            this.tabLocationClient.ResumeLayout(false);
            this.tabLocationClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrlLocations;
        private System.Windows.Forms.TabPage tabChambres;
        private System.Windows.Forms.Label lblNumeroChambre;
        private System.Windows.Forms.TextBox txtNumeroChambre;
        private System.Windows.Forms.RadioButton rbtnPrix;
        private System.Windows.Forms.RadioButton rbtnAZ;
        private System.Windows.Forms.Button btnTrier;
        private System.Windows.Forms.Button btnChercher;
        private System.Windows.Forms.Button btnLouer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.ListView listViewChambres;
        private System.Windows.Forms.TabPage tabLocationClient;
        private System.Windows.Forms.RadioButton rbtnVosPrix;
        private System.Windows.Forms.RadioButton rbtnVosAZ;
        private System.Windows.Forms.Button btnTrierVosLocation;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.TabPage tabActivites;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbHeures;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbActivite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnModifier;
    }
}