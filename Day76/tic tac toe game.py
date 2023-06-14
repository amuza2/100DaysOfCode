import PySimpleGUI as sg

layout = [[sg.Button("", size=(10, 5), key=(i, j))
           for j in range(3)] for i in range(3)]

layout.append([sg.Button("Reset"), sg.Button("Exit")])

window = sg.Window("Tic Tac Toe", layout)


def check_win(board):
    for i in range(3):
        if board[i][0] == board[i][1] == board[i][2] != "":
            return True
        if board[0][i] == board[1][i] == board[2][i] != "":
            return True
    if board[0][0] == board[1][1] == board[2][2] != "":
        return True
    if board[0][2] == board[1][1] == board[2][0] != "":
        return True
    return False


def make_move(board, player, position):
    if board[position[0]][position[1]] == "":
        board[position[0]][position[1]] = player
        return True
    else:
        return False


board = [["" for _ in range(3)] for _ in range(3)]
player = "X"

while True:
    event, values = window.read()
    if event == sg.WIN_CLOSED:
        break

    if event in [(i, j) for i in range(3) for j in range(3)]:
        position = (event[0], event[1])
        if make_move(board, player, position):
            window[event].update(player)
            if check_win(board):
                sg.popup(f"{player} wins!")
                break
            elif all([all(row) for row in board]):
                sg.popup("Tie game!")
                break
            player = "O" if player == "X" else "X"

    if event == "Reset":
        board = [["" for _ in range(3)] for _ in range(3)]
        player = "X"
        for i in range(3):
            for j in range(3):
                window[(i, j)].update("")

    if event == "Exit":
        window.close()

window.close()
