using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AirBNB
{
    partial class LogIn
    {
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
            username = new TextBox();
            password = new TextBox();
            signIn = new Button();
            length = new Label();
            capital = new Label();
            lowercase = new Label();
            number = new Label();
            label1 = new Label();
            changePassword = new Button();
            ThemeComboBox = new ComboBox();
            SuspendLayout();
            // 
            // username
            // 
            username.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            username.Location = new Point(83, 314);
            username.Margin = new Padding(3, 4, 3, 4);
            username.Name = "username";
            username.PlaceholderText = "username";
            username.Size = new Size(292, 27);
            username.TabIndex = 0;
            // 
            // password
            // 
            password.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            password.Location = new Point(83, 370);
            password.Margin = new Padding(3, 4, 3, 4);
            password.Name = "password";
            password.PasswordChar = '*';
            password.PlaceholderText = "password";
            password.Size = new Size(292, 27);
            password.TabIndex = 1;
            // 
            // signIn
            // 
            signIn.Anchor = AnchorStyles.None;
            signIn.Location = new Point(157, 426);
            signIn.Margin = new Padding(3, 4, 3, 4);
            signIn.Name = "signIn";
            signIn.Size = new Size(119, 33);
            signIn.TabIndex = 3;
            signIn.Text = "Log In";
            signIn.UseVisualStyleBackColor = true;
            signIn.Click += signIn_Click;
            // 
            // length
            // 
            length.Anchor = AnchorStyles.None;
            length.AutoSize = true;
            length.Location = new Point(94, 530);
            length.Name = "length";
            length.Size = new Size(0, 20);
            length.TabIndex = 4;
            length.Visible = false;
            // 
            // capital
            // 
            capital.Anchor = AnchorStyles.None;
            capital.AutoSize = true;
            capital.Location = new Point(94, 550);
            capital.Name = "capital";
            capital.Size = new Size(0, 20);
            capital.TabIndex = 5;
            capital.Visible = false;
            // 
            // lowercase
            // 
            lowercase.Anchor = AnchorStyles.None;
            lowercase.AutoSize = true;
            lowercase.Location = new Point(94, 570);
            lowercase.Name = "lowercase";
            lowercase.Size = new Size(0, 20);
            lowercase.TabIndex = 6;
            lowercase.Visible = false;
            // 
            // number
            // 
            number.Anchor = AnchorStyles.None;
            number.AutoSize = true;
            number.Location = new Point(94, 590);
            number.Name = "number";
            number.Size = new Size(0, 20);
            number.TabIndex = 7;
            number.Visible = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(332, 507);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 8;
            label1.Visible = false;
            // 
            // changePassword
            // 
            changePassword.AccessibleRole = AccessibleRole.Grip;
            changePassword.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            changePassword.Location = new Point(302, 608);
            changePassword.Margin = new Padding(3, 4, 3, 4);
            changePassword.Name = "changePassword";
            changePassword.Size = new Size(147, 32);
            changePassword.TabIndex = 13;
            changePassword.Text = "Change Password";
            changePassword.UseVisualStyleBackColor = true;
            changePassword.Click += changePassword_click;
            // 
            // ThemeComboBox
            // 
            ThemeComboBox.FormattingEnabled = true;
            ThemeComboBox.Items.AddRange(new object[] { "Light", "Dark" });
            ThemeComboBox.Location = new Point(81, 250);
            ThemeComboBox.Name = "ThemeComboBox";
            ThemeComboBox.Size = new Size(299, 28);
            ThemeComboBox.TabIndex = 14;
            ThemeComboBox.SelectedIndexChanged += ThemeComboBox_SelectionChanged;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 653);
            Controls.Add(ThemeComboBox);
            Controls.Add(label1);
            Controls.Add(number);
            Controls.Add(lowercase);
            Controls.Add(capital);
            Controls.Add(length);
            Controls.Add(signIn);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(changePassword);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(479, 700);
            Name = "LogIn";
            Text = "Log In";
            Load += onLoad;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private TextBox username;
        private TextBox password;
        private Button signIn;
        private Label length;
        private Label capital;
        private Label lowercase;
        private Label number;
        private Label label1;
        private Button changePassword;
        private ComboBox ThemeComboBox;
    }
}