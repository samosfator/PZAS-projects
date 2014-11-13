#include <iostream>
#include "BigInteger.cc"
#include "BigIntegerAlgorithms.cc"
#include "BigIntegerUtils.cc"
#include "BigUnsigned.cc"
#include "BigUnsignedInABase.cc"

using namespace std;

int main() {
	BigInteger x = 2, result = 1;

	for (int i = 0; i < 100; i++) {
		result *= x;
	}

	cout << result << endl;

	system("pause");

	return 0;
}