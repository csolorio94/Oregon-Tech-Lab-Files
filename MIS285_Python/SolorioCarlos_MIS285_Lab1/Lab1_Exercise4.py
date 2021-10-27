# Exercise 4: copy paste example. import/output 
import wmi
c = wmi.WMI()
for os in c.Win32_OperatingSystem():
    print (os.Caption)

# I assume by "create a new script" you mean "create a new file". comes up with an error on line 5. print needs to be further defined, maybe?