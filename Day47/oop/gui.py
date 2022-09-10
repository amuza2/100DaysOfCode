import PySimpleGUI as sg

sg.theme("default")
layout= [
		[sg.T("0:0",font="None 20 bold",key="-LABEL-")],
		[sg.T()],
		[sg.B("Start",size=(15,1),button_color="green",key="-START-")],
		[sg.B("Stop",size=(15,1),button_color="red",key="-STOP-")]
		]
