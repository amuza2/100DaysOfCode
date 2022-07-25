from tkinter import *
import time, random

class App:
	def __init__(self,parent):
		self.widgets(parent)

	def widgets(self, app):
		text_input = StringVar()
		operator = ""
		rand = StringVar()
		fries = StringVar()
		burger = StringVar()
		filet = StringVar()
		chicken = StringVar()
		cheese = StringVar()
		drinks = StringVar()
		cost = StringVar()
		charge = StringVar()
		state_tax = StringVar()
		sub_total = StringVar()
		total_cost = StringVar()
		def button_click(number):
			global operator
			operator += str(number)
			text_input.set(operator)

		def button_clear():
			global operator
			operator = ""
			text_input.set("")

		def button_equal():
			global operator
			sumit = str(eval(operator))
			text_input.set(sumit)
			operator=""

		def ref():
			num = str(random.randint(10000, 99999))
			rand.set(num)

			cost_of_fries = 0.99
			cost_of_drings = 1
			cost_of_filet = 2.99
			cost_of_burger = 2.87
			cost_of_chicken = 2.89
			cost_of_cheese = 2.69

			cof = float(fries.get()) * cost_of_filet
			cod = float(drinks.get()) * cost_of_drings
			cofilet = float(filet.get()) * cost_of_filet
			coburger = float(burger.get()) * cost_of_burger
			cochicken = float(chicken.get()) * cost_of_chicken
			cocheese = float(cheese.get()) * cost_of_cheese

			cost_of_meal = f"£, {(cof+cod+cofilet+coburger+cochicken+cocheese)}"
			pay_tax = (cof+cod+cofilet+coburger+cochicken+cocheese) * 0.2
			service_charge = (cof+cod+cofilet+coburger+cochicken+cocheese) * 0.01
			sub_total_gui = (cof+cod+cofilet+coburger+cochicken+cocheese)
			total = (cof+cod+cofilet+coburger+cochicken+cocheese) + pay_tax + service_charge

			tax_gui = f"£. {pay_tax}"
			service_gui = f"£. {service_charge}"
			sub_total_gui = f"£. {sub_total_gui}"
			total_gui = f"£. {total}"

			cost.set(cost_of_meal)
			charge.set(service_gui)
			state_tax.set(tax_gui)
			sub_total.set(sub_total_gui)
			total_cost.set(total_gui)

		def clear_button():
			rand.set("")
			fries.set("")
			burger.set("")
			filet.set("")
			chicken.set("")
			cheese.set("")
			drinks.set("")
			cost.set("")
			charge.set("")
			state_tax.set("")
			sub_total.set("")
			total_cost.set("")


		def exit():
			root.destroy()
		self.app_geometry = app.geometry("1600x700+0+0")
		self.app_title = app.title("Restaurent management system")
		self.top = Frame(app, width=1600,bg="powder blue", relief=SUNKEN)
		self.top.pack(side=TOP)
		self.f1 = Frame(app, width=800, height=700,pady=-100, relief=SUNKEN)
		self.f1.pack(side=LEFT)
		self.f2 = Frame(app, width=300, height=700, bg="powder blue",relief=SUNKEN)
		self.f2.pack(side=RIGHT)

		self.title_label = Label(self.top, cursor="man", font=("arial", 50, "bold"), text="Restaurant Management System", fg="Steel Blue", bd=10)
		self.title_label.grid(row=0, column=0)

		self.label_reference = Label(self.f1, font=("arial",16,"bold"),text="Reference",bd=16)
		self.label_reference.grid(row=0,column=0)
		self.entry_reference = Entry(self.f1, font=("arial",16,"bold"),textvariable=rand,bd=10,insertwidth=4,
							bg="powder blue", justify="right")
		self.entry_reference.grid(row=0,column=1)


		self.label_fries = Label(self.f1, font=("arial",16,"bold"),text="Large Fries",bd=16)
		self.label_fries.grid(row=1,column=0)
		self.entry_fries = Entry(self.f1, font=("arial",16,"bold"),textvariable=fries,bd=10,insertwidth=4,
							bg="powder blue", justify="right")
		self.entry_fries.grid(row=1,column=1)

		self.label_burger = Label(self.f1, font=("arial",16,"bold"),text="Burger meal",bd=16)
		self.label_burger.grid(row=2, column=0)
		self.entry_burger = Entry(self.f1, font=("arial",16,"bold"),textvariable=burger,bd=10,insertwidth=4,
							bg="powder blue", justify="right")
		self.entry_burger.grid(row=2,column=1)

		self.label_filet = Label(self.f1, font=("arial",16,"bold"),text="Filet o meal",bd=16)
		self.label_filet.grid(row=3, column=0)
		self.entry_filet = Entry(self.f1, font=("arial",16,"bold"),textvariable=filet,bd=10,insertwidth=4,
							bg="powder blue", justify="right")
		self.entry_filet.grid(row=3,column=1)

		self.label_chicken = Label(self.f1, font=("arial",16,"bold"),text="Chicken meal",bd=16)
		self.label_chicken.grid(row=4, column=0)
		self.entry_chicken = Entry(self.f1, font=("arial",16,"bold"),textvariable=chicken,bd=10,insertwidth=4,
							bg="powder blue", justify="right")
		self.entry_chicken.grid(row=4,column=1)

		self.label_cheese = Label(self.f1, font=("arial",16,"bold"),text="Cheese meal",bd=16)
		self.label_cheese.grid(row=5, column=0)
		self.entry_cheese = Entry(self.f1, font=("arial",16,"bold"),textvariable=cheese,bd=10,insertwidth=4,
							bg="powder blue", justify="right")
		self.entry_cheese.grid(row=5,column=1)

		#entries column 2
		self.label_drink = Label(self.f1, font=("arial",16,"bold"),text="Drinks",bd=16)
		self.label_drink.grid(row=0,column=2)
		self.entry_drink = Entry(self.f1, font=("arial",16,"bold"),textvariable=drinks,bd=10,insertwidth=4,
							bg="powder blue", justify="right")
		self.entry_drink.grid(row=0,column=3)


		self.label_cost = Label(self.f1, font=("arial",16,"bold"),text="Cost of meal",bd=16)
		self.label_cost.grid(row=1,column=2)
		self.entry_cost = Entry(self.f1, font=("arial",16,"bold"),textvariable=cost,bd=10,insertwidth=4,
							bg="powder blue", justify="right")
		self.entry_cost.grid(row=1,column=3)

		self.label_charge = Label(self.f1, font=("arial",16,"bold"),text="Service charge",bd=16)
		self.label_charge.grid(row=2, column=2)
		self.entry_charge = Entry(self.f1, font=("arial",16,"bold"),textvariable=charge,bd=10,insertwidth=4,
							bg="powder blue", justify="right")
		self.entry_charge.grid(row=2,column=3)

		self.label_tax = Label(self.f1, font=("arial",16,"bold"),text="State Tax",bd=16)
		self.label_tax.grid(row=3, column=2)
		self.entry_tax = Entry(self.f1, font=("arial",16,"bold"),textvariable=state_tax,bd=10,insertwidth=4,
							bg="powder blue", justify="right")
		self.entry_tax.grid(row=3,column=3)

		self.label_sub = Label(self.f1, font=("arial",16,"bold"),text="Sub Total",bd=16)
		self.label_sub.grid(row=4, column=2)
		self.entry_sub = Entry(self.f1, font=("arial",16,"bold"),textvariable=sub_total,bd=10,insertwidth=4,
							bg="powder blue", justify="right")
		self.entry_sub.grid(row=4,column=3)

		self.label_total_cost = Label(self.f1, font=("arial",16,"bold"),text="Total Cost",bd=16)
		self.label_total_cost.grid(row=5, column=2)
		self.entry_total_cost = Entry(self.f1, font=("arial",16,"bold"),textvariable=total_cost,bd=10,insertwidth=4,
							bg="powder blue", justify="right")
		self.entry_total_cost.grid(row=5,column=3)

		#more buttons

		self.id_generate = Button(self.f1,pady=16,padx=16, bd=16, fg="black",font=("arial",16,"bold"),width=10,
						text="Generate ID", bg="powder blue",command=ref).grid(row=7,column=1)
		self.clear_button = Button(self.f1,pady=16,padx=16, bd=16, fg="black",font=("arial",16,"bold"),width=10,
						text="Clear", bg="powder blue",command=clear_button).grid(row=7,column=2)
		self.exit = Button(self.f1,pady=16,padx=16, bd=16, fg="black",font=("arial",16,"bold"),width=10,
						text="Exit", bg="powder blue",command=exit).grid(row=7,column=3)


				#row 1 buttons
		self.text_display = Entry(self.f2, font=("arial", 20, "bold"), textvariable=text_input,bd=30,insertwidth=4,
					bg="powder blue", justify="right")
		self.text_display.grid(columnspan=4)
		self.button_7 = Button(self.f2, padx=16,pady=16,bd=8,fg="black",font=("arial",20,"bold"),
						text='7',bg="powder blue",command=lambda: button_click(7)).grid(row=2,column=0)
		self.button_8 = Button(self.f2, padx=16,pady=16,bd=8,fg="black",font=("arial",20,"bold"),
						text='8',bg="powder blue",command=lambda: button_click(8)).grid(row=2,column=1)
		self.button_9 = Button(self.f2, padx=16,pady=16,bd=8,fg="black",font=("arial",20,"bold"),
						text='9',bg="powder blue",command=lambda: button_click(9)).grid(row=2,column=2)
		self.button_addition = Button(self.f2, padx=16,pady=16,bd=8,fg="black",font=("arial",20,"bold"),
						text='+',bg="powder blue",command=lambda: button_click('+')).grid(row=2,column=3)
		#row 2 buttons
		self.button_4 = Button(self.f2, padx=16,pady=16,bd=8,fg="black",font=("arial",20,"bold"),
						text='4',bg="powder blue",command=lambda: button_click(4)).grid(row=3,column=0)
		self.button_5 = Button(self.f2, padx=16,pady=16,bd=8,fg="black",font=("arial",20,"bold"),
						text='8',bg="powder blue",command=lambda: button_click(5)).grid(row=3,column=1)
		self.button_6 = Button(self.f2, padx=16,pady=16,bd=8,fg="black",font=("arial",20,"bold"),
						text='9',bg="powder blue",command=lambda: button_click(6)).grid(row=3,column=2)
		self.button_minus = Button(self.f2, padx=16,pady=16,bd=8,fg="black",font=("arial",20,"bold"),
						text='-',bg="powder blue",command=lambda: button_click('-')).grid(row=3,column=3)

		#row 3 buttons
		self.button_1 = Button(self.f2, padx=16,pady=16,bd=8,fg="black",font=("arial",20,"bold"),
						text='1',bg="powder blue",command=lambda: button_click(1)).grid(row=4,column=0)
		self.button_2 = Button(self.f2, padx=16,pady=16,bd=8,fg="black",font=("arial",20,"bold"),
						text='2',bg="powder blue",command=lambda: button_click(2)).grid(row=4,column=1)
		self.button_3 = Button(self.f2, padx=16,pady=16,bd=8,fg="black",font=("arial",20,"bold"),
						text='3',bg="powder blue",command=lambda: button_click(3)).grid(row=4,column=2)
		self.button_multiply = Button(self.f2, padx=16,pady=16,bd=8,fg="black",font=("arial",20,"bold"),
						text='*',bg="powder blue",command=lambda: button_click('*')).grid(row=4,column=3)
		#row 4 buttons
		self.button_0 = Button(self.f2, padx=16,pady=16,bd=8,fg="black",font=("arial",20,"bold"),
						text='0',bg="powder blue",command=lambda: button_click(0)).grid(row=5,column=0)
		self.button_clear = Button(self.f2, padx=16,pady=16,bd=8,fg="black",font=("arial",20,"bold"),
						text='C',bg="powder blue",command=button_clear).grid(row=5,column=1)
		self.button_equal = Button(self.f2, padx=16,pady=16,bd=8,fg="black",font=("arial",20,"bold"),
						text='=',bg="powder blue",command=button_equal).grid(row=5,column=2)
		self.button_division = Button(self.f2, padx=16,pady=16,bd=8,fg="black",font=("arial",20,"bold"),
						text='/',bg="powder blue",command=lambda: button_click('/')).grid(row=5,column=3)
		



root = Tk()
obj = App(root)
root.mainloop()