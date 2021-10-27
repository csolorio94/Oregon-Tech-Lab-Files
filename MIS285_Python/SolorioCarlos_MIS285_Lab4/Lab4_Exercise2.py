# Gather user input
num = int(input('Enter a number to see if it is Prime or not: '))

# Calculation: if num is more than 1, meaning multiple divisions of a number, num is not prime
if num > 1:
   for i in range(2, num):
       if (num % i) == 0:
           print(num,"is not a prime number.")
           break
   else:
       print(num,"is a prime number.")
       
else:
   print(num,"is not a prime number.")
