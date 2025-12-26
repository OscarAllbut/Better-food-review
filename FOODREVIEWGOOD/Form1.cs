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
        //                                                                                     M:\\Visual Studio 2022\\SPECIAL PROJECTS
        //                                                                                     C:\Users\oscar\Documents\GitHub Repos\OscarAllbut\Better-food-review
        private const string CONNECT = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\oscar\\Documents\\GitHub Repos\\OscarAllbut\\Better-food-review\\FoodReviewsDatabase.mdf\";Integrated Security=True;Connect Timeout=30";
        private SqlConnection sqlConnection;
        private bool LoggedIn;
        private string Username;
        private int StarCount = 0;
        string[] StarRating = new string[5] { "☆", "☆", "☆", "☆", "☆" };
        string VisualStarRating = "";

        public Form1()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(CONNECT);
            PasswordTextBox.UseSystemPasswordChar = true;
            GetTags();
        }

        private void GetTags()   //get tags method for sql stuff
        {
            sqlConnection.Open();

            //setup query                          command text                  just referencing a generic sql connection
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


        private void LoginButton_Click(object sender, EventArgs e)//login event
        {

            sqlConnection.Open();//open the connection

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
                RestaurantListBox.Show();
                StarRatingButton.Show();
                StarRatingButton.BringToFront();
                LeaveAReviewLabel.Show();
                LeaveAReviewLabel.BringToFront();



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
        
        private void StarRatingButton_Click_1(object sender, EventArgs e)
        {
            if (StarCount < 5)
            {
                StarRating[StarCount] = "★";    // fill each star in 1 by 1
                StarCount++;
            }
            else
            {
                StarCount = 0;
                for (int n = 0; n < 5; n++)
                {
                    StarRating[n] = "☆"; //reset to blank stars
                }
            }
            if (StarCount == 0)
            {
                LeaveAReviewLabel.Show();
            }
            else
            {
                LeaveAReviewLabel.Hide();
            }
                VisualStarRating = "";
            for (int n = 0; n < 5; n++)   // putting each star into the string and displaying it on the button
            {
                VisualStarRating = VisualStarRating + StarRating[n];
            }
            StarRatingButton.Text = VisualStarRating;
            
        }


        private void checkedListBoxTags_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                sqlConnection.Open();//open the connection

                //setup query                          command text                  just referencing a generic sql connection
                SqlCommand command = new SqlCommand("SELECT Tag FROM Tags ORDER BY Tag", sqlConnection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        RestaurantListBox.Items.Add(reader["Tag"]);
                    }
                }
                sqlConnection.Close();
            }
            else
            {
                RestaurantListBox.Items.Clear();
            }

            
        }
    }
}
