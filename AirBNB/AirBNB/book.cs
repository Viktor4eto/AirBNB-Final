using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AirBNB
{
    public partial class book : Form
    {
        public book(string theme)
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

        private void reserve_Click(object sender, EventArgs e)
        {

            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=(localdb)\local; Initial Catalog=AirBNB; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection

                // Check if the room is available
                string availabilityQuery = "SELECT is_available FROM Apartments WHERE apartment_id = @apartment_id";

                SqlCommand availabilityCmd = new SqlCommand(availabilityQuery, sqlCon);
                availabilityCmd.Parameters.AddWithValue("@apartment_id", apartmentId.Text);
                bool availabilityResult = (bool)availabilityCmd.ExecuteScalar();

                if (availabilityResult)
                {
                    // Room is available, proceed with booking
                    string guestQuery = "SELECT user_id FROM Users WHERE username = @username";


                    SqlCommand guestCommand = new SqlCommand(guestQuery, sqlCon);
                    guestCommand.Parameters.AddWithValue("@username", username.Text);
                    int guestId = (int)guestCommand.ExecuteScalar();



                    string insertQuery = "INSERT INTO NewBookings (guest_id, apartment_id, check_in_date, check_out_date) VALUES (@guestId, @apartment_id, @checkIn, @checkOut)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, sqlCon);

                    // Set parameters based on selected values
                    insertCmd.Parameters.AddWithValue("@apartment_id", apartmentId.Text);
                    insertCmd.Parameters.AddWithValue("@guestId", guestId);
                    insertCmd.Parameters.AddWithValue("@checkIn", checkIn.Value);
                    insertCmd.Parameters.AddWithValue("@checkOut", checkOut.Value);

                    insertCmd.ExecuteNonQuery();

                    // Update room availability status
                    string updateAvailabilityQuery = "UPDATE Apartments SET is_available = 0 WHERE apartment_id = @apartment_id";
                    SqlCommand updateAvailabilityCmd = new SqlCommand(updateAvailabilityQuery, sqlCon);
                    updateAvailabilityCmd.Parameters.AddWithValue("@apartment_id", apartmentId.Text);
                    updateAvailabilityCmd.ExecuteNonQuery();

                    MessageBox.Show("Reservation Successful!");
                    
                }
                else
                {
                    // Room is not available
                    MessageBox.Show("Sorry, the apartment is not available for reservation.");
                }
            }


        }

        public bool ValidatePhoneNumber(string phoneNumber)
        {
            // Define a regular expression pattern for a typical phone number format
            // This pattern allows for optional hyphens, parentheses, and spaces
            string pattern = @"^\(?\d{3}\)?[-.\s]?\d{3}[-.\s]?\d{4}$";

            // Create a Regex object with the pattern
            Regex regex = new Regex(pattern);

            // Use the IsMatch method to check if the input matches the pattern
            return regex.IsMatch(phoneNumber);
        }

        private void phone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {


            if (phone.Text != string.Empty)
            {
                if (!ValidatePhoneNumber(phone.Text))
                {
                    MessageBox.Show("Phone is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    phone.SelectAll();
                    e.Cancel = true;
                }
            }
        }
    }
}
