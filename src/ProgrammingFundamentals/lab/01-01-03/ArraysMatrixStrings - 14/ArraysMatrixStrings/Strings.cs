using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ArraysMatrixStrings {
    class Strings {
        private readonly string _input;
        private readonly List<string> _sentences;

        public Strings(string input) {
            _input = input;
            _sentences = Regex.Split(_input, @"(?<=[\.!\?])\s+").ToList();
        }

        public void CountWordsInSentences() {
            var wordsCount = new Dictionary<int, int>();
            for (var i = 0; i < _sentences.Count; i++) {
                var words = Regex.Split(_sentences[i], " ");
                wordsCount.Add(i + 1, words.Length);
            }
            foreach (var sentence in wordsCount) {
                Console.WriteLine("В реченнi {0} є {1} слiв", sentence.Key, sentence.Value);
            }
        }

        public void PrintLongestSentence() {
            Console.WriteLine("Найдовше речення: \n {0}", _sentences.Max());
        }

        public void RemoveWordsWithPrelastVowel() {
            var vowels = new[] { 'а', 'е', 'и', 'і', 'о', 'у' };
            var puctuation = Regex.Match(_input, @"\p{P}");
            var words = Regex.Split(_input, " ")
                .Where(s => s.Length > 0).Where(s => Char.IsLetter(s.First()))
                .Select(word => new string(word.Where(char.IsLetterOrDigit).ToArray()));
            var result = "";
            foreach (var word in words) {
                Console.WriteLine("Передостання буква - " + word[word.Length - 2]);
                if (!vowels.Contains(word[word.Length - 2])) {
                    result += word + puctuation.NextMatch() + " ";
                }
            }
            Console.WriteLine(result);
        }
    }
}