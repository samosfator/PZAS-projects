(function() {
	var app = angular.module("shedule", []);
	var taskCheckbox;

	app.controller('WeekCountController', function() {
		this.currentWeek = moment().week() - moment("20140901", "YYYYMMDD").week() + 1;
		this.leftWeeks = moment("20141215", "YYYYMMDD").week() - moment().week() - 1;
		app.currentWeek = this.currentWeek;
	});

	app.controller('DayController', function($scope) {
		$scope.days = [{
			name: "Понеділок",
			lectures: [{
				lecturer: {
					name: "Пасічник Н.Р.",
					fullName: "Пасічник Наталя Романівна"
				},
				name: "Web-дизайн",
				number: 1,
				room: "6303",
				time: "08:00",
				type: "practical"
			}, {
				lecturer: {
					name: "Пасічник Н.Р.",
					fullName: "Пасічник Наталя Романівна"
				},
				name: "Web-дизайн",
				number: 2,
				room: "6402",
				time: "09:35",
				type: "lecture"
			}, {
				lecturer: {
					name: "Дивак М.П.",
					fullName: "Дивак Микола Петрович"
				},
				name: "Основи ПІ",
				number: 3,
				room: "6402",
				time: "11:10",
				type: "lecture"
			}]
		}, {
			name: "Вівторок",
			lectures: [{
				lecturer: {
					name: "Ткачук В.М.",
					fullName: "Ткачук Вадим Миколайович"
				},
				name: "Англійська",
				number: 1,
				room: "2312",
				time: "08:00",
				type: "practical"
			}, {
				lecturer: {
					name: "Гнасевич Н.В.",
					fullName: "Гнасевич Надія Володимирівна"
				},
				name: "Філософія",
				number: 2,
				room: "3405",
				time: "09:35",
				type: "lecture"
			}, {
				lecturer: {
					name: "Возняк О.Г.",
					fullName: "Возняк Ольга Григорівна"
				},
				name: "Алгебра",
				number: 3,
				room: "3405",
				time: "11:10",
				type: "lecture"
			}]
		}, {
			name: "Середа",
			lectures: [{
				lecturer: {
					name: "Гнасевич Н.В.",
					fullName: "Гнасевич Надія Володимирівна"
				},
				name: "Філософія",
				number: 1,
				room: "6408",
				time: "08:00",
				type: "practical"
			}, {
				lecturer: {
					name: app.currentWeek % 2 == 0 ? "Бубняк Л.М." : "Біловус Л.І.",
					fullName: app.currentWeek % 2 == 0 ? "Бубняк Л.М." : "Біловус Леся Іванівна"
				},
				name: app.currentWeek % 2 == 0 ? "Алгебра" : "Укр. мова",
				number: 2,
				room: "6407",
				time: "09:35",
				type: "practical"
			}, {
				lecturer: {
					name: "Біловус Л.І.",
					fullName: "Біловус Леся Іванівна"
				},
				name: "Укр. мова",
				number: 4,
				room: "3405",
				time: "12:50",
				type: "lecture"
			}]
		}, {
			name: "Четвер",
			lectures: [app.currentWeek % 2 == 0 ? {
				lecturer: {
					name: "Порплиця Н.П.",
					fullName: "Порплиця Наталя Петрівна"
				},
				name: "ОПІ",
				number: 1,
				room: "6406",
				time: "08:00",
				type: "practical"
			} : {
				name: "",
				number: 1,
				room: "",
				time: "08:00",
				type: "sleep"
			}, {
				lecturer: {
					name: "Порплиця Н.П.",
					fullName: "Порплиця Наталя Петрівна"
				},
				name: "ОПІ",
				number: 2,
				room: "6406",
				time: "09:35",
				type: "practical"
			}, {
				lecturer: {
					name: "Шпінталь М.Я.",
					fullName: "Шпінталь Михайло Ярославович"
				},
				name: "ОП",
				number: 3,
				room: "6402",
				time: "11:10",
				type: "lecture"
			}]
		}, {
			name: "П\'ятниця",
			lectures: [{
				lecturer: {
					name: "Порплиця Н.П.",
					fullName: "Порплиця Наталя Петрівна"
				},
				name: "ОП",
				number: 1,
				room: "6406",
				time: "08:00",
				type: "practical"
			}, {
				lecturer: {
					name: "Порплиця Н.П.",
					fullName: "Порплиця Наталя Петрівна"
				},
				name: "ОП",
				number: 2,
				room: "6406",
				time: "09:35",
				type: "practical"
			}, {
				lecturer: {
					name: "Шпінталь М.Я.",
					fullName: "Шпінталь Михайло Ярославович"
				},
				name: "ОП",
				number: 4,
				room: "6402",
				time: "12:50",
				type: "lecture"
			}]
		}];
		//Which day lectures are replaced in Saturday for?
		var Saturday = JSON.parse(JSON.stringify(
			$scope.days[app.currentWeek % 5 - 1 > -1 ? app.currentWeek % 5 - 1 : 4]));
		Saturday.name = "Субота";
		$scope.days.push(Saturday);
	});
})();