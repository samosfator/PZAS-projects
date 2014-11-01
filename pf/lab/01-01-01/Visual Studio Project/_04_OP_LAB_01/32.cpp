#include <iostream>
#include <cstdlib>
#include <sstream>
using namespace std;

int main() {
	setlocale(LC_ALL, "rus");

	char toDelete;

	cout << "Ââåä³òü ñèìâîë, ÿêèé âè õî÷åòå âèäàëèòè: ";
	cin >> toDelete;

	string str;

	cout << "Ââåä³òü ðÿäîê, ç ÿêîãî áóäóòü âèäàëåí³ ñèìâîëè: " << endl;
	cin.get();
	std::getline(std::cin, str);

	while (str.find(toDelete) != string::npos) {
		for (int i = 0; i < str.length(); i++) {
			if (str.at(i) == toDelete) {
				str.erase(i, 1);
			}
		}
	}

	cout << str << endl;

	system("pause");

	return 0;
}