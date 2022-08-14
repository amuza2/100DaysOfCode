import PySimpleGUI as sg

col_1 = [
        [sg.B(7,size=(4,2)),sg.B(8,size=(4,2)),sg.B(9,size=(4,2))],
        [sg.B(4,size=(4,2)),sg.B(5,size=(4,2)),sg.B(6,size=(4,2))],
        [sg.B(1,size=(4,2)),sg.B(2,size=(4,2)),sg.B(3,size=(4,2))],
        [sg.B('/',size=(4,2),key="-DEVID-"),sg.B(0,size=(4,2)),sg.B('+/-',size=(4,2))],
        ]

col_2 = [
        [sg.B('x',size=(4,2),key="-MULTI-")],
        [sg.B('-',size=(4,2),key="-MINUS-")],
        [sg.B('+',size=(4,2),key="-ADD-")],
        [sg.B('=',size=(4,2),key="-EQUAL-")],
        ]
layout = [
        [sg.I(size=(10,1),font=(None,30),key="-INPUT-",enable_events=True)],
        [sg.Col(col_1),sg.VerticalSeparator(),sg.Col(col_2)],
        ]

window = sg.Window("My app",layout)
history = ''
nums = [str(i) for i in range(10)]
operator = ['-MULTI-','-MINUS-','-ADD-','-DEVID-']

while True:
    event, values = window.read()
    if event == sg.WIN_CLOSED:  
        window.close()
        break
    elif event in nums:
        if (event != '0' and history == '') or (0<len(history)<10):
            window['-INPUT-'].update('')
            number = event 
            history += str(number)
            window["-INPUT-"].update(int(history))
    elif event in operator:
        op = event
        num_1 = float(history)
        history = ''
    elif event == '-EQUAL-':
        num_2 = float(history)
        history = ''
        if op == '-ADD-':
            result = num_1 + num_2
        elif op == '-MINUS-':
            result = num_1 - num_2
        elif op == '-MULTI-':
            result = num_1 * num_2
        elif op == '-DEVID-':
            result = num_1 / num_2        

        window['-INPUT-'].update(result)



    print(event, values)
