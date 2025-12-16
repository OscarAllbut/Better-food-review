namespace FOODREVIEWGOOD
{
    partial class Form1
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
            this.Title = new System.Windows.Forms.Label();
            this.checkedListBoxTags = new System.Windows.Forms.CheckedListBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.LoginFailLabel = new System.Windows.Forms.Label();
            this.BackgroundPicture = new System.Windows.Forms.PictureBox();
            this.FailBackground = new System.Windows.Forms.PictureBox();
            this.ReviewTextBox = new System.Windows.Forms.TextBox();
            this.ReviewLabel = new System.Windows.Forms.Label();
            this.PostReviewButton = new System.Windows.Forms.Button();
            this.ResterauntListBox = new System.Windows.Forms.ListBox();
            this.StarRatingButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FailBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Title.Font = new System.Drawing.Font("Onyx", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Title.Location = new System.Drawing.Point(11, 10);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1075, 96);
            this.Title.TabIndex = 0;
            this.Title.Text = "Food Review";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkedListBoxTags
            // 
            this.checkedListBoxTags.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkedListBoxTags.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkedListBoxTags.FormattingEnabled = true;
            this.checkedListBoxTags.Location = new System.Drawing.Point(20, 190);
            this.checkedListBoxTags.Name = "checkedListBoxTags";
            this.checkedListBoxTags.Size = new System.Drawing.Size(238, 487);
            this.checkedListBoxTags.TabIndex = 1;
            this.checkedListBoxTags.Visible = false;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.BackColor = System.Drawing.Color.Olive;
            this.UsernameLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(363, 191);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(357, 50);
            this.UsernameLabel.TabIndex = 2;
            this.UsernameLabel.Text = "Username:";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.BackColor = System.Drawing.Color.Olive;
            this.PasswordLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(369, 326);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(357, 50);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password:";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.Location = new System.Drawing.Point(336, 256);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(416, 55);
            this.UsernameTextBox.TabIndex = 4;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(336, 396);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(416, 55);
            this.PasswordTextBox.TabIndex = 5;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.LoginButton.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LoginButton.Location = new System.Drawing.Point(336, 508);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(202, 91);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.SignUpButton.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SignUpButton.Location = new System.Drawing.Point(550, 508);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(202, 91);
            this.SignUpButton.TabIndex = 7;
            this.SignUpButton.Text = "SignUp";
            this.SignUpButton.UseVisualStyleBackColor = false;
            // 
            // LoginFailLabel
            // 
            this.LoginFailLabel.BackColor = System.Drawing.Color.OliveDrab;
            this.LoginFailLabel.Font = new System.Drawing.Font("Trebuchet MS", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginFailLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.LoginFailLabel.Location = new System.Drawing.Point(282, 455);
            this.LoginFailLabel.Name = "LoginFailLabel";
            this.LoginFailLabel.Size = new System.Drawing.Size(517, 50);
            this.LoginFailLabel.TabIndex = 8;
            this.LoginFailLabel.Text = "WRONG LOGIN DETAILS!!!";
            this.LoginFailLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LoginFailLabel.Visible = false;
            // 
            // BackgroundPicture
            // 
            this.BackgroundPicture.Location = new System.Drawing.Point(4, 0);
            this.BackgroundPicture.Name = "BackgroundPicture";
            this.BackgroundPicture.Size = new System.Drawing.Size(1091, 698);
            this.BackgroundPicture.TabIndex = 9;
            this.BackgroundPicture.TabStop = false;
            // 
            // FailBackground
            // 
            this.FailBackground.Location = new System.Drawing.Point(8, 4);
            this.FailBackground.Name = "FailBackground";
            this.FailBackground.Size = new System.Drawing.Size(1086, 693);
            this.FailBackground.TabIndex = 10;
            this.FailBackground.TabStop = false;
            this.FailBackground.Visible = false;
            // 
            // ReviewTextBox
            // 
            this.ReviewTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ReviewTextBox.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviewTextBox.Location = new System.Drawing.Point(546, 269);
            this.ReviewTextBox.Multiline = true;
            this.ReviewTextBox.Name = "ReviewTextBox";
            this.ReviewTextBox.Size = new System.Drawing.Size(510, 402);
            this.ReviewTextBox.TabIndex = 11;
            this.ReviewTextBox.Visible = false;
            // 
            // ReviewLabel
            // 
            this.ReviewLabel.BackColor = System.Drawing.Color.Olive;
            this.ReviewLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviewLabel.Location = new System.Drawing.Point(547, 204);
            this.ReviewLabel.Name = "ReviewLabel";
            this.ReviewLabel.Size = new System.Drawing.Size(510, 50);
            this.ReviewLabel.TabIndex = 12;
            this.ReviewLabel.Text = "Write your review:";
            this.ReviewLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ReviewLabel.Visible = false;
            // 
            // PostReviewButton
            // 
            this.PostReviewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.PostReviewButton.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostReviewButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PostReviewButton.Location = new System.Drawing.Point(764, 128);
            this.PostReviewButton.Name = "PostReviewButton";
            this.PostReviewButton.Size = new System.Drawing.Size(292, 59);
            this.PostReviewButton.TabIndex = 13;
            this.PostReviewButton.Text = "Post Review";
            this.PostReviewButton.UseVisualStyleBackColor = false;
            this.PostReviewButton.Visible = false;
            // 
            // ResterauntListBox
            // 
            this.ResterauntListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ResterauntListBox.FormattingEnabled = true;
            this.ResterauntListBox.ItemHeight = 20;
            this.ResterauntListBox.Location = new System.Drawing.Point(278, 191);
            this.ResterauntListBox.Name = "ResterauntListBox";
            this.ResterauntListBox.Size = new System.Drawing.Size(243, 484);
            this.ResterauntListBox.TabIndex = 14;
            this.ResterauntListBox.Visible = false;
            // 
            // StarRatingButton
            // 
            this.StarRatingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.StarRatingButton.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StarRatingButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StarRatingButton.Location = new System.Drawing.Point(555, 605);
            this.StarRatingButton.Name = "StarRatingButton";
            this.StarRatingButton.Size = new System.Drawing.Size(484, 59);
            this.StarRatingButton.TabIndex = 15;
            this.StarRatingButton.Text = "placeholder";
            this.StarRatingButton.UseVisualStyleBackColor = false;
            this.StarRatingButton.Click += new System.EventHandler(this.StarRatingButton_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(1095, 702);
            this.Controls.Add(this.StarRatingButton);
            this.Controls.Add(this.ResterauntListBox);
            this.Controls.Add(this.PostReviewButton);
            this.Controls.Add(this.ReviewLabel);
            this.Controls.Add(this.ReviewTextBox);
            this.Controls.Add(this.LoginFailLabel);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.checkedListBoxTags);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.BackgroundPicture);
            this.Controls.Add(this.FailBackground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FailBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.CheckedListBox checkedListBoxTags;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Label LoginFailLabel;
        private System.Windows.Forms.PictureBox BackgroundPicture;
        private System.Windows.Forms.PictureBox FailBackground;
        private System.Windows.Forms.TextBox ReviewTextBox;
        private System.Windows.Forms.Label ReviewLabel;
        private System.Windows.Forms.Button PostReviewButton;
        private System.Windows.Forms.ListBox ResterauntListBox;
        private System.Windows.Forms.Button StarRatingButton;
    }
}

