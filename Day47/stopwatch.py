"""
	in this example I am creating a stopwatch app
"""

import PySimpleGUI as sg
from time import time
import ipdb
sg.theme("default")
layout= [
		[sg.T("00:00",font="None 20 bold",key="-LABEL-")],
		[sg.T()],
		[sg.B("Start",size=(15,1),button_color="green",key="-START-")],
		[sg.B("Peuse",size=(15,1),button_color="blue",key="-PEUSE-")],
		[sg.B("Stop",size=(15,1),button_color="red",key="-STOP-")]
		]
active = False
window = sg.Window("StopWatch", layout,element_justification="Center")
while True:
	peuse = False
	event, values = window.read(timeout=10)
	if event in ("Exit", sg.WIN_CLOSED):
		window.close()
		break
	if event == "-START-":
		active = True
		if not peuse:
			start_time = time()

	if active:
		if peuse:
			running_time = round(running_time - start_time,1)
		else:
			running_time = round(time() - start_time,1)
		window["-LABEL-"].update(running_time)

	if event == "-STOP-":
		peuse = False
		active = False
		start_time = round(time(),1)
		window["-LABEL-"].update("0.0")

	if event == "-PEUSE-":
		active = False
		peuse = True
		window["-LABEL-"].update(str(running_time))


	print(event, values)