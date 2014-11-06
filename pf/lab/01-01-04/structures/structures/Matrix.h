#ifndef MATRIX_H
#define MATRIX_H

class Matrix {
private:
	int getMatixSize();

	int** generateMatrix();

	int** copyRowToCol(int**, int);
	
	void printMatrix();

public:
	Matrix();
	int** matrix;
	int size;

	void FindSameColumnAndRow();

	void sumRowsWithNegativeEl();
};

#endif