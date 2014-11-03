//Дано ціле число N (> 0). Використовуючи один цикл, знайти суму 1! + 2! + 3! + . + N!

var n = 12,
	result;

function fact(n) {
	return n < 2 ? 1 : fact(n - 1) * n;
}

for (var i = 1; i <= 12; i++) {
	result += fact(i);
}

console.log("Результат:", result);