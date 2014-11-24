var n = parseInt(prompt("Введіть число N: ")),
	result = 0;


for (var i = 0; i <= n; i++) {
	result += calc(i);
}

function calc(i) {
	return 1 / fact(i);
}

function fact(n) {
	return n < 2 ? 1 : fact(n - 1) * n;
}

alert("Результат = " + result);