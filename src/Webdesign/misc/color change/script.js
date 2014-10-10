var body = document.getElementsByTagName("body")[0];
var r = 150,
	g = 1,
	b = 1;
var increaseR = true,
	increaseG = true,
	increaseB = true;

setInterval(function() {
	if (r < 255 && increaseR) {
		r++;
		if (b > 2) b--;
	} else {
		increaseR = false;
		if (g < 255 && increaseG) {
			g++;
			r--;
		} else {
			increaseG = false;
			if (b < 255 && increaseB) {
				b++;
				g--;
			} else {
				increaseR = true;
			}
		}
	}

	body.style.backgroundColor = "rgb(" + r + ", " + g + ", " + b + ")";
}, 1);


setInterval(function9) {
	var r = 150,
		g = 1,
		b = 1;
	var increaseR = true,
		increaseG = true,
		increaseB = true;

}, 5000);