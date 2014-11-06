#include "Matrix.h"
#include <iostream>

using namespace std;

Matrix::Matrix() {
	size = getMatixSize();
	matrix = generateMatrix();
	printMatrix();
}

int Matrix::getMatixSize() {
	int size = 0;
	cout << "Введіть бажаний розмір матриці N x N:\n" << endl;
	cin >> size;
	cin.ignore();
	return size;
}

int** Matrix::generateMatrix() {
	int** matrix = new int*[size];
	for (int i = 0; i < size; i++)
		matrix[i] = new int[size];

	int genSameRowAndCol = rand() % size;

	for (int i = 0; i < size; i++) {
		for (int j = 0; j < size; j++) {
			matrix[i][j] = rand() % 10 - 1;
		}
	}
	return copyRowToCol(matrix, genSameRowAndCol);
}

int** Matrix::copyRowToCol(int** rawMatrix, int answer) {
	for (int i = 0; i < size; i++) {
		for (int j = 0; j < size; j++) {
			rawMatrix[answer][j] = rawMatrix[j][answer];
		}
	}
	return rawMatrix;
}

void Matrix::printMatrix() {
	cout << endl;
	for (int i = 0; i < size; i++) {
		for (int j = 0; j < size; j++) {
			cout << matrix[i][j] << ", ";
		}
		cout << endl;
	}
}

void Matrix::FindSameColumnAndRow() {
	int sameRowAndCol, sameEls = 0, maxSameEls = 0;

	for (int i = 0; i < size; i++) {
		sameEls = 0;
		for (int j = 0; j < size; j++) {
			if (matrix[i][j] == matrix[j][i]) {
				if (++sameEls > maxSameEls) {
					maxSameEls = sameEls;
					sameRowAndCol = i;
				}
			}
		}
	}
	if (size == maxSameEls) {
		cout << "\nМатриця має однакові " << sameRowAndCol + 1 << "-ий рядок і стовпець\n\n";
	} else cout << "Матриця не має однакових рядків і стовпців\n\n";
}

void Matrix::sumRowsWithNegativeEl() {
	double sum = 0;
	for (int i = 0; i < size; i++) {
		bool hasNegative = false;
		for (int j = 0; j < size; j++) {
			if (matrix[i][j] < 0) hasNegative = true;
		}
		if (hasNegative) {
			for (int k = 0; k < size; k++) {
				sum += matrix[i][k];
			}
		}
	}
	cout << "Сума елементів у рядках де є хоча б один від'ємний елемент: " << sum << endl << endl;
}