namespace DBP_TeamP
{
    partial class SubFinF
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
            this.datetxt = new System.Windows.Forms.TextBox();
            this.reasontxt = new System.Windows.Forms.TextBox();
            this.amounttxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inrdoBtn = new System.Windows.Forms.RadioButton();
            this.outrdoBtn = new System.Windows.Forms.RadioButton();
            this.okBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // datetxt
            // 
            this.datetxt.Location = new System.Drawing.Point(122, 23);
            this.datetxt.Name = "datetxt";
            this.datetxt.Size = new System.Drawing.Size(100, 21);
            this.datetxt.TabIndex = 0;
            // 
            // reasontxt
            // 
            this.reasontxt.Location = new System.Drawing.Point(122, 50);
            this.reasontxt.Name = "reasontxt";
            this.reasontxt.Size = new System.Drawing.Size(100, 21);
            this.reasontxt.TabIndex = 1;
            // 
            // amounttxt
            // 
            this.amounttxt.Location = new System.Drawing.Point(122, 104);
            this.amounttxt.Name = "amounttxt";
            this.amounttxt.Size = new System.Drawing.Size(100, 21);
            this.amounttxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "날짜";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "명분";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "유형";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "양";
            // 
            // inrdoBtn
            // 
            this.inrdoBtn.AutoSize = true;
            this.inrdoBtn.Location = new System.Drawing.Point(122, 80);
            this.inrdoBtn.Name = "inrdoBtn";
            this.inrdoBtn.Size = new System.Drawing.Size(47, 16);
            this.inrdoBtn.TabIndex = 8;
            this.inrdoBtn.TabStop = true;
            this.inrdoBtn.Text = "수입";
            this.inrdoBtn.UseVisualStyleBackColor = true;
            // 
            // outrdoBtn
            // 
            this.outrdoBtn.AutoSize = true;
            this.outrdoBtn.Location = new System.Drawing.Point(175, 80);
            this.outrdoBtn.Name = "outrdoBtn";
            this.outrdoBtn.Size = new System.Drawing.Size(47, 16);
            this.outrdoBtn.TabIndex = 9;
            this.outrdoBtn.TabStop = true;
            this.outrdoBtn.Text = "지출";
            this.outrdoBtn.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(84, 151);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 10;
            this.okBtn.Text = "추가";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // SubFinF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 186);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.outrdoBtn);
            this.Controls.Add(this.inrdoBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amounttxt);
            this.Controls.Add(this.reasontxt);
            this.Controls.Add(this.datetxt);
            this.Name = "SubFinF";
            this.Text = "subFinF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubFinF_FormClosing);
            this.Load += new System.EventHandler(this.SubFinF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox datetxt;
        private System.Windows.Forms.TextBox reasontxt;
        private System.Windows.Forms.TextBox amounttxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton inrdoBtn;
        private System.Windows.Forms.RadioButton outrdoBtn;
        private System.Windows.Forms.Button okBtn;
    }
}