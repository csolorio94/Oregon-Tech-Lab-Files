#Collections funtions for most common
import collections

#Remove spaces to give the user a letter occurence back every time
string = input('Enter a string: ')
string = string.replace(" ","")

#Print results
print('You Entered: ' + string)
print('The most common character was: ')
print(collections.Counter(string).most_common(1)[0])


