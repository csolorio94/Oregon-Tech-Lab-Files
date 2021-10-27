#Calculaute Tuition over 5 years, 2.5% increase per year

cost = int(25000)
increase = float(.025)

#First year base
print('This is the price of Tuition over the next 5 years:')
print('Year 1: $25,000') 

#Exclude Year 1 / 0
for x in range(2, 6):
    tuition = cost * ((1.000+increase) ** x)
    print('Year ' + str(x) + ': $', format(tuition, ',.2f'), sep='')

