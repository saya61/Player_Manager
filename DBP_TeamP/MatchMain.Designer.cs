namespace DBP_TeamP
{
    partial class MatchMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.teamRank = new System.Windows.Forms.RadioButton();
            this.teamSearch = new System.Windows.Forms.Button();
            this.txtTeam = new System.Windows.Forms.TextBox();
            this.teamName = new System.Windows.Forms.RadioButton();
            this.DBGrid = new System.Windows.Forms.DataGridView();
            this.matchSearch = new System.Windows.Forms.Button();
            this.teamAdd = new System.Windows.Forms.Button();
            this.teamRemove = new System.Windows.Forms.Button();
            this.matchAdd = new System.Windows.Forms.Button();
            this.TeamUpdate = new System.Windows.Forms.Button();
            this.leagueMatchM = new System.Windows.Forms.Button();
            this.finBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.teamRank);
            this.groupBox1.Controls.Add(this.teamSearch);
            this.groupBox1.Controls.Add(this.txtTeam);
            this.groupBox1.Controls.Add(this.teamName);
            this.groupBox1.Location = new System.Drawing.Point(38, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(293, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "상대팀 검색";
            // 
            // teamRank
            // 
            this.teamRank.AutoSize = true;
            this.teamRank.Location = new System.Drawing.Point(115, 19);
            this.teamRank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teamRank.Name = "teamRank";
            this.teamRank.Size = new System.Drawing.Size(63, 16);
            this.teamRank.TabIndex = 2;
            this.teamRank.Text = "팀 순위";
            this.teamRank.UseVisualStyleBackColor = true;
            // 
            // teamSearch
            // 
            this.teamSearch.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.teamSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.teamSearch.Location = new System.Drawing.Point(184, 39);
            this.teamSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teamSearch.Name = "teamSearch";
            this.teamSearch.Size = new System.Drawing.Size(80, 18);
            this.teamSearch.TabIndex = 1;
            this.teamSearch.Text = "검색";
            this.teamSearch.UseVisualStyleBackColor = false;
            this.teamSearch.Click += new System.EventHandler(this.teamSearch_Click);
            // 
            // txtTeam
            // 
            this.txtTeam.Location = new System.Drawing.Point(29, 39);
            this.txtTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTeam.Name = "txtTeam";
            this.txtTeam.Size = new System.Drawing.Size(121, 21);
            this.txtTeam.TabIndex = 1;
            // 
            // teamName
            // 
            this.teamName.AutoSize = true;
            this.teamName.Location = new System.Drawing.Point(29, 19);
            this.teamName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teamName.Name = "teamName";
            this.teamName.Size = new System.Drawing.Size(63, 16);
            this.teamName.TabIndex = 1;
            this.teamName.Text = "팀 이름";
            this.teamName.UseVisualStyleBackColor = true;
            // 
            // DBGrid
            // 
            this.DBGrid.AllowUserToAddRows = false;
            this.DBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid.Location = new System.Drawing.Point(38, 131);
            this.DBGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DBGrid.Name = "DBGrid";
            this.DBGrid.RowHeadersWidth = 51;
            this.DBGrid.RowTemplate.Height = 27;
            this.DBGrid.Size = new System.Drawing.Size(556, 166);
            this.DBGrid.TabIndex = 1;
            // 
            // matchSearch
            // 
            this.matchSearch.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.matchSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.matchSearch.Location = new System.Drawing.Point(403, 319);
            this.matchSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.matchSearch.Name = "matchSearch";
            this.matchSearch.Size = new System.Drawing.Size(191, 18);
            this.matchSearch.TabIndex = 3;
            this.matchSearch.Text = "경기 전체 기록 관리";
            this.matchSearch.UseVisualStyleBackColor = false;
            this.matchSearch.Click += new System.EventHandler(this.matchSearch_Click);
            // 
            // teamAdd
            // 
            this.teamAdd.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.teamAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.teamAdd.Location = new System.Drawing.Point(393, 39);
            this.teamAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teamAdd.Name = "teamAdd";
            this.teamAdd.Size = new System.Drawing.Size(132, 18);
            this.teamAdd.TabIndex = 4;
            this.teamAdd.Text = "상대 팀 추가";
            this.teamAdd.UseVisualStyleBackColor = false;
            this.teamAdd.Click += new System.EventHandler(this.teamAdd_Click);
            // 
            // teamRemove
            // 
            this.teamRemove.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.teamRemove.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.teamRemove.Location = new System.Drawing.Point(393, 61);
            this.teamRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teamRemove.Name = "teamRemove";
            this.teamRemove.Size = new System.Drawing.Size(132, 18);
            this.teamRemove.TabIndex = 5;
            this.teamRemove.Text = "상대 팀 제거";
            this.teamRemove.UseVisualStyleBackColor = false;
            this.teamRemove.Click += new System.EventHandler(this.teamRemove_Click);
            // 
            // matchAdd
            // 
            this.matchAdd.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.matchAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.matchAdd.Location = new System.Drawing.Point(38, 319);
            this.matchAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.matchAdd.Name = "matchAdd";
            this.matchAdd.Size = new System.Drawing.Size(136, 18);
            this.matchAdd.TabIndex = 6;
            this.matchAdd.Text = "경기 기록 추가";
            this.matchAdd.UseVisualStyleBackColor = false;
            this.matchAdd.Click += new System.EventHandler(this.matchAdd_Click);
            // 
            // TeamUpdate
            // 
            this.TeamUpdate.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TeamUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TeamUpdate.Location = new System.Drawing.Point(393, 83);
            this.TeamUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TeamUpdate.Name = "TeamUpdate";
            this.TeamUpdate.Size = new System.Drawing.Size(132, 18);
            this.TeamUpdate.TabIndex = 7;
            this.TeamUpdate.Text = "상대 팀 업데이트";
            this.TeamUpdate.UseVisualStyleBackColor = false;
            this.TeamUpdate.Click += new System.EventHandler(this.TeamUpdate_Click);
            // 
            // leagueMatchM
            // 
            this.leagueMatchM.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.leagueMatchM.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.leagueMatchM.Location = new System.Drawing.Point(222, 319);
            this.leagueMatchM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leagueMatchM.Name = "leagueMatchM";
            this.leagueMatchM.Size = new System.Drawing.Size(136, 18);
            this.leagueMatchM.TabIndex = 8;
            this.leagueMatchM.Text = "리그 경기 관리";
            this.leagueMatchM.UseVisualStyleBackColor = false;
            this.leagueMatchM.Click += new System.EventHandler(this.leagueMatchM_Click);
            // 
            // finBtn
            // 
            this.finBtn.Location = new System.Drawing.Point(531, 22);
            this.finBtn.Name = "finBtn";
            this.finBtn.Size = new System.Drawing.Size(75, 23);
            this.finBtn.TabIndex = 10;
            this.finBtn.Text = "재무 통계";
            this.finBtn.UseVisualStyleBackColor = true;
            this.finBtn.Click += new System.EventHandler(this.finBtn_Click);
            // 
            // MatchMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 360);
            this.Controls.Add(this.finBtn);
            this.Controls.Add(this.leagueMatchM);
            this.Controls.Add(this.TeamUpdate);
            this.Controls.Add(this.matchAdd);
            this.Controls.Add(this.teamRemove);
            this.Controls.Add(this.teamAdd);
            this.Controls.Add(this.matchSearch);
            this.Controls.Add(this.DBGrid);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MatchMain";
            this.Text = "MatchMain";
            this.Load += new System.EventHandler(this.MatchMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button teamSearch;
        private System.Windows.Forms.TextBox txtTeam;
        private System.Windows.Forms.DataGridView DBGrid;
        private System.Windows.Forms.Button matchSearch;
        private System.Windows.Forms.Button teamAdd;
        private System.Windows.Forms.Button teamRemove;
        private System.Windows.Forms.Button matchAdd;
        private System.Windows.Forms.Button TeamUpdate;
        private System.Windows.Forms.Button leagueMatchM;
        private System.Windows.Forms.RadioButton teamName;
        private System.Windows.Forms.RadioButton teamRank;
        private System.Windows.Forms.Button finBtn;
    }
}