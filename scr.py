#takes a message in the form of a string, swaps adjacent pairs of characters and returns the resulting string
def swapPairs(message):
    if len(message) < 2:
        return message
    else:
        return message[1] + message[0] + swapPairs(message[2:])

print(swapPairs(input("Enter a message: ")))
