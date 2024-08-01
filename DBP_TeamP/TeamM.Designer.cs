namespace DBP_TeamP
{
    partial class TeamM
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
            this.txtConceded = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtPoint = new System.Windows.Forms.TextBox();
            this.txtRank = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtConceded);
            this.groupBox1.Controls.Add(this.txtScore);
            this.groupBox1.Controls.Add(this.txtPoint);
            this.groupBox1.Controls.Add(this.txtRank);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "상대 팀 정보";
            // 
            // txtConceded
            // 
            this.txtConceded.Location = new System.Drawing.Point(113, 211);
            this.txtConceded.Name = "txtConceded";
            this.txtConceded.Size = new System.Drawing.Size(135, 21);
            this.txtConceded.TabIndex = 9;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(113, 169);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(135, 21);
            this.txtScore.TabIndex = 8;
            // 
            // txtPoint
            // 
            this.txtPoint.Location = new System.Drawing.Point(113, 127);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(135, 21);
            this.txtPoint.TabIndex = 7;
            // 
            // txtRank
            // 
            this.txtRank.Location = new System.Drawing.Point(113, 85);
            this.txtRank.Name = "txtRank";
            this.txtRank.Size = new System.Drawing.Size(135, 21);
            this.txtRank.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(113, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(135, 21);
            this.txtName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "총 실점";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "총 득점";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "승점";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "리그 순위";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "팀 이름";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 291);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(302, 30);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "확인";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // TeamM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 333);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.Name = "TeamM";
            this.Text = "TeamM";
            this.Load += new System.EventHandler(this.TeamM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConceded;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtPoint;
        private System.Windows.Forms.TextBox txtRank;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnOK;
    }
}