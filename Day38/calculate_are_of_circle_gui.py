import PySimpleGUI as sg
import math

layout = [
		[sg.T("Enter radius in centimiters:"),sg.I(key="-RADIUS-",size=(7,1))],
		[sg.B("Calculate Volume",key="-VOLUME-"), sg.B("Calculate Area",key="-AREA-"),sg.Exit(button_color="red")],
		]

window = sg.Window("Circle calculate", layout)

while True:
	event, value = window.read()
	if event in (sg.WIN_CLOSED, "Exit"):
		window.close()
		break

	elif event == "-AREA-":
		if value["-RADIUS-"]:
			result = math.pi * (int(value["-RADIUS-"])**2)
			sg.popup(result)
	elif event == "-VOLUME-":
		if value["-RADIUS-"]:
			r = float(value["-RADIUS-"])
			result = (4*math.pi*(r**2))/3
			sg.popup(result)
