#include <iostream>
#include <cstdlib>

using namespace std;

int main() {
	int a, b;
	cin >> a;
	cin >> b;

	setlocale(LC_CTYPE, "rus");

	cout << (a < b) ?
		((b - a == 1 && b % 2 == 0) ? cout << "\bМісця поряд\n" :
		((a - b == 1 && a % 2 == 0) ? cout << "\bМісця поряд\n" : cout << "\bМісця не поряд\n")) :
		(cout << "\bМісця не поряд\n");

	system("cmd /C pause");

	return 0;
}