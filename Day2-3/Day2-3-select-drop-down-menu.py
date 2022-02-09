from selenium import webdriver
from selenium.webdriver.support.ui import Select
import pandas as pd

website = "https://www.adamchoi.co.uk/overs/detailed"
path = r"C:/SeleniumDrivers/chromedriver.exe"
driver = webdriver.Chrome(path)
driver.get(website)

#find the button
all_matches_button = driver.find_element_by_css_selector('label[analytics-event="All matches"]')
#click on it
all_matches_button.click()

#Select from a drop down menu
drop_down_menu = Select(driver.find_element_by_id("country"))
drop_down_menu.select_by_visible_text("Spain")
#equivalent to time.sleep()
driver.implicitly_wait(5)

#select tables
matches = driver.find_elements_by_css_selector("table.table-bordered")

###Select the 1st table
#Select the 1st column
date = matches[0].find_elements_by_css_selector("tr td:nth-of-type(1)")
#Select the 2nd column
team_1 = matches[0].find_elements_by_css_selector("tr td:nth-of-type(2)")
#Select the 3rd column
goal = matches[0].find_elements_by_css_selector("tr td:nth-of-type(3)")
#Select the 4th column
team_2 = matches[0].find_elements_by_css_selector("tr td:nth-of-type(4)")


l_home, l_date, l_goal, l_away = [], [], [], []
#Add each column to a list
for i in range(len(date)):
	l_date += [date[i].text]
	l_home += [team_1[i].text]
	l_goal += [str(goal[i].text)+"'"]
	l_away += [team_2[i].text]
#Once we finish scraping we close the browser	
driver.quit()

#Create a dict to save the date as csv using pandas
data = {"date":l_date,"home":l_home,"Goals":l_goal,"away":l_away}

df = pd.DataFrame(data)
df.to_csv("matches.csv", index=False)
print(df.head(3))
