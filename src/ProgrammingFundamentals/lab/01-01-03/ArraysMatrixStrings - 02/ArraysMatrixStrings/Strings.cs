using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ArraysMatrixStrings {
    class Strings {
        private readonly string _input;

        public Strings(string input) {
            _input = input;
        }

        public void IsParenthesesConcur() {
            var parentheses = 0;
            foreach (var ch in _input) {
                if (ch == '(' || ch == '[') parentheses++;
                if (ch == ')' || ch == ']') parentheses--;
            }

            Console.WriteLine("Кiлькiсть вiдкриваючих i закриваючих дужок " + (parentheses == 0 ? "" : " не ") +
                              "спiвпадає");
        }

        public void PrintLongestWord() {
            var longestWord =_input.Split(' ').GroupBy(str => str.Length).OrderByDescending(grp => grp.Key).First().First();
            Console.WriteLine("Найдовше слово: {0}", longestWord);
        }

        public void RemoveLatinWords() {
            var cleaned = String.Join(" ", _input.Split(' ').Except(_input.Split(' ').Where(word => Regex.IsMatch(word, "[a-zA-Z]"))));
            Console.WriteLine("Рядок без слiв на латиницi: {0}", cleaned);
        }
    }
}