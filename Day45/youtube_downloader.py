"""
	convering youtube videos into mp3 files
"""
from youtube_dl import YoutubeDL

class ConvertToMp3():
	"""
		this class has method to convert mp4 youtube vids into mp3
	"""

	def __init__(self):
		self.video_title = None
		self.video_info = None
		self.filename = None
		self.options = None

	def get_video_title(self, url):
		self.video_info = YoutubeDL().extract_info(url=url,download=False)
		self.video_title = self.video_info.get('title', None)
		return self.video_title

	@property
	def show_title(self):
		return self.video_title

	def run(self, video_urls):
		""" This method iterate through urls get video info and download file """
		for video_url in video_urls:
			self.download_to_mp3(video_url)

	def download_to_mp3(self, url):
		""" Download the file """
		self.filename = str(self.video_title) + ".mp3"
		self.options={'format':'bestaudio/best', 'keepvideo':False, 'outtmpl':self.filename}
		with YoutubeDL(self.options) as ydl:
			self.video_info = ydl.extract_info(url=url,download=False)
			self.video_title = self.video_info.get('title', None)
			ydl.download([self.video_info['webpage_url']])


