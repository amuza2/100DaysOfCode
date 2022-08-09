import PySimpleGUI as sg
from tool import convert_to_bytes


sg.theme("darkbrown")
layout = [
        [sg.T("Select a file")],
        [sg.I(key="-IMG-"), sg.FileBrowse(file_types=(("All Files",["*.jpeg","*.jpg","*.png"]),
									("JPEG","*.jpeg"),("jpg","*.jpg"),("PNG","*.png")))],
        [sg.Image(key="-PHOTO-",size=(300, 300))],
        [sg.Combo(["US","England","Spain"], default_value="US"), sg.Checkbox("check",key="-CHK-", enable_events=True),
        sg.Ok(),sg.Cancel(),sg.Button("Clear")]
]

window = sg.Window("Image Browser", layout)

while True:
	event, value = window.read()
	if event == sg.WIN_CLOSED:
		break
	elif event == "-IMG-":
		window['-PHOTO-'].update(data=convert_to_bytes(value["-IMG-"],resize=(300,300)))
	elif event == "Clear":
		window["-CHK-"].update(not value["-CHK-"])
	print(event, value)