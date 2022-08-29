"""
	in this example I am creating a kilometer to mile coverter 
	1 mile ==> 1.6 kilometer
	x      ==> 
	

"""


import PySimpleGUI as sg



values_list = ["Kilo to Mile","Mile to kilo", "Sec to Min","Min to Sec"]
layout = [
		[sg.I(key="-INPUT-"), sg.DD(default_value=values_list[0],values=values_list,size=(15,1),key="-SPIN-")],
		[sg.T("---",key="-OUTPUT-")],
		[sg.B("Convert",size=(10,1),button_color="green",key="-CONVERT-"),sg.Exit(button_color="red")]
		]
window = sg.Window("Converter", layout)

while True:
	event,values = window.read()
	if event in ("Exit", sg.WIN_CLOSED):
		window.close()
		break
	if event == "-CONVERT-":
		# breakpoint()
		if values["-INPUT-"]:
			val = float(values["-INPUT-"])
			if values["-SPIN-"] == "Kilo to Mile":
				result = val / 1.6
			elif values["-SPIN-"] == "Mile to kilo":
				result = val * 1.6
			elif values["-SPIN-"] == "Sec to Min":
				result = val / 60
			elif values["-SPIN-"] == "Min to Sec":
				result = val * 60
			window["-OUTPUT-"].update(result)

	print(event, values)
