#include <iostream>

using namespace std;

int main() {
	setlocale(LC_ALL, "rus");

	int a, b;
	cin >> a;
	cin >> b;

	if (!(a >= b && b >= 0)) {
		cout << "помилка";
		return -1;
	}

	for (int i = 1; ; i++) {
		if (i % a == 0 && i % b == 0) {
			cout << i << endl;
			break;
		}
	}

	return 0;
}