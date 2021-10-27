# Define numbers used for days of week

num1 = 1
num2 = 2
num3 = 3
num4 = 4
num5 = 5
num6 = 6
num7 = 7

# Get number from user 1-7
number = int(input('Enter a number between 1 and 7 for a day of the week. '))

# Determine day of week
if number == num1:
    print('You entered 1. This corresponds to Monday.')
else:
    if number == num2:
        print('You entered 2. This corresponds to Tuesday.')
    else:
        if number == num3:
            print('You entered 3. This corresponds to Wednesday.')
        else:
            if number == num4:
                print('You entered 4. This corresponds to Thursday.')
            else:
                if number == num5:
                    print('You entered 5. This corresponds to Friday.')
                else:
                    if number == num6:
                        print('You entered 6. This corresponds to Saturday.')
                    else:
                        if number == num7:
                            print('You entered 7. This corresponds to Sunday.')
                        else:
                            print('Please enter a number between 1 and 7.')