#include <iostream>
#include <string>
#include <sstream>
#include <unordered_set>
#include <algorithm>
#include <iterator>

std::unordered_set<int> &split(const std::string &s, char delim, std::unordered_set<int> &elems) {
	std::stringstream ss(s);
	std::string item;
	while (std::getline(ss, item, delim)) {
		elems.insert(std::stoi(item));
	}
	return elems;
}

std::unordered_set<int> split(const std::string &s, char delim) {
	std::unordered_set<int> elems;
	split(s, delim, elems);
	return elems;
}

int windowPlaceCounter = 0;
const int MAX_PLACES = 54;
int placeCounter = 1;

int main() {
	int rooms[9][6] = {};
	int inputPlaces[6] = {};
	int iter = 0;
	int inputPlacesRealSize = 0;

	std::string rawInput;
	std::cin >> rawInput;

	std::unordered_set <int> input = split(rawInput, ',');

	setlocale(LC_CTYPE, "rus");

	for (int i = 1; i < MAX_PLACES + 1; i += 6) {
		for (int k = 0; k < 4; k++) {
			rooms[i][k] = placeCounter;
			placeCounter++;
		}
		for (int j = 4; j < 6; j++) {
			rooms[i][j] = MAX_PLACES - windowPlaceCounter;
			windowPlaceCounter++;
		}
	}

	for (std::unordered_set<int>::iterator itr = input.begin(); itr != input.end(); ++itr, iter++) {
		inputPlaces[iter] = *itr;
	}

	for (int i = 0; i < 6; i++) {
		if (inputPlaces[i] != 0) {
			inputPlacesRealSize++;
		}
	}

	int containsCounter = 0;
	for (int i = 0; i < inputPlacesRealSize;) {
	nextInputPlace:
		i++;
		for (int room = 0; room < 9;) {
		nextRoom:
			room++;
			for (int place = 0; place < 6; place++) {
				if (inputPlaces[i] == rooms[room][place]) {
					containsCounter++;
					std::cout << "\n" << inputPlaces[i];
					goto nextInputPlace;
				} else goto nextRoom;
			}
		}
	}

	if (containsCounter - inputPlacesRealSize) {
		std::cout << "\nМісця поряд\n";
	} else std::cout << "\nМісця не поряд\n";

	system("pause");

	return 0;
}