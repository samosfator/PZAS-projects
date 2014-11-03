//Дане натуральне n, обчислити n! ( 0! = 1, n! = n * (n - 1)!).
var n = 12,
	result = fact(n);

function fact(n) {
	return n < 2 ? 1 : fact(n - 1) * n;
}

console.log(result);