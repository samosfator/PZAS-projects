#include <iostream>

using namespace std;

int main() {
	int a, b;
	cin >> a;
	cin >> b;

	setlocale(LC_CTYPE, "rus");

	cout << (a < b) ?
		((b - a == 1 && b % 2 == 0) ? cout << "\bÌ³ñöÿ ïîðÿä\n" :
		((a - b == 1 && a % 2 == 0) ? cout << "\bÌ³ñöÿ ïîðÿä\n" : cout << "\bÌ³ñöÿ íå ïîðÿä\n")) :
		(cout << "\bÌ³ñöÿ íå ïîðÿä\n");

	system("pause");
	return 0;
}