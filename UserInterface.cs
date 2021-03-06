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
using System.IO;

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
        /// <summary>
        /// Event handler for the log in button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            drv = new ChromeDriver(Path.Combine(Directory.GetCurrentDirectory(), "chromedriver_win32")); // Loads the chromedriver folder in the current directory
            drv.Navigate().GoToUrl(url);
        }

        /// <summary>
        /// Logs the user in with the provided credentials.
        /// </summary>
        private void LogIn() {
            try {
                drv.FindElements(By.XPath("//input[@class='_2hvTZ pexuQ zyHYP']"))[0].SendKeys(uxUsername.Text); Thread.Sleep(200);
                drv.FindElements(By.XPath("//input[@class='_2hvTZ pexuQ zyHYP']"))[0].SendKeys(uxPassword.Text); Thread.Sleep(200);
                drv.FindElement(By.XPath("//button[@class='sqdOP  L3NKy   y3zKF     ']")).Click();    
                Thread.Sleep(4500);
                CheckFollower();
            } catch (Exception e) {
                drv.FindElements(By.XPath("//input[@class='_2hvTZ pexuQ zyHYP']"))[0].SendKeys(OpenQA.Selenium.Keys.Control + 'a' + OpenQA.Selenium.Keys.Backspace); Thread.Sleep(200);
                drv.FindElements(By.XPath("//input[@class='_2hvTZ pexuQ zyHYP']"))[0].SendKeys(OpenQA.Selenium.Keys.Control + 'a' + OpenQA.Selenium.Keys.Backspace);
                MessageBox.Show("Username or password is invalid 1");
            }
        }

        /// <summary>
        /// This method calls the rest of the methods to load the followers into arrayLists
        /// </summary>
        private void CheckFollower() {
            try {
                drv.FindElement(By.XPath("//span[@class='_2dbep qNELH']")).Click(); Thread.Sleep(200);// Clicks the profile picture
                drv.FindElement(By.XPath("//div[@class='             qF0y9          Igw0E   rBNOH        eGOV_     ybXk5     _4EzTm                                                                                   XfCBB          HVWg4                  -Rt5j ZUqME']")).Click(); Thread.Sleep(200);// Clicks the profile button
                Thread.Sleep(2500);
                // By this point the program should be on the users home page
                int numFollowers = Convert.ToInt32(drv.FindElements(By.XPath("//span[@class='_ac2a _ac2b']"))[1].Text);
                int numFollowing = Convert.ToInt32(drv.FindElements(By.XPath("//span[@class='_ac2a _ac2b']"))[2].Text);
                drv.FindElements(By.XPath("//a[@class='oajrlxb2 g5ia77u1 qu0x051f esr5mh6w e9989ue4 r7d6kgcz rq0escxv nhd2j8a9 nc684nl6 p7hjln8o kvgmc6g5 cxmmr5t8 oygrvhab hcukyx3x jb3vyjys rz4wbd8a qt6c0cv9 a8nywdso i1ao9s8h esuyzwwr f1sip0of lzcic4wl _a6hd']"))[0].Click(); // Clicks the followers page
                Thread.Sleep(2500);                                            // Needs time for the followers page to load
                ScrollDown(numFollowers);                                      // Scrolls down the followers
                LoadPeople(followers, numFollowers);
                drv.FindElements(By.XPath("//button[@class='_abl-']"))[1].Click();// Clicks the X
                drv.FindElements(By.XPath("//a[@class='oajrlxb2 g5ia77u1 qu0x051f esr5mh6w e9989ue4 r7d6kgcz rq0escxv nhd2j8a9 nc684nl6 p7hjln8o kvgmc6g5 cxmmr5t8 oygrvhab hcukyx3x jb3vyjys rz4wbd8a qt6c0cv9 a8nywdso i1ao9s8h esuyzwwr f1sip0of lzcic4wl _a6hd']"))[1].Click(); // Clicks the following page
                Thread.Sleep(2500);                                            // Needs time for the followers page to load
                ScrollDown(numFollowing);                                      // Scrolls down the followers
                LoadPeople(following, numFollowing);
                drv.FindElements(By.XPath("//button[@class='_abl-']"))[1].Click();// Clicks the X
                ArrayList notFollowing = CheckLists(followers, following);     // Fills an ArrayList with names of people who you don't follow back
                ArrayList notFollowedBackBy = CheckLists(following, followers);
                uxFollowers.Text = Names(notFollowing);
                uxFollowing.Text = Names(notFollowedBackBy);
            } catch (Exception ee) {
                //drv.FindElements(By.XPath("//input[@class='_2hvTZ pexuQ zyHYP']"))[0].SendKeys(OpenQA.Selenium.Keys.Control + 'a' + OpenQA.Selenium.Keys.Backspace); Thread.Sleep(200);
                //drv.FindElements(By.XPath("//input[@class='_2hvTZ pexuQ zyHYP']"))[0].SendKeys(OpenQA.Selenium.Keys.Control + 'a' + OpenQA.Selenium.Keys.Backspace);
                MessageBox.Show("Username or password is invalid 2");
            }
        }

        /// <summary>
        /// Scrolls down until it reaches the very bottom of the followers/following pages
        /// </summary>
        private void ScrollDown(int num) {
            try {
                IWebElement scrollList = drv.FindElement(By.XPath("//ul[@class='_aaey']"));    // Holds the element that has the height of the total followers
                IJavaScriptExecutor js = drv; 
                int oldHeight = scrollList.Size.Height;
                int totalHeight = (num * 54) - 54;                                           // Number of followers/following times the height of each bar
                while (oldHeight <= totalHeight) {
                    js.ExecuteScript(String.Format("document.querySelector('div[class=\"_aano\"').scrollTo(0, {0})", scrollList.Size.Height));
                    oldHeight = scrollList.Size.Height;
                }
            } catch (Exception except) {
                MessageBox.Show("Something went wrong when scrolling down. Try restarting the program");
            }
        }

        /// <summary>
        /// Loads the people into the arrayList after it is done scrolling down
        /// </summary>
        /// <param name="array">Which arraylist to add the people to</param>
        /// <param name="people">How many people it should add</param>
        private void LoadPeople(ArrayList array, int people) {
            for (int i = 0; i < people; i++) {
                uxLoader.Text = String.Format("{0}/{1} loaded", i + 1, people);
                array.Add(drv.FindElements(By.XPath("//div[@class='_aaeq']"))[i].Text);
            }
        }

        /// <summary>
        /// Compars the arraylists to see who isn't in the other one
        /// </summary>
        /// <param name="first">First ArrayList being compared</param>
        /// <param name="second">Second ArrayList being compared</param>
        /// <returns>An ArrayList with names of people who are in the first list but not the second list</returns>
        private ArrayList CheckLists(ArrayList first, ArrayList second) {
            // Make this more efficient
            ArrayList names = new ArrayList();
            for (int i = 0; i < first.Count; i++) {
                if (!second.Contains(first[i]))
                    names.Add(first[i]);
            }
            return names;
        }

        /// <summary>
        /// Formats the names in the list 
        /// </summary>
        /// <param name="list">The ArrayList holding the names</param>
        /// <returns>Formatted string</returns>
        private string Names(ArrayList list) {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < list.Count; i++) {
                sb.AppendLine(list[i].ToString());
            }
            return sb.ToString();
        }
    }
}
