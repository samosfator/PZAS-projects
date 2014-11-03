//Дано речення. Вивести "стовпчиком" його перший, другий, п'ятий, шостий, дев'ятий, десятий і т. д. символи.
var sentence = "Речення з якого потрібно вивести деякі символи".split('');

for (var i = 0; i < sentence.length; i += 4) {
	console.log(sentence[i]);
	console.log(sentence[i + 1]);
};