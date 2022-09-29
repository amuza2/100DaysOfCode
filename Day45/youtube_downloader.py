"""
	convering youtube videos into mp3 files
"""
from youtube_dl import YoutubeDL

class ConvertToMp3():
	""" this class has method to convert mp4 youtube vids into mp3 """

	def __init__(self):
		pass

	def get_video_title(self, url):
		video_info = YoutubeDL().extract_info(url=url,download=False)
		video_title = video_info.get('title', None)
		return video_title

	def run(self, video_url):
		""" This method iterate through urls get video info and download file """
		# for video_url in video_url:
		video_info = YoutubeDL().extract_info(url=video_url,download=False)
		video_title = video_info.get("title", None)
		filename = str(video_title) + ".mp3"
		options={'format':'bestaudio/best', 'keepvideo':False, 'outtmpl':filename}
		
		with YoutubeDL(options) as ydl:
			ydl.download([video_info['webpage_url']])

