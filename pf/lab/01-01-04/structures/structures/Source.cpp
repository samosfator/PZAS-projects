#include <iostream>
#include "Matrix.h"
#include "Abit.h"

using namespace std;

int main() {
	setlocale(LC_ALL, "Russian");
	system("chcp 1251");

	Matrix* matrix = new Matrix();
	(*matrix).FindSameColumnAndRow();
	(*matrix).sumRowsWithNegativeEl();

	Abit* abit = new Abit();
	(*abit).sortAbits();
	(*abit).filterAbits();

	system("pause");
}