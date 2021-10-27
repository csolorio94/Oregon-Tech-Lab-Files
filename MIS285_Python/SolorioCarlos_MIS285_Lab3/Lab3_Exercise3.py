#allows user input in IP format i.e. 192.168.255.252 and 192.169.0.1

#Couldnt figure out how to do it without periods if that was required
import ipaddress
    
firstIP = ipaddress.IPv4Address(input('Enter the first IP Address: '))
lastIP = ipaddress.IPv4Address(input('Enter last IP address: '))
print('These are the IP addresses between the two provided:')
for x in range(int(firstIP), int(lastIP)):
    print(ipaddress.IPv4Address(x))

#This is the closest I could get to simulating your results    