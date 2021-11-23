/* UserInterface.cs
 * Author : Jordan Bui
 */
using System;
using System.Collections.Generic;
using System.Collections;
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
        private string url = "https://www.instagram.com/accounts/login/?hl=en";

        private ArrayList followers = new ArrayList();
        private ArrayList following = new ArrayList();
        private void uxLogIn_Click(object sender, EventArgs e) {
            string login = uxUsername.Text;
            string pass = uxPassword.Text;

            if (login == "") {
                MessageBox.Show("You have to enter a Phone Number, Username, or Email");
            } else if (pass == "") {
                MessageBox.Show("You have to enter a password");
            } else {
                thread = new Thread(LogIn); thread.Start();
                ArrayList notFollowing = CheckLists(followers, following);
                ArrayList notFollowedBackBy = CheckLists(following, followers);
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
        /// Logs the user in with the provided credentials.
        /// </summary>
        private void LogIn() {
            try {
                drv.FindElements(By.XPath("//input[@class='_2hvTZ pexuQ zyHYP']"))[0].SendKeys(uxUsername.Text); Thread.Sleep(200);
                drv.FindElements(By.XPath("//input[@class='_2hvTZ pexuQ zyHYP']"))[0].SendKeys(uxPassword.Text);
                drv.FindElement(By.XPath("//button[@class='sqdOP  L3NKy   y3zKF     ']")).Click();    
                Thread.Sleep(3500);
                CheckFollower();
            } catch (Exception e) {
                MessageBox.Show(e.Message);
            }
        }

        private void CheckFollower() {
            try {
                drv.FindElement(By.XPath("//span[@class='_2dbep qNELH']")).Click(); // Clicks the profile picture
                drv.FindElement(By.XPath("//div[@class='_7UhW9   xLCgt      MMzan  KV-D4              fDxYl     ']")).Click(); // Clicks the profile button
                Thread.Sleep(2000);
                // By this point the program should be on the users home page
                int numFollowers = Convert.ToInt32(drv.FindElements(By.XPath("//span[@class='g47SY ']"))[1].Text);
                int numFollowing = Convert.ToInt32(drv.FindElements(By.XPath("//span[@class='g47SY ']"))[2].Text);
                drv.FindElements(By.XPath("//a[@class='-nal3 ']"))[0].Click(); // Clicks the followers page
                Thread.Sleep(2000); // Needs time for the followers page to load
                ScrollDown();       // Scrolls down the followers
                Thread.Sleep(2000);
                LoadPeople(followers, numFollowers);
                Thread.Sleep(5000);
                drv.FindElement(By.XPath("//svg[@class='_8-yf5 ']")).Click(); // Clicks the X
                MessageBox.Show(followers.Count.ToString());
            } catch (Exception ee) {
                MessageBox.Show(ee.Message);
            }
        }

        /// <summary>
        /// Scrolls down until it reaches the very bottom of the followers/following pages
        /// </summary>
        private void ScrollDown() {
            try {
                IWebElement scrollList = drv.FindElement(By.XPath("//ul[@class='jSC57  _6xe7A']"));    // Holds the element that has the height of the total followers
                IJavaScriptExecutor js = drv; 
                int oldHeight = scrollList.Size.Height;
                Thread.Sleep(500);
                js.ExecuteScript(String.Format("document.querySelector('div[class=\"isgrP\"').scrollTo(0, {0})", scrollList.Size.Height));
                int sleepTime = 1100;
                Thread.Sleep(1000);
                while (oldHeight != scrollList.Size.Height) {
                    Thread.Sleep(sleepTime);
                    sleepTime += 65;
                    js.ExecuteScript(String.Format("document.querySelector('div[class=\"isgrP\"').scrollTo(0, {0})", scrollList.Size.Height));
                    Thread.Sleep(100);
                    oldHeight = scrollList.Size.Height;
                }
            } catch (Exception eeee) {
                MessageBox.Show(eeee.Message);
            }
        }

        /// <summary>
        /// Loads the people into the arrayList after it is done scrolling down
        /// </summary>
        /// <param name="array">Which arraylist to add the people to</param>
        /// <param name="people">How many people it should add</param>
        private void LoadPeople(ArrayList array, int people) {
            for (int i = 0; i < people; i++) {
                array.Add(drv.FindElements(By.XPath("//a[@class='FPmhX notranslate  _0imsa ']"))[i].Text);
            }
        }

        private void uxClear_Click(object sender, EventArgs e) {
            try {
                drv.FindElements(By.XPath("//input[@class='_2hvTZ pexuQ zyHYP']"))[0].Clear();
                drv.FindElements(By.XPath("//input[@class='_2hvTZ pexuQ zyHYP']"))[1].Clear();
            } catch (Exception fd) {
                MessageBox.Show(fd.Message);
            }
        }

        private ArrayList CheckLists(ArrayList first, ArrayList second) {
            // Make this more efficient
            ArrayList names = new ArrayList();
            for (int i = 0; i < first.Count; i++) {
                if (!second.Contains(first[i]))
                    names.Add(first[i]);
            }
            return names;
        }
    }
}
