namespace AirBNB
{
    partial class ChangePassword
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
            confirm = new Button();
            username = new TextBox();
            email = new TextBox();
            password = new TextBox();
            rePassword = new TextBox();
            SuspendLayout();
            // 
            // confirm
            // 
            confirm.Location = new Point(182, 419);
            confirm.Name = "confirm";
            confirm.Size = new Size(94, 29);
            confirm.TabIndex = 0;
            confirm.Text = "Confirm";
            confirm.UseVisualStyleBackColor = true;
            confirm.Click += onConfirm;
            // 
            // username
            // 
            username.Location = new Point(134, 273);
            username.Name = "username";
            username.PlaceholderText = "username";
            username.Size = new Size(213, 27);
            username.TabIndex = 1;
            // 
            // email
            // 
            email.Location = new Point(134, 306);
            email.Name = "email";
            email.PlaceholderText = "email";
            email.Size = new Size(213, 27);
            email.TabIndex = 2;
            // 
            // password
            // 
            password.Location = new Point(134, 339);
            password.Name = "password";
            password.PasswordChar = '*';
            password.PlaceholderText = "password";
            password.Size = new Size(213, 27);
            password.TabIndex = 3;
            // 
            // rePassword
            // 
            rePassword.Location = new Point(134, 372);
            rePassword.Name = "rePassword";
            rePassword.PasswordChar = '*';
            rePassword.PlaceholderText = "re-password";
            rePassword.Size = new Size(213, 27);
            rePassword.TabIndex = 4;
            rePassword.Validating += rePasswordValidating;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 594);
            Controls.Add(rePassword);
            Controls.Add(password);
            Controls.Add(email);
            Controls.Add(username);
            Controls.Add(confirm);
            Name = "ChangePassword";
            Text = "ChangePassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button confirm;
        private TextBox username;
        private TextBox email;
        private TextBox password;
        private TextBox rePassword;
    }
}