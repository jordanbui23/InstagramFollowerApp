# InstagramFollowerApp
This is a Windows Forms App that will take in user input for an Instagram Log In and tell the user who does not follow them back on Instagram. See more information about this app on my website.

# Packages Required
- Selenium.WebDriver
- Selenium.Support
- Selenium.Chrome.WebDriver

# Problems I Ran Into
- There was an error with using a different version of ChromeDriver compared to what my laptop was using
  - I bypassed this by downloading my laptop's version of ChromeDriver and referencing the downloaded version
- When trying to put all of the code in the log in button it ran too fast and the page couldn't load fast enough
  - Instead of using Thread.Sleep() I just created separate buttons that have different uses
- When the program clicks on the followers or following it only loads 12 elements at first. This is because it implements a dynamically infinite scrolling page.
  - I had to google a lot of information on how scroll within a web element until it reaches the buttom of the page
