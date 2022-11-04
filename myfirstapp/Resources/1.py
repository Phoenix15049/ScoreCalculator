import imp
import sys
x = sys.argv[1]

y = str(x)
try:
    z = eval(y)
    z = str(z)
    print(z)
except:
    pass

sys.path.append(r'C:\Python27\Lib\site-packages')
from sympy import *