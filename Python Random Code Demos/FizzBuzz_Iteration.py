#!/usr/bin/python2
#Author:    Daniel Christie
#Purpose    Iterate through a range of numbers, checking for
#           numbers that are evenly divisible by specified numbers.
#           Prints 'Buzz' whenever it encounters a number divisible
#           by 3, 'Fuzz' when that number is divisible by 5, and
#           'FizzBuzz' whenever the number is evenly divisible by
#           both 3 and 5!


for i in range(1,100):
    if i%15==0:
        print "FizzBuzz"
    elif i%3==0:
        print "Buzz"
    elif i%5==0:
        print "Fuzz"
    else:
        print i
