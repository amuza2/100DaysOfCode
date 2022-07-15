from kivy.app import App
from kivy.uix.screenmanager import ScreenManager, Screen
from kivy.lang import Builder
import time, os

Builder.load_file("frontend.kv")

class CameraScreen(Screen):
	def start(self):
		self.ids.camera.play = True
		self.ids.camera_button.text = "Stop Camera"
		self.ids.camera.texture = self.ids.camera._camera.texture

	def stop(self):
		self.ids.camera.play = False
		self.ids.camera_button.text = "Start Camera"
		self.ids.camera.texture = None

	def capture(self):
		current_time = time.strftime("%Y%m%d-%H%M%S")
		if not os.path.isdir("files"):
			os.mkdir("files")
		file_path = f"files/{current_time}.png"
		if self.ids.camera.play == True:
			self.ids.camera.export_to_png(file_path)

		self.manager.current = "image_screen"

class ImageScreen(Screen):
	pass

class RootWidget(ScreenManager):
	pass

class MainApp(App):
	def build(self):
		return RootWidget()

MainApp().run()