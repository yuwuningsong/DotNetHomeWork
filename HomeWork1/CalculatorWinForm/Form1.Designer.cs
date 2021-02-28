
namespace CalculatorWinForm
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNumOne = new System.Windows.Forms.Label();
            this.labelNumTwo = new System.Windows.Forms.Label();
            this.textNumOne = new System.Windows.Forms.TextBox();
            this.textNumTwo = new System.Windows.Forms.TextBox();
            this.comboCal = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelCal = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNumOne
            // 
            this.labelNumOne.AutoSize = true;
            this.labelNumOne.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelNumOne.Location = new System.Drawing.Point(111, 63);
            this.labelNumOne.Name = "labelNumOne";
            this.labelNumOne.Size = new System.Drawing.Size(109, 20);
            this.labelNumOne.TabIndex = 0;
            this.labelNumOne.Text = "第一个数字";
            // 
            // labelNumTwo
            // 
            this.labelNumTwo.AutoSize = true;
            this.labelNumTwo.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelNumTwo.Location = new System.Drawing.Point(545, 63);
            this.labelNumTwo.Name = "labelNumTwo";
            this.labelNumTwo.Size = new System.Drawing.Size(109, 20);
            this.labelNumTwo.TabIndex = 1;
            this.labelNumTwo.Text = "第二个数字";
            // 
            // textNumOne
            // 
            this.textNumOne.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textNumOne.Location = new System.Drawing.Point(115, 109);
            this.textNumOne.Name = "textNumOne";
            this.textNumOne.Size = new System.Drawing.Size(100, 30);
            this.textNumOne.TabIndex = 2;
            // 
            // textNumTwo
            // 
            this.textNumTwo.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textNumTwo.Location = new System.Drawing.Point(549, 109);
            this.textNumTwo.Name = "textNumTwo";
            this.textNumTwo.Size = new System.Drawing.Size(100, 30);
            this.textNumTwo.TabIndex = 3;
            // 
            // comboCal
            // 
            this.comboCal.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboCal.FormattingEnabled = true;
            this.comboCal.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboCal.Location = new System.Drawing.Point(317, 109);
            this.comboCal.Name = "comboCal";
            this.comboCal.Size = new System.Drawing.Size(121, 24);
            this.comboCal.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(326, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "计算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCal
            // 
            this.labelCal.AutoSize = true;
            this.labelCal.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCal.Location = new System.Drawing.Point(339, 63);
            this.labelCal.Name = "labelCal";
            this.labelCal.Size = new System.Drawing.Size(69, 20);
            this.labelCal.TabIndex = 6;
            this.labelCal.Text = "运算符";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelResult.Location = new System.Drawing.Point(183, 315);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(94, 21);
            this.labelResult.TabIndex = 7;
            this.labelResult.Text = "结果是：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelCal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboCal);
            this.Controls.Add(this.textNumTwo);
            this.Controls.Add(this.textNumOne);
            this.Controls.Add(this.labelNumTwo);
            this.Controls.Add(this.labelNumOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumOne;
        private System.Windows.Forms.Label labelNumTwo;
        private System.Windows.Forms.TextBox textNumOne;
        private System.Windows.Forms.TextBox textNumTwo;
        private System.Windows.Forms.ComboBox comboCal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelCal;
        private System.Windows.Forms.Label labelResult;
    }
}

