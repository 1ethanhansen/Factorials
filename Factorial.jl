print("Please enter a number to factorialize: ")

n = parse(Int64, readline())

counter = n
total = 1

while counter > 1
	global total *= counter
	global counter -= 1
end

println("$n ! = $total")
