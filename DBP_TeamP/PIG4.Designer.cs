namespace DBP_TeamP
{
    partial class PIG4
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
            this.add_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.all_search_btn = new System.Windows.Forms.Button();
            this.rdo_player_id = new System.Windows.Forms.RadioButton();
            this.rdo_injure_name = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DBGrid
            // 
            this.DBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid.Location = new System.Drawing.Point(37, 126);
            this.DBGrid.Name = "DBGrid";
            this.DBGrid.RowHeadersWidth = 51;
            this.DBGrid.RowTemplate.Height = 27;
            this.DBGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DBGrid.Size = new System.Drawing.Size(525, 278);
            this.DBGrid.TabIndex = 0;
            this.DBGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBGrid_CellContentClick);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(487, 33);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 1;
            this.add_btn.Text = "추가";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(487, 73);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(75, 23);
            this.update_btn.TabIndex = 2;
            this.update_btn.Text = "수정";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(37, 74);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(223, 25);
            this.txtSearch.TabIndex = 3;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(282, 74);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 4;
            this.search_btn.Text = "검색";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // all_search_btn
            // 
            this.all_search_btn.Location = new System.Drawing.Point(260, 415);
            this.all_search_btn.Name = "all_search_btn";
            this.all_search_btn.Size = new System.Drawing.Size(75, 23);
            this.all_search_btn.TabIndex = 6;
            this.all_search_btn.Text = "새로고침";
            this.all_search_btn.UseVisualStyleBackColor = true;
            this.all_search_btn.Click += new System.EventHandler(this.all_search_btn_Click);
            // 
            // rdo_player_id
            // 
            this.rdo_player_id.AutoSize = true;
            this.rdo_player_id.Location = new System.Drawing.Point(37, 36);
            this.rdo_player_id.Name = "rdo_player_id";
            this.rdo_player_id.Size = new System.Drawing.Size(88, 19);
            this.rdo_player_id.TabIndex = 7;
            this.rdo_player_id.TabStop = true;
            this.rdo_player_id.Text = "선수코드";
            this.rdo_player_id.UseVisualStyleBackColor = true;
            // 
            // rdo_injure_name
            // 
            this.rdo_injure_name.AutoSize = true;
            this.rdo_injure_name.Location = new System.Drawing.Point(163, 37);
            this.rdo_injure_name.Name = "rdo_injure_name";
            this.rdo_injure_name.Size = new System.Drawing.Size(73, 19);
            this.rdo_injure_name.TabIndex = 8;
            this.rdo_injure_name.TabStop = true;
            this.rdo_injure_name.Text = "부상명";
            this.rdo_injure_name.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 450);
            this.Controls.Add(this.rdo_injure_name);
            this.Controls.Add(this.rdo_player_id);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.all_search_btn);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.DBGrid);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DBGrid;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button all_search_btn;
        private System.Windows.Forms.RadioButton rdo_player_id;
        private System.Windows.Forms.RadioButton rdo_injure_name;
    }
}