fun main(args: Array<String>) {
    print("Enter the number to factorialize: ")

    val inputStr = readLine()

    if (inputStr == null) {
        println("Hey that's null idiot")
        return
    }

    val factorial = inputStr.toInt()
    var counter = factorial
    var total = 1

    if (factorial > 0) {
        while (counter > 1) {
            total *= counter
            counter -= 1
        }
        println("$factorial != $total")
    } else {
        println("That input is invalid")
    }
}