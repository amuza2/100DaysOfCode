import os
from datetime import datetime

# print(os.getcwd())
os.chdir("/Users/ASUS VIVOBOOK 17/Desktop/ps&ill/youtube work/")
# print(os.getcwd())


# os.makedirs("os_demo2")
# os.mkdir("os_demo/sub_demo")

# os.removedirs("os_demo/sub_demo")
# os.rmdir("os_demo2")

# os.rename("hhhh.jpg", "gag.jpg")

# print(os.listdir())

# time = os.stat("gag.jpg").st_mtime
# print(datetime.fromtimestamp(time))

print(os.environ.get("HOME"))