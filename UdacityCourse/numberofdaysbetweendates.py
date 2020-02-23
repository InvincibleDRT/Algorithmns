

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


def getMonth(months,name):
    month = [m for m in months if m.name.lower()==name.lower()]
    return month[0]

day1 = Date(1,'January',1999)
day2 = Date(1,'February',2000)
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
numOfDays =0
for i in range(month1.order,month2.order):
    numOfDays += days[i-1]
# if (day1.year %4 ==0 and month1.order<2) or (day2.year %4 ==0 and month2.order >2):
#     numOfDays += 1
print((day2.year - day1.year)*365  +  numOfDays + day2.date-day1.date)
