"""
    I made a video that explain the code
    https://www.youtube.com/watch?v=Xq5VDKkUCpo

"""
import PySimpleGUI as sg
from youtube_downloader import ConvertToMp3
from threading import Thread


layout = [
    [sg.B("Add", key="-ADD-", size=(10, 1), font="None 10 bold",
          button_color="#007339"), sg.I(key="-URL-")],
    [sg.LB(values='', key="-LB-", size=(60, 10), enable_events=True,
           horizontal_scroll=True)],
    [sg.B("Download", key="-DOWN-", font="None 10 bold", size=(15, 1), button_color=('white', '#007339')),
     sg.B("Remove", key="-REMOVE-", font="None 10 bold",
          size=(10, 1), button_color=("#735700")),
     sg.Exit(button_color=('white', 'firebrick4'), font="None 10 bold"), ],
    # [sg.B("testing", key="-testing-", visible=False)],
]

urls = {}
oDownload = ConvertToMp3()
window = sg.Window("Youtube to MP3", layout, icon="download.ico")


def add_url(active):
    try:
        file_title = oDownload.get_video_title(values['-URL-'])
    except:
        active = False
        window["-URL-"].update('')

    if active:
        urls[values["-URL-"]] = file_title
        window["-LB-"].update('')
        window["-LB-"].update(urls.values())
        window["-URL-"].update('')


while True:
    active = True
    event, values = window.read()
    if event in (sg.WIN_CLOSED, "Exit"):
        window.close()
        break
    if event == "-ADD-" and values["-URL-"]:
        Thread(target=add_url, args=(active,)).start()

    elif event == "-REMOVE-":
        if values["-LB-"]:
            for k, v in urls.items():
                if v == values["-LB-"][0]:
                    del urls[k]
                    break
            window["-LB-"].update(urls.values())

    elif event == "-DOWN-":
        if urls:
            for k in urls.keys():
                Thread(target=oDownload.start_download,
                       args=(k,), daemon=True).start()

    elif event == "-testing-":
        test_links = ["https://www.youtube.com/watch?v=rBtmXY3zTfw",
                      "https://www.youtube.com/watch?v=nJS_9wFaSts",
                      "https://www.youtube.com/watch?v=nAI3pF9LZiw"]
        dict_links = {}
        for link in test_links:
            file_name = oDownload.get_video_title(link)
            dict_links[link] = file_name
        urls = dict_links
        window["-LB-"].update(urls.values())

    print(event, values)
    print("URLS:", urls)
