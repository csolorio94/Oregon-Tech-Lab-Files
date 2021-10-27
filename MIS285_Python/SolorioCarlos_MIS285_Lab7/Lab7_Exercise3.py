def main():
    
    #Define Variables
    date = [0]
    price = [1]

    try:
        f = open('DJI.txt')
        for line in f:
            my_list = [line.rstrip('\n') for line in f]
            
        
        #Print results for the user
        print(my_list)
        print('Average close value for the entire year: ')
        print('Average close value per month: ')
        print('Highest close value and the date: ')
        print('Lowest close value and the date:')
        print('Prices from lowest to highest: ')
      
    #Error handling 
    except IOError:
        print('The file could not be found.')
        print('An error occurred.')
    except IndexError:
        print('There was an indexing error.')


#Call the main function
main()