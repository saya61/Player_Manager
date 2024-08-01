namespace DBP_TeamP
{
    partial class PIG1
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
            this.all_searchBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.rdo_match_id = new System.Windows.Forms.RadioButton();
            this.rdo_player_id = new System.Windows.Forms.RadioButton();
            this.DBGrid = new System.Windows.Forms.DataGridView();
            this.injure_player = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // all_searchBtn
            // 
            this.all_searchBtn.Location = new System.Drawing.Point(283, 398);
            this.all_searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.all_searchBtn.Name = "all_searchBtn";
            this.all_searchBtn.Size = new System.Drawing.Size(87, 22);
            this.all_searchBtn.TabIndex = 3;
            this.all_searchBtn.Text = "새로고침";
            this.all_searchBtn.UseVisualStyleBackColor = true;
            this.all_searchBtn.Click += new System.EventHandler(this.all_searchBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.searchBtn);
            this.groupBox1.Controls.Add(this.rdo_match_id);
            this.groupBox1.Controls.Add(this.rdo_player_id);
            this.groupBox1.Controls.Add(this.DBGrid);
            this.groupBox1.Location = new System.Drawing.Point(118, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(565, 366);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "출전 선수 명단";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "선수 추가";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(266, 44);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(156, 25);
            this.txtSearch.TabIndex = 4;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(450, 45);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 22);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "검색";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // rdo_match_id
            // 
            this.rdo_match_id.AutoSize = true;
            this.rdo_match_id.Location = new System.Drawing.Point(6, 45);
            this.rdo_match_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdo_match_id.Name = "rdo_match_id";
            this.rdo_match_id.Size = new System.Drawing.Size(88, 19);
            this.rdo_match_id.TabIndex = 2;
            this.rdo_match_id.TabStop = true;
            this.rdo_match_id.Text = "경기코드";
            this.rdo_match_id.UseVisualStyleBackColor = true;
            // 
            // rdo_player_id
            // 
            this.rdo_player_id.AutoSize = true;
            this.rdo_player_id.Location = new System.Drawing.Point(101, 46);
            this.rdo_player_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdo_player_id.Name = "rdo_player_id";
            this.rdo_player_id.Size = new System.Drawing.Size(118, 19);
            this.rdo_player_id.TabIndex = 1;
            this.rdo_player_id.TabStop = true;
            this.rdo_player_id.Text = "선수등록번호";
            this.rdo_player_id.UseVisualStyleBackColor = true;
            // 
            // DBGrid
            // 
            this.DBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid.Location = new System.Drawing.Point(6, 88);
            this.DBGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DBGrid.Name = "DBGrid";
            this.DBGrid.RowHeadersWidth = 51;
            this.DBGrid.RowTemplate.Height = 27;
            this.DBGrid.Size = new System.Drawing.Size(552, 272);
            this.DBGrid.TabIndex = 0;
            this.DBGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBGrid_CellContentClick);
            // 
            // injure_player
            // 
            this.injure_player.Location = new System.Drawing.Point(444, 398);
            this.injure_player.Name = "injure_player";
            this.injure_player.Size = new System.Drawing.Size(87, 22);
            this.injure_player.TabIndex = 4;
            this.injure_player.Text = "부상 선수";
            this.injure_player.UseVisualStyleBackColor = true;
            this.injure_player.Click += new System.EventHandler(this.injure_player_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.injure_player);
            this.Controls.Add(this.all_searchBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button all_searchBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.RadioButton rdo_match_id;
        private System.Windows.Forms.RadioButton rdo_player_id;
        private System.Windows.Forms.DataGridView DBGrid;
        private System.Windows.Forms.Button injure_player;
    }
}