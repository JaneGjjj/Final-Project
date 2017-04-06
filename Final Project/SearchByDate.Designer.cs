namespace Final_Project
{
    partial class SearchByDate
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
            this.dtpGameDay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvGamesInDay = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGamesInDay)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpGameDay
            // 
            this.dtpGameDay.Location = new System.Drawing.Point(137, 45);
            this.dtpGameDay.Name = "dtpGameDay";
            this.dtpGameDay.Size = new System.Drawing.Size(305, 26);
            this.dtpGameDay.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select A day You Want to Watch Games : ";
            // 
            // dgvGamesInDay
            // 
            this.dgvGamesInDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGamesInDay.Location = new System.Drawing.Point(23, 104);
            this.dgvGamesInDay.Name = "dgvGamesInDay";
            this.dgvGamesInDay.RowTemplate.Height = 28;
            this.dgvGamesInDay.Size = new System.Drawing.Size(608, 264);
            this.dgvGamesInDay.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(23, 403);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(144, 29);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(173, 403);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 29);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(449, 403);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(172, 29);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back To HomePage";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // SearchByDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 463);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvGamesInDay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpGameDay);
            this.Name = "SearchByDate";
            this.Text = "Search Game By Date";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGamesInDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpGameDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvGamesInDay;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
    }
}