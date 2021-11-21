/* UserInterface.cs
 * Author : Jordan Bui
 * Start - November 19, 2021
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace InstagramFollowerApp {
    public partial class UserInterface : Form {
        public UserInterface() {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        ChromeDriver drv; Thread thread;
        string url = "https://www.instagram.com/accounts/login/?hl=en";
        private void uxLogIn_Click(object sender, EventArgs e) {
            string login = uxUsername.Text;
            string pass = uxPassword.Text;
            
            if (login == "") {
                MessageBox.Show("You have to enter a Phone Number, Username, or Email");
            } else if (pass == "") {
                MessageBox.Show("You have to enter a password");
            } else {
                thread = new Thread(LogIn); thread.Start();
            }

        }

        /// <summary>
        /// Loads up the chrome driver when the user starts the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserInterface_Load(object sender, EventArgs e) {
            // I had to install the chrome driver for my version of chrome. This might make it harder for others to use
            drv = new ChromeDriver("C:/Users/jorda/OneDrive/Desktop/Instagram App/InstagramFollowerApp/chromedriver_win32");
            drv.Navigate().GoToUrl(url);
        }

        /// <summary>
        /// Logs the user in.
        /// </summary>
        private void LogIn() {
            try {
                drv.FindElements(By.XPath("//input[@class='_2hvTZ pexuQ zyHYP']"))[0].SendKeys(uxUsername.Text); Thread.Sleep(200);
                //drv.FindElement(By.XPath("//button[@class='_4_yKc']")).Click();
                drv.FindElements(By.XPath("//input[@class='_2hvTZ pexuQ zyHYP']"))[0].SendKeys(uxPassword.Text);
                drv.FindElement(By.XPath("//button[@class='sqdOP  L3NKy   y3zKF     ']")).Click();

                //MessageBox.Show(drv.Url); Used these to debug the log in
                //drv.Url = "https://www.instagram.com/accounts/onetap/?next=%2F&hl=en";
                //MessageBox.Show(drv.Url);
                /*
                if (drv.FindElements(By.XPath("//div[@class='pV7Qt         DPiy6    qF0y9          Igw0E     IwRSH      eGOV_         _4EzTm                                                                                                               qhGB0 ZUqME']")).Count > 0) {
                    MessageBox.Show("Success");
                } else {
                    uxPassword.Text = "";
                    uxUsername.Text = "";
                    MessageBox.Show("Username or Password is incorrect");
                }
                */
            } catch (Exception e) {
                MessageBox.Show("Something went wrong. Try again.");
            }
        }

        private void uxCheckFollower_Click(object sender, EventArgs e) {
            try {
                drv.FindElement(By.XPath("//span[@class='_2dbep qNELH']")).Click(); // Clicks the profile picture
                drv.FindElement(By.XPath("//div[@class='_7UhW9   xLCgt      MMzan  KV-D4              fDxYl     ']")).Click(); // Clicks the profile button
                drv.FindElements(By.XPath("//a[@class='-nal3 ']"))[0].Click(); // Clicks the followers
                //drv.FindElements(By.XPath("//a[@class='-nal3 ']"))[1].Click(); // Clicks the following
                // followers/following a class -nal3 
                // following/followers li Y8-fY 
                // follower specific FPmhX notranslate  _0imsa 
                // follower specific FPmhX notranslate  _0imsa
            } catch (Exception ee) {
                MessageBox.Show("Something went wrong. Try re running the program.");
            }
 
        }

        private void uxAddFollower_Click(object sender, EventArgs e) {
            try {
                IJavaScriptExecutor js = (IJavaScriptExecutor)drv;
                MessageBox.Show(drv.FindElements(By.XPath("//span[@class='g47SY ']"))[0].Text); // The amount of followers
                int SCROLL_PAUSE_TIME = 1;

                // Get scroll height
                string last_height = (string)js.ExecuteScript("return document.body.scrollHeight");

                while (true) {
                    // Scroll down to bottom
                    js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");

                    // Wait to load page
                    Thread.Sleep(SCROLL_PAUSE_TIME);

                    // Calculate new scroll height and compare with last scroll height
                    string new_height = (string)js.ExecuteScript("return document.body.scrollHeight");
                    if (new_height == last_height)
                        break;
                    last_height = new_height;
                }
                MessageBox.Show(drv.FindElements(By.XPath("//a[@class='FPmhX notranslate  _0imsa ']"))[0].Text); // Gets the username
                //Jv7Aj mArmR MqpiF  
            } catch (Exception eee) {
                MessageBox.Show("Something went wrong. SUCKS");
            }

        }
    }
}
