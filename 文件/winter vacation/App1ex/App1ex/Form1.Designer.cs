namespace App1ex
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnF2C = new System.Windows.Forms.Button();
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.TxtAns = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnF2C
            // 
            this.BtnF2C.Location = new System.Drawing.Point(112, 120);
            this.BtnF2C.Name = "BtnF2C";
            this.BtnF2C.Size = new System.Drawing.Size(75, 23);
            this.BtnF2C.TabIndex = 0;
            this.BtnF2C.Text = "轉成攝氏";
            this.BtnF2C.UseVisualStyleBackColor = true;
            this.BtnF2C.Click += new System.EventHandler(this.BtnF2C_Click);
            // 
            // TxtInput
            // 
            this.TxtInput.Location = new System.Drawing.Point(112, 85);
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Size = new System.Drawing.Size(100, 20);
            this.TxtInput.TabIndex = 1;
            // 
            // TxtAns
            // 
            this.TxtAns.Location = new System.Drawing.Point(112, 180);
            this.TxtAns.Name = "TxtAns";
            this.TxtAns.Size = new System.Drawing.Size(100, 20);
            this.TxtAns.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "請輸入華氏溫度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "攝氏";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtAns);
            this.Controls.Add(this.TxtInput);
            this.Controls.Add(this.BtnF2C);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnF2C;
        private System.Windows.Forms.TextBox TxtInput;
        private System.Windows.Forms.TextBox TxtAns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

