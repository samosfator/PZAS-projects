var body = document.getElementsByTagName("body")[0];

setInterval(function() {
	body.style.backgroundColor = "rgb(" + Math.floor(Math.random() * 255) + ", " +
											Math.floor(Math.random() * 255) + ", " +
											Math.floor(Math.random() * 255) + ")";
}, 1000);