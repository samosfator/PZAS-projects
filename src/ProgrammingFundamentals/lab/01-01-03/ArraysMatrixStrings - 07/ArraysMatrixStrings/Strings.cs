using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ArraysMatrixStrings {
    class Strings {
        private readonly string _input;

        public Strings(string input) {
            _input = input;
        }

        public int CountNumbers() {
            return Regex.Split(_input, "\\D").Where(n => n.Length > 0).ToList().Count;
        }

        public string RemoveNonLatinWords() {
            return Regex.Replace(_input, "\\p{IsBasicLatin}", "");
        }

        public string RemoveEvenWords() {
            var words = Regex.Split(_input, @"(\b[^\s]+\b)")
                .Where(s => s.Length > 0).Where(s => Char.IsLetter(s.First())).ToArray();
            var result = "";
            for (var i = 0; i < words.Length; i++) {
                if (i % 2 == 0) {
                    var word = words[i];
                    result += word + " ";
                }
            }
            return result;
        }
    }
}