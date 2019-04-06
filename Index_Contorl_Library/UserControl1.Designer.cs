namespace Index_Contorl_Library
{
    partial class IC_NumberChangeBox
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

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()

        {
            this.but_Reduce = new System.Windows.Forms.Button();
            this.but_Add = new System.Windows.Forms.Button();
            this.txt_Number = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // but_Reduce
            // 
            this.but_Reduce.Font = new System.Drawing.Font("宋体", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Reduce.Location = new System.Drawing.Point(4, 10);
            this.but_Reduce.Margin = new System.Windows.Forms.Padding(4);
            this.but_Reduce.Name = "but_Reduce";
            this.but_Reduce.Size = new System.Drawing.Size(61, 49);
            this.but_Reduce.TabIndex = 0;
            this.but_Reduce.Text = "←";
            this.but_Reduce.UseVisualStyleBackColor = true;
            this.but_Reduce.Click += new System.EventHandler(this.But_Reduce_Click);
            // 
            // but_Add
            // 
            this.but_Add.Font = new System.Drawing.Font("宋体", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Add.Location = new System.Drawing.Point(220, 12);
            this.but_Add.Margin = new System.Windows.Forms.Padding(4);
            this.but_Add.Name = "but_Add";
            this.but_Add.Size = new System.Drawing.Size(65, 49);
            this.but_Add.TabIndex = 0;
            this.but_Add.Text = "→";
            this.but_Add.UseVisualStyleBackColor = true;
            this.but_Add.Click += new System.EventHandler(this.But_Add_Click);
            // 
            // txt_Number
            // 
            this.txt_Number.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Number.Location = new System.Drawing.Point(72, 3);
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(141, 63);
            this.txt_Number.TabIndex = 1;
            this.txt_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Number.TextChanged += new System.EventHandler(this.Txt_Number_TextChanged);
            // 
            // IC_NumberChangeBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_Number);
            this.Controls.Add(this.but_Add);
            this.Controls.Add(this.but_Reduce);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IC_NumberChangeBox";
            this.Size = new System.Drawing.Size(294, 73);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_Reduce;
        private System.Windows.Forms.Button but_Add;
        private System.Windows.Forms.TextBox txt_Number;
    }
}
