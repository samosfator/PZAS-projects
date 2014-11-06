#include <iostream>
#include <string>
#include <algorithm>
#include "Abit.h"

using namespace std;

int getAbitNumber() {
	int abitNumber = 0;
	cout << "Скільки абітурієнтів ви хочете додати?";
	cin >> abitNumber;
	cin.ignore();
	return abitNumber;
}

int getPassingScore() {
	int passingScore = 0;
	cout << "Введіть бажаний прохідний бал: " << endl;
	cin >> passingScore;
	cin.ignore();
	return passingScore;
}

ABITURIENT* inputAbits(int abitNumber) {
	ABITURIENT* ABITUR = new ABITURIENT[abitNumber];
	for (int i = 0; i < abitNumber; i++) {
		cout << "Введіть ім'я: \n";
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

void printAbits(ABITURIENT * ABITUR, int abitNumber) {
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

double getAvScore(const ABITURIENT &a) {
	double aSum = 0;
	for (int i = 0; i < 3; i++) {
		aSum += stod(a.EXAM[i][1]);
	}
	return aSum / 3.0;
}

bool sortAvScore(const ABITURIENT &a, const ABITURIENT &b) {
	return getAvScore(a) < getAvScore(b);
}

void filterAbits(ABITURIENT * ABITUR, int abitNumber, int passingScore) {
	int filteredAbits = 0;
	for (int i = 0; i < abitNumber; i++) {
		ABITURIENT abit = ABITUR[i];
		if (getAvScore(abit) < passingScore) {
			filteredAbits++;
			cout << abit.NAME << " - " << abit.SPEC << endl;
		}
	}
	if (filteredAbits < 1) {
		cout << "Немає абітурієнтів, у яких середній бал нижче за прохідний" << endl;
	}
}
