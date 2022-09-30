import PySimpleGUI as sg
from countdowntimer import *

layout = [
        [sg.T("Pomodoro",key="-TITLE-")],
        [sg.T("round: 0",key="-ROUNDS-")],
        [sg.T("00:00",key="-TIME_LABEL-")],
        [sg.B("Start",key="-START-")],
        ]
        
oTimer = CountDownTimer(50)
window = sg.Window("Pomodoro",layout, size=(200,150), element_justification="Center", icon="Sprite-0001.ico")
running = False
while True:
        event, values = window.read(timeout=1)
        if event in ("Exit", sg.WIN_CLOSED):
                window.close()
                break
        if event == "-START-" and not running:
                running = True
                oTimer.start()
                window["-START-"].update("Interrupt")
        elif event == "-START-" and running:
                running = False
                oTimer.stop()
                window["-START-"].update("Start")
        if oTimer.show_time() <= 0:
                # play a finish sound
                pass
        window["-TIME_LABEL-"].update(oTimer.formated_time())

        oTimer.update()
        print(event, values)