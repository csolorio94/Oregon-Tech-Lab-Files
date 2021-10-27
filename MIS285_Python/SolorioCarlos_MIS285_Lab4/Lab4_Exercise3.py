import random

# Generate computer's choice to play against        
def computer_choice():
    random_num = random.randint(1,3)
    if random_num == 1:
        return 'rock'
    elif random_num == 2:
        return 'paper'
    else:
        return 'scissors'

# Gather user input
def user_entry(choice):
    return choice == 'rock' or choice == 'paper' or choice == 'scissors'

# Invalid input recognition    
def user_entry_retry(choice):
    while choice != 'rock' and choice != 'paper' and choice != 'scissors':
          print('Please choose from one of the options.')
          choice = input('Enter rock, paper, or scissors: ')
    return choice

# Determine logic for different expected scenarios (win, lose, tie)
def results(user, computer):
    if user == 'rock' and computer == 'scissors':
        return True
    elif user == 'scissors' and computer == 'paper':
        return True
    elif user == 'paper' and computer == 'rock':
        return True
    else:
        return False


# Execute the game and display results
computer_choice = computer_choice()
user_choice = input('Enter rock, paper, or scissors: ')
if not user_entry(user_choice):
    user_choice = user_entry_retry(user_choice)

# Determines if it is a tie
while user_choice == computer_choice:
    print('Computer choice:', computer_choice)
    print('It was a tie! Try again.')
    
    comp_choice = computer_choice()
    user_choice = input('Enter rock, paper, or scissors: ')
    if not user_entry(user_choice):
        user_choice = user_entry_retry(user_choice)

# Determines if you won (else, you lost)
print('Computer choice:', computer_choice)
if results(user_choice, computer_choice):
    print('You won!')
else:
    print('You lost! Sorry! Try again.')