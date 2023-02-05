import unittest
import calc


class TestCalc(unittest.TestCase):
    def test_add(self):
        self.assertEqual(calc.add(10, 5), 15)
        self.assertEqual(calc.add(-1, 1), 0)
        self.assertEqual(calc.add(-1, -1), -2)

    def test_minus(self):
        self.assertEqual(calc.minus(10, 5), 5)
        self.assertEqual(calc.minus(-1, 1), -2)
        self.assertEqual(calc.minus(-1, -1), 0)

    def test_multi(self):
        self.assertEqual(calc.multi(10, 5), 50)
        self.assertEqual(calc.multi(-1, 1), -1)
        self.assertEqual(calc.multi(-1, -1), 1)

    def test_div(self):
        self.assertEqual(calc.div(10, 5), 2)
        self.assertEqual(calc.div(-1, 1), -1)
        self.assertEqual(calc.div(-1, -1), 1)

        self.assertRaises(ValueError, calc.div, 10, 2)


if __name__ == '__main__':
    unittest.main(exit=False)
