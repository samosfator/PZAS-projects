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

//Change width of shedule on settings hover
(function() {
	$(document).ready(function() {
		$("#settings").hover(function() {
			$("#week").css("width", "74%");
		}, function() {
			$("#week").css("width", "95%");
		});
	});
})();