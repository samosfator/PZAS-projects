#include <iostream>
#include <math.h>

using namespace std;

int main01() {
	setlocale(LC_ALL, "rus");

	int a, b, c;
	double arithmeticMean, geometricMean;

	cout << "Введiть перше число" << endl;
	cin >> a;
	cout << "Введiть друге число" << endl;
	cin >> b;
	cout << "Введiть третє число" << endl;
	cin >> c;

	arithmeticMean = (a + b + c) / 3;
	geometricMean = pow((a * b * c), 0.3333333333333333);

	cout << "Середнє арифметичне: " << arithmeticMean << endl;
	cout << "Середнє геометричне: " << geometricMean << endl;

	system("pause");

	return 0;
}