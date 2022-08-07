import PySimpleGUI as sg

layout = [
		[sg.T("Full name:",size=(13,1)),sg.I(key="-NAME-")],
		[sg.T("Passport number:",size=(13,1)),sg.I(key="-PASSPORT-")],
		[sg.Radio("Male","radio",key="-MALE-"),sg.Radio("Female","radio",key="-FEMALE-")],
		[sg.I(),sg.CalendarButton("Date of Departure",close_when_date_chosen=True,key="-DEPARTURE-",location=(0, 0))],
		[sg.I(),sg.CalendarButton("Date of Arrival",close_when_date_chosen=True,key="-ARRIVAL-",location=(0, 0),size=(13, 1))],
		[sg.T("Choose your destination")],
		[sg.Listbox(["mosco","algeries","tunis","new york","riad","cairo","tarablos","gaza"],key="-CITIES-",size=(15, 5))],
		[sg.B("Add reservation",key="-ADD RESERVATION-"),sg.B("Show reservations table",key="-TABLE-"),sg.Exit()],
		]

window = sg.Window("Passport Reservation", layout)
while True:
	event, value = window.read()
	if event in (sg.WIN_CLOSED, "Exit"):
		window.close()
		break

