//Дано ціле число N (> 0). Знайти суму N^2 + (N + 1)^2 + (N + 2)^2 + . + (2*N)^2

var n = 12,
	sum = 0;
for (var i = 0; i <= n; i++) {
	sum += Math.pow((i + n), 2);
}
console.log("Сума =", sum);