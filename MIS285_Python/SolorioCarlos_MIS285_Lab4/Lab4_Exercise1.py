#Write a function named feed_to_inches that accepts a number of feet as an argument and returns the number of inches in that many feet
def feet_to_inches(feet):
    return 12.0 * feet

# Function that gathers data from user and calculates
def main():
    feet = float(input('Enter the number of feet you would like converted to inches: '))
    inches = feet_to_inches(feet)
    print('There are', inches, "inches in", feet, "feet.")

# Call the function to execute
main()
