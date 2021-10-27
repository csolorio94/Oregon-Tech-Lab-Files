import subprocess
import os

print('IP Addresses: ', file = open('addresses_file.txt', 'a')) 
printChoice = input('Would you like to print the addresses to a text file? y = yes, anything else = no: ')
       
if printChoice == 'y':
    with open(os.devnull, "wb") as limbo:
        for n in range(1, 100):
            ip="192.168.1.{0}".format(n)
            result=subprocess.Popen(["ping", "-n", "1", "-w", "200", ip],
                stdout=limbo, stderr=limbo).wait()
            if result:
                print (ip + " inactive", file = open('addresses_file.txt', 'a'))
            else:
                print (ip + " active", file = open('addresses_file.txt', 'a'))
else:            
    with open(os.devnull, "wb") as limbo:
        for n in range(1, 100):
            ip="192.168.1.{0}".format(n)
            result=subprocess.Popen(["ping", "-n", "1", "-w", "200", ip],
                stdout=limbo, stderr=limbo).wait()
            if result:
                print (ip + ' inactive')
            else:
                print (ip + ' active')

lookup = 'active'
with open('addresses_file.txt') as myFile:
    for num, line in enumerate(myFile, 1):
        if lookup in line:
            print ('active found at line:', num)           

lookup = 'inactive'
with open('addresses_file.txt') as myFile:
    for num, line in enumerate(myFile, 1):
        if lookup in line:
            print ('inactive found at line:', num)    