
namespace HomeWork8
{
    partial class FormCreate
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labCreate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.textNum = new System.Windows.Forms.TextBox();
            this.labNum = new System.Windows.Forms.Label();
            this.comboProduct = new System.Windows.Forms.ComboBox();
            this.labProduct = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.labAddress = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labCreate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 66);
            this.panel1.TabIndex = 0;
            // 
            // labCreate
            // 
            this.labCreate.AutoSize = true;
            this.labCreate.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCreate.Location = new System.Drawing.Point(25, 21);
            this.labCreate.Name = "labCreate";
            this.labCreate.Size = new System.Drawing.Size(93, 20);
            this.labCreate.TabIndex = 0;
            this.labCreate.Text = "创建订单";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Controls.Add(this.textNum);
            this.panel2.Controls.Add(this.labNum);
            this.panel2.Controls.Add(this.comboProduct);
            this.panel2.Controls.Add(this.labProduct);
            this.panel2.Controls.Add(this.textAddress);
            this.panel2.Controls.Add(this.labAddress);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 303);
            this.panel2.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("宋体", 14F);
            this.btnOK.Location = new System.Drawing.Point(119, 258);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 33);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // textNum
            // 
            this.textNum.Font = new System.Drawing.Font("宋体", 14F);
            this.textNum.Location = new System.Drawing.Point(119, 191);
            this.textNum.Name = "textNum";
            this.textNum.Size = new System.Drawing.Size(168, 29);
            this.textNum.TabIndex = 6;
            // 
            // labNum
            // 
            this.labNum.AutoSize = true;
            this.labNum.Font = new System.Drawing.Font("宋体", 14F);
            this.labNum.Location = new System.Drawing.Point(26, 201);
            this.labNum.Name = "labNum";
            this.labNum.Size = new System.Drawing.Size(66, 19);
            this.labNum.TabIndex = 5;
            this.labNum.Text = "数量：";
            // 
            // comboProduct
            // 
            this.comboProduct.Font = new System.Drawing.Font("宋体", 12F);
            this.comboProduct.FormattingEnabled = true;
            this.comboProduct.Items.AddRange(new object[] {
            "AAA   单价：2",
            "BBB   单价：3",
            "CCC   单价：5"});
            this.comboProduct.Location = new System.Drawing.Point(119, 111);
            this.comboProduct.Name = "comboProduct";
            this.comboProduct.Size = new System.Drawing.Size(168, 24);
            this.comboProduct.TabIndex = 4;
            // 
            // labProduct
            // 
            this.labProduct.AutoSize = true;
            this.labProduct.Font = new System.Drawing.Font("宋体", 14F);
            this.labProduct.Location = new System.Drawing.Point(26, 116);
            this.labProduct.Name = "labProduct";
            this.labProduct.Size = new System.Drawing.Size(66, 19);
            this.labProduct.TabIndex = 2;
            this.labProduct.Text = "商品：";
            // 
            // textAddress
            // 
            this.textAddress.Font = new System.Drawing.Font("宋体", 14F);
            this.textAddress.Location = new System.Drawing.Point(119, 28);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(168, 29);
            this.textAddress.TabIndex = 1;
            // 
            // labAddress
            // 
            this.labAddress.AutoSize = true;
            this.labAddress.Font = new System.Drawing.Font("宋体", 14F);
            this.labAddress.Location = new System.Drawing.Point(26, 31);
            this.labAddress.Name = "labAddress";
            this.labAddress.Size = new System.Drawing.Size(66, 19);
            this.labAddress.TabIndex = 0;
            this.labAddress.Text = "地址：";
            // 
            // FormCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 369);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormCreate";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormCreate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labCreate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox textNum;
        private System.Windows.Forms.Label labNum;
        private System.Windows.Forms.ComboBox comboProduct;
        private System.Windows.Forms.Label labProduct;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Label labAddress;
    }
}