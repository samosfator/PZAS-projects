#include <iostream>
#include <cstdlib>
using namespace std;

int main() {
	setlocale(LC_ALL, "rus");

	int n, x = 2;
	cin >> n;

	for (int i = 0; x < n; i++) {
		cout << x << endl;
		x += 10;
	}

	system("pause");

	return 0;
}