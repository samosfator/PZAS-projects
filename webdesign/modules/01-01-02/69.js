//Дано речення. Визначити, скільки в ньому однакових сусідніх букв.
var sentence = "Речення з однаковими сусідніми літерами: рааз дваа ііі трииии".split(''),
	count = 0;
for (var i = 0; i < sentence.length; i++) {
	var char = sentence[i],
		nextChar = sentence[i + 1];
	if (char == nextChar) {
		count++;
		console.log("Сусідні букви:", char, nextChar);
	}
}
console.log("Взагалі сусідніх букв у реченні:", count);