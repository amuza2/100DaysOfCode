import PySimpleGUI as sg

# Create a custom popup specifying the window size 
def custom_yes_no_popup(message, title="Custom Yes/No Popup", size=(300, 150)):
    
    layout = [
        [sg.Text(message)],
        [sg.Button("Yes"), sg.Button("No")]
    ]
    
    window = sg.Window(title, layout, size=size)

    while True:
        event, values = window.read()
        if event == "Yes":
            window.close()
            return True
        elif event == "No" or event == sg.WIN_CLOSED:
            window.close()
            return False
        
custom_yes_no_popup("Do you want to proceed?", size=(400, 200))