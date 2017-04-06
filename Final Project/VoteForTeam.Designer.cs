namespace Final_Project
{
    partial class VoteForTeam
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
            this.btnAll = new System.Windows.Forms.Button();
            this.btnVote = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSupportRate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(228, 12);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(169, 29);
            this.btnAll.TabIndex = 0;
            this.btnAll.Text = "Show me ALL teams";
            this.btnAll.UseVisualStyleBackColor = true;
            // 
            // btnVote
            // 
            this.btnVote.Location = new System.Drawing.Point(38, 433);
            this.btnVote.Name = "btnVote";
            this.btnVote.Size = new System.Drawing.Size(112, 28);
            this.btnVote.TabIndex = 1;
            this.btnVote.Text = "Vote";
            this.btnVote.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(38, 482);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 27);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Reset";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(466, 481);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(198, 28);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back To HomePage";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnSupportRate
            // 
            this.btnSupportRate.Location = new System.Drawing.Point(466, 435);
            this.btnSupportRate.Name = "btnSupportRate";
            this.btnSupportRate.Size = new System.Drawing.Size(198, 26);
            this.btnSupportRate.TabIndex = 4;
            this.btnSupportRate.Text = "Show me Support Rate";
            this.btnSupportRate.UseVisualStyleBackColor = true;
            // 
            // VoteForTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 536);
            this.Controls.Add(this.btnSupportRate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnVote);
            this.Controls.Add(this.btnAll);
            this.Name = "VoteForTeam";
            this.Text = "Vote For Your Team";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnVote;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSupportRate;
    }
}