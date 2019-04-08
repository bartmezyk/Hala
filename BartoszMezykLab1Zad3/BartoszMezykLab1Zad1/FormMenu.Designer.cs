namespace BartoszMezykLab1Zad1
{
    partial class FormMenu
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
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonInstruction = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.BackColor = System.Drawing.Color.Gold;
            this.buttonNewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNewGame.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewGame.Location = new System.Drawing.Point(183, 35);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(250, 98);
            this.buttonNewGame.TabIndex = 0;
            this.buttonNewGame.Text = "Nowa Gra";
            this.buttonNewGame.UseVisualStyleBackColor = false;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            this.buttonNewGame.MouseEnter += new System.EventHandler(this.buttonNewGame_MouseEnter);
            this.buttonNewGame.MouseLeave += new System.EventHandler(this.buttonNewGame_MouseLeave);
            // 
            // buttonInstruction
            // 
            this.buttonInstruction.BackColor = System.Drawing.Color.Gold;
            this.buttonInstruction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInstruction.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInstruction.Location = new System.Drawing.Point(183, 155);
            this.buttonInstruction.Name = "buttonInstruction";
            this.buttonInstruction.Size = new System.Drawing.Size(250, 98);
            this.buttonInstruction.TabIndex = 1;
            this.buttonInstruction.Text = "Instrukcja";
            this.buttonInstruction.UseVisualStyleBackColor = false;
            this.buttonInstruction.Click += new System.EventHandler(this.buttonInstruction_Click);
            this.buttonInstruction.MouseEnter += new System.EventHandler(this.buttonInstruction_MouseEnter);
            this.buttonInstruction.MouseLeave += new System.EventHandler(this.buttonInstruction_MouseLeave);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Gold;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(183, 275);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(250, 98);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Wyjście";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            this.buttonExit.MouseEnter += new System.EventHandler(this.buttonExit_MouseEnter);
            this.buttonExit.MouseLeave += new System.EventHandler(this.buttonExit_MouseLeave);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.BackgroundImage = global::BartoszMezykLab1Zad1.Properties.Resources.menu;
            this.ClientSize = new System.Drawing.Size(586, 406);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonInstruction);
            this.Controls.Add(this.buttonNewGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swojska Chata";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button buttonInstruction;
        private System.Windows.Forms.Button buttonExit;
    }
}

