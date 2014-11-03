//Дано речення. Визначити число входжень в нього деякого символу.
var sentence = "Речення з про гланами",
	char = "н",
	regex = new RegExp(char, 'g');
console.log("Число літер " + char + ":", sentence.match(regex).length);