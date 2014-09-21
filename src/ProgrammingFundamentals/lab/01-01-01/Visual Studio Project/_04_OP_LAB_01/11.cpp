#include <iostream>
#include <math.h>

using namespace std;

int main11() {
	setlocale(LC_ALL, "rus");

	double input;
	int nearest;
	cin >> input;
	nearest = input;
	
	if (nearest + 0.5 < input) {
		nearest++;
	}

	cout << nearest << endl;

	system("pause");

	return 0;
}

/*
double input;
cin >> input;

cout << ceil(input) << endl;
*/