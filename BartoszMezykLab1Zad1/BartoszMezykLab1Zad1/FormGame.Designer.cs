namespace BartoszMezykLab1Zad1
{
    partial class FormGame
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
            this.components = new System.ComponentModel.Container();
            this.labelHotelRest = new System.Windows.Forms.Label();
            this.labelCampsiteRest = new System.Windows.Forms.Label();
            this.progressBarAccountingOfficeLevel = new System.Windows.Forms.ProgressBar();
            this.progressBarRestaurantLevel = new System.Windows.Forms.ProgressBar();
            this.labelAccountingOfficeLevel = new System.Windows.Forms.Label();
            this.labelRestaurantLevel = new System.Windows.Forms.Label();
            this.labelEquipementAmount = new System.Windows.Forms.Label();
            this.labelHireAccountingOffice = new System.Windows.Forms.Label();
            this.labelExtendRestaurant = new System.Windows.Forms.Label();
            this.labelMakeOffer = new System.Windows.Forms.Label();
            this.labelRepairEquipement = new System.Windows.Forms.Label();
            this.labelBuyEquipement = new System.Windows.Forms.Label();
            this.labelOwnerFatigue = new System.Windows.Forms.Label();
            this.labelEquipementExhaustion = new System.Windows.Forms.Label();
            this.labelClientsGladness = new System.Windows.Forms.Label();
            this.labelRestaurantPopularity = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.labelDays = new System.Windows.Forms.Label();
            this.pictureBoxRestHotel = new System.Windows.Forms.PictureBox();
            this.pictureBoxRestCampsite = new System.Windows.Forms.PictureBox();
            this.pictureBoxHireAccountingOffice = new System.Windows.Forms.PictureBox();
            this.pictureBoxExtendRestaurant = new System.Windows.Forms.PictureBox();
            this.pictureBoxMakeOffer = new System.Windows.Forms.PictureBox();
            this.pictureBoxRepairEquipement = new System.Windows.Forms.PictureBox();
            this.pictureBoxBuyEquipement = new System.Windows.Forms.PictureBox();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestHotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestCampsite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHireAccountingOffice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExtendRestaurant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMakeOffer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRepairEquipement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuyEquipement)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHotelRest
            // 
            this.labelHotelRest.AutoSize = true;
            this.labelHotelRest.Location = new System.Drawing.Point(264, 412);
            this.labelHotelRest.Name = "labelHotelRest";
            this.labelHotelRest.Size = new System.Drawing.Size(187, 17);
            this.labelHotelRest.TabIndex = 61;
            this.labelHotelRest.Text = "Odpocznij w hotelu (1000 zł)";
            // 
            // labelCampsiteRest
            // 
            this.labelCampsiteRest.AutoSize = true;
            this.labelCampsiteRest.Location = new System.Drawing.Point(25, 412);
            this.labelCampsiteRest.Name = "labelCampsiteRest";
            this.labelCampsiteRest.Size = new System.Drawing.Size(208, 17);
            this.labelCampsiteRest.TabIndex = 60;
            this.labelCampsiteRest.Text = "Odpocznij na kempingu (200 zł)";
            // 
            // progressBarAccountingOfficeLevel
            // 
            this.progressBarAccountingOfficeLevel.Location = new System.Drawing.Point(1052, 396);
            this.progressBarAccountingOfficeLevel.Name = "progressBarAccountingOfficeLevel";
            this.progressBarAccountingOfficeLevel.Size = new System.Drawing.Size(200, 33);
            this.progressBarAccountingOfficeLevel.TabIndex = 52;
            // 
            // progressBarRestaurantLevel
            // 
            this.progressBarRestaurantLevel.Location = new System.Drawing.Point(772, 396);
            this.progressBarRestaurantLevel.Name = "progressBarRestaurantLevel";
            this.progressBarRestaurantLevel.Size = new System.Drawing.Size(200, 33);
            this.progressBarRestaurantLevel.TabIndex = 51;
            // 
            // labelAccountingOfficeLevel
            // 
            this.labelAccountingOfficeLevel.AutoSize = true;
            this.labelAccountingOfficeLevel.Location = new System.Drawing.Point(1049, 366);
            this.labelAccountingOfficeLevel.Name = "labelAccountingOfficeLevel";
            this.labelAccountingOfficeLevel.Size = new System.Drawing.Size(214, 17);
            this.labelAccountingOfficeLevel.TabIndex = 50;
            this.labelAccountingOfficeLevel.Text = "Poziom biura rachunkowego: 0/3";
            // 
            // labelRestaurantLevel
            // 
            this.labelRestaurantLevel.AutoSize = true;
            this.labelRestaurantLevel.Location = new System.Drawing.Point(769, 366);
            this.labelRestaurantLevel.Name = "labelRestaurantLevel";
            this.labelRestaurantLevel.Size = new System.Drawing.Size(252, 17);
            this.labelRestaurantLevel.TabIndex = 49;
            this.labelRestaurantLevel.Text = "Poziom rozbudowania restauracji: 0/10";
            // 
            // labelEquipementAmount
            // 
            this.labelEquipementAmount.AutoSize = true;
            this.labelEquipementAmount.Location = new System.Drawing.Point(25, 366);
            this.labelEquipementAmount.Name = "labelEquipementAmount";
            this.labelEquipementAmount.Size = new System.Drawing.Size(147, 17);
            this.labelEquipementAmount.TabIndex = 48;
            this.labelEquipementAmount.Text = "Ilość sprzętu i mebli: 0";
            // 
            // labelHireAccountingOffice
            // 
            this.labelHireAccountingOffice.AutoSize = true;
            this.labelHireAccountingOffice.Location = new System.Drawing.Point(1030, 106);
            this.labelHireAccountingOffice.Name = "labelHireAccountingOffice";
            this.labelHireAccountingOffice.Size = new System.Drawing.Size(285, 17);
            this.labelHireAccountingOffice.TabIndex = 47;
            this.labelHireAccountingOffice.Text = "Wynajmij lepsze biuro rachunkowe (6500 zł)";
            // 
            // labelExtendRestaurant
            // 
            this.labelExtendRestaurant.AutoSize = true;
            this.labelExtendRestaurant.Location = new System.Drawing.Point(769, 106);
            this.labelExtendRestaurant.Name = "labelExtendRestaurant";
            this.labelExtendRestaurant.Size = new System.Drawing.Size(211, 17);
            this.labelExtendRestaurant.TabIndex = 46;
            this.labelExtendRestaurant.Text = "Rozbuduj restaurację (30000 zł)";
            // 
            // labelMakeOffer
            // 
            this.labelMakeOffer.AutoSize = true;
            this.labelMakeOffer.Location = new System.Drawing.Point(528, 106);
            this.labelMakeOffer.Name = "labelMakeOffer";
            this.labelMakeOffer.Size = new System.Drawing.Size(189, 17);
            this.labelMakeOffer.TabIndex = 45;
            this.labelMakeOffer.Text = "Zorganizuj promocję (100 zł)";
            // 
            // labelRepairEquipement
            // 
            this.labelRepairEquipement.AutoSize = true;
            this.labelRepairEquipement.Location = new System.Drawing.Point(264, 106);
            this.labelRepairEquipement.Name = "labelRepairEquipement";
            this.labelRepairEquipement.Size = new System.Drawing.Size(216, 17);
            this.labelRepairEquipement.TabIndex = 44;
            this.labelRepairEquipement.Text = "Napraw sprzęt lub meble (200 zł)";
            // 
            // labelBuyEquipement
            // 
            this.labelBuyEquipement.AutoSize = true;
            this.labelBuyEquipement.Location = new System.Drawing.Point(25, 106);
            this.labelBuyEquipement.Name = "labelBuyEquipement";
            this.labelBuyEquipement.Size = new System.Drawing.Size(193, 17);
            this.labelBuyEquipement.TabIndex = 43;
            this.labelBuyEquipement.Text = "Kup sprzęt lub meble (200 zł)";
            // 
            // labelOwnerFatigue
            // 
            this.labelOwnerFatigue.AutoSize = true;
            this.labelOwnerFatigue.Location = new System.Drawing.Point(932, 24);
            this.labelOwnerFatigue.Name = "labelOwnerFatigue";
            this.labelOwnerFatigue.Size = new System.Drawing.Size(175, 17);
            this.labelOwnerFatigue.TabIndex = 42;
            this.labelOwnerFatigue.Text = "Zmęczenie właściciela: 0%";
            // 
            // labelEquipementExhaustion
            // 
            this.labelEquipementExhaustion.AutoSize = true;
            this.labelEquipementExhaustion.Location = new System.Drawing.Point(739, 24);
            this.labelEquipementExhaustion.Name = "labelEquipementExhaustion";
            this.labelEquipementExhaustion.Size = new System.Drawing.Size(180, 17);
            this.labelEquipementExhaustion.TabIndex = 41;
            this.labelEquipementExhaustion.Text = "Zużycie sprzętu i mebli: 0%";
            // 
            // labelClientsGladness
            // 
            this.labelClientsGladness.AutoSize = true;
            this.labelClientsGladness.Location = new System.Drawing.Point(547, 24);
            this.labelClientsGladness.Name = "labelClientsGladness";
            this.labelClientsGladness.Size = new System.Drawing.Size(170, 17);
            this.labelClientsGladness.TabIndex = 40;
            this.labelClientsGladness.Text = "Zadowolenie klientów: 0%";
            // 
            // labelRestaurantPopularity
            // 
            this.labelRestaurantPopularity.AutoSize = true;
            this.labelRestaurantPopularity.Location = new System.Drawing.Point(333, 24);
            this.labelRestaurantPopularity.Name = "labelRestaurantPopularity";
            this.labelRestaurantPopularity.Size = new System.Drawing.Size(185, 17);
            this.labelRestaurantPopularity.TabIndex = 39;
            this.labelRestaurantPopularity.Text = "Popularność restauracji: 0%";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Location = new System.Drawing.Point(189, 24);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(100, 17);
            this.labelMoney.TabIndex = 38;
            this.labelMoney.Text = "Pieniądze: 0 zł";
            // 
            // labelDays
            // 
            this.labelDays.AutoSize = true;
            this.labelDays.Location = new System.Drawing.Point(35, 24);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(60, 17);
            this.labelDays.TabIndex = 37;
            this.labelDays.Text = "Dzień: 0";
            // 
            // pictureBoxRestHotel
            // 
            this.pictureBoxRestHotel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRestHotel.Image = global::BartoszMezykLab1Zad1.Properties.Resources.hotel;
            this.pictureBoxRestHotel.Location = new System.Drawing.Point(267, 438);
            this.pictureBoxRestHotel.Name = "pictureBoxRestHotel";
            this.pictureBoxRestHotel.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxRestHotel.TabIndex = 59;
            this.pictureBoxRestHotel.TabStop = false;
            this.pictureBoxRestHotel.Click += new System.EventHandler(this.pictureBoxRestHotel_Click);
            // 
            // pictureBoxRestCampsite
            // 
            this.pictureBoxRestCampsite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRestCampsite.Image = global::BartoszMezykLab1Zad1.Properties.Resources.campsite;
            this.pictureBoxRestCampsite.Location = new System.Drawing.Point(28, 438);
            this.pictureBoxRestCampsite.Name = "pictureBoxRestCampsite";
            this.pictureBoxRestCampsite.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxRestCampsite.TabIndex = 58;
            this.pictureBoxRestCampsite.TabStop = false;
            this.pictureBoxRestCampsite.Click += new System.EventHandler(this.pictureBoxRestCampsite_Click);
            // 
            // pictureBoxHireAccountingOffice
            // 
            this.pictureBoxHireAccountingOffice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxHireAccountingOffice.Image = global::BartoszMezykLab1Zad1.Properties.Resources.taxes;
            this.pictureBoxHireAccountingOffice.Location = new System.Drawing.Point(1033, 146);
            this.pictureBoxHireAccountingOffice.Name = "pictureBoxHireAccountingOffice";
            this.pictureBoxHireAccountingOffice.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxHireAccountingOffice.TabIndex = 57;
            this.pictureBoxHireAccountingOffice.TabStop = false;
            this.pictureBoxHireAccountingOffice.Click += new System.EventHandler(this.pictureBoxHireAccountingOffice_Click);
            // 
            // pictureBoxExtendRestaurant
            // 
            this.pictureBoxExtendRestaurant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExtendRestaurant.Image = global::BartoszMezykLab1Zad1.Properties.Resources.level_up;
            this.pictureBoxExtendRestaurant.Location = new System.Drawing.Point(772, 146);
            this.pictureBoxExtendRestaurant.Name = "pictureBoxExtendRestaurant";
            this.pictureBoxExtendRestaurant.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxExtendRestaurant.TabIndex = 56;
            this.pictureBoxExtendRestaurant.TabStop = false;
            this.pictureBoxExtendRestaurant.Click += new System.EventHandler(this.pictureBoxExtendRestaurant_Click);
            // 
            // pictureBoxMakeOffer
            // 
            this.pictureBoxMakeOffer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMakeOffer.Image = global::BartoszMezykLab1Zad1.Properties.Resources.offer;
            this.pictureBoxMakeOffer.Location = new System.Drawing.Point(531, 146);
            this.pictureBoxMakeOffer.Name = "pictureBoxMakeOffer";
            this.pictureBoxMakeOffer.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxMakeOffer.TabIndex = 55;
            this.pictureBoxMakeOffer.TabStop = false;
            this.pictureBoxMakeOffer.Click += new System.EventHandler(this.pictureBoxMakeOffer_Click);
            // 
            // pictureBoxRepairEquipement
            // 
            this.pictureBoxRepairEquipement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRepairEquipement.Image = global::BartoszMezykLab1Zad1.Properties.Resources.repair;
            this.pictureBoxRepairEquipement.Location = new System.Drawing.Point(267, 146);
            this.pictureBoxRepairEquipement.Name = "pictureBoxRepairEquipement";
            this.pictureBoxRepairEquipement.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxRepairEquipement.TabIndex = 54;
            this.pictureBoxRepairEquipement.TabStop = false;
            this.pictureBoxRepairEquipement.Click += new System.EventHandler(this.pictureBoxRepairEquipement_Click);
            // 
            // pictureBoxBuyEquipement
            // 
            this.pictureBoxBuyEquipement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxBuyEquipement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBuyEquipement.Image = global::BartoszMezykLab1Zad1.Properties.Resources.buying;
            this.pictureBoxBuyEquipement.Location = new System.Drawing.Point(28, 146);
            this.pictureBoxBuyEquipement.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxBuyEquipement.Name = "pictureBoxBuyEquipement";
            this.pictureBoxBuyEquipement.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxBuyEquipement.TabIndex = 53;
            this.pictureBoxBuyEquipement.TabStop = false;
            this.pictureBoxBuyEquipement.Click += new System.EventHandler(this.pictureBoxBuyEquipement_Click);
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 670);
            this.Controls.Add(this.labelHotelRest);
            this.Controls.Add(this.labelCampsiteRest);
            this.Controls.Add(this.pictureBoxRestHotel);
            this.Controls.Add(this.pictureBoxRestCampsite);
            this.Controls.Add(this.pictureBoxHireAccountingOffice);
            this.Controls.Add(this.pictureBoxExtendRestaurant);
            this.Controls.Add(this.pictureBoxMakeOffer);
            this.Controls.Add(this.pictureBoxRepairEquipement);
            this.Controls.Add(this.pictureBoxBuyEquipement);
            this.Controls.Add(this.progressBarAccountingOfficeLevel);
            this.Controls.Add(this.progressBarRestaurantLevel);
            this.Controls.Add(this.labelAccountingOfficeLevel);
            this.Controls.Add(this.labelRestaurantLevel);
            this.Controls.Add(this.labelEquipementAmount);
            this.Controls.Add(this.labelHireAccountingOffice);
            this.Controls.Add(this.labelExtendRestaurant);
            this.Controls.Add(this.labelMakeOffer);
            this.Controls.Add(this.labelRepairEquipement);
            this.Controls.Add(this.labelBuyEquipement);
            this.Controls.Add(this.labelOwnerFatigue);
            this.Controls.Add(this.labelEquipementExhaustion);
            this.Controls.Add(this.labelClientsGladness);
            this.Controls.Add(this.labelRestaurantPopularity);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.labelDays);
            this.Name = "FormGame";
            this.Text = "Swojska chata";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestHotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestCampsite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHireAccountingOffice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExtendRestaurant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMakeOffer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRepairEquipement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuyEquipement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHotelRest;
        private System.Windows.Forms.Label labelCampsiteRest;
        private System.Windows.Forms.PictureBox pictureBoxRestHotel;
        private System.Windows.Forms.PictureBox pictureBoxRestCampsite;
        private System.Windows.Forms.PictureBox pictureBoxHireAccountingOffice;
        private System.Windows.Forms.PictureBox pictureBoxExtendRestaurant;
        private System.Windows.Forms.PictureBox pictureBoxMakeOffer;
        private System.Windows.Forms.PictureBox pictureBoxRepairEquipement;
        private System.Windows.Forms.PictureBox pictureBoxBuyEquipement;
        private System.Windows.Forms.ProgressBar progressBarAccountingOfficeLevel;
        private System.Windows.Forms.ProgressBar progressBarRestaurantLevel;
        private System.Windows.Forms.Label labelAccountingOfficeLevel;
        private System.Windows.Forms.Label labelRestaurantLevel;
        private System.Windows.Forms.Label labelEquipementAmount;
        private System.Windows.Forms.Label labelHireAccountingOffice;
        private System.Windows.Forms.Label labelExtendRestaurant;
        private System.Windows.Forms.Label labelMakeOffer;
        private System.Windows.Forms.Label labelRepairEquipement;
        private System.Windows.Forms.Label labelBuyEquipement;
        private System.Windows.Forms.Label labelOwnerFatigue;
        private System.Windows.Forms.Label labelEquipementExhaustion;
        private System.Windows.Forms.Label labelClientsGladness;
        private System.Windows.Forms.Label labelRestaurantPopularity;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Label labelDays;
        private System.Windows.Forms.Timer timerTime;
    }
}