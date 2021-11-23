
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
            this.uxClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxLogIn
            // 
            this.uxLogIn.Location = new System.Drawing.Point(53, 209);
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
            // uxClear
            // 
            this.uxClear.Location = new System.Drawing.Point(127, 299);
            this.uxClear.Name = "uxClear";
            this.uxClear.Size = new System.Drawing.Size(112, 34);
            this.uxClear.TabIndex = 9;
            this.uxClear.Text = "clear";
            this.uxClear.UseVisualStyleBackColor = true;
            this.uxClear.Click += new System.EventHandler(this.uxClear_Click);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 372);
            this.Controls.Add(this.uxClear);
            this.Controls.Add(this.uxPasswordInfo);
            this.Controls.Add(this.uxUsernameInfo);
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
        private System.Windows.Forms.Label uxUsernameInfo;
        private System.Windows.Forms.Label uxPasswordInfo;
        private System.Windows.Forms.Button uxClear;
    }
}

