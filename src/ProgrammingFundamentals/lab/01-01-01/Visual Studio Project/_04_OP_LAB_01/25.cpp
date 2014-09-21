#include <iostream>

using namespace std;

int main25() {
	setlocale(LC_ALL, "rus");

	int input;
	cin >> input;

	for (int i = 1; i < input + 1; i++) {
		if (input % i == 0) {
			cout << i << ", ";
		}
	}
	cout << endl;

	system("pause");

	return 0;
}