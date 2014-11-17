function calcImp() {
	var arr = f1.s.value.split(',');
	for (var i = 0; i < arr.length; i++) {
		arr[i] = parseInt(arr[i]);
	}
	for (var i = 1; i < arr.length - 1; i++) {
		if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1]) {
			f1.res.value += arr[i] + " - локальний максимум\n";
		}
	}
}

function calcFunc() {
	var arr = f1.s.value.split(',').map(function(a) { return parseInt(a, 10) });
	arr.filter(function(val) {
		var i = arr.indexOf(val);
		return arr[i] > arr[i - 1] && arr[i] > arr[i + 1];
	}).forEach(function(val) {
			f1.res.value += val + " - локальний максимум\n";
	});
}