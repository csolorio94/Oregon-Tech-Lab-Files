def main():
    
    another = 'y'

    furniture_file = open('furniture.txt', 'a')

    while another == 'y' or another == 'Y':
        #Get information
        print('Enter your furniture information: ')
        code = input('Product Code: ')
        description = input('Product Description: ')
        price = float(input('Price (in dollars): '))

        #append the data to file
        furniture_file.write(code + ' | ')
        furniture_file.write(description + ' | ')
        furniture_file.write(str(price) + '\n')

        #Determine if user wants to add more
        print('Do you want to enter another product?')

        another = input('Y = yes, anything else = no ')

    #close file
    furniture_file.close()
    print('Data appended to furniture.txt') 

#call function
main()