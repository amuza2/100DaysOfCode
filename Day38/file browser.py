import PySimpleGUI as sg
import csv

layout = [
		[sg.T("Choose a CSV file:")],
		[sg.I(), sg.FileBrowse()],
		[sg.B("Submit"),sg.B("Exit")],
		]

window = sg.Window("Csv reader", layout)

def read_csv(csv_address):
	with open(csv_address) as f:
		csv_reader = csv.reader(f)
		header = next(csv_reader)
		rows = []
		for row in csv_reader:
			rows.append(row)
	return rows

while True:
	event, value = window.read()
	if event == sg.WIN_CLOSED or event == "Exit":
		window.close()
		break
	print(event, value)
	if event == "Submit":
		print(read_csv(value["Browse"]))