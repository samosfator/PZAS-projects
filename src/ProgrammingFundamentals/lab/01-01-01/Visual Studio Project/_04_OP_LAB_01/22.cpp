#include <iostream>

using namespace std;

int main() {
	setlocale(LC_ALL, "rus");

	int divisor, numbersInRow = 0;

	cout << "¬ведiть число €ке буде дiльником\n";

	cin >> divisor;

	for (int i = 1; i < 1001; i++) {
		if (i % divisor == 0) {
			if (numbersInRow < 3) {
				cout << i << ", ";
				numbersInRow++;
			} else {
				cout << endl;
				numbersInRow = 0;
			}
		}
	}

	cout << endl;

	system("pause");

	return 0;
}