//Дано речення. Визначити число букв о в ньому.
var sentence = "Рачання з бакваю а";

console.log("Частота входжень букви а:",
	((sentence.match(/а/g).length / sentence.length) * 100).toFixed(2) + "%");