#include <iostream>

using namespace std;

int main15() {
	setlocale(LC_ALL, "rus");

	for (int i = 1; i < 1001; i++) {
		if (i > 0 && i < 3 || (i % 2 != 0 && i % 3 != 0)) {
			cout << i << endl;
		}
	}
	cout << endl;

	system("pause");

	return 0;
}