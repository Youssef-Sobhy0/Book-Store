namespace BookStore
{
	partial class UpdateBook
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
            btnCreate = new Button();
            txtDescription = new RichTextBox();
            comAuthor = new ComboBox();
            txtTitle = new TextBox();
            picBook = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)picBook).BeginInit();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(285, 374);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(179, 45);
            btnCreate.TabIndex = 14;
            btnCreate.Text = "Submit";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(392, 113);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(336, 144);
            txtDescription.TabIndex = 13;
            txtDescription.Text = "";
            // 
            // comAuthor
            // 
            comAuthor.FormattingEnabled = true;
            comAuthor.Location = new Point(392, 70);
            comAuthor.Name = "comAuthor";
            comAuthor.Size = new Size(205, 23);
            comAuthor.TabIndex = 11;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(391, 31);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(206, 23);
            txtTitle.TabIndex = 10;
            // 
            // picBook
            // 
            picBook.BackgroundImageLayout = ImageLayout.Center;
            picBook.Location = new Point(30, 31);
            picBook.Name = "picBook";
            picBook.Size = new Size(179, 157);
            picBook.TabIndex = 9;
            picBook.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(242, 26);
            label1.Name = "label1";
            label1.Size = new Size(58, 28);
            label1.TabIndex = 15;
            label1.Text = "Title :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(242, 70);
            label2.Name = "label2";
            label2.Size = new Size(82, 28);
            label2.TabIndex = 16;
            label2.Text = "Author :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(242, 113);
            label3.Name = "label3";
            label3.Size = new Size(121, 28);
            label3.TabIndex = 17;
            label3.Text = "Description :";
            // 
            // UpdateBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCreate);
            Controls.Add(txtDescription);
            Controls.Add(comAuthor);
            Controls.Add(txtTitle);
            Controls.Add(picBook);
            Name = "UpdateBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateBook";
            Load += UpdateBook_Load;
            ((System.ComponentModel.ISupportInitialize)picBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate;
		private RichTextBox txtDescription;
		private ComboBox comAuthor;
		private TextBox txtTitle;
		private PictureBox picBook;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}