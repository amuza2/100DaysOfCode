from youtube_dl import YoutubeDL


class ConvertToMp3():

    def get_video_title(self, url):
        """ get the video title

        Args:
            url (string): Youtube url

        Returns:
            string: Youtube video title
        """
        video_info = YoutubeDL().extract_info(url=url, download=False)
        video_title = video_info.get('title', None)
        return video_title

    def start_download(self, url):
        """Download file as mp3 format

        Args:
            url (string): Youtube url
        """
        video_info = YoutubeDL().extract_info(url=url, download=False)
        video_title = video_info.get("title", None)
        filename = str(video_title) + ".mp3"
        options = {'format': 'bestaudio/best',
                   'keepvideo': False, 'outtmpl': filename}

        with YoutubeDL(options) as ydl:
            ydl.download([video_info['webpage_url']])
