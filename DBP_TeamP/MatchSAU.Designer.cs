namespace DBP_TeamP
{
    partial class MatchSAU
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnPlayerSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DBGrid
            // 
            this.DBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid.Location = new System.Drawing.Point(12, 12);
            this.DBGrid.Name = "DBGrid";
            this.DBGrid.RowTemplate.Height = 23;
            this.DBGrid.Size = new System.Drawing.Size(1179, 480);
            this.DBGrid.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 502);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(360, 53);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnPlayerSearch
            // 
            this.btnPlayerSearch.Location = new System.Drawing.Point(831, 502);
            this.btnPlayerSearch.Name = "btnPlayerSearch";
            this.btnPlayerSearch.Size = new System.Drawing.Size(360, 53);
            this.btnPlayerSearch.TabIndex = 2;
            this.btnPlayerSearch.Text = "출전 선수 조회";
            this.btnPlayerSearch.UseVisualStyleBackColor = true;
            this.btnPlayerSearch.Click += new System.EventHandler(this.btnPlayerSearch_Click);
            // 
            // MatchSAU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 567);
            this.Controls.Add(this.btnPlayerSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.DBGrid);
            this.Name = "MatchSAU";
            this.Text = "MatchSAU";
            this.Load += new System.EventHandler(this.MatchSAU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DBGrid;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnPlayerSearch;
    }
}