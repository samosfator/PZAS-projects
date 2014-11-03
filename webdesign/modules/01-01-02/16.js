//Дано дійсне число А і ціле число N (> 0). Використовуючи один цикл, знайти суму 1 + А + A^2 + A^3 + . + A^N.

var a = 8.9,
	n = 12,
	result = 1;
for (var i = 1; i <= n; i++) {
	result += Math.pow(a, i);
}
console.log("Результат: N^2 =", result);