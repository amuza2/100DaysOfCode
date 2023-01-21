import PySimpleGUI as sg

layout = [
    [sg.Graph(
        canvas_size=(400, 400),
        graph_bottom_left=(0, 0),
        graph_top_right=(400, 400),
        key="graph"
    )],
]

window = sg.Window("draw an image", layout)
window.Finalize()

graph = window.Element("graph")

graph.DrawImage(filename="rectangle.png", location=(0, 300))

while True:
    event, values = window.Read()
    if event is None:
        break
