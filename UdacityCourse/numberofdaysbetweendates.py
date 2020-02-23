def createMonths():
    monthsObjects = []
    months = ['January', 'February', 'March', 'April', 'May', 'June',
              'July', 'August', 'September', 'October', 'November', 'December']
    orders = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12]
    days = [31, 27, 31, 30, 31, 30, 31, 30, 30, 31, 30, 31]
    zipped = zip(months, days, orders)
    for item in zipped:
        monthsObjects.append(Month(*item))
    return monthsObjects

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

day1 = Date(3,'January',1998)
day2 = Date(4,'January',1998)
monthslist = createMonths()


