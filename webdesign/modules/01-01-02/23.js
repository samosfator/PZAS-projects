//23.	Дано ціле число N (> 1). Послідовність дійсних чисел AK визначається таким чином: A1 = 1, A2 = 2, AK = (AK-2 + 2•AK-1)/3,    К = 3, 4 . Вивести елементи A1, A2 ., AN.

var n = 12;

for (var i = 1; i <= n; i++) {
	console.log("A" + i + " = " + calcAK(i));
}

function calcAK(i) {
	if (i == 1) {
		return 1;
	} else if (i == 2) {
		return 2;
	} else {
		return (calcAK(i - 2) + 2 * calcAK(i - 1)) / 3;
	}
}