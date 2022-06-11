"""
build an app that has a screen where you draw shapes
depends on input you give
"""
from canvas import Canvas
from shape import Rectangle

canvas = Canvas(200, 300, (1,1,1))
r1 = Rectangle(50, 50, 120, 200, (100,200,125))
r1.draw(canvas)
canvas.make("rectangle.png")
