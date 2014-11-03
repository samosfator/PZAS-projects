//Дано ціле число N (> 0). Знайти суму 1 + 1/2 + 1/3 + . + 1/N

var n = 12,
	sum = 0;
for (var i = 1; i <= n; i++) {
	sum += 1 / i;
}
console.log("Сума =", sum);