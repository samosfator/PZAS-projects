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
	cout << "������ �������� �� ������ ������?";
	cin >> abitNumber;
	cin.ignore();
	return abitNumber;
}

ABITURIENT* inputAbits(int abitNumber) {
	ABITURIENT* ABITUR = new ABITURIENT[abitNumber];
	for (int i = 0; i < abitNumber; i++) {
		cout << "������ ��'�: \n";
		getline(cin, ABITUR[i].NAME);
		cout << "������ �����: \n";
		getline(cin, ABITUR[i].GENDER);
		cout << "������ �����������: \n";
		getline(cin, ABITUR[i].SPEC);
		for (int j = 0; j < 3; j++) {
			cout << "������ ����� " << j + 1 << " ��������: \n";
			getline(cin, ABITUR[i].EXAM[j][0]);
			cout << "������ ��������� " << j + 1 << " ��������: \n";
			getline(cin, ABITUR[i].EXAM[j][1]);
		}
	}
	return ABITUR;
}

void printAbits(ABITURIENT ** ABITUR, int abitNumber) {
	for (int i = 0; i < abitNumber; i++) {
		cout << "-----------------" << endl;
		cout << "��'�: " << ABITUR[i]->NAME << endl;
		cout << "�����: " << ABITUR[i]->GENDER << endl;
		cout << "������������: " << ABITUR[i]->SPEC << endl;
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