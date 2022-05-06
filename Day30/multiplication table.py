import tkinter
from tkinter import Label, Entry, Button
import sys

def times_table():
	print()
	for i in range(1,13):
		m = int(Enter_table.get())
		print(f"{i} * {m} = {i*m}")

multiply = tkinter.Tk()
multiply.geometry("250x200+700+250")
multiply.title("Muliplication table")

Enter_table = tkinter.StringVar()

lable_1 = Label(multiply,text="multiplication times table").pack()
label_2 = Label(multiply,text="                       ").pack()
entry = Entry(multiply,textvariable=Enter_table,justify="center").pack()
label_3 = Label(multiply,text="                       ").pack()
button_1 = Button(multiply, text="create table", command=times_table).pack()
label_4 = Label(multiply,text="                       ").pack()
button_2 = Button(multiply,text="Quit",fg="red",command=multiply.destroy).pack()

multiply.mainloop()