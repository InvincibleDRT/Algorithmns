"""
Read file into texts and calls.
It's ok if you don't understand how to read files.
"""
import csv

with open('texts.csv', 'r') as f:
    reader = csv.reader(f)
    texts = list(reader)

with open('calls.csv', 'r') as f:
    reader = csv.reader(f)
    calls = list(reader)

"""
TASK 4:
The telephone company want to identify numbers that might be doing
telephone marketing. Create a set of possible telemarketers:
these are numbers that make outgoing calls but never send texts,
receive texts or receive incoming calls.

Print a message:
"These numbers could be telemarketers: "
<list of numbers>
The list of numbers should be print out one per line in lexicographic order with no duplicates.
"""

sendnumbers =[]
checknums =[]
for i in texts:
    checknums.append(i[0])
    checknums.append(i[1])
for i in calls:
    sendnumbers.append(i[0])
    checknums.append(i[1])

posTeleMarkets=[]
for i in sendnumbers:
    if i not in checknums:
        posTeleMarkets.append(i)

print("These numbers could be telemarketers: ")
print(sorted(list(set(posTeleMarkets))))