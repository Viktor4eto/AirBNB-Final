using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AirBNB.authenticate;

namespace AirBNB
{
    public partial class LogIn : Form
    {
        public string theme;

        private SqlConnection sqlCon;

        public LogIn()
        {
            InitializeComponent();
            ApplyTheme("Light");
        }

        private void ApplyTheme(string theme)
        {

            switch (theme)
            {
                case "Light":
                    BackColor = SystemColors.Control;
                    ForeColor = SystemColors.ControlText;
                    break;
                case "Dark":
                    BackColor = Color.FromArgb(10, 10, 10);
                    ForeColor = Color.White;
                    break;
            }

            this.theme = theme;
            UpdateControlsForTheme(Controls, ForeColor, BackColor);

        }

        private void UpdateControlsForTheme(Control.ControlCollection controls, Color foreColor, Color backColor)
        {
            foreach (Control control in controls)
            {
                control.ForeColor = foreColor;
                control.BackColor = backColor;

                if (control is Button)
                {
                    Button button = (Button)control;
                    button.FlatAppearance.BorderColor = foreColor;
                    button.FlatAppearance.MouseOverBackColor = ControlPaint.Light(backColor, 0.2f);
                }
                else if (control is TextBox || control is ComboBox || control is ListBox || control is DataGridView)
                {
                    // Update text-based control properties
                    control.ForeColor = foreColor;
                    control.BackColor = backColor;
                }

                // Recursively update properties for child controls
                if (control.HasChildren)
                {
                    UpdateControlsForTheme(control.Controls, foreColor, backColor);
                }
            }
        }



        private void signIn_Click(object sender, EventArgs e)
        {
            string user = username.Text;
            string pass = password.Text;

            // Validate input before attempting authentication
            if (!string.IsNullOrWhiteSpace(user) && !string.IsNullOrWhiteSpace(pass))
            {
                User authenticatedUser = DatabaseManager.AuthenticateUser(user, pass);

                if (authenticatedUser != null)
                {
                    // Display the username on Form5
                    Form1 welcome = new Form1(authenticatedUser, theme);
                    welcome.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            else
            {
                MessageBox.Show("Please enter both username and password.");
            }

        }
        private void changePassword_click(object sender, EventArgs e)
        {
            ChangePassword pass = new ChangePassword(theme);
            pass.Show();
            this.Hide();
        }

        private void onLoad(object sender, EventArgs e)
        {
            try
            {
                sqlCon = new SqlConnection(@"Data Source=(localdb)\local; Initial Catalog=AirBNB; Integrated Security=True;");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void ThemeComboBox_SelectionChanged(object sender, EventArgs e)
        {
            // Get the selected theme from the dropdown
            if (ThemeComboBox.SelectedItem != null)
            {
                string selectedTheme = (string)ThemeComboBox.SelectedItem;
                ApplyTheme(selectedTheme);
            }
        }

    }

}


