namespace BookStore
{
	partial class BookDetails
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
            lblAuthor = new Label();
            lblDescription = new Label();
            lblTitle = new Label();
            picBook = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)picBook).BeginInit();
            SuspendLayout();
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 15F);
            lblAuthor.Location = new Point(383, 75);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(65, 28);
            lblAuthor.TabIndex = 10;
            lblAuthor.Text = "label3";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 12F);
            lblDescription.Location = new Point(383, 121);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(52, 21);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "label2";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15F);
            lblTitle.Location = new Point(383, 32);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(65, 28);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "label1";
            // 
            // picBook
            // 
            picBook.Location = new Point(31, 32);
            picBook.Name = "picBook";
            picBook.Size = new Size(195, 111);
            picBook.TabIndex = 7;
            picBook.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(242, 32);
            label1.Name = "label1";
            label1.Size = new Size(58, 28);
            label1.TabIndex = 13;
            label1.Text = "Title :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(242, 75);
            label2.Name = "label2";
            label2.Size = new Size(82, 28);
            label2.TabIndex = 14;
            label2.Text = "Author :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(242, 114);
            label3.Name = "label3";
            label3.Size = new Size(121, 28);
            label3.TabIndex = 15;
            label3.Text = "Description :";
            label3.Click += label3_Click;
            // 
            // BookDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblAuthor);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Controls.Add(picBook);
            Name = "BookDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookDetails";
            Load += BookDetails_Load;
            ((System.ComponentModel.ISupportInitialize)picBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblAuthor;
		private Label lblDescription;
		private Label lblTitle;
		private PictureBox picBook;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}