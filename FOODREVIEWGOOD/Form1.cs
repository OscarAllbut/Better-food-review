using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOODREVIEWGOOD
{
    public partial class Form1 : Form
    {
        private const string CONNECT = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"M:\\Visual Studio 2022\\SPECIAL PROJECTS\\Better-food-review\\FoodReviewsDatabase.mdf\";Integrated Security=True;Connect Timeout=30";
        private SqlConnection sqlConnection;
        private bool LoggedIn;
        private string Username;
        private string Placeholde2;

        public Form1()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(CONNECT);
            GetTags();
        }
        
        private void GetTags()
        {
            sqlConnection.Open();

            //setup query
            SqlCommand command = new SqlCommand("SELECT Tag FROM Tags ORDER BY Tag", sqlConnection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    checkedListBoxTags.Items.Add(reader["Tag"], false);
                }
            }
            sqlConnection.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BackgroundPicture.Load("https://thumbs.dreamstime.com/b/balanced-diet-food-background-balanced-diet-food-background-organic-food-healthy-nutrition-superfoods-meat-fish-legumes-nuts-121937194.jpg");
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            sqlConnection.Open();

            //setup query

            SqlCommand command = new SqlCommand("SELECT * FROM Users", sqlConnection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    if ((string)reader["UserName"] == UsernameTextBox.Text || (string)reader["UserEmail"] == UsernameTextBox.Text)
                    {
                        if ((string)reader["UserPassword"] == PasswordTextBox.Text)
                        {
                            LoggedIn = true;
                            Username = UsernameTextBox.Text;
                            break;
                        }
                    }
                }
            }

            sqlConnection.Close();

            if (LoggedIn)

            {
                PasswordLabel.Hide();
                UsernameLabel.Hide();
                UsernameTextBox.Hide();
                PasswordTextBox.Hide();
                SignUpButton.Hide();
                LoginButton.Hide();
                LoginFailLabel.Hide();
                checkedListBoxTags.Show();
                BackgroundPicture.Show();
                ReviewLabel.Show();
                ReviewTextBox.Show();
                PostReviewButton.Show();
                ResterauntListBox.Show();
                StarRatingButton.Show();
                string[] StarRating = new string[5] { "☆", "☆", "☆", "☆", "☆" };
                string VisualStarRating = "";
                
                for (int n = 0; n < 5; n++)     //begin by putting in empty stars
                {
                    VisualStarRating = VisualStarRating + StarRating[n];
                }
                StarRatingButton.Text = VisualStarRating;

            }

            else
            {
                LoginFailLabel.Show();
            }
        }

        private void StarRatingButton_Click(object sender, EventArgs e)
        {

        }
    }


    
}
