

class Month:
    def __init__(self, name, days, order):
        self.name = name
        self.days = days
        self.order = order


class Date:
    def __init__(self, date, month, year):
        self.date = date
        self.month = month
        self.year = year


def getMonth(months, name):
    month = [m for m in months if m.name.lower() == name.lower()]
    return month[0]


day1 = Date(1, 'January', 1999)
day2 = Date(1, 'February', 2020)
monthsObjects = []
months = ['January', 'February', 'March', 'April', 'May', 'June',
          'July', 'August', 'September', 'October', 'November', 'December']
orders = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12]
days = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31]
zipped = zip(months, days, orders)
for item in zipped:
    monthsObjects.append(Month(*item))

month1 = getMonth(monthsObjects, day1.month)
month2 = getMonth(monthsObjects, day2.month)
numOfDays = 0
# if (day1.year %4 ==0 and month1.order<2) or (day2.year %4 ==0 and month2.order >2):
#     numOfDays += 1
numOfDays += day2.date
numOfDays -= day1.date
for year in range(day1.year + 1, day2.year):
    numOfDays += 365
    if year % 4 == 0:
        numOfDays += 1
def calculateDaysTillYearEnd(m1,m2):
    index = m1-1
    nd=0
    while(index <12 and index < m2):
        print(index)
        nd += days[index]
        index += 1
    return nd
m2 =month2.order
if(month1.order < month2.order):
    m2=12
numOfDays += calculateDaysTillYearEnd(month1.order ,m2)
numOfDays += calculateDaysTillYearEnd(1,month2.order-1)
print(numOfDays)
