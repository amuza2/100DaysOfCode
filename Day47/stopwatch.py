"""
	in this example I am creating a stopwatch app
"""

import PySimpleGUI as sg
from time import time

sg.theme("default")
layout= [
		[sg.T("0:0",font="None 20 bold",key="-LABEL-")],
		[sg.T()],
		[sg.B("Start",size=(15,1),button_color="green",key="-START-")],
		[sg.B("Stop",size=(15,1),button_color="red",key="-STOP-")]
		]
active = False
pause = False
b_pause = False
window = sg.Window("StopWatch",layout,size=(250,150),element_justification="Center")
while True:
	event, values = window.read(timeout=10)
	if event in ("Exit", sg.WIN_CLOSED):
		window.close()
		break
	if event == "-START-":
		if b_pause:
			pause = True
			b_pause = False
			active = False
			window["-START-"].update("Continue")
		else:
			active = True
			b_pause = True
			window["-START-"].update("Pause")

		if pause == False:
			start_time = time()

	if active:
		if pause:
			updated_time += 0.01
			running_time = round(updated_time - start_time,1)
		else:
			updated_time = time()
			running_time = round(updated_time - start_time,1)
		window["-LABEL-"].update(running_time)


	if event == "-STOP-":
		active = False
		b_pause = False
		pause = False
		window["-LABEL-"].update("0.0")
		window["-START-"].update("Start")



	print(event, values)