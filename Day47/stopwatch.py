"""
	in this example I am creating a stopwatch app
"""

import PySimpleGUI as sg
from time import time

layout= [
		[sg.T("00:00",font="None 20 bold",key="-LABEL-")],
		[sg.T()],
		[sg.B("Start",size=(15,1),button_color="green",key="-START-")],
		[sg.B("Stop",size=(15,1),button_color="red",key="-STOP-")]
		]
active = False
window = sg.Window("StopWatch", layout,size=(200,150),element_justification="Center")
while True:
	event, values = window.read(timeout=10)
	if event in ("Exit", sg.WIN_CLOSED):
		window.close()
		break
	if event == "-START-":
		start_time = time()
		active = True
	if active:
		running_time = round(time() - start_time,0)
		window["-LABEL-"].update(running_time)
	else:
		start_time = round(time(),0)
		window["-LABEL-"].update(start_time)

	print(event, values)