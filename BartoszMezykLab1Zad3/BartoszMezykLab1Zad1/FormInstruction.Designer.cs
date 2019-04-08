namespace BartoszMezykLab1Zad1
{
    partial class FormInstruction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInstruction));
            this.textBoxInstruction = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInstruction
            // 
            this.textBoxInstruction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInstruction.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxInstruction.Enabled = false;
            this.textBoxInstruction.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInstruction.Location = new System.Drawing.Point(12, 12);
            this.textBoxInstruction.Multiline = true;
            this.textBoxInstruction.Name = "textBoxInstruction";
            this.textBoxInstruction.Size = new System.Drawing.Size(679, 529);
            this.textBoxInstruction.TabIndex = 2;
            this.textBoxInstruction.Text = resources.GetString("textBoxInstruction.Text");
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Gold;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(229, 547);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(250, 100);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Wyjście";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            this.buttonExit.MouseEnter += new System.EventHandler(this.buttonExit_MouseEnter);
            this.buttonExit.MouseLeave += new System.EventHandler(this.buttonExit_MouseLeave);
            // 
            // FormInstruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BartoszMezykLab1Zad1.Properties.Resources.menu;
            this.ClientSize = new System.Drawing.Size(700, 656);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBoxInstruction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInstruction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swojska chata";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInstruction;
        private System.Windows.Forms.Button buttonExit;
    }
}