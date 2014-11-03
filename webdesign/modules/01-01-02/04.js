//Скласти програму, що друкує квадрати всіх натуральних чисел від 0 до заданого натурального n
var n = 25;

new Array(n + 1).join('0').split('').map(function(val, i) {
	console.log(i * i)
});