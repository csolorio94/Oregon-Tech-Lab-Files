#Main Function
def main():
    
    #Define Variables
    yearly_change = []
    change = 0.0
    total_change = 0.0
    average_change = 0.0
    greatest_change = 0.0
    smallest_change = 0.0
    greatest_year = 0
    smallest_year = 0

    #Year starts at 1950
    BASE_YEAR = 1950
  
    try:
        #Open the given file
        input_file = open('USPopulation.txt', 'r')
      
        #Put contents of the file into a list
        yearly_population = input_file.readlines()

        #Each line is read as a number
        for i in range(len(yearly_population)):
            yearly_population[i] = float(yearly_population[i])

        #Change in population each year calculation
        for i in range(1, len(yearly_population)):
            change = yearly_population[i] - yearly_population[i-1]
            yearly_change.append(change)

            #Check if first year, set value to it
            if i==1:
                greatest_change = change
                smallest_change = change
                greatest_year = 1
                smallest_year = 1

            #Keep greatest and smallest changes up to date
            else:
                if change > greatest_change:
                    greatest_change = change
                    greatest_year = i
                  
                elif change < smallest_change:
                    smallest_change = change
                smallest_year = i

        total_change = float(sum(yearly_change))
        average_change = total_change / len(yearly_change)

        #Print results for the user
        print('The average change in population during the time period was', format(average_change, ',.2f'))
        print('The year with the greatest increase in population during the time period was', BASE_YEAR + greatest_year)
        print('The year with the smallest increase in population (from the previous year) during the time period was', BASE_YEAR + smallest_year)
      
    #Error handling 
    except IOError:
        print('The file could not be found.')
        print('An error occurred.')
    except IndexError:
        print('There was an indexing error.')


#Call the main function
main()