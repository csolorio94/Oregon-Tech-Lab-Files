#Main function pig latin converter
def main():

    print('Welcome to the Pig Latin translator.')
    words = str(input("Enter a sentence in English to be translated: ")).split()
    for word in words:
        print(word[1:] + word[0] + "ay", end = " ")
  
#calls the main function
main()