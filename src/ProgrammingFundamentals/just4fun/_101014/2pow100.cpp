#include <iostream>

using namespace std;

int main() {
	double result = 1;

	for (int i = 0; i < 100; i++) {
		result = 2 * result;
	}

	cout << fixed << result << endl;

	return 0;
}