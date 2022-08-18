"""
	This is Youtube Downloader project
	used the pytube module
	download mp3 and mp4 files
	customize the resolution for the video

"""

from pytube import YouTube
from pytube import Stream

yt = YouTube("https://www.youtube.com/watch?v=BJ76PGWSooE")
stream = yt.streams.get_by_resolution("720p")
# stream.filter(res="480")
stream.download()