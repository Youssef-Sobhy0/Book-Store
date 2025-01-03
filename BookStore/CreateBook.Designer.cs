namespace BookStore
{
	partial class CreateBook
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
            picBook = new PictureBox();
            txtTitle = new TextBox();
            comAuthor = new ComboBox();
            btnUpload = new Button();
            txtDescription = new RichTextBox();
            btnCreate = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)picBook).BeginInit();
            SuspendLayout();
            // 
            // picBook
            // 
            picBook.Location = new Point(32, 31);
            picBook.Name = "picBook";
            picBook.Size = new Size(179, 157);
            picBook.TabIndex = 0;
            picBook.TabStop = false;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(356, 31);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(206, 23);
            txtTitle.TabIndex = 1;
            // 
            // comAuthor
            // 
            comAuthor.FormattingEnabled = true;
            comAuthor.Location = new Point(356, 69);
            comAuthor.Name = "comAuthor";
            comAuthor.Size = new Size(205, 23);
            comAuthor.TabIndex = 2;
            comAuthor.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(42, 214);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(149, 30);
            btnUpload.TabIndex = 6;
            btnUpload.Text = "Upload Image";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(356, 112);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(336, 144);
            txtDescription.TabIndex = 7;
            txtDescription.Text = "";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(272, 374);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(179, 45);
            btnCreate.TabIndex = 8;
            btnCreate.Text = "Submit";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(228, 26);
            label1.Name = "label1";
            label1.Size = new Size(58, 28);
            label1.TabIndex = 9;
            label1.Text = "Title :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(228, 69);
            label2.Name = "label2";
            label2.Size = new Size(82, 28);
            label2.TabIndex = 10;
            label2.Text = "Author :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(228, 112);
            label3.Name = "label3";
            label3.Size = new Size(121, 28);
            label3.TabIndex = 11;
            label3.Text = "Description :";
            // 
            // CreateBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCreate);
            Controls.Add(txtDescription);
            Controls.Add(btnUpload);
            Controls.Add(comAuthor);
            Controls.Add(txtTitle);
            Controls.Add(picBook);
            Controls.Add(label1);
            Name = "CreateBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateBook";
            Load += CreateBook_Load;
            ((System.ComponentModel.ISupportInitialize)picBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBook;
		private TextBox txtTitle;
		private ComboBox comAuthor;
		private Button btnUpload;
		private RichTextBox txtDescription;
		private Button btnCreate;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}