namespace _006
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(315, 198);
            button1.Name = "button1";
            button1.Size = new Size(127, 43);
            button1.TabIndex = 0;
            button1.Text = "開始計算";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(304, 134);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 39);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(326, 288);
            label1.Name = "label1";
            label1.Size = new Size(109, 30);
            label1.TabIndex = 3;
            label1.Text = "星期六有";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(326, 367);
            label2.Name = "label2";
            label2.Size = new Size(109, 30);
            label2.TabIndex = 4;
            label2.Text = "星期日有";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(290, 68);
            label3.Name = "label3";
            label3.Size = new Size(181, 30);
            label3.TabIndex = 5;
            label3.Text = "請輸入西元年份";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 478);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "周末計算機";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
