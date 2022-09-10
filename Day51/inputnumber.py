import pygame
from pygame.locals import *
import pygwidgets


BLACK = (0,0,0)
WHITE = (255,255,255)
LEGAL_KEYS_TUPLE = (pygame.K_RIGHT, pygame.K_LEFT,pygame.K_HOME,
					pygame.K_END,pygame.K_DELETE,pygame.K_BACKSPACE,
					pygame.K_RETURN, pygame.K_KP_ENTER)
LEGAL_UNICODE_CHARS = ("0123456789.-")

class InputNumber(pygwidgets.InputText):
	def __init__(self, window, loc, value='',fontName=None,
				fontSize=24,width=200,textColor=BLACK,
				backgroundColor=WHITE,focusColor=BLACK,
				initialFocus=False,nickName=None,callback=None,
				mask=None,keepFocusOnSubmit=False,
				allowFloatingNumber=True,allowNegativeNumber=True):
		self.allowFloatingNumber = allowFloatingNumber
		self.allowNegativeNumber = allowNegativeNumber
		super().__init__(window,loc,value,fontName,fontSize,width,
						textColor,backgroundColor,focusColor,
						initialFocus,nickName,callback,mask,keepFocusOnSubmit)

	def handleEvent(self, event):
		if (event.type == pygame.KEYDOWN):
			allowableKey = (event.key in LEGAL_KEYS_TUPLE) or\
							(event.unicode in LEGAL_UNICODE_CHARS)

			if not allowableKey:
				return False
			if event.unicode == '-':
				if not self.allowNegativeNumber:
					return False
				if self.cursorPosition > 0:
					return False
				if '-' in self.text:
					return False

			if event.unicode == '.':
				if not self.allowFloatingNumber:
					return False
				if '.' in self.text:
					return False

		result = super().handleEvent(event)
		return result

	def getValue(self):
		userString = super().getValue()
		try:
			if self.allowFloatingNumber:
				returnValue = float(userString)
			else:
				returnValue = int(userString)
		except ValueError:
			raise ValueError("Entry is not a number, needs to have at least one digit.")
		return returnValue