number = int(input("Enter the number to factorialize "))
total = 1
counter = number

if (number > 0) :
    while (counter > 1) :
        total = total * counter
        counter = counter - 1
    print(number,  "! = ",  total)
else :
    print("that is an invalid input")
          
