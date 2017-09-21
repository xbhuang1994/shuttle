namespace Bullfighting
{
    partial class FormRoom
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
            this.buttonTouch = new System.Windows.Forms.Button();
            this.labelBird = new System.Windows.Forms.Label();
            this.timerFixedUpdate = new System.Windows.Forms.Timer(this.components);
            this.timerTransmitter = new System.Windows.Forms.Timer(this.components);
            this.linkLabelTop = new System.Windows.Forms.LinkLabel();
            this.linkLabelBottom = new System.Windows.Forms.LinkLabel();
            this.labelScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonTouch
            // 
            this.buttonTouch.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonTouch.Location = new System.Drawing.Point(229, 379);
            this.buttonTouch.Name = "buttonTouch";
            this.buttonTouch.Size = new System.Drawing.Size(118, 52);
            this.buttonTouch.TabIndex = 0;
            this.buttonTouch.Text = "Touch";
            this.buttonTouch.UseVisualStyleBackColor = true;
            this.buttonTouch.Click += new System.EventHandler(this.buttonTouch_Click);
            // 
            // labelBird
            // 
            this.labelBird.AutoSize = true;
            this.labelBird.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelBird.Location = new System.Drawing.Point(227, 224);
            this.labelBird.Name = "labelBird";
            this.labelBird.Size = new System.Drawing.Size(29, 12);
            this.labelBird.TabIndex = 1;
            this.labelBird.Text = "小鸟";
            // 
            // timerFixedUpdate
            // 
            this.timerFixedUpdate.Enabled = true;
            this.timerFixedUpdate.Tick += new System.EventHandler(this.timerFixedUpdate_Tick);
            // 
            // timerTransmitter
            // 
            this.timerTransmitter.Enabled = true;
            this.timerTransmitter.Interval = 500;
            this.timerTransmitter.Tick += new System.EventHandler(this.timerTransmitter_Tick);
            // 
            // linkLabelTop
            // 
            this.linkLabelTop.AutoSize = true;
            this.linkLabelTop.LinkColor = System.Drawing.Color.Red;
            this.linkLabelTop.Location = new System.Drawing.Point(-47, 42);
            this.linkLabelTop.Name = "linkLabelTop";
            this.linkLabelTop.Size = new System.Drawing.Size(953, 12);
            this.linkLabelTop.TabIndex = 2;
            this.linkLabelTop.TabStop = true;
            this.linkLabelTop.Text = "                                                                                 " +
    "                                                                             ";
            // 
            // linkLabelBottom
            // 
            this.linkLabelBottom.AutoSize = true;
            this.linkLabelBottom.LinkColor = System.Drawing.Color.Red;
            this.linkLabelBottom.Location = new System.Drawing.Point(-76, 349);
            this.linkLabelBottom.Name = "linkLabelBottom";
            this.linkLabelBottom.Size = new System.Drawing.Size(953, 12);
            this.linkLabelBottom.TabIndex = 3;
            this.linkLabelBottom.TabStop = true;
            this.linkLabelBottom.Text = "                                                                                 " +
    "                                                                             ";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("SimSun", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelScore.Location = new System.Drawing.Point(252, 9);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(31, 33);
            this.labelScore.TabIndex = 4;
            this.labelScore.Text = "0";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 456);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.linkLabelBottom);
            this.Controls.Add(this.linkLabelTop);
            this.Controls.Add(this.labelBird);
            this.Controls.Add(this.buttonTouch);
            this.Name = "FormRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTouch;
        private System.Windows.Forms.Label labelBird;
        private System.Windows.Forms.Timer timerFixedUpdate;
        private System.Windows.Forms.Timer timerTransmitter;
        private System.Windows.Forms.LinkLabel linkLabelTop;
        private System.Windows.Forms.LinkLabel linkLabelBottom;
        private System.Windows.Forms.Label labelScore;
    }
}