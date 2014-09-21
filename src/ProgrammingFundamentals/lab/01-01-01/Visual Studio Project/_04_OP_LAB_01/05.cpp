#include <iostream>
#include <math.h>
#include <cstdlib>

using namespace std;

int main() {
	setlocale(LC_ALL, "rus");

	double square, difference, height;

	cout << "Введіть площу: ";
	cin >> square;
	cout << "Введіть різницю основи і висоти: ";
	cin >> difference;

	height = (sqrt(difference * difference + 8 * square) - difference) / 2;

	cout << height << endl;

	system("pause");

	return 0;
}