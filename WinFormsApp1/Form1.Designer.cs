﻿namespace WinFormsApp1
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
            label1 = new Label();
            button_hello = new Button();
            textBox1 = new TextBox();
            label_hello = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(132, 88);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.MouseMove += button1_MouseMove;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 103);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // button_hello
            // 
            button_hello.Location = new Point(576, 12);
            button_hello.Name = "button_hello";
            button_hello.Size = new Size(124, 29);
            button_hello.TabIndex = 2;
            button_hello.Text = "Say hello to...";
            button_hello.UseVisualStyleBackColor = true;
            button_hello.Click += button_hello_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(283, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(287, 27);
            textBox1.TabIndex = 3;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label_hello
            // 
            label_hello.AutoSize = true;
            label_hello.Location = new Point(283, 80);
            label_hello.Name = "label_hello";
            label_hello.Size = new Size(45, 20);
            label_hello.TabIndex = 4;
            label_hello.Text = "Hello";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_hello);
            Controls.Add(textBox1);
            Controls.Add(button_hello);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button_hello;
        private TextBox textBox1;
        private Label label_hello;
    }
}
