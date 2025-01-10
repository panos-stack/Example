namespace _25_11_24_ALEPIS
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
            Conn = new Button();
            Sel = new Button();
            SuspendLayout();
            // 
            // Conn
            // 
            Conn.Location = new Point(221, 181);
            Conn.Name = "Conn";
            Conn.Size = new Size(141, 168);
            Conn.TabIndex = 0;
            Conn.Text = "Insert";
            Conn.UseVisualStyleBackColor = true;
            // 
            // Sel
            // 
            Sel.Location = new Point(399, 181);
            Sel.Name = "Sel";
            Sel.Size = new Size(141, 168);
            Sel.TabIndex = 1;
            Sel.Text = "Select";
            Sel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 678);
            Controls.Add(Sel);
            Controls.Add(Conn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Conn;
        private Button Sel;
    }
}
