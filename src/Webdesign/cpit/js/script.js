//Animate background of current day
(function() {
	$(document).ready(function() {
		setTimeout(function() {
			$(".day").eq(moment().day() - 1).css('background', 'yellow');
			setTimeout(function() {
				$(".day").eq(moment().day() - 1).css('background', 'white');
			}, 300);
		}, 100);
	});
})();