using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ArraysMatrixStrings {
    class Strings {
        private static string _input;

        public Strings(string input) {
            _input = input;
        }

        public bool IsParenthesesConcur() {
            var parentheses = 0;
            foreach (var ch in _input) {
                if (ch == '(' || ch == '[') parentheses++;
                if (ch == ')' || ch == ']') parentheses--;
            }

            Console.WriteLine("Кiлькiсть вiдкриваючих i закриваючих дужок " + (parentheses == 0 ? "" : " не ") +
                              "спiвпадає");

            return parentheses == 0;
        }

        public void PrintLongestWord() {
            var longestWord =_input.Split(' ').GroupBy(str => str.Length).OrderByDescending(grp => grp.Key).First().First();
            Console.WriteLine(longestWord);
        }

        public void RemoveLatinWords() {
            var cleaned = String.Join(" ", _input.Split(' ').Except(_input.Split(' ').Where(word => Regex.IsMatch(word, "[a-zA-Z]"))));
            Console.WriteLine(cleaned);
        }
    }
}