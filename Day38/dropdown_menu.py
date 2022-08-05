import PySimpleGUI as sg

menu = [
		["File", ["Open", "Save","Exit"]],
		["Edit",["Past",["Special","Normal"],"Undo","Redo"]],
		["Help",["Documentation","about"]],
		]

button_menu =["File",["Option",['1','2','3'],"Save","Settings","Exit"]]

layout = [
		[sg.Menu(menu,text_color="black",pad=(10,10))],
		[sg.ButtonMenu("Button Menu",menu_def=button_menu,border_width=5,key="-B-MENU-")],
		[sg.Multiline(size=(80,10),tooltip="write you text here")],
		[sg.T("File Name"),sg.I(),sg.OptionMenu(values=[".txt",".pdf",".jpg"],default_value=".txt",key="-DATA_TYPE-")],
		[sg.B("Save File",button_color="green"),sg.Exit()],
		]

window = sg.Window("Desktop application", layout)

while True:
	event, value = window.read()
	if event in (sg.WIN_CLOSED, "Exit"):
		window.close()
		break
	elif event == "Open":
		print("Clicked on open")
	elif event == "Save" or event == "Save File":
		print("clicked on save")
		print(value["-DATA_TYPE-"])
	elif value["-B-MENU-"]:
		print(f'clicked on {value["-B-MENU-"]}')