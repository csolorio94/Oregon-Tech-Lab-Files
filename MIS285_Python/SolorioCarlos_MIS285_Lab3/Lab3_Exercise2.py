#Calculate sum of positive integers. Break if negative number, display sum

print('Positive number summation calculator. Enter a negative number to find your sum.')
x = 0
total = 0
sum = 0

#Wanted to say "while infinity"
while sum <= 999999999:
    x = int(input("Enter a positive number: "))
    if x < 0:
        print("Negative number entered, here is your sum: ")
        print(format(sum, ',.1f'))
        break
    sum += x
    