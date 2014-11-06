#include <iostream>
#include <string>
#include <algorithm>
#include "Abit.h"

using namespace std;

Abit::Abit() {
	abitNumber = getAbitNumber();
	passingScore = getPassingScore();
	ABITUR = inputAbits(abitNumber);
}

int Abit::getAbitNumber() {
	int abitNumber = 0;
	cout << "Скільки абітурієнтів ви хочете додати?";
	cin >> abitNumber;
	cin.ignore();
	return abitNumber;
}

int Abit::getPassingScore() {
	int passingScore = 0;
	cout << "Введіть бажаний прохідний бал: " << endl;
	cin >> passingScore;
	cin.ignore();
	return passingScore;
}

Abit::ABITURIENT* Abit::inputAbits(int abitNumber) {
	ABITURIENT* ABITUR = new ABITURIENT[abitNumber];
	for (int i = 0; i < abitNumber; i++) {
		cout << "\nВведіть ім'я " << i + 1 << "-ого абітурієнта\n";
		getline(cin, ABITUR[i].NAME);
		cout << "Введіть стать: \n";
		getline(cin, ABITUR[i].GENDER);
		cout << "Введіть спеціальніть: \n";
		getline(cin, ABITUR[i].SPEC);
		for (int j = 0; j < 3; j++) {
			cout << "Введіть назву " << j + 1 << " екзамену: \n";
			getline(cin, ABITUR[i].EXAM[j][0]);
			cout << "Введіть результат " << j + 1 << " екзамену: \n";
			getline(cin, ABITUR[i].EXAM[j][1]);
		}
	}
	return ABITUR;
}

void Abit::printAbits(ABITURIENT * ABITUR, int abitNumber) {
	for (int i = 0; i < abitNumber; i++) {
		cout << "-----------------" << endl;
		cout << "Ім'я: " << ABITUR[i].NAME << endl;
		cout << "Стать: " << ABITUR[i].GENDER << endl;
		cout << "Спеціальність: " << ABITUR[i].SPEC << endl;
		for (int j = 0; j < 3; j++) {
			cout << ABITUR[i].EXAM[j][0] << " : " << ABITUR[i].EXAM[j][1] << endl;
		}
	}
}

double Abit::getAvScore(const ABITURIENT &a) {
	double aSum = 0;
	for (int i = 0; i < 3; i++) {
		aSum += stod(a.EXAM[i][1]);
	}
	return aSum / 3.0;
}

bool Abit::avScoreComparator(const ABITURIENT &a, const ABITURIENT &b) {
	return getAvScore(a) < getAvScore(b);
}

void Abit::sortAbits() {
	cout << "\nАбітурієнти відсортовані за зростанням середнього балу\n";
	sort(ABITUR, ABITUR + abitNumber,
		[this](ABITURIENT a, ABITURIENT b) {
			return avScoreComparator(a, b);
		});
	Abit::printAbits(ABITUR, abitNumber);
}

void Abit::filterAbits() {
	cout << "\nАбітурієнти, у яких середній бал нижче за прохідний:\n";

	int filteredAbits = 0;
	for (int i = 0; i < abitNumber; i++) {
		ABITURIENT abit = ABITUR[i];
		if (getAvScore(abit) < passingScore) {
			filteredAbits++;
			cout << endl;
			cout << abit.NAME << " - " << abit.SPEC << endl;
			cout << endl;
		}
	}
	if (filteredAbits < 1) {
		cout << "Немає абітурієнтів, у яких середній бал нижче за прохідний" << endl;
	}
}
