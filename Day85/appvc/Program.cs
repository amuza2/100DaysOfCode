using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;
using Microsoft.VisualBasic;

namespace exercice1
{
    class Program
    {
        public static void print<T>(IList<T> collection)
        {
            foreach (var word in collection)
            {
                Console.Write(word);
            }
        }
        static void Main()
        {
            string inputText = @"
            Around 825, Persian scientist and polymath Muḥammad ibn Mūsā al-Khwārizmī wrote kitāb al-ḥisāb al-hindī (""Book of Indian computation"") and kitab al-jam' wa'l-tafriq al-ḥisāb al-hindī (""Addition and subtraction in Indian arithmetic""). Both of these texts are lost in the original Arabic at this time. (However, his other book on algebra remains.)[16]

            In the early 12th century, Latin translations of said al-Khwarizmi texts involving the Hindu–Arabic numeral system and arithmetic appeared: Liber Alghoarismi de practica arismetrice (attributed to John of Seville) and Liber Algorismi de numero Indorum (attributed to Adelard of Bath).[17] Hereby, alghoarismi or algorismi is the Latinization of Al-Khwarizmi's name; the text starts with the phrase Dixit Algorismi (""Thus spoke Al-Khwarizmi"").[18]

            In 1240, Alexander of Villedieu writes a Latin text titled Carmen de Algorismo. It begins with:

            Haec algorismus ars praesens dicitur, in qua / Talibus Indorum fruimur bis quinque figuris.

            which translates to:

            Algorism is the art by which at present we use those Indian figures, which number two times five.

            The poem is a few hundred lines long and summarizes the art of calculating with the new styled Indian dice (Tali Indorum), or Hindu numerals.";

            var words = Regex.Split(inputText, @"\s+");
            var myList = new List<string>();
            foreach (var word in words)
            {
                foreach (var letter in word)
                {
                    if(char.IsDigit(letter)) myList.Add("X");
                    else myList.Add(letter.ToString());
                }
                myList.Add(" ");
            }

            var asciiText = new List<string>();
            foreach (var letter in myList)
            {
                var endodedLetter = Encoding.ASCII.GetBytes(letter);
                var decodedLetter = Encoding.ASCII.GetString(endodedLetter);
                asciiText.Add(decodedLetter);
            }
            
            var newLines = new List<string>();
            foreach (var letter in asciiText)
            {
                if(letter.EndsWith(".")) newLines.Add("." + "\n");
                else newLines.Add(letter);
            }

            const int linesSize = 80;
            var lines = new List<string>();
            var line = "";
            foreach (var letter in newLines)
            {
                if(line.EndsWith("\n") || line.Length + letter.Length > linesSize)
                {
                    lines.Add(line);
                    line = "";
                }
                line += letter;
            }

            var word1 = new CultureInfo("en_US", false).TextInfo;
            var result = string.Join("\n", lines.Select(l => word1.ToTitleCase(l)));

            System.Console.WriteLine(result);

        }
    }
}

