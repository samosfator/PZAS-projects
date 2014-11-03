//Дано речення. Визначити число входжень в нього деякого буквосполучення з двох букв
var sentence = "Речення з буквосполученням нн",
	pattern = "нн",
	regex = new RegExp(pattern, 'g');
console.log("Числов входжень буквосполучення '" + pattern + "':", sentence.match(regex).length);