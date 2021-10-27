#Random module
import random

#Access/Create the rng.txt file
randomNumbers = open("rng.txt", "a" )

#Get integer input from user
try:
    for i in range(int(input('Enter the amount of random numbers you want to have: '))):
        numbers = str(random.randint(1, 5000))
        randomNumbers.write(numbers)
        print(numbers)
except ValueError:
#Breaks if given input is not integer

    randomNumbers.close()