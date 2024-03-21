using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data;
using System.Data.SqlClient;
using static AirBNB.authenticate;

namespace AirBNB
{
    public partial class Form1 : Form
    {

        private User user;
        private string theme;
        public Form1(User user, string theme)
        {
            InitializeComponent();
            this.user = user;
            this.theme = theme;
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
                else if (control is ListBox || control is DataGridView)
                {
                    // Update text-based control properties
                    control.ForeColor = Color.Black;
                    control.BackColor = backColor;
                }

                // Recursively update properties for child controls
                if (control.HasChildren)
                {
                    UpdateControlsForTheme(control.Controls, foreColor, backColor);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=(localdb)\local; Initial Catalog=AirBNB; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection

                // Start with a base SQL query
                string query = "SELECT * FROM Apartments WHERE 1 = 1";

                // Create a list to store the conditions for filtering
                List<string> conditions = new List<string>();

                // Check each ComboBox and add a condition if an item is selected
                if (location.SelectedItem != null)
                    conditions.Add("location = @location");

                if (bedrooms.SelectedItem != null)
                    conditions.Add("num_bedrooms = @num_bedrooms");

                if (availability.SelectedItem != null)
                    conditions.Add("is_available = @is_available");

                if (price.SelectedItem != null)
                    conditions.Add("price_per_night = @price");

                // combine the conditions into the SQL query
                if (conditions.Count > 0)
                {
                    query += " AND " + string.Join(" AND ", conditions);
                }

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                if (location.SelectedItem != null)
                    cmd.Parameters.AddWithValue("@location", location.SelectedItem.ToString());

                if (bedrooms.SelectedItem != null)
                    cmd.Parameters.AddWithValue("@num_bedrooms", bedrooms.SelectedItem.ToString());

                if (availability.SelectedItem != null)
                    cmd.Parameters.AddWithValue("@is_available", availability.SelectedItem.ToString());

                if (price.SelectedItem != null)
                    cmd.Parameters.AddWithValue("@price", price.SelectedItem.ToString());

                // Set parameters based on selected values

                // Use SqlDataAdapter to fetch data and populate DataGridView
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;
                }
            }


        }
        private void clear_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            location.SelectedIndex = -1;
            availability.SelectedIndex = -1;
            bedrooms.SelectedIndex = -1;
            price.SelectedIndex = -1;
        }

        private void book_Click(object sender, EventArgs e)
        {
            using (book userInputForm = new book(this.theme))
            {
                // Display the form as a dialog
                userInputForm.ShowDialog();

            }
        }



        private void delete_click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user confirms the deletion, proceed with deletion
            if (result == DialogResult.Yes)
            {
                using (SqlConnection sqlCon = new SqlConnection(@"Data Source=(localdb)\local; Initial Catalog=AirBNB; Integrated Security=True;"))
                {
                    string query = "DELETE FROM Users WHERE user_id = @id";
                    sqlCon.Open();

                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    cmd.Parameters.AddWithValue("@id", this.user.id);
                    cmd.ExecuteNonQuery();

                    sqlCon.Close();

                    this.Close();

                    MessageBox.Show("User deleted successfully!", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LogIn logIn = new LogIn();
                    logIn.Show();
                }
                

            }
        }
    }
}