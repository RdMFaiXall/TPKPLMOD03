namespace PBO_TP_03
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
            Inputan = new TextBox();
            button1 = new Button();
            Outputan = new Label();
            SuspendLayout();
            // 
            // Inputan
            // 
            Inputan.Location = new Point(197, 148);
            Inputan.Multiline = true;
            Inputan.Name = "Inputan";
            Inputan.Size = new Size(207, 34);
            Inputan.TabIndex = 0;
            Inputan.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(432, 148);
            button1.Name = "button1";
            button1.Size = new Size(111, 34);
            button1.TabIndex = 1;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Outputan
            // 
            Outputan.AutoSize = true;
            Outputan.BackColor = SystemColors.ScrollBar;
            Outputan.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Outputan.Location = new Point(197, 224);
            Outputan.Name = "Outputan";
            Outputan.Size = new Size(363, 50);
            Outputan.TabIndex = 2;
            Outputan.Text = "OUTPUT DARI INPUT";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Outputan);
            Controls.Add(button1);
            Controls.Add(Inputan);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Inputan;
        private Button button1;
        private Label Outputan;
    }
}
