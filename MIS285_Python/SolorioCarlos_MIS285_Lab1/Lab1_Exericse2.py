# Exercise 2 - Get user input: fuel used and miles driven (display as whole number //)
miles_driven = int(input('How many miles did you drive? '))
fuel_used = int(input('How many gallons of fuel did you use? '))
mpg = miles_driven // fuel_used

# Display mpg Calculation
print('Thank you for your entry.')
print('You traveled' , mpg , 'miles per gallon of fuel.')
