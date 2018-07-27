using IronOcr;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GoiPlayerProfileDB
{
    class OcrManager
    {

        private static string[] shipNames = { "Magnate", "Pyramidion", "Crusader", "Corsair", "Goldfish", "Spire", "Mobula", "Squid", "Stormbreaker", "Junker", "Galleon", "Shrike", "Judgement" };
        private static string acceptedCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789[]-.";

        public static OcrResult OcrImage(Image image)
        {
            AdvancedOcr ocr = new AdvancedOcr();
            ocr.ReadBarCodes = false;
            ocr.Strategy = AdvancedOcr.OcrStrategy.Advanced;
            ocr.DetectWhiteTextOnDarkBackgrounds = true;
            ocr.AcceptedOcrCharacters = acceptedCharacters;
            return ocr.Read(image);
        }
        
        public static List<string> ParseOcrResult(OcrResult result)
        {
            var pages = result.Pages;
            foreach (var page in pages)
            {
                var lines = page.LinesOfText;
                foreach (var line in lines)
                {
                    string ending = line.Words.Last().Text;
                    string beforeLast = line.Words[line.WordCount - 2].Text;
                    if (shipNames.Contains(ending) || shipNames.Contains(beforeLast))
                    {
                        return ParseNameList(page, line.LineNumber);
                    }
                    if (IsNamedLine(ending))
                    {
                        return ParseNameList(page, line.LineNumber - 1);
                    }
                }
            }
            return null;
        }

        private static List<string> ParseNameList(OcrResult.OcrPage page, int lineNo)
        {
            List<string> names = new List<string>();
            List<string> redNames = new List<string>();
            List<string> blueNames = new List<string>();
            var lines = page.LinesOfText;
            int lineCount = lines.Length;

            for (int i = lineNo; i < lineCount; i++)
            {
                var line = lines[i];
                string name1, name2;
                if (GetNamesFromLine(line, out name1, out name2))
                {
                    redNames.Add(name2);
                    blueNames.Add(name1);
                }
            }

            names.AddRange(redNames);
            names.AddRange(blueNames);

            return names;
        }

        private static bool GetNamesFromLine(OcrResult.OcrLine line, out string name1, out string name2)
        {
            name1 = "";
            name2 = "";
            var words = line.Words;
            if (!IsNamedLine(words.Last().Text))
            {
                return false;
            }
            int wordCount = line.WordCount;
            bool hasName1 = false, gettingName = false;
            for (int j = wordCount - 1; j >= 0; j--)
            {
                string word = words[j].Text;
                if (!gettingName && IsNamedLine(word))
                {
                    gettingName = true;
                }
                else if (gettingName && (!Regex.IsMatch(word, @"^[\-a-zA-Z0-9.]+$") || ((hasName1 ? name2.Length : name1.Length) > 0 && Regex.IsMatch(word, @"^[0-9]+$"))))
                {
                    gettingName = false;
                    if (hasName1)
                    {
                        name1 = name1.Remove(name1.Length - 1);
                        name2 = name2.Remove(name2.Length - 1);
                        return true;
                    }
                    else
                    {
                        hasName1 = true;
                    }
                }
                else if(gettingName)
                {
                    if (hasName1)
                    {
                        name2 = word + " " + name2;
                    }
                    else
                    {
                        name1 = word + " " + name1;
                    }
                }
            }
            return true;
        }

        private static bool IsNamedLine(string ending)
        {
            return (ending.Equals("A") || ending.Equals("a") || ending.Equals("5") || ending.Equals("3"));
        }

    }
}
