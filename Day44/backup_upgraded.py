import PySimpleGUI as sg
import os,shutil,zipfile

col_1 = [
		[sg.CB("Compress",key="-CBCOM-")],
		[sg.CB("Recursive",key="-CBREC-")],
		[sg.T("Extension"), sg.I("*.*",key="-EXTENSION-")],
		]

layout = [
		[sg.T("Choose Source Folder:",size=(19,1)),sg.I(key="-SOURCEFOLDER-",enable_events=True),sg.FolderBrowse()],
		[sg.T("Choose Destination Folder:",size=(19,1)),sg.I(key="-DESTINATIONFOLDER-"),sg.FolderBrowse()],
		[sg.T("File name:",size=(19,1)), sg.I(key="-FILENAME-")],
		[sg.T("File List:")],
		[sg.Listbox(values='',key="-LISTBOX-", size=(50,15)),sg.Col(col_1)],
		[sg.B("Backup",button_color="green"),sg.Exit()],
		]

window = sg.Window("Backup tool", layout,size=(600,450))
while True:
	event, values = window.read()
	
	if event in ("Exit", sg.WIN_CLOSED):
		window.close()
		break
	elif event == "-SOURCEFOLDER-":
		window["-LISTBOX-"].update('')
		fname = os.listdir(values["-SOURCEFOLDER-"])
		window["-LISTBOX-"].update(fname)
		
	elif event == "Backup":
		if not values["-SOURCEFOLDER-"]:
			sg.popup("Select Source Folder")
		elif not values["-DESTINATIONFOLDER-"]:
			sg.popup("Select Destination Folder")
		elif not values["-FILENAME-"]:
			sg.popup("Add a file name")
		else:
			source_path = values["-SOURCEFOLDER-"]
			destination_path = values["-DESTINATIONFOLDER-"]
			file_name = values["-FILENAME-"]

			files_source = os.path.dirname(source_path)
			folder_name = os.path.basename(source_path)
			file_path = os.path.join(os.getcwd(),f"{file_name}.zip")
			# shutil.make_archive(file_name, "zip",files_source,folder_name)
			

			compress = False
			if values["-CBCOM-"]:
				compress = zipfile.ZIP_DEFLATED
			with zipfile.ZipFile(f"{file_name}.zip", 'w',compression=compress) as f:
				for i in fname:
					file = os.path.join(values['-SOURCEFOLDER-'],i)
					file.split('/')
					f.write(file,f"{folder_name}\\")
			# shutil.move(file_path, destination_path)
			print("Zip files Created")




	print(event, values)
