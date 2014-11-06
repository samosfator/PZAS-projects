#ifndef ABIT_H
#define ABIT_H

class Abit {
private:
	struct ABITURIENT {
		std::string NAME, GENDER, SPEC, EXAM[3][2];
	};

	int abitNumber, passingScore;

	int getAbitNumber();

	int getPassingScore();

	ABITURIENT* inputAbits(int abitNumber);

	void printAbits(ABITURIENT * ABITUR, int abitNumber);

	double getAvScore(const ABITURIENT &a);

	bool avScoreComparator(const ABITURIENT &a, const ABITURIENT &b);

public:
	Abit();
	ABITURIENT* ABITUR;

	void sortAbits();

	void filterAbits();
};

#endif