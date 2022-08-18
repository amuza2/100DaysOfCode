"""
	This is Youtube Downloader project
	used the youtube_dl module
	For downloading Youtube video as mp3

"""

import youtube_dl
import threading


def run():
    video_urls = ["https://www.youtube.com/watch?v=pmlNSa1szEA",
    			"https://www.youtube.com/watch?v=voICYzatU5c"]
    
    for video_url in video_urls:
	    video_info = youtube_dl.YoutubeDL().extract_info(
	        url = video_url,download=False)
	    filename = f"{video_info['title']}.mp3"
	    options={
	        'format':'bestaudio/best',
	        'keepvideo':False,
	        'outtmpl':filename,
	    }

	    with youtube_dl.YoutubeDL(options) as ydl:
	        ydl.download([video_info['webpage_url']])
    
    print(f"Download complete... {filename}")

if __name__=='__main__':
	run()






