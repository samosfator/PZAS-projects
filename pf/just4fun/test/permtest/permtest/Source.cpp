#include <iostream>

using namespace std;

float av(float, float, float);

int main() {

	float a, b, c;

	cin >> a >> b >> c;
	
	cout << av(a, b, c) << endl;

	system("pause");

	return 0;
}

float av(float a, float b, float c) {
	return (a + b + c) / 3;
}