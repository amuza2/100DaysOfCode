import PySimpleGUI as sg


def add_contact():
	layout = [
			[sg.T("Full Name:",size=(10,1)),sg.I(key="-NAME-")],
			[sg.T("Address:",size=(10,1)),sg.I(key="-ADDRESS-")],
			[sg.T("Mobile:",size=(10,1)),sg.I(key="-MOBILE-")],
			[sg.B("Add Contact",key="-SUBMIT-"), sg.Exit()],
			]

	window = sg.Window("Contact Creator", layout)
	contact = []
	while True:
		event, value = window.read()
		if event in (sg.WIN_CLOSED, "Exit"):
			window.close()
			break
		elif event == "-SUBMIT-":
			contact.append([value["-NAME-"],value["-ADDRESS-"],value["-MOBILE-"]])
			window["-NAME-"].update("")
			window["-ADDRESS-"].update("")
			window["-MOBILE-"].update("")
			add_to_table(contact)


def add_to_table(contact):
	header = ["Full name","Address","Mobile"]
	layout = [
			[sg.Table(contact,header,num_rows=5)],
			]

	window = sg.Window("Contact Table", layout)
	while True:
		event, value = window.read()
		if event == sg.WIN_CLOSED:
			window.close()
			break
			

def main():
	add_contact()
	
main()


