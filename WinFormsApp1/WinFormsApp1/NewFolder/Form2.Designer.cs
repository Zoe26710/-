﻿namespace WinFormsApp1.NewFolder
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            bindingSource1 = new BindingSource(components);
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(27, 67);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(50, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "會員";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(162, 67);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(76, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "10元折扣";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(72, 128);
            button1.Name = "button1";
            button1.Size = new Size(109, 44);
            button1.TabIndex = 2;
            button1.Text = "確定";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 193);
            Controls.Add(button1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private BindingSource bindingSource1;
        private Button button1;
    }
}