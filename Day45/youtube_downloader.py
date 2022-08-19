"""
	convering youtube videos into mp3 files
"""
import youtube_dl


def run(video_urls):
    """ this funtion responssible for downloading and convering"""
    
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
