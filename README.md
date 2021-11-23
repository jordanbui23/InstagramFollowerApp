# InstagramFollowerApp
This is a Windows Forms App that will take in user input for an Instagram Log In and tell the user who does not follow them back on Instagram. See more information about this app on my website.

# How to use
1. Run the program
2. A terminal will pop up. Ignore this, but do not delete it.
3. Enter your instagram credentials in the Windows Forms not the actual web page.
4. Wait for program to run. There will be a progress bar under the Log In button

# Things to note
- When testing the program on my account it took 9 minutes to fully finish. This is with roughly 500 followers and 500 following
- The program will take much longer the more followers you have
- The program will not run if you have two factor authentication on

# Packages Required
- Selenium.WebDriver
- Selenium.Support
- Selenium.Chrome.WebDriver

# Problems I Ran Into
- There was an error with using a different version of ChromeDriver compared to what my laptop was using
  - I bypassed this by downloading my laptop's version of ChromeDriver and referencing the downloaded version
- When trying to put all of the code in the log in button it ran too fast and the page couldn't load fast enough
  - I had to write Thread.Sleep() functions in a lot of places to keep the program from running too fast
- When the program clicks on the followers or following it only loads 12 elements at first. This is because it implements a dynamically infinite scrolling page.
  - I had to google a lot of information on how scroll within a web element until it reaches the buttom of the page
  - The scrolling within the web element took about 4 hours to figure out
