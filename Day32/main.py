"""
create a gui app that showes an image of what you write using wikipedia module

"""
import wikipedia
import requests
from kivy.app import App
from kivy.uix.screenmanager import ScreenManager, Screen
from kivy.lang import Builder

Builder.load_file("frontend.kv")

class FirstScreen(Screen):
	def get_link(self):
		query = self.manager.current_screen.ids.user_query.text
		page = wikipedia.page(query)
		image_link = page.images[0]
		return image_link

	def download_image(self):
		req = requests.get(self.get_link())
		image_path = "image.jpg"
		with open(image_path, "wb") as file:
			file.write(req.content)
		return image_path

	def preview_image(self):
		self.manager.current_screen.ids.img.source = self.download_image()

class RootWidget(ScreenManager):
	pass

class MainApp(App):
	
	def build(self):
		return RootWidget()

MainApp().run()