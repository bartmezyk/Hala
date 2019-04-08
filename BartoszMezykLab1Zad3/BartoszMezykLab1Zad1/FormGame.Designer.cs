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
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxRestHotel = new System.Windows.Forms.PictureBox();
            this.pictureBoxRestCampsite = new System.Windows.Forms.PictureBox();
            this.pictureBoxHireAccountingOffice = new System.Windows.Forms.PictureBox();
            this.pictureBoxExtendRestaurant = new System.Windows.Forms.PictureBox();
            this.pictureBoxMakeOffer = new System.Windows.Forms.PictureBox();
            this.pictureBoxRepairEquipement = new System.Windows.Forms.PictureBox();
            this.pictureBoxBuyEquipement = new System.Windows.Forms.PictureBox();
            this.pictureBoxBuyEquip = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestHotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestCampsite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHireAccountingOffice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExtendRestaurant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMakeOffer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRepairEquipement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuyEquipement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuyEquip)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHotelRest
            // 
            this.labelHotelRest.AutoSize = true;
            this.labelHotelRest.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHotelRest.Location = new System.Drawing.Point(275, 487);
            this.labelHotelRest.Name = "labelHotelRest";
            this.labelHotelRest.Size = new System.Drawing.Size(195, 20);
            this.labelHotelRest.TabIndex = 61;
            this.labelHotelRest.Text = "Odpocznij w hotelu (1000 zł)";
            // 
            // labelCampsiteRest
            // 
            this.labelCampsiteRest.AutoSize = true;
            this.labelCampsiteRest.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCampsiteRest.Location = new System.Drawing.Point(12, 487);
            this.labelCampsiteRest.Name = "labelCampsiteRest";
            this.labelCampsiteRest.Size = new System.Drawing.Size(211, 20);
            this.labelCampsiteRest.TabIndex = 60;
            this.labelCampsiteRest.Text = "Odpocznij na kempingu (200 zł)";
            // 
            // progressBarAccountingOfficeLevel
            // 
            this.progressBarAccountingOfficeLevel.ForeColor = System.Drawing.Color.Gold;
            this.progressBarAccountingOfficeLevel.Location = new System.Drawing.Point(518, 420);
            this.progressBarAccountingOfficeLevel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.progressBarAccountingOfficeLevel.Maximum = 3;
            this.progressBarAccountingOfficeLevel.Name = "progressBarAccountingOfficeLevel";
            this.progressBarAccountingOfficeLevel.Size = new System.Drawing.Size(250, 50);
            this.progressBarAccountingOfficeLevel.Step = 1;
            this.progressBarAccountingOfficeLevel.TabIndex = 52;
            // 
            // progressBarRestaurantLevel
            // 
            this.progressBarRestaurantLevel.Location = new System.Drawing.Point(247, 420);
            this.progressBarRestaurantLevel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.progressBarRestaurantLevel.Maximum = 10;
            this.progressBarRestaurantLevel.Name = "progressBarRestaurantLevel";
            this.progressBarRestaurantLevel.Size = new System.Drawing.Size(250, 50);
            this.progressBarRestaurantLevel.Step = 1;
            this.progressBarRestaurantLevel.TabIndex = 51;
            // 
            // labelAccountingOfficeLevel
            // 
            this.labelAccountingOfficeLevel.AutoSize = true;
            this.labelAccountingOfficeLevel.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccountingOfficeLevel.Location = new System.Drawing.Point(525, 395);
            this.labelAccountingOfficeLevel.Name = "labelAccountingOfficeLevel";
            this.labelAccountingOfficeLevel.Size = new System.Drawing.Size(217, 20);
            this.labelAccountingOfficeLevel.TabIndex = 50;
            this.labelAccountingOfficeLevel.Text = "Poziom biura rachunkowego: 0/3";
            // 
            // labelRestaurantLevel
            // 
            this.labelRestaurantLevel.AutoSize = true;
            this.labelRestaurantLevel.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRestaurantLevel.Location = new System.Drawing.Point(243, 395);
            this.labelRestaurantLevel.Name = "labelRestaurantLevel";
            this.labelRestaurantLevel.Size = new System.Drawing.Size(261, 20);
            this.labelRestaurantLevel.TabIndex = 49;
            this.labelRestaurantLevel.Text = "Poziom rozbudowania restauracji: 0/10";
            // 
            // labelEquipementAmount
            // 
            this.labelEquipementAmount.AutoSize = true;
            this.labelEquipementAmount.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEquipementAmount.Location = new System.Drawing.Point(22, 395);
            this.labelEquipementAmount.Name = "labelEquipementAmount";
            this.labelEquipementAmount.Size = new System.Drawing.Size(161, 20);
            this.labelEquipementAmount.TabIndex = 48;
            this.labelEquipementAmount.Text = "Ilość sprzętu i mebli: 0";
            // 
            // labelHireAccountingOffice
            // 
            this.labelHireAccountingOffice.AutoSize = true;
            this.labelHireAccountingOffice.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHireAccountingOffice.Location = new System.Drawing.Point(496, 171);
            this.labelHireAccountingOffice.Name = "labelHireAccountingOffice";
            this.labelHireAccountingOffice.Size = new System.Drawing.Size(300, 20);
            this.labelHireAccountingOffice.TabIndex = 47;
            this.labelHireAccountingOffice.Text = "Wynajmij lepsze biuro rachunkowe (6500 zł)";
            // 
            // labelExtendRestaurant
            // 
            this.labelExtendRestaurant.AutoSize = true;
            this.labelExtendRestaurant.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExtendRestaurant.Location = new System.Drawing.Point(254, 171);
            this.labelExtendRestaurant.Name = "labelExtendRestaurant";
            this.labelExtendRestaurant.Size = new System.Drawing.Size(225, 20);
            this.labelExtendRestaurant.TabIndex = 46;
            this.labelExtendRestaurant.Text = "Rozbuduj restaurację (30000 zł)";
            // 
            // labelMakeOffer
            // 
            this.labelMakeOffer.AutoSize = true;
            this.labelMakeOffer.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMakeOffer.Location = new System.Drawing.Point(827, 487);
            this.labelMakeOffer.Name = "labelMakeOffer";
            this.labelMakeOffer.Size = new System.Drawing.Size(196, 20);
            this.labelMakeOffer.TabIndex = 45;
            this.labelMakeOffer.Text = "Zorganizuj promocję (100 zł)";
            // 
            // labelRepairEquipement
            // 
            this.labelRepairEquipement.AutoSize = true;
            this.labelRepairEquipement.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRepairEquipement.Location = new System.Drawing.Point(813, 171);
            this.labelRepairEquipement.Name = "labelRepairEquipement";
            this.labelRepairEquipement.Size = new System.Drawing.Size(228, 20);
            this.labelRepairEquipement.TabIndex = 44;
            this.labelRepairEquipement.Text = "Napraw sprzęt lub meble (200 zł)";
            // 
            // labelBuyEquipement
            // 
            this.labelBuyEquipement.AutoSize = true;
            this.labelBuyEquipement.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuyEquipement.Location = new System.Drawing.Point(12, 171);
            this.labelBuyEquipement.Name = "labelBuyEquipement";
            this.labelBuyEquipement.Size = new System.Drawing.Size(202, 20);
            this.labelBuyEquipement.TabIndex = 43;
            this.labelBuyEquipement.Text = "Kup sprzęt lub meble (200 zł)";
            // 
            // labelOwnerFatigue
            // 
            this.labelOwnerFatigue.AutoSize = true;
            this.labelOwnerFatigue.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOwnerFatigue.Location = new System.Drawing.Point(799, 77);
            this.labelOwnerFatigue.Name = "labelOwnerFatigue";
            this.labelOwnerFatigue.Size = new System.Drawing.Size(242, 27);
            this.labelOwnerFatigue.TabIndex = 42;
            this.labelOwnerFatigue.Text = "Zmęczenie właściciela: 0%";
            // 
            // labelEquipementExhaustion
            // 
            this.labelEquipementExhaustion.AutoSize = true;
            this.labelEquipementExhaustion.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEquipementExhaustion.Location = new System.Drawing.Point(367, 77);
            this.labelEquipementExhaustion.Name = "labelEquipementExhaustion";
            this.labelEquipementExhaustion.Size = new System.Drawing.Size(256, 27);
            this.labelEquipementExhaustion.TabIndex = 41;
            this.labelEquipementExhaustion.Text = "Zużycie sprzętu i mebli: 0%";
            // 
            // labelClientsGladness
            // 
            this.labelClientsGladness.AutoSize = true;
            this.labelClientsGladness.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientsGladness.Location = new System.Drawing.Point(8, 77);
            this.labelClientsGladness.Name = "labelClientsGladness";
            this.labelClientsGladness.Size = new System.Drawing.Size(237, 27);
            this.labelClientsGladness.TabIndex = 40;
            this.labelClientsGladness.Text = "Zadowolenie klientów: 0%";
            // 
            // labelRestaurantPopularity
            // 
            this.labelRestaurantPopularity.AutoSize = true;
            this.labelRestaurantPopularity.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRestaurantPopularity.Location = new System.Drawing.Point(781, 34);
            this.labelRestaurantPopularity.Name = "labelRestaurantPopularity";
            this.labelRestaurantPopularity.Size = new System.Drawing.Size(260, 27);
            this.labelRestaurantPopularity.TabIndex = 39;
            this.labelRestaurantPopularity.Text = "Popularność restauracji: 0%";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoney.Location = new System.Drawing.Point(351, 34);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(137, 27);
            this.labelMoney.TabIndex = 38;
            this.labelMoney.Text = "Pieniądze: 0 zł";
            // 
            // labelDays
            // 
            this.labelDays.AutoSize = true;
            this.labelDays.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDays.Location = new System.Drawing.Point(8, 34);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(85, 27);
            this.labelDays.TabIndex = 37;
            this.labelDays.Text = "Dzień: 0";
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // pictureBoxRestHotel
            // 
            this.pictureBoxRestHotel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRestHotel.Image = global::BartoszMezykLab1Zad1.Properties.Resources.hotel;
            this.pictureBoxRestHotel.Location = new System.Drawing.Point(279, 512);
            this.pictureBoxRestHotel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBoxRestHotel.Name = "pictureBoxRestHotel";
            this.pictureBoxRestHotel.Size = new System.Drawing.Size(180, 180);
            this.pictureBoxRestHotel.TabIndex = 59;
            this.pictureBoxRestHotel.TabStop = false;
            this.pictureBoxRestHotel.Click += new System.EventHandler(this.pictureBoxRestHotel_Click);
            // 
            // pictureBoxRestCampsite
            // 
            this.pictureBoxRestCampsite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRestCampsite.Image = global::BartoszMezykLab1Zad1.Properties.Resources.campsite;
            this.pictureBoxRestCampsite.Location = new System.Drawing.Point(26, 512);
            this.pictureBoxRestCampsite.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBoxRestCampsite.Name = "pictureBoxRestCampsite";
            this.pictureBoxRestCampsite.Size = new System.Drawing.Size(180, 180);
            this.pictureBoxRestCampsite.TabIndex = 58;
            this.pictureBoxRestCampsite.TabStop = false;
            this.pictureBoxRestCampsite.Click += new System.EventHandler(this.pictureBoxRestCampsite_Click);
            // 
            // pictureBoxHireAccountingOffice
            // 
            this.pictureBoxHireAccountingOffice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxHireAccountingOffice.Image = global::BartoszMezykLab1Zad1.Properties.Resources.taxes;
            this.pictureBoxHireAccountingOffice.Location = new System.Drawing.Point(541, 196);
            this.pictureBoxHireAccountingOffice.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBoxHireAccountingOffice.Name = "pictureBoxHireAccountingOffice";
            this.pictureBoxHireAccountingOffice.Size = new System.Drawing.Size(180, 180);
            this.pictureBoxHireAccountingOffice.TabIndex = 57;
            this.pictureBoxHireAccountingOffice.TabStop = false;
            this.pictureBoxHireAccountingOffice.Click += new System.EventHandler(this.pictureBoxHireAccountingOffice_Click);
            // 
            // pictureBoxExtendRestaurant
            // 
            this.pictureBoxExtendRestaurant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExtendRestaurant.Image = global::BartoszMezykLab1Zad1.Properties.Resources.level_up;
            this.pictureBoxExtendRestaurant.Location = new System.Drawing.Point(279, 196);
            this.pictureBoxExtendRestaurant.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBoxExtendRestaurant.Name = "pictureBoxExtendRestaurant";
            this.pictureBoxExtendRestaurant.Size = new System.Drawing.Size(180, 180);
            this.pictureBoxExtendRestaurant.TabIndex = 56;
            this.pictureBoxExtendRestaurant.TabStop = false;
            this.pictureBoxExtendRestaurant.Click += new System.EventHandler(this.pictureBoxExtendRestaurant_Click);
            // 
            // pictureBoxMakeOffer
            // 
            this.pictureBoxMakeOffer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMakeOffer.Image = global::BartoszMezykLab1Zad1.Properties.Resources.offer;
            this.pictureBoxMakeOffer.Location = new System.Drawing.Point(831, 512);
            this.pictureBoxMakeOffer.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBoxMakeOffer.Name = "pictureBoxMakeOffer";
            this.pictureBoxMakeOffer.Size = new System.Drawing.Size(180, 180);
            this.pictureBoxMakeOffer.TabIndex = 55;
            this.pictureBoxMakeOffer.TabStop = false;
            this.pictureBoxMakeOffer.Click += new System.EventHandler(this.pictureBoxMakeOffer_Click);
            // 
            // pictureBoxRepairEquipement
            // 
            this.pictureBoxRepairEquipement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRepairEquipement.Image = global::BartoszMezykLab1Zad1.Properties.Resources.repair;
            this.pictureBoxRepairEquipement.Location = new System.Drawing.Point(831, 196);
            this.pictureBoxRepairEquipement.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBoxRepairEquipement.Name = "pictureBoxRepairEquipement";
            this.pictureBoxRepairEquipement.Size = new System.Drawing.Size(180, 180);
            this.pictureBoxRepairEquipement.TabIndex = 54;
            this.pictureBoxRepairEquipement.TabStop = false;
            this.pictureBoxRepairEquipement.Click += new System.EventHandler(this.pictureBoxRepairEquipement_Click);
            // 
            // pictureBoxBuyEquipement
            // 
            this.pictureBoxBuyEquipement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxBuyEquipement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBuyEquipement.Image = global::BartoszMezykLab1Zad1.Properties.Resources.buying;
            this.pictureBoxBuyEquipement.Location = new System.Drawing.Point(-210, 133);
            this.pictureBoxBuyEquipement.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxBuyEquipement.Name = "pictureBoxBuyEquipement";
            this.pictureBoxBuyEquipement.Size = new System.Drawing.Size(180, 180);
            this.pictureBoxBuyEquipement.TabIndex = 53;
            this.pictureBoxBuyEquipement.TabStop = false;
            // 
            // pictureBoxBuyEquip
            // 
            this.pictureBoxBuyEquip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBuyEquip.Image = global::BartoszMezykLab1Zad1.Properties.Resources.buying;
            this.pictureBoxBuyEquip.Location = new System.Drawing.Point(26, 196);
            this.pictureBoxBuyEquip.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBoxBuyEquip.Name = "pictureBoxBuyEquip";
            this.pictureBoxBuyEquip.Size = new System.Drawing.Size(180, 180);
            this.pictureBoxBuyEquip.TabIndex = 62;
            this.pictureBoxBuyEquip.TabStop = false;
            this.pictureBoxBuyEquip.Click += new System.EventHandler(this.pictureBoxBuyEquip_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BartoszMezykLab1Zad1.Properties.Resources.game;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1065, 714);
            this.Controls.Add(this.pictureBoxBuyEquip);
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
            this.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swojska chata";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestHotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestCampsite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHireAccountingOffice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExtendRestaurant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMakeOffer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRepairEquipement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuyEquipement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuyEquip)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBoxBuyEquip;
    }
}