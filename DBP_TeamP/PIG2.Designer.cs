namespace DBP_TeamP
{
    partial class PIG2
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
            this.assists = new System.Windows.Forms.TextBox();
            this.goal_scored = new System.Windows.Forms.TextBox();
            this.position = new System.Windows.Forms.TextBox();
            this.player_id = new System.Windows.Forms.TextBox();
            this.match_code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.ListAll = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.선택한행업데이트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새로운데이터추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.선택한행삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // assists
            // 
            this.assists.Enabled = false;
            this.assists.Location = new System.Drawing.Point(547, 330);
            this.assists.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.assists.Name = "assists";
            this.assists.Size = new System.Drawing.Size(157, 25);
            this.assists.TabIndex = 70;
            // 
            // goal_scored
            // 
            this.goal_scored.Enabled = false;
            this.goal_scored.Location = new System.Drawing.Point(547, 289);
            this.goal_scored.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.goal_scored.Name = "goal_scored";
            this.goal_scored.Size = new System.Drawing.Size(157, 25);
            this.goal_scored.TabIndex = 69;
            // 
            // position
            // 
            this.position.Enabled = false;
            this.position.Location = new System.Drawing.Point(547, 248);
            this.position.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(157, 25);
            this.position.TabIndex = 68;
            // 
            // player_id
            // 
            this.player_id.Enabled = false;
            this.player_id.Location = new System.Drawing.Point(547, 200);
            this.player_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.player_id.Name = "player_id";
            this.player_id.Size = new System.Drawing.Size(157, 25);
            this.player_id.TabIndex = 67;
            // 
            // match_code
            // 
            this.match_code.Enabled = false;
            this.match_code.Location = new System.Drawing.Point(547, 154);
            this.match_code.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.match_code.Name = "match_code";
            this.match_code.Size = new System.Drawing.Size(157, 25);
            this.match_code.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(401, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 65;
            this.label2.Text = "어시스트";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(401, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 64;
            this.label1.Text = "경기코드";
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mailLabel.Location = new System.Drawing.Point(401, 292);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(47, 19);
            this.mailLabel.TabIndex = 63;
            this.mailLabel.Text = "득점";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.phoneLabel.Location = new System.Drawing.Point(401, 248);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(66, 19);
            this.phoneLabel.TabIndex = 62;
            this.phoneLabel.Text = "포지션";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nameLabel.Location = new System.Drawing.Point(401, 200);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(123, 19);
            this.nameLabel.TabIndex = 61;
            this.nameLabel.Text = "선수등록번호";
            // 
            // ListAll
            // 
            this.ListAll.ContextMenuStrip = this.contextMenuStrip1;
            this.ListAll.FormattingEnabled = true;
            this.ListAll.ItemHeight = 15;
            this.ListAll.Location = new System.Drawing.Point(58, 26);
            this.ListAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListAll.Name = "ListAll";
            this.ListAll.Size = new System.Drawing.Size(178, 394);
            this.ListAll.TabIndex = 60;
            this.ListAll.SelectedIndexChanged += new System.EventHandler(this.ListAll_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.선택한행업데이트ToolStripMenuItem,
            this.새로운데이터추가ToolStripMenuItem,
            this.선택한행삭제ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(209, 76);
            // 
            // 선택한행업데이트ToolStripMenuItem
            // 
            this.선택한행업데이트ToolStripMenuItem.Name = "선택한행업데이트ToolStripMenuItem";
            this.선택한행업데이트ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.선택한행업데이트ToolStripMenuItem.Text = "선택한 행 업데이트";
            this.선택한행업데이트ToolStripMenuItem.Click += new System.EventHandler(this.선택한행업데이트ToolStripMenuItem_Click);
            // 
            // 새로운데이터추가ToolStripMenuItem
            // 
            this.새로운데이터추가ToolStripMenuItem.Name = "새로운데이터추가ToolStripMenuItem";
            this.새로운데이터추가ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.새로운데이터추가ToolStripMenuItem.Text = "새로운 데이터 추가";
            this.새로운데이터추가ToolStripMenuItem.Click += new System.EventHandler(this.새로운데이터추가ToolStripMenuItem_Click);
            // 
            // 선택한행삭제ToolStripMenuItem
            // 
            this.선택한행삭제ToolStripMenuItem.Name = "선택한행삭제ToolStripMenuItem";
            this.선택한행삭제ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.선택한행삭제ToolStripMenuItem.Text = "선택한 행 삭제";
            this.선택한행삭제ToolStripMenuItem.Click += new System.EventHandler(this.선택한행삭제ToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.assists);
            this.Controls.Add(this.goal_scored);
            this.Controls.Add(this.position);
            this.Controls.Add(this.player_id);
            this.Controls.Add(this.match_code);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mailLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.ListAll);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox assists;
        private System.Windows.Forms.TextBox goal_scored;
        private System.Windows.Forms.TextBox position;
        private System.Windows.Forms.TextBox player_id;
        private System.Windows.Forms.TextBox match_code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ListBox ListAll;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 선택한행업데이트ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새로운데이터추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 선택한행삭제ToolStripMenuItem;
    }
}