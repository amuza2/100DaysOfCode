from tkinter import *

class Example:
    def __init__(self, parent):
        self.widgets(parent)

    def widgets(self, app):
        var_1 = StringVar()
        var_2 = StringVar()

        self.geometry = app.geometry("200x300+0+0")
        self.title = app.title("Example")
        self.label1 = Label(app,text="what is your name: ")
        self.label1.pack()
        self.entry1 = Entry(app, textvariable=var_1)
        self.entry1.pack()
        self.label2 = Label(app,text="result:")
        self.label2.pack()
        self.entry2 = Entry(app, textvariable=var_2)
        self.entry2.pack()
        self.button = Button(app, text="click",command=self.click(var_1,var_2))
        self.button.pack()


    def click(self,var_1,var_2):
        var_2.set(var_1.get())


root = Tk()
exam = Example(root)
root.mainloop()