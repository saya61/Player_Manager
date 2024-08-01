namespace DBP_TeamP
{
    partial class FinancialF
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
            this.addBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.incometxt = new System.Windows.Forms.TextBox();
            this.outcometxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totaltxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DBGrid
            // 
            this.DBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid.Location = new System.Drawing.Point(12, 33);
            this.DBGrid.Name = "DBGrid";
            this.DBGrid.RowTemplate.Height = 23;
            this.DBGrid.Size = new System.Drawing.Size(561, 272);
            this.DBGrid.TabIndex = 0;
            this.DBGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBGrid_CellContentClick);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(331, 316);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(109, 23);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "추가";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(332, 343);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(108, 23);
            this.delBtn.TabIndex = 2;
            this.delBtn.Text = "삭제";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // incometxt
            // 
            this.incometxt.Enabled = false;
            this.incometxt.Location = new System.Drawing.Point(58, 318);
            this.incometxt.Name = "incometxt";
            this.incometxt.Size = new System.Drawing.Size(100, 21);
            this.incometxt.TabIndex = 3;
            // 
            // outcometxt
            // 
            this.outcometxt.Enabled = false;
            this.outcometxt.Location = new System.Drawing.Point(58, 345);
            this.outcometxt.Name = "outcometxt";
            this.outcometxt.Size = new System.Drawing.Size(100, 21);
            this.outcometxt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "수입";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "지출";
            // 
            // totaltxt
            // 
            this.totaltxt.Enabled = false;
            this.totaltxt.Location = new System.Drawing.Point(198, 345);
            this.totaltxt.Name = "totaltxt";
            this.totaltxt.Size = new System.Drawing.Size(100, 21);
            this.totaltxt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "총";
            // 
            // FinancialF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 378);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totaltxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outcometxt);
            this.Controls.Add(this.incometxt);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.DBGrid);
            this.Name = "FinancialF";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.FinancialF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DBGrid;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.TextBox incometxt;
        private System.Windows.Forms.TextBox outcometxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totaltxt;
        private System.Windows.Forms.Label label3;
    }
}