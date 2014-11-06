#include <iostream>
#include <string>
#include <algorithm>

using namespace std;

struct ABITURIENT {
	string NAME;
	string GENDER;
	string SPEC;
	string EXAM[3][2];
};

int getAbitNumber() {
	int abitNumber = 0;
	cout << "Скільки абітурієнтів ви хочете додати?";
	cin >> abitNumber;
	cin.ignore();
	return abitNumber;
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

int main() {
	setlocale(LC_ALL, "Russian");
	system("chcp 1251");

	int abitNumber = getAbitNumber();
	
	ABITURIENT* ABITUR = inputAbits(abitNumber);
	sort(ABITUR, ABITUR + abitNumber, &sortAvScore);
	printAbits(ABITUR, abitNumber);

	system("pause");
}