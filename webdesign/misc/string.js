var titles = [" Rambler", " Yandex ", "Google", " Altavista "];
var urls = [
	" http://www.rambler.ru ",
	" http://www.ya.ru ",
	" http://www.google.com ",
	" http://www.altavista.com "
]
for (var i = 0; i < titles.length; i++) {
	document.write(
		titles[i].bold() + ":" + urls[i].link(urls[i]) + "<br/>");
}


do {
	var email = prompt("Введіть свій e-mail : ", " ")
	if (email.indexOf("@") == -1) {
		alert("Введений e-mail синтаксично некоректний!
			\nПовторіть операцію.");
	} else break;
} while (true);
alert("Дякуємо за співпрацю !");



var text = " Карл у Клари вкрав корали, Клара у Карла вкрала кларнет.";
var count = 0,
	start = -1;
do {
	start = text.indexOf("а", start + 1);
	if (start >= 0) count++;
} while (start >= 0);
alert("Символ 'а' зустрічається в рядку з частотою " +
	(count / text.length * 100).toFixed(2) + "%");

var s = prompt("Введіть кілька числових значень , розділених комами : ", " 1,2,5,0,3,7 ");
var a = s.split(",");
var sum = 0;
for (var i = 0; i < a.length; i++) sum += parseInt(a[i]);
alert(" Сума елементів введеного масиву: " + sum);







//інший варіант
alert(prompt().split(",").map(function(a) {
	return parseInt(a, 10)
}).reduce(function(a, b) {
	return a + b
}))





