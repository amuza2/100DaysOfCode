from tkinter import ttk, font, Label, Tk, StringVar
import datetime

global end_time

def quit(*arg):
	root.destroy()

def time_counter():
	time_left = end_time - datetime.datetime.now()
	time_left = time_left - datetime.timedelta(microseconds=time_left.microseconds)
	text.set(time_left)
	root.after(1000, time_counter)

root = Tk()
root.title("time count down")
root.geometry("500x100+500+200")
root.attributes("-fullscreen", False)
root.configure(background="black")
root.bind('x', quit)
root.after(1000, time_counter)

end_time = datetime.datetime(2022, 5, 7)
fnt = font.Font(family="arial", size=50, weight="bold")
text = StringVar()
label = ttk.Label(root, textvariable=text, font=fnt, foreground="green",background="black")
label.pack()
root.mainloop()