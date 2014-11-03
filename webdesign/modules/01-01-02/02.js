//Послідовність Фібоначчі  визначається так: a0 = 0, a1 = 1, ak = ak-1 + ak-2 при k>1. Дане n, обчислити an.
var n = 12,
	result = fib(n);

function fib(n) {
	return n < 2 ? n : fib(n - 1) + fib(n - 2);
}

console.log(result);