#Given code to run, screen shot in Zip folder
import numpy as np
from matplotlib import pyplot as plt

x = np.arange(1,11)
y = 2 * x + 5
z = 4* x + 12
plt.title("Revenue  by Years")
plt.xlabel("Time")
plt.ylabel("Dollars")
plt.plot(x,y,z)
plt.show()