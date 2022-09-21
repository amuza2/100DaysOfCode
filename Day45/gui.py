"""
	This is Youtube Downloader project
	used the youtube_dl module
	For downloading Youtube video as mp3

"""
import PySimpleGUI as sg
from youtube_downloader import ConvertToMp3
from threading import Thread


layout = [
		[sg.B("Add",key="-ADD-",size=(10,1),font="None 10 bold",button_color="green"),sg.I(key="-URL-")],
		[sg.Listbox(values='',key="-LB-",size=(60,10),horizontal_scroll=True,enable_events=True)],
		[sg.B("Download",key="-DOWN-",font="None 10 bold",size=(15,1)),sg.B("Remove",key="-REMOVE-",font="None 10 bold",size=(10,1)),sg.Exit(button_color="red",font="None 10 bold")],
		]

urls = []
window = sg.Window("Youtube to MP3", layout)
while True:
	oDownload = ConvertToMp3()
	event, values = window.read()
	if event in (sg.WIN_CLOSED, "Exit"):
		window.close()
		break
	
	if event == "-ADD-" and values["-URL-"]:
			Thread(target=oDownload.get_video_title, args=(values["-URL-"],), daemon=True).start()
			urls.append(values['-URL-'])
			window["-LB-"].update('')
			window["-LB-"].update([oDownload.show_title])
			window["-URL-"].update('')
	elif event == "-REMOVE-":
		if values["-LB-"]:
			s = "".join(values["-LB-"])
			urls.remove(s)
			window["-LB-"].update(urls)
	elif event == "-DOWN-":
		if urls:
			
			Thread(target=oDownload.run, args=(urls,),daemon=True).start()
			

	print(event, values)
