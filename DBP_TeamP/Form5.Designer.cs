namespace DBP_TeamP
{
    partial class Form5
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
            this.txtInjury_duration = new System.Windows.Forms.TextBox();
            this.txtInjury_date = new System.Windows.Forms.TextBox();
            this.txtInjury_name = new System.Windows.Forms.TextBox();
            this.txtPlayer_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInjury_duration
            // 
            this.txtInjury_duration.Location = new System.Drawing.Point(187, 167);
            this.txtInjury_duration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInjury_duration.Name = "txtInjury_duration";
            this.txtInjury_duration.Size = new System.Drawing.Size(157, 25);
            this.txtInjury_duration.TabIndex = 88;
            // 
            // txtInjury_date
            // 
            this.txtInjury_date.Location = new System.Drawing.Point(187, 126);
            this.txtInjury_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInjury_date.Name = "txtInjury_date";
            this.txtInjury_date.Size = new System.Drawing.Size(157, 25);
            this.txtInjury_date.TabIndex = 87;
            // 
            // txtInjury_name
            // 
            this.txtInjury_name.Location = new System.Drawing.Point(187, 78);
            this.txtInjury_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInjury_name.Name = "txtInjury_name";
            this.txtInjury_name.Size = new System.Drawing.Size(157, 25);
            this.txtInjury_name.TabIndex = 86;
            // 
            // txtPlayer_id
            // 
            this.txtPlayer_id.Location = new System.Drawing.Point(187, 32);
            this.txtPlayer_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPlayer_id.Name = "txtPlayer_id";
            this.txtPlayer_id.Size = new System.Drawing.Size(157, 25);
            this.txtPlayer_id.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(41, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 84;
            this.label1.Text = "선수코드";
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mailLabel.Location = new System.Drawing.Point(41, 171);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(91, 19);
            this.mailLabel.TabIndex = 83;
            this.mailLabel.Text = "부상 기간";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.phoneLabel.Location = new System.Drawing.Point(41, 126);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(91, 19);
            this.phoneLabel.TabIndex = 82;
            this.phoneLabel.Text = "부상 날짜";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nameLabel.Location = new System.Drawing.Point(41, 78);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(72, 19);
            this.nameLabel.TabIndex = 81;
            this.nameLabel.Text = "부상 명";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(168, 216);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 89;
            this.btn_ok.Text = "추가";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 262);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txtInjury_duration);
            this.Controls.Add(this.txtInjury_date);
            this.Controls.Add(this.txtInjury_name);
            this.Controls.Add(this.txtPlayer_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mailLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInjury_duration;
        private System.Windows.Forms.TextBox txtInjury_date;
        private System.Windows.Forms.TextBox txtInjury_name;
        private System.Windows.Forms.TextBox txtPlayer_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button btn_ok;
    }
}