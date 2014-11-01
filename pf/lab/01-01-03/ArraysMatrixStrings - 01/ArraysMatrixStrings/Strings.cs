using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ArraysMatrixStrings {
    class Strings {
        private readonly string _input;

        public Strings(string input) {
            _input = input;
        }

        public int CountOddLengthWords() {
            return _input.Split(' ').Count(word => word.Length % 2 != 0);
        }

        public void PrintLetterOccurrences() {
            var occurrences = new Dictionary<char, int>();
            var chars = _input.ToCharArray();
            foreach (var ch in chars) {
                var occurrencesCount = _input.ToCharArray().Count(i => i.Equals(ch));
                if (!occurrences.ContainsKey(ch)) {
                    occurrences.Add(ch, occurrencesCount);
                }
            }
            var sortedOccurrences = occurrences.ToList();
            sortedOccurrences.Sort((curr, next) => curr.Value.CompareTo(next.Value));
            sortedOccurrences.Reverse();

            foreach (var occurrence in sortedOccurrences) {
                Console.WriteLine(occurrence);
            }
        }

        public void RemoveWordsInParentheses() {
            var regex = new Regex(@"\((.*?)\)");
            var cleaned = regex.Replace(_input, "");
            Console.WriteLine(cleaned);
        }
    }
}