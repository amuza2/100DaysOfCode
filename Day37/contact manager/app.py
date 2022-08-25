import PySimpleGUI as sg
from manage import *
from tool import convert_to_bytes
import shutil


def create_contact_gui():
	sg.set_options(element_padding=(5,10))
	layout_left = [
			[sg.T("First name",size=(9,1)),sg.I(key="-FIRST-")],
			[sg.T("Last name",size=(9,1)),sg.I(key="-LAST-")],
			[sg.T("Address",size=(9,1)),sg.I(key="-ADD-")],
			[sg.T("Phone",size=(9,1)),sg.I(size=(18,1),key="-PHONE-"),
			sg.T("Mobile",size=(5,1)),sg.I(size=(17,1),key="-MOB-")],
			[sg.T("Email",size=(9,1)),sg.I(key="-EMAIL-")],
			[sg.T("Occupation",size=(9,1)),sg.I(key="-OCC-")],
			[sg.T("Gender",size=(9,1)),sg.Combo(["Male","Female"],key="-GEN-")],
			[sg.T("Age",size=(9,1)),sg.Slider(range=(16,50),orientation="h",size=(40,20),default_value=20,key="-AGE-")],
			]
	layout_right = [
					[sg.T("Select image"),
					sg.I(enable_events=True,key="-IMG-"),
					sg.FileBrowse(key="-BROWSE-",file_types=(("All Files",["*.jpeg","*.jpg","*.png"]),
												("JPEG","*.jpeg"),("jpg","*.jpg"),("PNG","*.png")))],
					[sg.Image(key="-PHOTO-",data=convert_to_bytes("res/placeholder-image.png",resize=(300,300)))]
					]
	layout = [
			[sg.Frame("Contact Data",layout_left,vertical_alignment="center",pad=((10,10),(10,10))),sg.VerticalSeparator(),sg.Col(layout_right,element_justification="center")],
			[sg.B("Add",enable_events=True),sg.Cancel()]
			]
	window = sg.Window("Create Contact", layout)
	while True:
		event, value = window.read()
		if event == sg.WIN_CLOSED or event == "Cancel":
			window.close()
			break
		elif event == "-IMG-":
			window["-PHOTO-"].update(data=convert_to_bytes(value["-IMG-"],resize=(300,300)))
		elif event == "Add":
			first_name = value["-FIRST-"]
			last_name = value["-LAST-"]
			address = value["-ADD-"]
			phone = value["-PHONE-"]
			mobile = value["-MOB-"]
			email = value["-EMAIL-"]
			gender = value["-GEN-"]
			occupation = value["-OCC-"]
			age = value["-AGE-"]
			_photo = value["-IMG-"]
			if _photo:
				name = _photo.split("/")[-1]
				photo = "imageDB/"+name
				shutil.copy(_photo, photo)
			else:
				photo = "res/placeholder-image.png"
			create_contact(first_name, last_name, address, phone, mobile, email, gender, occupation, age, photo)
			for key in value:
				if key != "-BROWSE-":
					window[key].update("")
			window["-PHOTO-"].update(data=convert_to_bytes("res/placeholder-image.png",resize=(300,300)))
			window["-AGE-"].update(20)


def create_user_gui():
	layout = [
			[sg.T("User name", size=(10,1)), sg.I(key="-USER-")],
			[sg.T("password",size=(10,1)),sg.I(key="-PASS-",password_char='*')],
			[sg.T("Email",size=(10,1)), sg.I(key="-EMAIL-")],
			[sg.Ok(), sg.Cancel(),sg.B("admin")],
			]
	window = sg.Window("Create user", layout)
	while True:
		event, value = window.read()
		if event == sg.WIN_CLOSED or event == "Cancel":
			window.close()
			break
		elif event == "Ok":
			username = value["-USER-"]
			password = value["-PASS-"]
			email = value["-EMAIL-"]
			create_user(username, password, email)
			window.close()
		elif event == "admin":
			admin_account()


def list_contacts_gui():
	sg.set_options(element_padding=(10, 10))
	layout = []
	contacts = contact_list()
	idx = 0
	for con in contacts:
		photo = con.photo
		row = [sg.CB("",key=f"-ID-{idx}",enable_events=True),sg.I(con.first_name + " " + con.last_name,size=(25,1)),sg.I(con.email,size=(20,1),key=f"-EMAIL-{idx}"),
				sg.Image(data=convert_to_bytes(photo,resize=(100,150)))]
		layout.append(row)
		idx += 1
	layout.append([sg.B("Edit"),sg.B("Delete"),sg.Cancel()])
	window = sg.Window("Contact list", layout)
	selected = []
	while True:
		event, value = window.read()
		print(event, value)
		if event in (sg.WIN_CLOSED,"Cancel"):
			window.close()
			break
		elif "-ID-" in event:
			if value[event]:
				selected.append(event)
			else:
				selected.remove(event)
		elif event == "Delete":
			if selected:
				for d_con in selected:
					delete_contact(value["-EMAIL-"+d_con.split('-')[-1]])
				window.close()
		elif event == "Edit":
			if len(selected)>1:
				sg.popup_error("Please select one contact")
			elif len(selected) == 1:
				sg.set_options(element_padding=(5,10))
				layout_left = [
						[sg.T("First name",size=(9,1)),sg.I(key="-FIRST-")],
						[sg.T("Last name",size=(9,1)),sg.I(key="-LAST-")],
						[sg.T("Address",size=(9,1)),sg.I(key="-ADD-")],
						[sg.T("Phone",size=(9,1)),sg.I(size=(18,1),key="-PHONE-"),
						sg.T("Mobile",size=(5,1)),sg.I(size=(17,1),key="-MOB-")],
						[sg.T("Email",size=(9,1)),sg.I(key="-EMAIL-")],
						[sg.T("Occupation",size=(9,1)),sg.I(key="-OCC-")],
						[sg.T("Gender",size=(9,1)),sg.Combo(["Male","Female"],key="-GEN-")],
						[sg.T("Age",size=(9,1)),sg.Slider(range=(16,50),orientation="h",size=(40,20),default_value=20,key="-AGE-")],
						]
				layout_right = [
								[sg.T("Select image"),
								sg.I(enable_events=True,key="-IMG-"),
								sg.FileBrowse(key="-BROWSE-",file_types=(("All Files",["*.jpeg","*.jpg","*.png"]),
															("JPEG","*.jpeg"),("jpg","*.jpg"),("PNG","*.png")))],
								[sg.Image(key="-PHOTO-",data=convert_to_bytes("res/placeholder-image.png",resize=(300,300)))]
								]
				layout = [
						[sg.Frame("Contact Data",layout_left,vertical_alignment="center",pad=((10,10),(10,10))),sg.VerticalSeparator(),sg.Col(layout_right,element_justification="center")],
						[sg.B("Ok"),sg.Cancel()]
						]
				window = sg.Window("Edit Contact", layout)
				while True:
					event, value = window.read()
					if event == sg.WIN_CLOSED or event == "Cancel":
						window.close()
						break
					elif event == "-IMG-":
						window["-PHOTO-"].update(data=convert_to_bytes(value["-IMG-"],resize=(300,300)))
					elif event == "Add":
						first_name = value["-FIRST-"]
						last_name = value["-LAST-"]
						address = value["-ADD-"]
						phone = value["-PHONE-"]
						mobile = value["-MOB-"]
						email = value["-EMAIL-"]
						gender = value["-GEN-"]
						occupation = value["-OCC-"]
						age = value["-AGE-"]
						_photo = value["-IMG-"]
						if _photo:
							name = _photo.split("/")[-1]
							photo = "imageDB/"+name
							shutil.copy(_photo, photo)
						else:
							photo = "res/placeholder-image.png"
					else:
						sg.popup("Please select a contact")

def list_user_gui():
	layout = []
	users = list_users()
	idx = 0
	for user in users:
		layout.append([sg.CB('',key=f"-ID-{idx}",enable_events=True),sg.I(user.username, size=(20,1),key=f"-USER-{idx}"),sg.I(user.email,size=(25,1))])
		idx += 1
	layout.append([sg.B("Delete"), sg.Cancel()])
	window = sg.Window("List Users", layout)
	selected = []
	while True:
		event, value = window.read()
		if event == sg.WIN_CLOSED or event == "Cancel":
			window.close()
			break
		elif "-ID-" in event:
			if value[event]:
				selected.append(event)
			else:
				selected.delete(event)

		elif event == "Delete":
			for d_user in selected:
				delete_user(value["-USER-"+d_user.split('-')[-1]])
			window.close()


def delete_user_gui():
	username = sg.popup_get_text("Enter username to delete:")
	user = query_user(username)
	if user:
		response = sg.popup_ok_cancel("want to delete user?")
		if response:
			delete_user(username)

	else:
		sg.popup_error("User doesn't exit")


def admin_account():
	if not query_user("admin"):
		create_user("admin", "password", "admin@email.com")


def main():
	menu = [
			["Contacts",["Create contact","List Contact","Find contact","Delete contact"]],
			["User",["Create User","List users","Delete user"]],
			["Exit",["Quit"]],
			]

	layout = [
				[sg.Menu(menu)],
				[sg.Image(data=convert_to_bytes("res/contact-image.png", resize=(490,220)))],
			]

	window = sg.Window("Contact Manager", layout,background_color="#6c69df",icon="res/contact-icon.ico")

	while True:
		event, value = window.read()
		if event == sg.WIN_CLOSED or event == "Quit":
			window.close()
			break
		elif event == "Create User":
			create_user_gui()
		elif event == "List users":
			list_user_gui()
		elif event == "Delete user":
			delete_user_gui()
		elif event == "Create contact":
			create_contact_gui()
		elif event == "List Contact":
			list_contacts_gui()


if __name__ == "__main__":
	sg.theme("DarkGrey")
	main()

