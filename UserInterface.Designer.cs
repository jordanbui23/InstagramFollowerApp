
namespace InstagramFollowerApp {
    partial class UserInterface {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
            this.uxLogIn = new System.Windows.Forms.Button();
            this.uxFollowers = new System.Windows.Forms.TextBox();
            this.uxUsername = new System.Windows.Forms.TextBox();
            this.uxPassword = new System.Windows.Forms.TextBox();
            this.uxUsernameInfo = new System.Windows.Forms.Label();
            this.uxPasswordInfo = new System.Windows.Forms.Label();
            this.uxFollowing = new System.Windows.Forms.TextBox();
            this.uxFollowerLabel = new System.Windows.Forms.Label();
            this.uxFollowingLabel = new System.Windows.Forms.Label();
            this.uxLoaderLabel = new System.Windows.Forms.Label();
            this.uxLoader = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxLogIn
            // 
            this.uxLogIn.Location = new System.Drawing.Point(56, 219);
            this.uxLogIn.Name = "uxLogIn";
            this.uxLogIn.Size = new System.Drawing.Size(198, 44);
            this.uxLogIn.TabIndex = 0;
            this.uxLogIn.Text = "Log In";
            this.uxLogIn.UseVisualStyleBackColor = true;
            this.uxLogIn.Click += new System.EventHandler(this.uxLogIn_Click);
            // 
            // uxFollowers
            // 
            this.uxFollowers.Location = new System.Drawing.Point(315, 65);
            this.uxFollowers.Multiline = true;
            this.uxFollowers.Name = "uxFollowers";
            this.uxFollowers.ReadOnly = true;
            this.uxFollowers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxFollowers.Size = new System.Drawing.Size(287, 348);
            this.uxFollowers.TabIndex = 1;
            // 
            // uxUsername
            // 
            this.uxUsername.Location = new System.Drawing.Point(11, 100);
            this.uxUsername.Name = "uxUsername";
            this.uxUsername.Size = new System.Drawing.Size(297, 31);
            this.uxUsername.TabIndex = 2;
            // 
            // uxPassword
            // 
            this.uxPassword.Location = new System.Drawing.Point(11, 172);
            this.uxPassword.Name = "uxPassword";
            this.uxPassword.PasswordChar = '*';
            this.uxPassword.Size = new System.Drawing.Size(297, 31);
            this.uxPassword.TabIndex = 3;
            // 
            // uxUsernameInfo
            // 
            this.uxUsernameInfo.AutoSize = true;
            this.uxUsernameInfo.Location = new System.Drawing.Point(13, 65);
            this.uxUsernameInfo.Name = "uxUsernameInfo";
            this.uxUsernameInfo.Size = new System.Drawing.Size(296, 25);
            this.uxUsernameInfo.TabIndex = 7;
            this.uxUsernameInfo.Text = "Username, Phone Number, Or Email";
            // 
            // uxPasswordInfo
            // 
            this.uxPasswordInfo.AutoSize = true;
            this.uxPasswordInfo.Location = new System.Drawing.Point(111, 144);
            this.uxPasswordInfo.Name = "uxPasswordInfo";
            this.uxPasswordInfo.Size = new System.Drawing.Size(87, 25);
            this.uxPasswordInfo.TabIndex = 8;
            this.uxPasswordInfo.Text = "Password";
            // 
            // uxFollowing
            // 
            this.uxFollowing.Location = new System.Drawing.Point(623, 65);
            this.uxFollowing.Multiline = true;
            this.uxFollowing.Name = "uxFollowing";
            this.uxFollowing.ReadOnly = true;
            this.uxFollowing.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxFollowing.Size = new System.Drawing.Size(287, 348);
            this.uxFollowing.TabIndex = 10;
            // 
            // uxFollowerLabel
            // 
            this.uxFollowerLabel.AutoSize = true;
            this.uxFollowerLabel.Location = new System.Drawing.Point(623, 27);
            this.uxFollowerLabel.Name = "uxFollowerLabel";
            this.uxFollowerLabel.Size = new System.Drawing.Size(245, 25);
            this.uxFollowerLabel.TabIndex = 11;
            this.uxFollowerLabel.Text = "Who doesn\'t follow you back\r\n";
            // 
            // uxFollowingLabel
            // 
            this.uxFollowingLabel.AutoSize = true;
            this.uxFollowingLabel.Location = new System.Drawing.Point(315, 27);
            this.uxFollowingLabel.Name = "uxFollowingLabel";
            this.uxFollowingLabel.Size = new System.Drawing.Size(228, 25);
            this.uxFollowingLabel.TabIndex = 12;
            this.uxFollowingLabel.Text = "Who you don\'t follow back";
            // 
            // uxLoaderLabel
            // 
            this.uxLoaderLabel.AutoSize = true;
            this.uxLoaderLabel.Location = new System.Drawing.Point(109, 344);
            this.uxLoaderLabel.Name = "uxLoaderLabel";
            this.uxLoaderLabel.Size = new System.Drawing.Size(81, 25);
            this.uxLoaderLabel.TabIndex = 13;
            this.uxLoaderLabel.Text = "Progress";
            // 
            // uxLoader
            // 
            this.uxLoader.Location = new System.Drawing.Point(67, 372);
            this.uxLoader.Name = "uxLoader";
            this.uxLoader.ReadOnly = true;
            this.uxLoader.Size = new System.Drawing.Size(169, 31);
            this.uxLoader.TabIndex = 14;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 425);
            this.Controls.Add(this.uxLoader);
            this.Controls.Add(this.uxLoaderLabel);
            this.Controls.Add(this.uxFollowingLabel);
            this.Controls.Add(this.uxFollowerLabel);
            this.Controls.Add(this.uxFollowing);
            this.Controls.Add(this.uxPasswordInfo);
            this.Controls.Add(this.uxUsernameInfo);
            this.Controls.Add(this.uxPassword);
            this.Controls.Add(this.uxUsername);
            this.Controls.Add(this.uxFollowers);
            this.Controls.Add(this.uxLogIn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserInterface";
            this.Text = "Instagram Followers Tracker";
            this.Load += new System.EventHandler(this.UserInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxLogIn;
        private System.Windows.Forms.TextBox uxFollowers;
        private System.Windows.Forms.TextBox uxUsername;
        private System.Windows.Forms.TextBox uxPassword;
        private System.Windows.Forms.Label uxUsernameInfo;
        private System.Windows.Forms.Label uxPasswordInfo;
        private System.Windows.Forms.TextBox uxFollowing;
        private System.Windows.Forms.Label uxFollowerLabel;
        private System.Windows.Forms.Label uxFollowingLabel;
        private System.Windows.Forms.Label uxLoaderLabel;
        private System.Windows.Forms.TextBox uxLoader;
    }
}

