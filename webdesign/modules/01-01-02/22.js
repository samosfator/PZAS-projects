//Дано ціле число N (> 1). Послідовність чисел Фібоначчі FK (цілого типу) визначається таким чином: F1 = 1,        F2 = 1, FK = FK-2 + FK-1, К = 3, 4. Вивести елементи F1, F2 ..., FN.

var n = 12,
	result = fib(n);

function fib(n) {
	return n < 2 ? n : fib(n - 1) + fib(n - 2);
}

for(var i = 1; i <= n; i++) {
	console.log("F" + i, "=", fib(i));
}
