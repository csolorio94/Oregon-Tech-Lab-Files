#Display Username(provided code) and whether or not it exists

import win32api
username = win32api.GetUserName()
print (username)

if username == "Carlos":
    print ("username exists")
else:
    print ("username doesnt exist")

