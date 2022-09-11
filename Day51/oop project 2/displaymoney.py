import pygwidgets


BLACK = (0,0,0)

class DisplayMoney(pygwidgets.DisplayText):
	def __init__(self, window, loc, value=None,fontName=None,
					fontSize=24,width=150,height=None,textColor=BLACK,
					backgroundColor=None,justified="left",
					currencySymbol='$',currencySymbolOnLeft=True,
					showCents=True):
		self.currencySymbol = currencySymbol
		self.currencySymbolOnLeft = currencySymbol
		self.showCents = showCents
		if value is None:
			value = 0.00

		super().__init__(window,loc,value,fontName,fontSize,width,
						height,textColor,backgroundColor,justified)

	def setValue(self, money):
		if money == '':
			money = 0.00
		money = float(money)
		if self.showCents:
			money = "{:,.2f}".format(money)
		else:
			money = "{:,.0f}".format(money)
		if self.currencySymbolOnLeft:
			theText = self.currencySymbol + money
		else:
			theText = money + self.currencySymbol
		super().setValue(theText)

