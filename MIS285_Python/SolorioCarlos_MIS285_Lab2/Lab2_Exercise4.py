#Display Username(provided code) and if it exists
import win32api
username = win32api.GetUserName()
print (username)

if username == "Carlos":
    print ("username exists")
else:
    print ("username doesnt exist")


#Display computer name
import socket
hostname = socket.gethostname()
print(hostname)

#Display current working path (directory)
import os
cwd = os.getcwd()
print (cwd)