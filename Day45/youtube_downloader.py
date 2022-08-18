"""
	This is Youtube Downloader project
	used the pytube module
	download mp3 and mp4 files
	customize the resolution for the video

"""

from pytube import YouTube

yt = YouTube("https://www.youtube.com/watch?v=BJ76PGWSooE")
stream = yt.streams.get_lowest_resolution()
stream.download()