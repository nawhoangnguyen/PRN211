namespace BookManagement_NamNH
{
    partial class frmLogin
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
            cboCategory = new ComboBox();
            button2 = new Button();
            btnExit = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(553, 41);
            button1.Name = "button1";
            button1.Size = new Size(240, 89);
            button1.TabIndex = 1;
            button1.Text = "Show Category";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(553, 12);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(240, 23);
            cboCategory.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(553, 262);
            button2.Name = "button2";
            button2.Size = new Size(240, 176);
            button2.TabIndex = 3;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(136, 262);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(240, 176);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(333, 38);
            label1.Name = "label1";
            label1.Size = new Size(33, 13);
            label1.TabIndex = 5;
            label1.Text = "Login";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(805, 450);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(button2);
            Controls.Add(cboCategory);
            Controls.Add(button1);
            Name = "frmLogin";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private ComboBox cboCategory;
        private Button button2;
        private Button btnExit;
        private Label label1;
    }
}