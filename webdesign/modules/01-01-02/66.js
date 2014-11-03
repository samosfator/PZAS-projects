//Дано речення. Визначити число прогалин у ньому.
var sentence = "Речеоння з про гланами";

console.log("Число прогалин:", sentence.match(/\s/g).length);