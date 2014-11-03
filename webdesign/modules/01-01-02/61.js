//Дано речення. Скласти програму, яка виводить всі входження в речення двох заданих символів.
var sentence = "Забуття, Туреччина, речення",
	pattern = prompt('Введіть два символи для пошуку'),
	regex = new RegExp(pattern, 'g');
console.log("Входження символів '" + pattern + "' у реченні:", sentence.match(regex).length);