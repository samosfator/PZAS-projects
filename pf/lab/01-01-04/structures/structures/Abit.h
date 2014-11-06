#ifndef ABIT_H
#define ABIT_H
#include <string>

struct ABITURIENT {
	std::string NAME, GENDER, SPEC, EXAM[3][2];
};

int getAbitNumber();

int getPassingScore();

ABITURIENT* inputAbits(int abitNumber);

void printAbits(ABITURIENT * ABITUR, int abitNumber);

double getAvScore(const ABITURIENT &a);

bool sortAvScore(const ABITURIENT &a, const ABITURIENT &b);

void filterAbits(ABITURIENT * ABITUR, int abitNumber, int passingScore);

#endif