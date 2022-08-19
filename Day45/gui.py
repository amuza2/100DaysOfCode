"""
	This is Youtube Downloader project
	used the youtube_dl module
	For downloading Youtube video as mp3

"""
import PySimpleGUI as sg
from youtube_downloader import run
import threading


layout = [
		[sg.B("Add",key="-ADD-",size=(10,1),font="None 10 bold",button_color="green"),sg.I(key="-URL-")],
		[sg.Listbox(values='',key="-LB-",size=(60,10),horizontal_scroll=True,enable_events=True)],
		[sg.B("Download",key="-DOWN-",font="None 10 bold",size=(15,1)),sg.B("Remove",key="-REMOVE-",font="None 10 bold",size=(10,1)),sg.Exit(button_color="red",font="None 10 bold")],
		]

urls = []
l = []
c = 1
window = sg.Window("Youtube to audio converter", layout)
while True:
	event, values = window.read()
	if event in (sg.WIN_CLOSED, "Exit"):
		window.close()
		break
	if urls:
		l = [i.split()[-1] for i in urls]
			
	if event == "-ADD-":
		urls.append(f"{c}- {values['-URL-']}")
		window["-LB-"].update('')
		window["-LB-"].update(urls)
		window["-URL-"].update('')
		c+=1
	elif event == "-REMOVE-":
		if values["-LB-"]:
			s = "".join(values["-LB-"])
			urls.remove(s)
			window["-LB-"].update(urls)
	elif event == "-DOWN-":
		if l:
			threading.Thread(target=run, args=(l,),daemon=True).start()
			

	print(event, values)
