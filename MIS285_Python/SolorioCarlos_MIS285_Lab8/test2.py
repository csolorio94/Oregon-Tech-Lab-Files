def main():
    # declare a new, empty dictionary to hold your animal species and sounds. 
    # Note that I'm avoiding the use of "dict" as a variable name since it 
    # shadows/overrides the built-in method 
    animal_dict = {}
    file = open("file.txt")
    for i in file:
        i = i.strip()
        animal, sound = i.split(",")
        animal_dict[animal] = sound

    # Remember to close your files after reading
    file.close()

    keyinput = input("Enter animal to know what it sounds like: ")
    if keyinput in animal_dict:

        # here, keyinput is the string/key and to do a lookup
        # in the dictionary, you use brackets. 
        # animal_dict[keyinput] thus returns the sound

        print("The ",keyinput,animal_dict[keyinput],"s")
    else:
        print("The animal is not in the list")