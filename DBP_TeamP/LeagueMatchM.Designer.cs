namespace DBP_TeamP
{
    partial class LeagueMatchM
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
            this.DBGrid = new System.Windows.Forms.DataGridView();
            this.MatchScheduleSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DBGrid
            // 
            this.DBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid.Location = new System.Drawing.Point(12, 57);
            this.DBGrid.Name = "DBGrid";
            this.DBGrid.RowTemplate.Height = 23;
            this.DBGrid.Size = new System.Drawing.Size(366, 150);
            this.DBGrid.TabIndex = 0;
            // 
            // MatchScheduleSearch
            // 
            this.MatchScheduleSearch.Location = new System.Drawing.Point(12, 219);
            this.MatchScheduleSearch.Name = "MatchScheduleSearch";
            this.MatchScheduleSearch.Size = new System.Drawing.Size(366, 46);
            this.MatchScheduleSearch.TabIndex = 1;
            this.MatchScheduleSearch.Text = "조회";
            this.MatchScheduleSearch.UseVisualStyleBackColor = true;
            this.MatchScheduleSearch.Click += new System.EventHandler(this.MatchScheduleSearch_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "리그 경기 정보";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LeagueMatchM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 277);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MatchScheduleSearch);
            this.Controls.Add(this.DBGrid);
            this.Name = "LeagueMatchM";
            this.Text = "LeagueMatchM";
            this.Load += new System.EventHandler(this.LeagueMatchM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DBGrid;
        private System.Windows.Forms.Button MatchScheduleSearch;
        private System.Windows.Forms.Label label1;
    }
}