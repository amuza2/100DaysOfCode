import PySimpleGUI as sg
from work_file import create_invoice

layout = [
		[sg.T("Client name:",size=(10,1)),sg.I(key="-NAME-")],
		[sg.T("Vendor name:",size=(10,1)),sg.I(key="-VENDOR-")],
		[sg.T("Amount name:",size=(10,1)),sg.I(key="-AMOUNT-")],
		[sg.T("Quantity:",size=(10,1)),sg.I(key="-QUAN-")],
		[sg.B("Create Contact"), sg.Exit()]
		]

window = sg.Window("Contact generator", layout)
info = {}
while True:
	event, value = window.read()
	if event in (sg.WIN_CLOSED, "Exit"):
		window.close()
		break
	elif event == "Create Contact":
		info["client_name"] = value["-NAME-"]
		info["vendor_name"] = value["-VENDOR-"]
		info["amount"] = value["-AMOUNT-"]
		info["quantity"] = value["-QUAN-"]
		create_invoice(info)
