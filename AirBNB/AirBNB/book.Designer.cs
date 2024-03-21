namespace AirBNB
{
    partial class book
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
            username = new TextBox();
            phone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            checkIn = new DateTimePicker();
            checkOut = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            apartmentId = new TextBox();
            label5 = new Label();
            reserve = new Button();
            SuspendLayout();
            // 
            // username
            // 
            username.Location = new Point(92, 63);
            username.Name = "username";
            username.Size = new Size(259, 23);
            username.TabIndex = 0;
            // 
            // phone
            // 
            phone.Location = new Point(473, 63);
            phone.Name = "phone";
            phone.Size = new Size(259, 23);
            phone.TabIndex = 1;
            phone.Validating += phone_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 45);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(473, 45);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 3;
            label2.Text = "Phone";
            // 
            // checkIn
            // 
            checkIn.Location = new Point(92, 145);
            checkIn.Name = "checkIn";
            checkIn.Size = new Size(259, 23);
            checkIn.TabIndex = 4;
            // 
            // checkOut
            // 
            checkOut.Location = new Point(473, 145);
            checkOut.Name = "checkOut";
            checkOut.Size = new Size(259, 23);
            checkOut.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 127);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 6;
            label3.Text = "Check In";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(473, 127);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 7;
            label4.Text = "Check Out";
            // 
            // apartmentId
            // 
            apartmentId.Location = new Point(92, 227);
            apartmentId.Name = "apartmentId";
            apartmentId.Size = new Size(262, 23);
            apartmentId.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(92, 209);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 9;
            label5.Text = "Apartment ID";
            // 
            // reserve
            // 
            reserve.Location = new Point(583, 226);
            reserve.Name = "reserve";
            reserve.Size = new Size(149, 23);
            reserve.TabIndex = 10;
            reserve.Text = "Reserve";
            reserve.UseVisualStyleBackColor = true;
            reserve.Click += reserve_Click;
            // 
            // book
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(reserve);
            Controls.Add(label5);
            Controls.Add(apartmentId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(checkOut);
            Controls.Add(checkIn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(phone);
            Controls.Add(username);
            Name = "book";
            Text = "book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username;
        private TextBox phone;
        private Label label1;
        private Label label2;
        private DateTimePicker checkIn;
        private DateTimePicker checkOut;
        private Label label3;
        private Label label4;
        private TextBox apartmentId;
        private Label label5;
        private Button reserve;
    }
}