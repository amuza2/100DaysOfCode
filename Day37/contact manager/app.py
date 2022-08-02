import PySimpleGUI as sg
from manage import *
from tool import convert_to_bytes


def create_contact_gui():
	layout = [
			[sg.T("First name",size=(10,1)),sg.I(),sg.FileBrowse(file_types=(("All Files",["*.jpeg","*.jpg","*.png"]),
																			("JPEG","*.jpeg"),("jpg","*.jpg"),("PNG","*.png")))],
			[sg.T("Last name",size=(10,1)),sg.I()],
			[sg.T("Gender",size=(10,1)),sg.Combo(["Male","Female"])],
			[sg.T("Age",size=(10,1)),sg.Slider(range=(1,100),orientation="horizontal")],
			]
	window = sg.Window("Create Contact", layout)
	while True:
		event, value = window.read()
		if event == sg.WIN_CLOSED:
			window.close()
			break

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


def list_user_gui():
	layout = []
	users = list_users()
	idx = 0
	for user in users:
		layout.append([sg.CB('',key=f"-ID-{idx}",enable_events=True),sg.I(user.username, size=(20,1),key=f"-USER-{idx}"),sg.I(user.email,size=(25,1))])
		idx += 1
	layout.append([sg.B("Delete"), sg.B("Cancel")])
	window = sg.Window("List Users", layout)
	selected = []
	while True:
		event, value = window.read()
		print(event, value)
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


if __name__ == "__main__":
	sg.theme("DarkGrey")
	main()

