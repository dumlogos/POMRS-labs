namespace Lab_1_2
{
    partial class Form1
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
            this.plus_button = new System.Windows.Forms.Button();
            this.minus_button = new System.Windows.Forms.Button();
            this.multiplication_button = new System.Windows.Forms.Button();
            this.division_button = new System.Windows.Forms.Button();
            this.pow_button = new System.Windows.Forms.Button();
            this.sqrt_button = new System.Windows.Forms.Button();
            this.cos_button = new System.Windows.Forms.Button();
            this.fo_textBox = new System.Windows.Forms.TextBox();
            this.so_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.result_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // plus_button
            // 
            this.plus_button.Location = new System.Drawing.Point(42, 84);
            this.plus_button.Name = "plus_button";
            this.plus_button.Size = new System.Drawing.Size(75, 23);
            this.plus_button.TabIndex = 0;
            this.plus_button.Text = "+";
            this.plus_button.UseVisualStyleBackColor = true;
            this.plus_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // minus_button
            // 
            this.minus_button.Location = new System.Drawing.Point(123, 84);
            this.minus_button.Name = "minus_button";
            this.minus_button.Size = new System.Drawing.Size(75, 23);
            this.minus_button.TabIndex = 1;
            this.minus_button.Text = "-";
            this.minus_button.UseVisualStyleBackColor = true;
            this.minus_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // multiplication_button
            // 
            this.multiplication_button.Location = new System.Drawing.Point(42, 119);
            this.multiplication_button.Name = "multiplication_button";
            this.multiplication_button.Size = new System.Drawing.Size(75, 23);
            this.multiplication_button.TabIndex = 2;
            this.multiplication_button.Text = "x";
            this.multiplication_button.UseVisualStyleBackColor = true;
            this.multiplication_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // division_button
            // 
            this.division_button.Location = new System.Drawing.Point(123, 119);
            this.division_button.Name = "division_button";
            this.division_button.Size = new System.Drawing.Size(75, 23);
            this.division_button.TabIndex = 3;
            this.division_button.Text = "/";
            this.division_button.UseVisualStyleBackColor = true;
            this.division_button.Click += new System.EventHandler(this.button4_Click);
            // 
            // pow_button
            // 
            this.pow_button.Location = new System.Drawing.Point(42, 154);
            this.pow_button.Name = "pow_button";
            this.pow_button.Size = new System.Drawing.Size(75, 23);
            this.pow_button.TabIndex = 4;
            this.pow_button.Text = "^";
            this.pow_button.UseVisualStyleBackColor = true;
            this.pow_button.Click += new System.EventHandler(this.button5_Click);
            // 
            // sqrt_button
            // 
            this.sqrt_button.Location = new System.Drawing.Point(123, 154);
            this.sqrt_button.Name = "sqrt_button";
            this.sqrt_button.Size = new System.Drawing.Size(75, 23);
            this.sqrt_button.TabIndex = 5;
            this.sqrt_button.Text = "√";
            this.sqrt_button.UseVisualStyleBackColor = true;
            this.sqrt_button.Click += new System.EventHandler(this.button6_Click);
            // 
            // cos_button
            // 
            this.cos_button.Location = new System.Drawing.Point(42, 192);
            this.cos_button.Name = "cos_button";
            this.cos_button.Size = new System.Drawing.Size(156, 23);
            this.cos_button.TabIndex = 6;
            this.cos_button.Text = "cos()";
            this.cos_button.UseVisualStyleBackColor = true;
            this.cos_button.Click += new System.EventHandler(this.button7_Click);
            // 
            // fo_textBox
            // 
            this.fo_textBox.Location = new System.Drawing.Point(42, 50);
            this.fo_textBox.Name = "fo_textBox";
            this.fo_textBox.Size = new System.Drawing.Size(75, 20);
            this.fo_textBox.TabIndex = 7;
            this.fo_textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // so_textBox
            // 
            this.so_textBox.Location = new System.Drawing.Point(123, 50);
            this.so_textBox.Name = "so_textBox";
            this.so_textBox.Size = new System.Drawing.Size(75, 20);
            this.so_textBox.TabIndex = 8;
            this.so_textBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Первый \r\nоперанд";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Второй \r\nоперанд\r\n";
            // 
            // result_textBox
            // 
            this.result_textBox.Location = new System.Drawing.Point(42, 233);
            this.result_textBox.Name = "result_textBox";
            this.result_textBox.ReadOnly = true;
            this.result_textBox.Size = new System.Drawing.Size(156, 20);
            this.result_textBox.TabIndex = 11;
            this.result_textBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 271);
            this.Controls.Add(this.result_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.so_textBox);
            this.Controls.Add(this.fo_textBox);
            this.Controls.Add(this.cos_button);
            this.Controls.Add(this.sqrt_button);
            this.Controls.Add(this.pow_button);
            this.Controls.Add(this.division_button);
            this.Controls.Add(this.multiplication_button);
            this.Controls.Add(this.minus_button);
            this.Controls.Add(this.plus_button);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button plus_button;
        private System.Windows.Forms.Button minus_button;
        private System.Windows.Forms.Button multiplication_button;
        private System.Windows.Forms.Button division_button;
        private System.Windows.Forms.Button pow_button;
        private System.Windows.Forms.Button sqrt_button;
        private System.Windows.Forms.Button cos_button;
        private System.Windows.Forms.TextBox fo_textBox;
        private System.Windows.Forms.TextBox so_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox result_textBox;
    }
}

