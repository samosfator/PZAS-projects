#include <iostream>

using namespace std;

int main() {
	int arr[10] = {1, 2, -3, -4, 13, 12, -9, 9, 0, 11};
	int min = 0, max = 0;
	for (auto i : arr) {
		if (i < 0 && i < min) {
			min = i;
		}
	}

	cout << min;
}