#include <iostream>
#include <string>
#include <algorithm>
#include "Abit.h"

using namespace std;

int main() {
	setlocale(LC_ALL, "Russian");
	system("chcp 1251");

	int abitNumber = getAbitNumber();
	int passingScore = getPassingScore();
	
	ABITURIENT* ABITUR = inputAbits(abitNumber);

	cout << "\nАбітурієнти відсортовані за зростанням середнього балу\n";
	sort(ABITUR, ABITUR + abitNumber, &sortAvScore);
	printAbits(ABITUR, abitNumber);

	cout << "\nАбітурієнти, у яких середній бал нижче за прохідний\n";
	filterAbits(ABITUR, abitNumber, passingScore);

	system("pause");
}