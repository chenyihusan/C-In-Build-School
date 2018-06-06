namespace RectangleWindows
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
            this.label1 = new System.Windows.Forms.Label();
            this.width_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.height_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.computeButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.width_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.height_NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "請輸入長方形的寬";
            // 
            // width_NumericUpDown
            // 
            this.width_NumericUpDown.Location = new System.Drawing.Point(137, 160);
            this.width_NumericUpDown.Name = "width_NumericUpDown";
            this.width_NumericUpDown.Size = new System.Drawing.Size(241, 46);
            this.width_NumericUpDown.TabIndex = 1;
            // 
            // height_NumericUpDown
            // 
            this.height_NumericUpDown.Location = new System.Drawing.Point(137, 299);
            this.height_NumericUpDown.Name = "height_NumericUpDown";
            this.height_NumericUpDown.Size = new System.Drawing.Size(241, 46);
            this.height_NumericUpDown.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "請輸入長方形的高";
            // 
            // computeButton
            // 
            this.computeButton.Location = new System.Drawing.Point(137, 408);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(169, 61);
            this.computeButton.TabIndex = 4;
            this.computeButton.Text = "計算";
            this.computeButton.UseVisualStyleBackColor = true;
            this.computeButton.Click += new System.EventHandler(this.ComputeButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(407, 420);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(218, 36);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "長方形的面積為";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 697);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.computeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.height_NumericUpDown);
            this.Controls.Add(this.width_NumericUpDown);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.width_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.height_NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown width_NumericUpDown;
        private System.Windows.Forms.NumericUpDown height_NumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button computeButton;
        private System.Windows.Forms.Label resultLabel;
    }
}

