import PySimpleGUI as sg

# new window
def createwindow():
    layout = [[sg.T("Hello from PySimpleGUI")], [sg.Button("OK")]]
    window = sg.Window("Demo", layout)
    while True:
        event, values = window.read()
        if event == "Exit" or event == sg.WIN_CLOSED:
            break
        elif event == "OK":
            break
    window.close()


# main window
layout = [
    [sg.T("Click to create a nw window:")],
    [sg.B("open window", key="NEWWINDOW")]
]
window = sg.Window("PySimpleGUI", layout)
while True:
    event, values = window.read()
    if event == "Cancel" or event == sg.WIN_CLOSED:
        break
    elif event == "NEWWINDOW":
        # call the method that will create a new window
        createwindow()
window.close()
