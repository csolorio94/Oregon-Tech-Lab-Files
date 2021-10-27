#Begin Wifi troubleshooting
print('Welcome to the Wifi fixer 9000.')
begin = input("Reboot the computer and try to connect. Did that fix the problem? Yes/No: ")

#If answer yes, end program with you're welcome. Otherwise, proceed to the next step
if begin == "Yes" or begin == "yes":
  print("You're welcome.")
else:
  router = input("Reboot the router and try to connect. Did that fix the problem? Yes/No: ")
  if router == "Yes" or router == "yes":
    print("You're welcome.")
  else:
    cables = input("Make sure the cables between the router & modem are plugged in firmly. Did that fix the problem? Yes/No: ")
    if cables == "Yes" or cables == "yes":
      print("You're welcome.")
    else:
      location = input("Move the router to a new location and try to connect. Did that fix the problem? Yes/No: ")
      if location == "Yes" or location == "yes":
        print("You're welcome.")
      else:
        print("Get a new router.")