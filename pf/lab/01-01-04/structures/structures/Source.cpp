#include <iostream>
#include <string>

using namespace std;

struct ABITURIENT {
	string NAME;
	string GENDER;
	string SPEC;
	string EXAM[3][2];
};

int getAbitNumber() {
	int abitNumber = 0;
	cout << "—к≥льки аб≥тур≥Їнт≥в ви хочете додати?";
	cin >> abitNumber;
	cin.ignore();
	return abitNumber;
}

ABITURIENT* inputAbits(int abitNumber) {
	ABITURIENT* ABITUR = new ABITURIENT[abitNumber];
	for (int i = 0; i < abitNumber; i++) {
		cout << "¬вед≥ть ≥м'€: \n";
		getline(cin, ABITUR[i].NAME);
		cout << "¬вед≥ть стать: \n";
		getline(cin, ABITUR[i].GENDER);
		cout << "¬вед≥ть спец≥альн≥ть: \n";
		getline(cin, ABITUR[i].SPEC);
		for (int j = 0; j < 3; j++) {
			cout << "¬вед≥ть назву " << j + 1 << " екзамену: \n";
			getline(cin, ABITUR[i].EXAM[j][0]);
			cout << "¬вед≥ть результат " << j + 1 << " екзамену: \n";
			getline(cin, ABITUR[i].EXAM[j][1]);
		}
	}
	return ABITUR;
}

void printAbits(ABITURIENT ** ABITUR, int abitNumber) {
	for (int i = 0; i < abitNumber; i++) {
		cout << "-----------------" << endl;
		cout << "≤м'€: " << ABITUR[i]->NAME << endl;
		cout << "—тать: " << ABITUR[i]->GENDER << endl;
		cout << "—пец≥альн≥сть: " << ABITUR[i]->SPEC << endl;
		for (int j = 0; j < 3; j++) {
			cout << ABITUR[i]->EXAM[j][0] << " : " << ABITUR[i]->EXAM[j][1] << endl;
		}
	}
}

int main() {
	setlocale(LC_ALL, "Russian");
	system("chcp 1251");

	int abitNumber = getAbitNumber();
	
	ABITURIENT* ABITUR = inputAbits(abitNumber);
	printAbits(&ABITUR, abitNumber);

	system("pause");
}