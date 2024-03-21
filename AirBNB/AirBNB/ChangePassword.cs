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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AirBNB
{
    public partial class ChangePassword : Form
    {
        public ChangePassword(string theme)
        {
            InitializeComponent(); 
            ApplyTheme(theme);
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


            UpdateControlsForTheme(Controls, ForeColor, BackColor);

        }

        private void UpdateControlsForTheme(Control.ControlCollection controls, Color foreColor, Color backColor)
        {
            foreach (Control control in controls)
            {
                control.ForeColor = foreColor;
                control.BackColor = backColor;

                if (control is System.Windows.Forms.Button)
                {
                    System.Windows.Forms.Button button = (System.Windows.Forms.Button)control;
                    button.FlatAppearance.BorderColor = foreColor;
                    button.FlatAppearance.MouseOverBackColor = ControlPaint.Light(backColor, 0.2f);
                }
                else if (control is System.Windows.Forms.TextBox)
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

        private void onConfirm(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(username.Text) || String.IsNullOrWhiteSpace(password.Text) || String.IsNullOrWhiteSpace(rePassword.Text) || String.IsNullOrWhiteSpace(email.Text)) 
            {
                MessageBox.Show("Fill all empty places to change your password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!rePassword.Text.Equals(password.Text))
                {
                    MessageBox.Show("Password and Re-Password should match and they do not.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (SqlConnection sqlCon = new SqlConnection(@"Data Source=(localdb)\local; Initial Catalog=AirBNB; Integrated Security=True;"))
                {
                    int id = 0;

                    string id_query = "SELECT user_id FROM Users WHERE username = @username AND email = @email;";
                    string query = "UPDATE Users SET password = @password WHERE user_id = @id;";
                    sqlCon.Open();

                    SqlCommand cmd = new SqlCommand(query, sqlCon);

                    SqlCommand sqlCommand = new SqlCommand(id_query, sqlCon);
                    sqlCommand.Parameters.AddWithValue("@username", username.Text);
                    sqlCommand.Parameters.AddWithValue("@email", email.Text);

                    int count = Convert.ToInt32(sqlCommand.ExecuteScalar());

                    if (count != 0)
                    {

                        cmd.Parameters.AddWithValue("@password", password.Text);
                        cmd.Parameters.AddWithValue("@id", count);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Password updated successfully!", "Update Password", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();


                        LogIn logIn = new LogIn();
                        logIn.Show();

                    }
                    else
                    {
                        MessageBox.Show("No such user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    sqlCon.Close();
                    
                }
            }
        }

        private void rePasswordValidating(object sender, CancelEventArgs e)
        {
            if (!rePassword.Text.Equals(password.Text))
            {
                MessageBox.Show("Password and Re-Password should match and they do not.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
