#!/usr/local/bin/python3
#Python 3.5.0
#Daniel A. Christie ©2015


#Available to all classes but will only initialize once
#
tuple1 = (1,2,3,4)
class upper_A(object):
    
    #upper_A.__init__(self)
    def __init__(self):
        #If tuple1 is provided locally than it is used
        #first before the global varial outside classes
        #tuple1 = (1,2,3,4,5) 
        print("I am inside of Class A")

        for i in tuple1:
            print(i)

        super(upper_A, self).__init__()
        print("I am leaving Class A")

class upper_B(object):

    def __init__(self):
        print("I am inside of Class B")

        super(upper_B, self).__init__()
        print("I am leaving Class B")

class upper_C(upper_A,upper_B):

    def __init__(self):
        print("I am inside of Class C")

        upper_A.__init__(self) #This targets the super A

        upper_B.__init__(self) #This targets the super B
        print("I am leaving Class C")
        

if __name__ == "__main__":
   upper_C()
   
