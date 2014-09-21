#include <iostream>

using namespace std;

int main02() {
	setlocale(LC_ALL, "rus");

	double p, min, max;

	cout << "Введiть дiапазон: \nМiнiмальне число:" << endl;
	cin >> min;
	cout << "Максимальне число:" << endl;
	cin >> max;
	cout << "Введiть число p" << endl;
	cin >> p;

	if (p >= min && p <= max) {
		cout << "Задане число належить дiапазону" << endl;
	} else cout << "Задане число не належить дiапазону" << endl;

	system("pause");

	return 0;
}