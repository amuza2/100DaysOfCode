"""
build an app that has a screen where you draw shapes
depends on input you give
"""
from canvas import Canvas
from shape import Square, Rectangle

canvas = Canvas(200, 300, (1,1,1))
# r1 = Rectangle(50, 50, 120, 200, (100,200,125))
# r1.draw(canvas)
r2 = Square(50,50, 75, (124,251,30))
r2.draw(canvas)
canvas.make("rectangle.png")
