//Дано ціле число N (> 0). Знайти подвійний факторіал N: N!! = N•(N-2)•(N-4)•.(останній співмножник рівний 2, якщо N - парне, і 1, якщо N - непарне).

var n = 5,
	result;

function doubleFact(n) {
	return n < 2 ? 1 : doubleFact(n - 2) * doubleFact(n - 4) * n;
}