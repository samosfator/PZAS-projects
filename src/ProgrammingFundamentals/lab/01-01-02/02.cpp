#include <iostream>

using namespace std;

int main() {
	int a, b, c, //Користувацькі значення
	x1, x2, //Інтервал
	h; //Крок
	double result;

	cout << "Введіть число a: ";
	cin >> a;
	cout << "Введіть число b: ";
	cin >> b;
	cout << "Введіть число c: ";
	cin >> c;
	cout << "Введіть число x1: ";
	cin >> x1;
	cout << "Введіть число x2: ";
	cin >> x2;
	cout << "Введіть число h: ";
	cin >> h;


	for (int x = x1; x <= x2; x += h) {
		if ((x + 5) < 0 && c == 0) {
			result = (1 / (a * x)) - b;
		} else if ((x + 5) > 0 && c != 0) {
			result = (x - a) / x;
		} else {
			result = (10 * x) / (c - 4);
		}
		if (!((a != 0 && b != 0) || (b != 0 && c != 0))) {
			result = (int) result;
		}
		cout << result << endl;
	}
}