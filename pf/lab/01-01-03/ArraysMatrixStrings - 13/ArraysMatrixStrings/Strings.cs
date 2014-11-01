using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Timers;

namespace ArraysMatrixStrings {
    class Strings {
        private readonly string _input;

        public Strings(string input) {
            _input = input;
        }

        public void SplitAfterColon() {
            var words = _input.Split(':').Where((el, index) => index > 0).ToList();
            Console.WriteLine(String.Join(":", words));
        }

        public void CountSentencesWithOddWords() {
            var sentences = Regex.Split(_input, @"(?<=[\.!\?])\s+").ToList();
            var sentStat = sentences.ToDictionary(sentence => sentence, GetWordsCount);
            Console.WriteLine("Текст має {0} речень з непарною кiлькiстю слiв", sentStat.Count(sentence => sentence.Value % 2 != 0));
        }

        private int GetWordsCount(string sentence) {
            return Regex.Split(sentence, " ").Count(s => Char.IsLetter(s.First()));
        }

        public void RemoveWordsAfterComma() {
            var words = _input.Split(' ').ToList();
            var result = new List<string>(words);
            foreach (var word in words) {
                if (word.Last().Equals(',') && word.Length > 1) {
                    result.RemoveAt(result.IndexOf(word) + 1);
                }
            }
            Console.WriteLine(String.Join(" ", result));
        }
    }
}