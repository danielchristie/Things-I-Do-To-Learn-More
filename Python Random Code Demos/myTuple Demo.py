# Fig. 35.7: fig35_07.py
# A program that illustrates tuples, lists and dictionaries.
 
# tuples
aTuple = ( 1, "a", 3.0 ) # create tuple
firstItem = aTuple[ 0 ] # first tuple item
secondItem = aTuple[ 1 ] # second tuple item
thirdItem = aTuple[ 2 ] # third tuple item

print "The first item in the tuple is", firstItem
print "The second item in the tuple is", secondItem
print "The third item in the tuple is", thirdItem
print

firstItem, secondItem, thirdItem = aTuple
print "The first item in the tuple is", firstItem
print "The second item in the tuple is", secondItem
print "The third item in the tuple is", thirdItem
print

aTuple += ( 4, )
print "Used the += statement on the tuple"
print

# print the tuple
print "The raw tuple data is:", aTuple
print "The items in the tuple are:"

for item in aTuple: # print each item
    print(item)

print # end previous line
print # blank line

# lists
aList = [ 1, 2, 3 ] # create list
aList[ 0 ] = 0 # change first element of list
aList.append( 5 ) # add item to end of list

print "The raw list data is:", aList # print list data
print

aList += [ 4 ] # add an item to the end of the list
print "Added an item to the list using the += statement"
print

# print each item in the list
print "The items in the list are:"

for item in aList:
    print item,

print # end previous line
print # blank line

# dictionaries
moDictionary = { 1 : "January", 2 : "February", 3 : "March",
                4 : "April", 5 : "May", 6 : "June", 7 : "July",
                8 : "August", 9 : "September", 10 : "October",
                11 : "November" }
moDictionary[ 12 ] = "December" # add item to dictionary

print "The raw dictionary of months is:", moDictionary
print "\nIndividual entries in the dictionary are:"

for item in moDictionary.keys():
    print "moDictionary[ ", item, " ] = ", moDictionary[ item ]
