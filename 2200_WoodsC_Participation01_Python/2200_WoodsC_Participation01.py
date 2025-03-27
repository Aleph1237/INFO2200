#Name: Your First Name Last Name
#Class: INFO 2200
#Section: See syllabus, schedule, or Canvas course for section
#Professor: Insert instructor last name
#Date: Insert date submitted
#Participation or Assignment #: Insert participation or assignment number
#By submitting this assignment, I declare that the source code contained in this assignment was written #solely by me, unless specifically provided in the assignment. I attest that no part of this assignment, #in whole or in part, was directly created by Generative AI, unless explicitly stated in the assignment #instructions, nor obtained from a subscription service. I understand that copying any source code, #in whole or in part, unless specifically provided in the assignment, constitutes cheating, and that #I will receive a zero on this project if I am found in violation of this policy.

#!/usr/bin/env python3
import random # import random module

def main():
    '''
    Main function to search user input for the state capital
    '''
    print("Welcome to Corbin's State Capital Lookup App") #display the welcome message
    print() #display blank line



    #prompts the user for input
    userinput = input("Please enter a state and I will return the capital (x to exit).")

    #continues as long as user input is not an x, uses the lower() function
    while userinput.lower() != "x":
        with open("statecaps.txt","r") as file: # with statement automatically closes the file
        # file.readline() # consumes the first line or heading, State,Capital
            stateCapDict = {} # create a dictionary
            for line in file: # use a for statement to read each line of the file
                line = line.replace("\n", "") # replace() method replaces the new line character with
                                    # an empty string
                tempstatecap = line.split(",") # split() method is an array returning method
                stateCapDict.update({tempstatecap[0]:tempstatecap[1]}) # tempstatecap array used to
                                                                # create key/value
                                                                
        # title function converts text, first character of each word becomes uppercase
        userState = userinput.title()

        totalStates = random.randrange(1, len(stateCapDict))

        randState = list(stateCapDict)[totalStates]

        """
        if userState in stateCapDict: # determine if state is in the dictionary
             print() # display blank line
             print(f"State: {userState}") # display userState using f string, functional string
             print(f"Capital: {stateCapDict[userState]}") # display the value (capital) of the userState key (state)
             print()# display blank line
        else: # follow false path
             print(f"Could not find {userinput} in the database.") # display error message
             print() # display blank line
        """

        if userState in stateCapDict:
            print()
            print(f"State: {userState}")
            print(f"Capital: {stateCapDict[userState]}")
            print()
        elif userState == "Random" and randState in stateCapDict:
            print()
            print(f"Random State: {randState}, {stateCapDict[randState]}.")
            print()
        else:
            print(f"Could not find {userinput} in the database.")
            print()
     
        userinput = input("Please enter a state and I will return the capital (x to exit). ")
    print("Good-bye")
        

'''
checks whether the current module is being run as the main module; if so, it calls the main() function.
otherwise, it does not call the main() function; this lets other programs import this module without running the main() function
'''
if __name__ == "__main__": main()
