
#Main function
def main():

    #Variables
    total = 0.0
    daily_sale = [0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0]
    index = 0

    #List of days
    days = ['Monday', 'Tuesday', 'Wednsday', 'Thursday', 'Friday']

    #Loop until Friday
    for index in range(5):

        print("Please enter figure sales for: ", days[index])
        daily_sale[index] = float(input("Enter the sales here: "))

        total += daily_sale[index]

    print("Total sales for the week are: $", format(total, '.2f'), sep = ' ')

#Calls main function
main()