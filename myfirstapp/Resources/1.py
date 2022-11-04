import sys
from sys import *
x = sys.argv[1]

y = str(x)
try:
    z = eval(y)
    z = str(z)
    print(z)
except:
    pass

sys.path.append(r'G:\\Projects\\winapp1\\packages\\IronPython.2.7.12\\lib')
from sympy import *





