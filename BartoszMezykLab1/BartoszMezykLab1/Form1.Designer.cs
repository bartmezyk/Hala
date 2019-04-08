namespace BartoszMezykLab1
{
    partial class FormName
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
            this.labelName = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonChangeColors = new System.Windows.Forms.Button();
            this.buttonChangeName = new System.Windows.Forms.Button();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxShowNumber = new System.Windows.Forms.TextBox();
            this.timerCounter = new System.Windows.Forms.Timer(this.components);
            this.textBoxShowTimer = new System.Windows.Forms.TextBox();
            this.buttonRunTimer = new System.Windows.Forms.Button();
            this.buttonNewForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Sitka Small", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Maroon;
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(507, 88);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Bartosz Mężyk";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(560, 403);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(228, 67);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Zamknij";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonChangeColors
            // 
            this.buttonChangeColors.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonChangeColors.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeColors.Location = new System.Drawing.Point(27, 100);
            this.buttonChangeColors.Name = "buttonChangeColors";
            this.buttonChangeColors.Size = new System.Drawing.Size(226, 67);
            this.buttonChangeColors.TabIndex = 2;
            this.buttonChangeColors.Text = "Zmień kolory";
            this.buttonChangeColors.UseVisualStyleBackColor = false;
            this.buttonChangeColors.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonChangeName
            // 
            this.buttonChangeName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonChangeName.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeName.Location = new System.Drawing.Point(27, 173);
            this.buttonChangeName.Name = "buttonChangeName";
            this.buttonChangeName.Size = new System.Drawing.Size(226, 67);
            this.buttonChangeName.TabIndex = 5;
            this.buttonChangeName.Text = "Zmień napis";
            this.buttonChangeName.UseVisualStyleBackColor = false;
            this.buttonChangeName.Click += new System.EventHandler(this.buttonChangeName_Click);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(27, 246);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(226, 22);
            this.textBoxNumber.TabIndex = 6;
            this.textBoxNumber.Text = "1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(27, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 67);
            this.button1.TabIndex = 7;
            this.button1.Text = "Wyświetl";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxShowNumber
            // 
            this.textBoxShowNumber.Location = new System.Drawing.Point(27, 347);
            this.textBoxShowNumber.Name = "textBoxShowNumber";
            this.textBoxShowNumber.Size = new System.Drawing.Size(226, 22);
            this.textBoxShowNumber.TabIndex = 9;
            this.textBoxShowNumber.Text = "0";
            // 
            // timerCounter
            // 
            this.timerCounter.Interval = 1000;
            this.timerCounter.Tick += new System.EventHandler(this.timerCounter_Tick);
            // 
            // textBoxShowTimer
            // 
            this.textBoxShowTimer.Location = new System.Drawing.Point(27, 375);
            this.textBoxShowTimer.Name = "textBoxShowTimer";
            this.textBoxShowTimer.Size = new System.Drawing.Size(226, 22);
            this.textBoxShowTimer.TabIndex = 10;
            this.textBoxShowTimer.Text = "0";
            // 
            // buttonRunTimer
            // 
            this.buttonRunTimer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRunTimer.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRunTimer.Location = new System.Drawing.Point(27, 403);
            this.buttonRunTimer.Name = "buttonRunTimer";
            this.buttonRunTimer.Size = new System.Drawing.Size(228, 67);
            this.buttonRunTimer.TabIndex = 11;
            this.buttonRunTimer.Text = "Włącz timer";
            this.buttonRunTimer.UseVisualStyleBackColor = false;
            this.buttonRunTimer.Click += new System.EventHandler(this.buttonRunTimer_Click);
            // 
            // buttonNewForm
            // 
            this.buttonNewForm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonNewForm.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewForm.Location = new System.Drawing.Point(560, 103);
            this.buttonNewForm.Name = "buttonNewForm";
            this.buttonNewForm.Size = new System.Drawing.Size(228, 67);
            this.buttonNewForm.TabIndex = 12;
            this.buttonNewForm.Text = "Nowe okno";
            this.buttonNewForm.UseVisualStyleBackColor = false;
            this.buttonNewForm.Click += new System.EventHandler(this.buttonNewForm_Click);
            // 
            // FormName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.buttonNewForm);
            this.Controls.Add(this.buttonRunTimer);
            this.Controls.Add(this.textBoxShowTimer);
            this.Controls.Add(this.textBoxShowNumber);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.buttonChangeName);
            this.Controls.Add(this.buttonChangeColors);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelName);
            this.Name = "FormName";
            this.Text = "1 zajęcia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonChangeColors;
        private System.Windows.Forms.Button buttonChangeName;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxShowNumber;
        private System.Windows.Forms.Timer timerCounter;
        private System.Windows.Forms.TextBox textBoxShowTimer;
        private System.Windows.Forms.Button buttonRunTimer;
        private System.Windows.Forms.Button buttonNewForm;
    }
}

