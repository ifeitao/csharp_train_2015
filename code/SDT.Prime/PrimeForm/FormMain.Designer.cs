namespace PrimeForm
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.buttonResolve = new System.Windows.Forms.Button();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入正整数";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(28, 43);
            this.textBoxNumber.Multiline = true;
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(327, 86);
            this.textBoxNumber.TabIndex = 1;
            this.textBoxNumber.TextChanged += new System.EventHandler(this.textBoxNumber_TextChanged);
            // 
            // buttonResolve
            // 
            this.buttonResolve.Enabled = false;
            this.buttonResolve.Location = new System.Drawing.Point(28, 148);
            this.buttonResolve.Name = "buttonResolve";
            this.buttonResolve.Size = new System.Drawing.Size(75, 23);
            this.buttonResolve.TabIndex = 2;
            this.buttonResolve.Text = "分解";
            this.buttonResolve.UseVisualStyleBackColor = true;
            this.buttonResolve.Click += new System.EventHandler(this.buttonResolve_Click);
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(28, 189);
            this.textBoxAnswer.Multiline = true;
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(327, 86);
            this.textBoxAnswer.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 310);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.buttonResolve);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.Text = "质因数分解";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Button buttonResolve;
        private System.Windows.Forms.TextBox textBoxAnswer;
    }
}

