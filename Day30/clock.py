from tkinter import Tk,ttk,StringVar,font
import datetime


def quit(*args):
	root.destroy()

def clock_time():
	clock = datetime.datetime.now()
	clock = clock.strftime("%H:%M:%S")
	text.set(clock)
	root.after(1000, clock_time)

root = Tk()
root.title("clock")
root.geometry("500x100+550+150")
root.configure(background="black")
root.bind('x',quit)
root.after(1000, clock_time)

fnt = font.Font(family="arial", size=50, weight="bold")
text = StringVar()
label = ttk.Label(root, textvariable=text,font=fnt,foreground="green",background="black").pack()
root.mainloop()