import PySimpleGUI as sg

layout = [
		[sg.T("Choose a CSV file:")],
		[sg.I(), sg.FileBrowse()],
		[sg.B("Submit"),sg.B("Exit")],
		]

window = sg.Window("Csv reader", layout)
while True:
	event, value = window.read()
	if event == sg.WIN_CLOSED or event == "Exit":
		window.close()
		break