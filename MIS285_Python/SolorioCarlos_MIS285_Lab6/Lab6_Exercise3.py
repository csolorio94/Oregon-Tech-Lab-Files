import matplotlib.pyplot as plotter

#Pie chart labels
piechartLabels = 'Rent', 'Gas', 'Food', 'Clothing', 'Vehicle Cost', 'Entertainment', 'Utilities', 'Other Misc.'

#IImport text file data to list
input_file = open('Expenses.txt', 'r')
expensesValues = [line.split(',') for line in input_file.readlines()]

figureObject, axesObject = plotter.subplots()

#Draw pie chart
axesObject.pie(expensesValues,

        labels=piechartLabels,
        autopct='%1.2f',
        startangle=90)

#Pie chart will show all expenses in percentage based portions
axesObject.axis('equal')
plotter.show()