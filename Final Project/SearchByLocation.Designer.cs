namespace Final_Project
{
    partial class SearchByLocation
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboPlace = new System.Windows.Forms.ComboBox();
            this.dgvGamesPlace = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGamesPlace)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose One Sports Cneter : ";
            // 
            // cboPlace
            // 
            this.cboPlace.FormattingEnabled = true;
            this.cboPlace.Location = new System.Drawing.Point(257, 26);
            this.cboPlace.Name = "cboPlace";
            this.cboPlace.Size = new System.Drawing.Size(246, 28);
            this.cboPlace.TabIndex = 1;
            this.cboPlace.Text = "Please choose here";
            // 
            // dgvGamesPlace
            // 
            this.dgvGamesPlace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGamesPlace.Location = new System.Drawing.Point(37, 90);
            this.dgvGamesPlace.Name = "dgvGamesPlace";
            this.dgvGamesPlace.RowTemplate.Height = 28;
            this.dgvGamesPlace.Size = new System.Drawing.Size(542, 244);
            this.dgvGamesPlace.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(36, 370);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(125, 29);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(181, 370);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 28);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(408, 370);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(170, 28);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back To HomePage";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // SearchByLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 443);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvGamesPlace);
            this.Controls.Add(this.cboPlace);
            this.Controls.Add(this.label1);
            this.Name = "SearchByLocation";
            this.Text = "Search Games By Location";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGamesPlace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPlace;
        private System.Windows.Forms.DataGridView dgvGamesPlace;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
    }
}