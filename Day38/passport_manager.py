import PySimpleGUI as sg

def add_table(contact):
	header = ["Full Name","Passport","Gender","Departure","Arrival","City"]
	layout = [
			[sg.Table(info,header,num_rows=10)],
			[sg.Exit()],
			]

	window = sg.Window("Passport table", layout)
	while True:
		event, value = window.read()
		if event in (sg.WIN_CLOSED, "Exit"):
			window.close()
			break

def submit_reservation(value):
	if all([value["-NAME-"], value["-PASSPORT-"],(value["-MALE-"] or value["-FEMALE-"]),value["-DEPARTURE-"],value["-ARRIVAL-"],value["-CITIES-"]]):
			gender = "Male" if value["-MALE-"] else "Female"
			data = [value["-NAME-"], value["-PASSPORT-"],gender,value["-DEPARTURE-"],value["-ARRIVAL-"],value["-CITIES-"][0]]
			info.append(data)
			sg.popup("reservation submited!")
	else:
		sg.popup("Fill empty slots please!")



layout = [
		[sg.T("Full name:",size=(13,1)),sg.I(key="-NAME-",size=(20,1))],
		[sg.T("Passport number:",size=(13,1)),sg.I(key="-PASSPORT-",size=(20,1))],
		[sg.Radio("Male","radio",key="-MALE-"),sg.Radio("Female","radio",key="-FEMALE-")],
		[sg.I(size=(20,1),key="-DEPARTURE-"),sg.CalendarButton("Date of Departure",close_when_date_chosen=True,location=(0, 0))],
		[sg.I(size=(20,1),key="-ARRIVAL-"),sg.CalendarButton("Date of Arrival",close_when_date_chosen=True,location=(0, 0),size=(13, 1))],
		[sg.T("Choose your destination")],
		[sg.Listbox(["London","New York","Tokyo","Berlin","Paris","Cairo","Mixico"],select_mode="single",key="-CITIES-",size=(15, 5))],
		[sg.B("Add reservation",key="-ADD RESERVATION-"),sg.B("Show reservations table",key="-TABLE-"),sg.B("Reset")],
		[sg.Exit()],
		]

window = sg.Window("Passport Reservation", layout)
info = []
while True:
	event, value = window.read()
	if event in (sg.WIN_CLOSED, "Exit"):
		window.close()
		break
	elif event == "-ADD RESERVATION-":
		submit_reservation(value)
	elif event == "-TABLE-":
		add_table(info)
	elif event == "Reset":
		window["-NAME-"].update("")
		window["-PASSPORT-"].update("")
		window["-MALE-"].reset_group()
		window["-DEPARTURE-"].update("")
		window["-ARRIVAL-"].update("")