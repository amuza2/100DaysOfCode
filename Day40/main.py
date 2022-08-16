import PySimpleGUI as sg
import os.path

left_layout = [
			[sg.T("Image Folder"),sg.I(key="FOLDER",size=(25,1),enable_events=True), sg.FolderBrowse()],
			[sg.Listbox(values=[],key="LISTBOX",size=(40,20),enable_events=True)],
			]
right_layout = [
			[sg.T("Choose an image from the list on the left:")],
			[sg.T(key="LINK",size=(40,1))],
			[sg.Image(key="IMG")],
			]
layout = [
			[sg.Column(left_layout),
			sg.VerticalSeparator(),
			sg.Column(right_layout),
			]
		]
window = sg.Window("Image Viewer", layout)
while True:
	event, value = window.read()
	if event == sg.WIN_CLOSED:
		window.close()
		break
	elif event == "FOLDER":
		folder = value["FOLDER"]
		try:
			file_list = os.listdir(folder)
			# print(file_list)
		except:
			file_list = []
		fname = [
				f for f in file_list if os.path.isfile(os.path.join(folder, f)) and f.lower().endswith((".png",".gif"))
				]
		# print(fname)
		window["LISTBOX"].update(fname)
	elif event == "LISTBOX":
		try:
			filename = os.path.join(value["FOLDER"], value["LISTBOX"][0])
			window["LINK"].update(filename)
			window["IMG"].update(filename=filename)

		except:
			print("not working")

