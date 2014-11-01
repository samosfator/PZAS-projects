#include <iostream>
#include <math.h>

using namespace std;

int main14() {
	setlocale(LC_ALL, "rus");

	int input;
	cin >> input;

	if (input > 0 && input < 3 || (input % 2 != 0 && input % 3 != 0)) {
		cout << "просте" << endl;
	} else cout << "непросте" << endl;

	system("pause");

	return 0;
}