
import PySimpleGUI as sg
import random

# Set the theme and color scheme
sg.theme('DarkGrey7')
sg.set_options(font=('Helvetica', 14))

# Images filenames
rock_image = r"C:\Users\REALMAN\Desktop\psill\playground\100DaysOfCode\Day78\rock-paper-scissors\rock.png"
paper_image = r"C:\Users\REALMAN\Desktop\psill\playground\100DaysOfCode\Day78\rock-paper-scissors\paper.png"
scissor_image = r"C:\Users\REALMAN\Desktop\psill\playground\100DaysOfCode\Day78\rock-paper-scissors\scissor.png"

layout = [
    [sg.Text('Choose your move:',size=(20, 1), justification='center')],
    [sg.Image(filename=rock_image, key='ROCK', enable_events=True), 
     sg.Image(filename=paper_image, key='PAPER', enable_events=True),
     sg.Image(filename=scissor_image, key='SCISSORS', enable_events=True)],
    [sg.Output(size=(30, 10), key="OUTPUT")]
]

window = sg.Window('Rock-Paper-Scissors', layout)

while True:
    event, values = window.read()
    if event == sg.WINDOW_CLOSED:
        break
    
    user_choice = event
    print(user_choice)
    
    # Generate computer's choice
    computer_choice = random.choice(['Rock', 'Paper', 'Scissors'])
    
    # Determine the winner
    if user_choice == computer_choice:
        result = 'It\'s a tie!'
    elif (user_choice == 'Rock' and computer_choice == 'Scissors') or (user_choice == 'Paper' and computer_choice == 'Rock') or (user_choice == 'Scissors' and computer_choice == 'Paper'):
        result = 'You win!'
    else:
        result = 'Computer wins!'
    
    # Print the result
    window['OUTPUT'].update("")
    print(f'You chose {user_choice}. Computer chose {computer_choice}. {result}')

window.close()
