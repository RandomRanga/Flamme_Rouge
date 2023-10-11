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
            this.buttonDrawTrack = new System.Windows.Forms.Button();
            this.buttonSprinter = new System.Windows.Forms.Button();
            this.buttonRoller = new System.Windows.Forms.Button();
            this.buttonSprinterExhaustion = new System.Windows.Forms.Button();
            this.buttonRollerExhaustion = new System.Windows.Forms.Button();
            this.listBoxCards = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.pictureBoxDraw.Click += new System.EventHandler(this.pictureBoxDraw_Click);
            // 
            // buttonDrawTrack
            // 
            this.buttonDrawTrack.Location = new System.Drawing.Point(21, 465);
            this.buttonDrawTrack.Name = "buttonDrawTrack";
            this.buttonDrawTrack.Size = new System.Drawing.Size(124, 59);
            this.buttonDrawTrack.TabIndex = 2;
            this.buttonDrawTrack.Text = "Draw Track";
            this.buttonDrawTrack.UseVisualStyleBackColor = true;
            this.buttonDrawTrack.Click += new System.EventHandler(this.buttonDrawTrack_Click);
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
            // buttonSprinterExhaustion
            // 
            this.buttonSprinterExhaustion.Location = new System.Drawing.Point(770, 320);
            this.buttonSprinterExhaustion.Name = "buttonSprinterExhaustion";
            this.buttonSprinterExhaustion.Size = new System.Drawing.Size(117, 204);
            this.buttonSprinterExhaustion.TabIndex = 6;
            this.buttonSprinterExhaustion.Text = "Draw Sprinter Exhaustion Card";
            this.buttonSprinterExhaustion.UseVisualStyleBackColor = true;
            // 
            // buttonRollerExhaustion
            // 
            this.buttonRollerExhaustion.Location = new System.Drawing.Point(893, 320);
            this.buttonRollerExhaustion.Name = "buttonRollerExhaustion";
            this.buttonRollerExhaustion.Size = new System.Drawing.Size(117, 204);
            this.buttonRollerExhaustion.TabIndex = 7;
            this.buttonRollerExhaustion.Text = "Draw Roller Exhaustion Card";
            this.buttonRollerExhaustion.UseVisualStyleBackColor = true;
            // 
            // listBoxCards
            // 
            this.listBoxCards.FormattingEnabled = true;
            this.listBoxCards.ItemHeight = 16;
            this.listBoxCards.Location = new System.Drawing.Point(424, 320);
            this.listBoxCards.Name = "listBoxCards";
            this.listBoxCards.Size = new System.Drawing.Size(150, 164);
            this.listBoxCards.TabIndex = 8;
            this.listBoxCards.SelectedIndexChanged += new System.EventHandler(this.listBoxCards_SelectedIndexChanged);
            //this.listBoxCards.SelectedValueChanged += new System.EventHandler(this.listBoxCards_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.888F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 44);
            this.label1.TabIndex = 9;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.888F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 44);
            this.label2.TabIndex = 10;
            this.label2.Text = "B";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 536);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxCards);
            this.Controls.Add(this.buttonRollerExhaustion);
            this.Controls.Add(this.buttonSprinterExhaustion);
            this.Controls.Add(this.buttonRoller);
            this.Controls.Add(this.buttonSprinter);
            this.Controls.Add(this.buttonDrawTrack);
            this.Controls.Add(this.pictureBoxDraw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxDraw;
        private System.Windows.Forms.Button buttonDrawTrack;
        private System.Windows.Forms.Button buttonSprinter;
        private System.Windows.Forms.Button buttonRoller;
        private System.Windows.Forms.Button buttonSprinterExhaustion;
        private System.Windows.Forms.Button buttonRollerExhaustion;
        private System.Windows.Forms.ListBox listBoxCards;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

