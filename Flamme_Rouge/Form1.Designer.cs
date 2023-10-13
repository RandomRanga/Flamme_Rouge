namespace Flamme_Rouge
{
    partial class Form1
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
            this.pictureBoxDraw = new System.Windows.Forms.PictureBox();
            this.buttonSprinter = new System.Windows.Forms.Button();
            this.buttonRoller = new System.Windows.Forms.Button();
            this.listBoxCards = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDraw
            // 
            this.pictureBoxDraw.Location = new System.Drawing.Point(51, 170);
            this.pictureBoxDraw.Name = "pictureBoxDraw";
            this.pictureBoxDraw.Size = new System.Drawing.Size(1680, 144);
            this.pictureBoxDraw.TabIndex = 1;
            this.pictureBoxDraw.TabStop = false;
            // 
            // buttonSprinter
            // 
            this.buttonSprinter.Location = new System.Drawing.Point(166, 320);
            this.buttonSprinter.Name = "buttonSprinter";
            this.buttonSprinter.Size = new System.Drawing.Size(117, 204);
            this.buttonSprinter.TabIndex = 4;
            this.buttonSprinter.Text = "Draw Sprinter Cards";
            this.buttonSprinter.UseVisualStyleBackColor = true;
            this.buttonSprinter.Click += new System.EventHandler(this.buttonSprinter_Click);
            // 
            // buttonRoller
            // 
            this.buttonRoller.Location = new System.Drawing.Point(289, 320);
            this.buttonRoller.Name = "buttonRoller";
            this.buttonRoller.Size = new System.Drawing.Size(117, 204);
            this.buttonRoller.TabIndex = 5;
            this.buttonRoller.Text = "Draw Roller Cards";
            this.buttonRoller.UseVisualStyleBackColor = true;
            this.buttonRoller.Click += new System.EventHandler(this.buttonRoller_Click);
            // 
            // listBoxCards
            // 
            this.listBoxCards.FormattingEnabled = true;
            this.listBoxCards.ItemHeight = 16;
            this.listBoxCards.Location = new System.Drawing.Point(424, 376);
            this.listBoxCards.Name = "listBoxCards";
            this.listBoxCards.Size = new System.Drawing.Size(179, 148);
            this.listBoxCards.TabIndex = 8;
            this.listBoxCards.SelectedIndexChanged += new System.EventHandler(this.listBoxCards_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Click on which card you \r\nwould like to play.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "Red inside is a Sprinter \r\nBlue inside is a Roller\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 536);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxCards);
            this.Controls.Add(this.buttonRoller);
            this.Controls.Add(this.buttonSprinter);
            this.Controls.Add(this.pictureBoxDraw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxDraw;
        private System.Windows.Forms.Button buttonSprinter;
        private System.Windows.Forms.Button buttonRoller;
        private System.Windows.Forms.ListBox listBoxCards;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

