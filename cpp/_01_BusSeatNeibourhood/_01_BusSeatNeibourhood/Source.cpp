#include <iostream>

using namespace std;

int main() {
	int a, b;
	cin >> a;
	cin >> b;

	setlocale(LC_CTYPE, "rus");

	cout << (a < b) ?
		((b - a == 1 && b % 2 == 0) ? cout << "\b̳��� �����\n" :
		((a - b == 1 && a % 2 == 0) ? cout << "\b̳��� �����\n" : cout << "\b̳��� �� �����\n")) :
		(cout << "\b̳��� �� �����\n");

	system("pause");
	return 0;
}