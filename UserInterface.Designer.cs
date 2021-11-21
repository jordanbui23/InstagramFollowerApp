
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
            this.uxCheckFollower = new System.Windows.Forms.Button();
            this.uxUsernameInfo = new System.Windows.Forms.Label();
            this.uxPasswordInfo = new System.Windows.Forms.Label();
            this.uxFollowerButtonInfo = new System.Windows.Forms.Label();
            this.uxAddFollower = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxLogIn
            // 
            this.uxLogIn.Location = new System.Drawing.Point(53, 178);
            this.uxLogIn.Name = "uxLogIn";
            this.uxLogIn.Size = new System.Drawing.Size(198, 44);
            this.uxLogIn.TabIndex = 0;
            this.uxLogIn.Text = "Log In";
            this.uxLogIn.UseVisualStyleBackColor = true;
            this.uxLogIn.Click += new System.EventHandler(this.uxLogIn_Click);
            // 
            // uxFollowers
            // 
            this.uxFollowers.Location = new System.Drawing.Point(315, 12);
            this.uxFollowers.Multiline = true;
            this.uxFollowers.Name = "uxFollowers";
            this.uxFollowers.ReadOnly = true;
            this.uxFollowers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxFollowers.Size = new System.Drawing.Size(287, 348);
            this.uxFollowers.TabIndex = 1;
            // 
            // uxUsername
            // 
            this.uxUsername.Location = new System.Drawing.Point(12, 45);
            this.uxUsername.Name = "uxUsername";
            this.uxUsername.Size = new System.Drawing.Size(297, 31);
            this.uxUsername.TabIndex = 2;
            // 
            // uxPassword
            // 
            this.uxPassword.Location = new System.Drawing.Point(12, 137);
            this.uxPassword.Name = "uxPassword";
            this.uxPassword.Size = new System.Drawing.Size(297, 31);
            this.uxPassword.TabIndex = 3;
            // 
            // uxCheckFollower
            // 
            this.uxCheckFollower.Location = new System.Drawing.Point(73, 258);
            this.uxCheckFollower.Name = "uxCheckFollower";
            this.uxCheckFollower.Size = new System.Drawing.Size(160, 43);
            this.uxCheckFollower.TabIndex = 6;
            this.uxCheckFollower.Text = "Check Followers";
            this.uxCheckFollower.UseVisualStyleBackColor = true;
            this.uxCheckFollower.Click += new System.EventHandler(this.uxCheckFollower_Click);
            // 
            // uxUsernameInfo
            // 
            this.uxUsernameInfo.AutoSize = true;
            this.uxUsernameInfo.Location = new System.Drawing.Point(12, 17);
            this.uxUsernameInfo.Name = "uxUsernameInfo";
            this.uxUsernameInfo.Size = new System.Drawing.Size(296, 25);
            this.uxUsernameInfo.TabIndex = 7;
            this.uxUsernameInfo.Text = "Username, Phone Number, Or Email";
            // 
            // uxPasswordInfo
            // 
            this.uxPasswordInfo.AutoSize = true;
            this.uxPasswordInfo.Location = new System.Drawing.Point(102, 109);
            this.uxPasswordInfo.Name = "uxPasswordInfo";
            this.uxPasswordInfo.Size = new System.Drawing.Size(87, 25);
            this.uxPasswordInfo.TabIndex = 8;
            this.uxPasswordInfo.Text = "Password";
            // 
            // uxFollowerButtonInfo
            // 
            this.uxFollowerButtonInfo.AutoSize = true;
            this.uxFollowerButtonInfo.Location = new System.Drawing.Point(24, 230);
            this.uxFollowerButtonInfo.Name = "uxFollowerButtonInfo";
            this.uxFollowerButtonInfo.Size = new System.Drawing.Size(260, 25);
            this.uxFollowerButtonInfo.TabIndex = 9;
            this.uxFollowerButtonInfo.Text = "Click Button Below If Logged In";
            // 
            // uxAddFollower
            // 
            this.uxAddFollower.Location = new System.Drawing.Point(12, 326);
            this.uxAddFollower.Name = "uxAddFollower";
            this.uxAddFollower.Size = new System.Drawing.Size(142, 34);
            this.uxAddFollower.TabIndex = 10;
            this.uxAddFollower.Text = "Add Follower";
            this.uxAddFollower.UseVisualStyleBackColor = true;
            this.uxAddFollower.Click += new System.EventHandler(this.uxAddFollower_Click);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 372);
            this.Controls.Add(this.uxAddFollower);
            this.Controls.Add(this.uxFollowerButtonInfo);
            this.Controls.Add(this.uxPasswordInfo);
            this.Controls.Add(this.uxUsernameInfo);
            this.Controls.Add(this.uxCheckFollower);
            this.Controls.Add(this.uxPassword);
            this.Controls.Add(this.uxUsername);
            this.Controls.Add(this.uxFollowers);
            this.Controls.Add(this.uxLogIn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserInterface";
            this.Text = "Instagram Followers Form";
            this.Load += new System.EventHandler(this.UserInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxLogIn;
        private System.Windows.Forms.TextBox uxFollowers;
        private System.Windows.Forms.TextBox uxUsername;
        private System.Windows.Forms.TextBox uxPassword;
        private System.Windows.Forms.Button uxCheckFollower;
        private System.Windows.Forms.Label uxUsernameInfo;
        private System.Windows.Forms.Label uxPasswordInfo;
        private System.Windows.Forms.Label uxFollowerButtonInfo;
        private System.Windows.Forms.Button uxAddFollower;
    }
}

