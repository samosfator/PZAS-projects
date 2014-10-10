var currentEducationalWeek = moment().week() - moment("20140901", "YYYYMMDD").week() + 1;

$(document).ready(function() {
	console.log("Зараз " + currentEducationalWeek + " тиждень навчання");
});