#include <iostream>
#include <cstdlib>
using namespace std;

int main() {
	setlocale(LC_ALL, "rus");

	int inputArrSize,
		positiveNumbers = 0,
		negativeNumbers = 0;
	cout << "Скільки чисел ви введете?: ";
	cin >> inputArrSize;

	double *in = new double[inputArrSize - 1];
	double inNumber;

	for (int i = 0; i < inputArrSize; i++) {
		cin >> inNumber;
		if (inNumber != 0) {
			in[i] = inNumber;
		} else break;
	}

	for (int i = 0; i < inputArrSize; i++) {
		if (in[i] > 0) {
			positiveNumbers++;
		} else if (in[i] < 0) negativeNumbers++;
	}

	cout << "Äîäàòí³õ ÷èñåë: " << positiveNumbers << endl;
	cout << "Â³ä'ºìíèõ' ÷èñåë: " << negativeNumbers << endl;

	system("pause");

	return 0;
}