"""
create a gui app that showes image when you write a name

"""
import wikipedia
from kivy.app import App
from kivy.uix.screenmanager import ScreenManager, Screen
from kivy.lang import Builder

Builder.load_file("frontend.kv")

class FirstScreen(Screen):
	def search_image(self):
		query = self.manager.current_screen.ids.user_query.text
		page = wikipedia.page(query)
		image_link = page.images[0]
		req = request.get(image_link)
		with open("file/image.jpeg", "wb") as file:
			file.write(req.content)


		# self.manager.current_screen.ids.img.source = "analytics.png"

class RootWidget(ScreenManager):
	pass

class MainApp(App):
	
	def build(self):
		return RootWidget()

MainApp().run()