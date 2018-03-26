import os

name = "_20180108_01_PRT_BH"
dirname = "files"

if not os.path.isdir(dirname):
    os.mkdir(dirname)

for i in range(50):
    filename = str(i).zfill(4) + name +".txt"
    path = os.path.join(dirname, filename)
    print(filename)
    f= open(path, "w")
    f.write("ooxx")
    f.close()

print("ok!")
input("press any key...")