import PySimpleGUI as sg


tab1_layout =  [[sg.ML('Enter text here',size=(65,20))]]

tab2_layout = [
				[sg.T('Enter full name:',size=(15,1)), sg.I(key="-NAME-")],
				[sg.T('Enter address:',size=(15,1)), sg.I(key="-ADDRESS-")],
				[sg.T('Enter phone number:',size=(15,1)), sg.I(key="-PHONE-")],
                [sg.B("Submit Contact Information",key="-SUBMIT-")],
               ]


contact_info = [['Med',"Tipaza","0558268821"]]
headings = ["Full Name","Address","phone number"]
tab3_layout = [[sg.Table(contact_info,headings,num_rows=5,
				display_row_numbers=True,max_col_width=40,key="-TABLE1-",row_height=35,justification="right",
				)]]

layout = [
			[sg.TabGroup(
						[
							[sg.Tab('Instruction', tab1_layout), sg.Tab('Enter contact information', tab2_layout),sg.Tab("All contacts",tab3_layout)],
						]
						,tab_location="centertop",selected_background_color="purple"),
			],
            [sg.Button('Submit')],
          ]

window = sg.Window("My Tool", layout)

while True:
	event, value = window.read()
	if event in (sg.WIN_CLOSED, "Exit"):
		window.close()
		break
	elif event == "-SUBMIT-":
		contact_info.append([value["-NAME-"],value["-ADDRESS-"],value["-PHONE-"]])
		window["-TABLE1-"].update(contact_info)
		sg.popup_ok("Contact added")
		print(event, value)