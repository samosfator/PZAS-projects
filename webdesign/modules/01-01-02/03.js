//Дане натуральне n, обчислити 1 / 0! + 1 / 1! + ... + 1 / n!
var n = 5,
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

console.log(result);
