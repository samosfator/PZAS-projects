#include <iostream>

using namespace std;

int main12() {
	setlocale(LC_ALL, "rus");

	for (int i = 1; i < 1001; i++) {
		if (i % 2 == 0) {
			cout << i << ", ";
		}
	}
	cout << endl;

	system("pause");

	return 0;
}