//Дано речення. Вивести "стовпчиком" всі його літери і, що стоять на парних місцях.
var sentence = "Речення з якого потрібно вивести деякі символи".split('');

for (var i = 0; i < sentence.length; i += 2) {
	if(sentence[i] === 'і') console.log(sentence[i]);
};