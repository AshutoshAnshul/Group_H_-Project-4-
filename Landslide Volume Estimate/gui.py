from tkinter import *
from tkinter.filedialog import askopenfilename
from gacode import gacode
from tkinter import messagebox

import os

global post
global pre
global azi
global alt

def printeer(event):
    print("print fn",e1)


def get_file_pre():
    filename = askopenfilename()            # show an "Open" dialog box and return the path to the selected file
    file= Label(root,text=filename)
    global pre
    pre = filename
    file.grid(row=5,column=1)

def get_file_pos():
    filename = askopenfilename()            # show an "Open" dialog box and return the path to the selected file
    file= Label(root,text=filename)
    global post
    post= filename
    file.grid(row=5,column=1) 

def check_and_execute():
    global azi
    azi=e1.get()
    global alt
    alt=e2.get()
    msg="Dta missing:-\n"
    if not post:
        msg=msg+"PostDTM\n"
    if not pre:
        msg=msg+"PreDTM\n"
    if not azi:
        msg=msg+"Azimuth\n"
    if not alt:
        msg=msg+"Altitude\n"
    if not post or not pre or not azi or not alt:
        messagebox.showerror("Error",msg)
    else:
        vol,err=gacode(post,pre,float(azi),float(alt))
        msg=" Volume of Landslide= "+str(vol)+" cubic meter\n Error="+str(err)+" %\n Resultant images saved \n Data added in data.csv"
        messagebox.showinfo("Result",msg)

root = Tk()


head= Label(root,text="Landslide model",bg="grey",fg="white")
head.grid(row=0)

label1= Label(root,text="Azimuth :")
label2= Label(root,text="Altitude :")
e1= Entry(root)
e2= Entry(root)


label1.grid(row=1,sticky=E)
label2.grid(row=2,sticky=E)
e1.grid(row=1,column=1)
e2.grid(row=2,column=1)

#adding button
button1 = Button(text="postdtm",fg="red",command=get_file_pos)
#button1.bind("<Button-1>",get_file_pos())



button2 = Button(text="predtm",fg="blue",command=get_file_pre)


button3 = Button(text="Submit",fg="black",command=check_and_execute)
button1.grid(row=3)
button2.grid(row=3,column=1)
button3.grid(row=4,column=1)


root.mainloop()