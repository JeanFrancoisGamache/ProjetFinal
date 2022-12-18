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
            this.bntActualiserChambre = new System.Windows.Forms.Button();
            this.lblNumeroChambre = new System.Windows.Forms.Label();
            this.txtNumeroChambre = new System.Windows.Forms.TextBox();
            this.rbtnPrix = new System.Windows.Forms.RadioButton();
            this.rbtnAZ = new System.Windows.Forms.RadioButton();
            this.btnTrier = new System.Windows.Forms.Button();
            this.btnChercher = new System.Windows.Forms.Button();
            this.btnReserver = new System.Windows.Forms.Button();
            this.lblTitre7 = new System.Windows.Forms.Label();
            this.listViewChambres = new System.Windows.Forms.ListView();
            this.columnChambre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNbLitAdulte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNbLitEnfant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrixParJour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnChambreVIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDisponibilite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLocataire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabActivites = new System.Windows.Forms.TabPage();
            this.btnAjouterr = new System.Windows.Forms.Button();
            this.btnAnnulerAct = new System.Windows.Forms.Button();
            this.listViewActivite = new System.Windows.Forms.ListView();
            this.columnNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSaleActivite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prix = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblHeureDispo = new System.Windows.Forms.Label();
            this.cmbHeures = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbActivite = new System.Windows.Forms.ComboBox();
            this.lbltitre4 = new System.Windows.Forms.Label();
            this.tabLocationClient = new System.Windows.Forms.TabPage();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.listViewChambreClient = new System.Windows.Forms.ListView();
            this.columnClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnChambreRéserver = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDateDébut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDateFin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrixTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnModifier = new System.Windows.Forms.Button();
            this.rbtnVosPrix = new System.Windows.Forms.RadioButton();
            this.rbtnVosAZ = new System.Windows.Forms.RadioButton();
            this.btnTrierVosLocation = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblTitre3 = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
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
            this.tabChambres.Controls.Add(this.bntActualiserChambre);
            this.tabChambres.Controls.Add(this.lblNumeroChambre);
            this.tabChambres.Controls.Add(this.txtNumeroChambre);
            this.tabChambres.Controls.Add(this.rbtnPrix);
            this.tabChambres.Controls.Add(this.rbtnAZ);
            this.tabChambres.Controls.Add(this.btnTrier);
            this.tabChambres.Controls.Add(this.btnChercher);
            this.tabChambres.Controls.Add(this.btnReserver);
            this.tabChambres.Controls.Add(this.lblTitre7);
            this.tabChambres.Controls.Add(this.listViewChambres);
            this.tabChambres.Location = new System.Drawing.Point(4, 22);
            this.tabChambres.Name = "tabChambres";
            this.tabChambres.Padding = new System.Windows.Forms.Padding(3);
            this.tabChambres.Size = new System.Drawing.Size(795, 428);
            this.tabChambres.TabIndex = 0;
            this.tabChambres.Text = "Affichage de toutes les chambres";
            this.tabChambres.UseVisualStyleBackColor = true;
            // 
            // bntActualiserChambre
            // 
            this.bntActualiserChambre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntActualiserChambre.Location = new System.Drawing.Point(239, 380);
            this.bntActualiserChambre.Name = "bntActualiserChambre";
            this.bntActualiserChambre.Size = new System.Drawing.Size(167, 36);
            this.bntActualiserChambre.TabIndex = 31;
            this.bntActualiserChambre.Text = "Actualiser";
            this.bntActualiserChambre.UseVisualStyleBackColor = true;
            this.bntActualiserChambre.Click += new System.EventHandler(this.bntActualiserChambre_Click);
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
            this.btnTrier.Click += new System.EventHandler(this.btnTrier_Click);
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
            this.btnChercher.Click += new System.EventHandler(this.btnChercher_Click);
            // 
            // btnReserver
            // 
            this.btnReserver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserver.Location = new System.Drawing.Point(55, 380);
            this.btnReserver.Name = "btnReserver";
            this.btnReserver.Size = new System.Drawing.Size(158, 36);
            this.btnReserver.TabIndex = 16;
            this.btnReserver.Text = "Reserver";
            this.btnReserver.UseVisualStyleBackColor = true;
            this.btnReserver.Click += new System.EventHandler(this.btnReserver_Click);
            // 
            // lblTitre7
            // 
            this.lblTitre7.AutoSize = true;
            this.lblTitre7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre7.Location = new System.Drawing.Point(209, 9);
            this.lblTitre7.Name = "lblTitre7";
            this.lblTitre7.Size = new System.Drawing.Size(368, 25);
            this.lblTitre7.TabIndex = 15;
            this.lblTitre7.Text = "Affichage des chambres de l\'hôtel";
            // 
            // listViewChambres
            // 
            this.listViewChambres.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnChambre,
            this.columnNbLitAdulte,
            this.columnNbLitEnfant,
            this.columnPrixParJour,
            this.columnChambreVIP,
            this.columnDisponibilite,
            this.columnLocataire});
            this.listViewChambres.FullRowSelect = true;
            this.listViewChambres.GridLines = true;
            this.listViewChambres.HideSelection = false;
            this.listViewChambres.Location = new System.Drawing.Point(52, 123);
            this.listViewChambres.Name = "listViewChambres";
            this.listViewChambres.Size = new System.Drawing.Size(694, 251);
            this.listViewChambres.TabIndex = 13;
            this.listViewChambres.UseCompatibleStateImageBehavior = false;
            this.listViewChambres.View = System.Windows.Forms.View.Details;
            // 
            // columnChambre
            // 
            this.columnChambre.Text = "Numéro de chambre";
            this.columnChambre.Width = 115;
            // 
            // columnNbLitAdulte
            // 
            this.columnNbLitAdulte.Text = "Nombre de lit adulte";
            this.columnNbLitAdulte.Width = 111;
            // 
            // columnNbLitEnfant
            // 
            this.columnNbLitEnfant.Text = "Nombre de lit enfant";
            this.columnNbLitEnfant.Width = 112;
            // 
            // columnPrixParJour
            // 
            this.columnPrixParJour.Text = "Prix par jour";
            this.columnPrixParJour.Width = 80;
            // 
            // columnChambreVIP
            // 
            this.columnChambreVIP.Text = "Chambre VIP";
            this.columnChambreVIP.Width = 86;
            // 
            // columnDisponibilite
            // 
            this.columnDisponibilite.Text = "Disponibilité";
            this.columnDisponibilite.Width = 73;
            // 
            // columnLocataire
            // 
            this.columnLocataire.Text = "Locataire";
            this.columnLocataire.Width = 77;
            // 
            // tabActivites
            // 
            this.tabActivites.Controls.Add(this.btnAjouterr);
            this.tabActivites.Controls.Add(this.btnAnnulerAct);
            this.tabActivites.Controls.Add(this.listViewActivite);
            this.tabActivites.Controls.Add(this.lblHeureDispo);
            this.tabActivites.Controls.Add(this.cmbHeures);
            this.tabActivites.Controls.Add(this.lblType);
            this.tabActivites.Controls.Add(this.cmbActivite);
            this.tabActivites.Controls.Add(this.lbltitre4);
            this.tabActivites.Location = new System.Drawing.Point(4, 22);
            this.tabActivites.Name = "tabActivites";
            this.tabActivites.Size = new System.Drawing.Size(795, 428);
            this.tabActivites.TabIndex = 2;
            this.tabActivites.Text = "Locations d\'activités";
            this.tabActivites.UseVisualStyleBackColor = true;
            // 
            // btnAjouterr
            // 
            this.btnAjouterr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterr.Location = new System.Drawing.Point(289, 112);
            this.btnAjouterr.Name = "btnAjouterr";
            this.btnAjouterr.Size = new System.Drawing.Size(167, 26);
            this.btnAjouterr.TabIndex = 33;
            this.btnAjouterr.Text = "Ajouter";
            this.btnAjouterr.UseVisualStyleBackColor = true;
            this.btnAjouterr.Click += new System.EventHandler(this.btnAjouterr_Click);
            // 
            // btnAnnulerAct
            // 
            this.btnAnnulerAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerAct.Location = new System.Drawing.Point(50, 384);
            this.btnAnnulerAct.Name = "btnAnnulerAct";
            this.btnAnnulerAct.Size = new System.Drawing.Size(158, 36);
            this.btnAnnulerAct.TabIndex = 31;
            this.btnAnnulerAct.Text = "Annuler la location";
            this.btnAnnulerAct.UseVisualStyleBackColor = true;
            this.btnAnnulerAct.Click += new System.EventHandler(this.btnAnnulerAct_Click);
            // 
            // listViewActivite
            // 
            this.listViewActivite.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNom,
            this.columnSaleActivite,
            this.Type,
            this.columnHeure,
            this.Prix});
            this.listViewActivite.FullRowSelect = true;
            this.listViewActivite.GridLines = true;
            this.listViewActivite.HideSelection = false;
            this.listViewActivite.Location = new System.Drawing.Point(50, 144);
            this.listViewActivite.Name = "listViewActivite";
            this.listViewActivite.Size = new System.Drawing.Size(681, 234);
            this.listViewActivite.TabIndex = 30;
            this.listViewActivite.UseCompatibleStateImageBehavior = false;
            this.listViewActivite.View = System.Windows.Forms.View.Details;
            // 
            // columnNom
            // 
            this.columnNom.Text = "Utilisateur";
            this.columnNom.Width = 113;
            // 
            // columnSaleActivite
            // 
            this.columnSaleActivite.Text = "Salle";
            this.columnSaleActivite.Width = 133;
            // 
            // Type
            // 
            this.Type.Text = "Type d\'activité";
            this.Type.Width = 157;
            // 
            // columnHeure
            // 
            this.columnHeure.Text = "Heure loué";
            this.columnHeure.Width = 148;
            // 
            // Prix
            // 
            this.Prix.Text = "Prix";
            this.Prix.Width = 146;
            // 
            // lblHeureDispo
            // 
            this.lblHeureDispo.AutoSize = true;
            this.lblHeureDispo.Location = new System.Drawing.Point(436, 66);
            this.lblHeureDispo.Name = "lblHeureDispo";
            this.lblHeureDispo.Size = new System.Drawing.Size(96, 13);
            this.lblHeureDispo.TabIndex = 16;
            this.lblHeureDispo.Text = "Heures disponibles";
            // 
            // cmbHeures
            // 
            this.cmbHeures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cmbActivite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActivite.FormattingEnabled = true;
            this.cmbActivite.Location = new System.Drawing.Point(99, 85);
            this.cmbActivite.Name = "cmbActivite";
            this.cmbActivite.Size = new System.Drawing.Size(205, 21);
            this.cmbActivite.TabIndex = 13;
            // 
            // lbltitre4
            // 
            this.lbltitre4.AutoSize = true;
            this.lbltitre4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitre4.Location = new System.Drawing.Point(211, 16);
            this.lbltitre4.Name = "lbltitre4";
            this.lbltitre4.Size = new System.Drawing.Size(338, 25);
            this.lbltitre4.TabIndex = 12;
            this.lbltitre4.Text = "Location d\'activités aujourd\'hui";
            // 
            // tabLocationClient
            // 
            this.tabLocationClient.Controls.Add(this.btnActualiser);
            this.tabLocationClient.Controls.Add(this.listViewChambreClient);
            this.tabLocationClient.Controls.Add(this.btnModifier);
            this.tabLocationClient.Controls.Add(this.rbtnVosPrix);
            this.tabLocationClient.Controls.Add(this.rbtnVosAZ);
            this.tabLocationClient.Controls.Add(this.btnTrierVosLocation);
            this.tabLocationClient.Controls.Add(this.btnAnnuler);
            this.tabLocationClient.Controls.Add(this.lblTitre3);
            this.tabLocationClient.Location = new System.Drawing.Point(4, 22);
            this.tabLocationClient.Name = "tabLocationClient";
            this.tabLocationClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabLocationClient.Size = new System.Drawing.Size(795, 428);
            this.tabLocationClient.TabIndex = 1;
            this.tabLocationClient.Text = "Vos locations";
            this.tabLocationClient.UseVisualStyleBackColor = true;
            // 
            // btnActualiser
            // 
            this.btnActualiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualiser.Location = new System.Drawing.Point(408, 383);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(167, 36);
            this.btnActualiser.TabIndex = 30;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = true;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // listViewChambreClient
            // 
            this.listViewChambreClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnClient,
            this.columnChambreRéserver,
            this.columnDateDébut,
            this.columnDateFin,
            this.columnPrixTotal});
            this.listViewChambreClient.FullRowSelect = true;
            this.listViewChambreClient.GridLines = true;
            this.listViewChambreClient.HideSelection = false;
            this.listViewChambreClient.Location = new System.Drawing.Point(50, 110);
            this.listViewChambreClient.Name = "listViewChambreClient";
            this.listViewChambreClient.Size = new System.Drawing.Size(694, 251);
            this.listViewChambreClient.TabIndex = 29;
            this.listViewChambreClient.UseCompatibleStateImageBehavior = false;
            this.listViewChambreClient.View = System.Windows.Forms.View.Details;
            // 
            // columnClient
            // 
            this.columnClient.Text = "Client";
            this.columnClient.Width = 115;
            // 
            // columnChambreRéserver
            // 
            this.columnChambreRéserver.Text = "Chambre réserver";
            this.columnChambreRéserver.Width = 143;
            // 
            // columnDateDébut
            // 
            this.columnDateDébut.Text = "Date réservation";
            this.columnDateDébut.Width = 153;
            // 
            // columnDateFin
            // 
            this.columnDateFin.Text = "Date du retour";
            this.columnDateFin.Width = 168;
            // 
            // columnPrixTotal
            // 
            this.columnPrixTotal.Text = "Prix total";
            this.columnPrixTotal.Width = 181;
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
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
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
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // lblTitre3
            // 
            this.lblTitre3.AutoSize = true;
            this.lblTitre3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre3.Location = new System.Drawing.Point(299, 10);
            this.lblTitre3.Name = "lblTitre3";
            this.lblTitre3.Size = new System.Drawing.Size(154, 25);
            this.lblTitre3.TabIndex = 23;
            this.lblTitre3.Text = "Vos locations";
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
            this.Load += new System.EventHandler(this.GestionLocations_Load);
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
        private System.Windows.Forms.Button btnReserver;
        private System.Windows.Forms.Label lblTitre7;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.ListView listViewChambres;
        private System.Windows.Forms.TabPage tabLocationClient;
        private System.Windows.Forms.RadioButton rbtnVosPrix;
        private System.Windows.Forms.RadioButton rbtnVosAZ;
        private System.Windows.Forms.Button btnTrierVosLocation;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label lblTitre3;
        private System.Windows.Forms.TabPage tabActivites;
        private System.Windows.Forms.Label lblHeureDispo;
        private System.Windows.Forms.ComboBox cmbHeures;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbActivite;
        private System.Windows.Forms.Label lbltitre4;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.ColumnHeader columnChambre;
        private System.Windows.Forms.ColumnHeader columnNbLitAdulte;
        private System.Windows.Forms.ColumnHeader columnNbLitEnfant;
        private System.Windows.Forms.ColumnHeader columnPrixParJour;
        private System.Windows.Forms.ColumnHeader columnChambreVIP;
        private System.Windows.Forms.ColumnHeader columnDisponibilite;
        private System.Windows.Forms.ColumnHeader columnLocataire;
        private System.Windows.Forms.ListView listViewChambreClient;
        private System.Windows.Forms.ColumnHeader columnClient;
        private System.Windows.Forms.ColumnHeader columnChambreRéserver;
        private System.Windows.Forms.ColumnHeader columnDateDébut;
        private System.Windows.Forms.ColumnHeader columnDateFin;
        private System.Windows.Forms.ColumnHeader columnPrixTotal;
        private System.Windows.Forms.ListView listViewActivite;
        private System.Windows.Forms.ColumnHeader columnSaleActivite;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader columnHeure;
        private System.Windows.Forms.ColumnHeader Prix;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.Button bntActualiserChambre;
        private System.Windows.Forms.Button btnAnnulerAct;
        private System.Windows.Forms.Button btnAjouterr;
        private System.Windows.Forms.ColumnHeader columnNom;
    }
}