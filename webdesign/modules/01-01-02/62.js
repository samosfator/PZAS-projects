//Дано речення. Вивести всі наявні в ньому буквосполучення нн.
var sentence = "Речення з буквосполученням нн";
sentence.match(/нн/g).forEach(function(el) {
	console.log(el);
});