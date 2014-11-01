#include <iostream>

using namespace std;

int main() {
	setlocale(LC_ALL, "rus");

	int input;
	cin >> input;

	for (int i = 1; i <= (input / 2); i++) {
		if (input % i == 0) {
			cout << i << ", ";
		}
	}
	cout << input << endl;

	return 0;
}