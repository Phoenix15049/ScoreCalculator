import sys
x = sys.argv[1]

y = str(x)
try:
    z = eval(y)
    z = str(z)
    print(z)
except:
    pass
