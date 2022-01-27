using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnagramMatcherConsoleApp
{
    class AnagramMatcher
    {
        public AnagramMatcher()
        {
        }

        public void Match(string inputString)
        {
            var wordDict = new Dictionary<string, List<string>>();
            var wordList = ParseInput(inputString).OrderBy(x => x);

            foreach (string word in wordList)
            {
                string wordKey = String.Join(',', word.ToCharArray().OrderBy(x => x).ToArray());

                if(wordDict.ContainsKey(wordKey))
                {
                    wordDict[wordKey].Add(word);
                }
                else
                {
                    wordDict.Add(wordKey, new List<string> { word });
                }
            }
            Print(wordDict);
        }

        private List<string> ParseInput(string input)
        {
            string[] removeFileEnd = input.ToLower().Split(".");

            string[] wordArray = removeFileEnd[0].Split("_");
            List<string> wordList = new List<string>();

            foreach (string word in wordArray)
            {
                wordList.Add(word);
            }

            return wordList;
        }

        private void Print(Dictionary<string, List<string>> matched)
        {
            foreach (List<string> match in matched.Values)
            {
                foreach (string word in match)
                {
                    Console.Write(word + " ");
                }
                Console.WriteLine(Environment.NewLine);
            }
        }

    }
}
