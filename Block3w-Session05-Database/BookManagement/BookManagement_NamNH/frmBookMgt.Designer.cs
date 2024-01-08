namespace BookManagement_NamNH
{
    partial class frmBookMgt
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
            dgvBooks = new DataGridView();
            lblMainName = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            txtKeyword = new TextBox();
            groupBox1 = new GroupBox();
            btnSearch = new Button();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(12, 66);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowTemplate.Height = 25;
            dgvBooks.Size = new Size(776, 232);
            dgvBooks.TabIndex = 6;
            // 
            // lblMainName
            // 
            lblMainName.AutoSize = true;
            lblMainName.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblMainName.Location = new Point(247, -2);
            lblMainName.Name = "lblMainName";
            lblMainName.Size = new Size(348, 65);
            lblMainName.TabIndex = 1;
            lblMainName.Text = "Book Manager";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 192, 255);
            btnAdd.Location = new Point(12, 384);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(328, 34);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Book";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 192, 255);
            btnDelete.Location = new Point(12, 304);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(328, 34);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 192, 255);
            btnExit.Location = new Point(12, 421);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(0, 32);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(328, 23);
            txtKeyword.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(txtKeyword);
            groupBox1.Location = new Point(460, 318);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(328, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(253, 71);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(255, 192, 255);
            btnEdit.Location = new Point(12, 344);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(328, 34);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Update";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // frmBookMgt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 245, 245);
            ClientSize = new Size(800, 450);
            Controls.Add(btnEdit);
            Controls.Add(groupBox1);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(lblMainName);
            Controls.Add(dgvBooks);
            Name = "frmBookMgt";
            Text = "frmBookMgt";
            Load += frmBookMgt_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBooks;
        private Label lblMainName;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnExit;
        private TextBox txtKeyword;
        private GroupBox groupBox1;
        private Button btnSearch;
        private Button btnEdit;
    }
}