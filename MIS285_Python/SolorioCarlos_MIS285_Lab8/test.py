import pickle

# main function
def main():
        again = 'y' # To control loop repitition

        # open a file for binary writing
        output_file = open('info.dat', 'wb')

        # get data until user wants to stop
        while again.lower() == 'y':
            #get data about a person and save it
            save_data(output_file)

            #does the user want to enter more data?
            again = input('Enter more data? (y/n): ')

        #close the file
        output_file.close()

#The save_data function gets data about a person
#stores it in a dictionary, and then pickles the
#dictionary to the specified file.
def save_data(file):
    #create an empty dictionary
    person = {}

    #get data fgor a person and store it in the dictionary
    person['name'] = input('Name: ')
    person['age'] = int(input('Age: '))
    person['name'] = float(input('Weight: '))

    #pickle the dictionary
    pickle.dump(person.file)

#call main function
main()

