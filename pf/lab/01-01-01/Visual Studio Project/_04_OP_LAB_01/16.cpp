#include <iostream>
#include <cstdlib>

using namespace std;

int main() {
	setlocale(LC_ALL, "rus");

	int n, result = 1;
	cin >> n;

	if (n <=0) {
		cout << "Не існує";
		return -1;
	}

	for (int i = 1; i <= n; i++) {
		result *= i;
	}

	cout << result;

	system("pause");

	return 0;
}