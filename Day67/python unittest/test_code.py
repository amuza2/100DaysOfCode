import unittest
import main


class TestCalc(unittest.TestCase):
    def test_add(self):
        result = main.add(10, 5)
        return self.assertEqual(result, 15)


if __name__ == '__main__':
    unittest.main()
