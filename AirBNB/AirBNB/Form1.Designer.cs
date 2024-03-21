namespace AirBNB
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            clear = new Button();
            book = new Button();
            location = new ComboBox();
            bedrooms = new ComboBox();
            availability = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            price = new ComboBox();
            delete = new Button();

            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(133, 123);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(626, 316);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.AccessibleRole = AccessibleRole.Grip;
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(133, 459);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(162, 51);
            button1.TabIndex = 1;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // clear
            // 
            clear.AccessibleRole = AccessibleRole.Grip;
            clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            clear.Location = new Point(322, 459);
            clear.Margin = new Padding(3, 4, 3, 4);
            clear.Name = "clear";
            clear.Size = new Size(162, 51);
            clear.TabIndex = 2;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // book
            // 
            book.AccessibleRole = AccessibleRole.Grip;
            book.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            book.Location = new Point(597, 459);
            book.Margin = new Padding(3, 4, 3, 4);
            book.Name = "book";
            book.Size = new Size(162, 51);
            book.TabIndex = 3;
            book.Text = "Book";
            book.UseVisualStyleBackColor = true;
            book.Click += book_Click;
            // 
            // location
            // 
            location.Anchor = AnchorStyles.Top;
            location.FormattingEnabled = true;
            location.Items.AddRange(new object[] { "Downtown", "City Center", "Parkside", "Beachfront", "Mountain Valley", "Urban Center" });
            location.Location = new Point(133, 84);
            location.Margin = new Padding(3, 4, 3, 4);
            location.Name = "location";
            location.Size = new Size(162, 28);
            location.TabIndex = 4;
            // 
            // bedrooms
            // 
            bedrooms.Anchor = AnchorStyles.Top;
            bedrooms.FormattingEnabled = true;
            bedrooms.Items.AddRange(new object[] { "1", "2", "3" });
            bedrooms.Location = new Point(302, 84);
            bedrooms.Margin = new Padding(3, 4, 3, 4);
            bedrooms.Name = "bedrooms";
            bedrooms.Size = new Size(159, 28);
            bedrooms.TabIndex = 5;
            // 
            // availability
            // 
            availability.Anchor = AnchorStyles.Top;
            availability.FormattingEnabled = true;
            availability.Items.AddRange(new object[] { "0", "1" });
            availability.Location = new Point(617, 84);
            availability.Margin = new Padding(3, 4, 3, 4);
            availability.Name = "availability";
            availability.Size = new Size(141, 28);
            availability.TabIndex = 6;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(133, 60);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 7;
            label1.Text = "Location";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(617, 60);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 8;
            label2.Text = "Availability";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(302, 60);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 9;
            label3.Text = "Bedrooms";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(469, 60);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 11;
            label4.Text = "Price";
            // 
            // price
            // 
            price.Anchor = AnchorStyles.Top;
            price.FormattingEnabled = true;
            price.Items.AddRange(new object[] { "80", "100", "120", "130", "150", "180", "200", "220", "300" });
            price.Location = new Point(469, 84);
            price.Margin = new Padding(3, 4, 3, 4);
            price.Name = "price";
            price.Size = new Size(141, 28);
            price.TabIndex = 10;
            // 
            // delete
            // 
            delete.AccessibleRole = AccessibleRole.Grip;
            delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            delete.Location = new Point(755, 555);
            delete.Margin = new Padding(3, 4, 3, 4);
            delete.Name = "delete";
            delete.Size = new Size(147, 32);
            delete.TabIndex = 12;
            delete.Text = "Delete Profile";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_click;

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(delete);
            Controls.Add(label4);
            Controls.Add(price);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(availability);
            Controls.Add(bedrooms);
            Controls.Add(location);
            Controls.Add(book);
            Controls.Add(clear);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Search";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button clear;
        private Button book;
        private ComboBox location;
        private ComboBox bedrooms;
        private ComboBox availability;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox price;
        private Button delete;
    }
}