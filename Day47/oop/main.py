from gui import *
from stopwatch import StopWatch

window = sg.Window("StopWatch",layout,size=(250,150),element_justification="Center")
oStopWatch = StopWatch(window)
while True:
	event, values = window.read(timeout=10)
	if event in ("Exit", sg.WIN_CLOSED):
		window.close()
		break
	if event == "-START-":
		oStopWatch.start_count("-START-")

	oStopWatch.calculate_time("-LABEL-")

	if event == "-STOP-":
		oStopWatch.stop_count("-LABEL-", "-START-")
