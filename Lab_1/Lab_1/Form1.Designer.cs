namespace Lab_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.deg_label = new System.Windows.Forms.Label();
            this.deg_textBox = new System.Windows.Forms.TextBox();
            this.rad_label = new System.Windows.Forms.Label();
            this.rad_textBox = new System.Windows.Forms.TextBox();
            this.OK_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deg_label
            // 
            resources.ApplyResources(this.deg_label, "deg_label");
            this.deg_label.Name = "deg_label";
            // 
            // deg_textBox
            // 
            resources.ApplyResources(this.deg_textBox, "deg_textBox");
            this.deg_textBox.Name = "deg_textBox";
            this.deg_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.deg_textBox_KeyPress);
            // 
            // rad_label
            // 
            resources.ApplyResources(this.rad_label, "rad_label");
            this.rad_label.Name = "rad_label";
            // 
            // rad_textBox
            // 
            resources.ApplyResources(this.rad_textBox, "rad_textBox");
            this.rad_textBox.Name = "rad_textBox";
            this.rad_textBox.ReadOnly = true;
            // 
            // OK_button
            // 
            this.OK_button.BackColor = System.Drawing.Color.Snow;
            resources.ApplyResources(this.OK_button, "OK_button");
            this.OK_button.Name = "OK_button";
            this.OK_button.UseVisualStyleBackColor = false;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.rad_textBox);
            this.Controls.Add(this.rad_label);
            this.Controls.Add(this.deg_textBox);
            this.Controls.Add(this.deg_label);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deg_label;
        private System.Windows.Forms.TextBox deg_textBox;
        private System.Windows.Forms.Label rad_label;
        private System.Windows.Forms.TextBox rad_textBox;
        private System.Windows.Forms.Button OK_button;
    }
}

