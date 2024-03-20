namespace codewars
{
    class Kata
    {
        public static bool HasSubpattern(string str)
        {
            int stringLength = str.Length;
            if(stringLength < 2) return false;

            if(stringLength == 2)
            {
                if (str[0] == str[1]) return true;
                else return false;
            }

            bool areAllTrue = false;
            int incrementer = stringLength % 2 == 0 ? 2 : 1;
            int incVal = 2;
            for (int i = 0; i < stringLength; i++)
            {
                if(stringLength - incrementer >= incrementer && stringLength - incrementer % incrementer == 0)
                {
                    areAllTrue = true;
                    string firstPart = str.Substring(0, incrementer);
                    for (int j = incrementer; j < stringLength; j += incrementer)
                    {
                        string otherPart = str.Substring(j, incrementer);
                        if (otherPart != firstPart)
                        {
                            if(incrementer + incVal > stringLength / 2 ) incrementer = stringLength / 2;
                            else incrementer += incVal;
                            areAllTrue = false;
                            Console.WriteLine(incrementer);
                            break;
                        }
                    }
                    if (areAllTrue) return areAllTrue;
                }
                else break;
            }
            
            return areAllTrue;
        }
        public static int TestingMethod(string str)
        {
            return str.Length % 2;
        }
    }
}
