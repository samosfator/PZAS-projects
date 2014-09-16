#include <iostream>
#include <string>
#include <sstream>
#include <vector>
#include <unordered_set>
#include <algorithm>
#include <iterator>
#include <clocale>

std::unordered_set<std::string> &split(const std::string &s, char delim, std::unordered_set<std::string> &elems) {
	std::stringstream ss(s);
	std::string item;
	while (std::getline(ss, item, delim)) {
		elems.insert(item);
	}
	return elems;
}

std::unordered_set<std::string> split(const std::string &s, char delim) {
	std::unordered_set<std::string> elems;
	split(s, delim, elems);
	return elems;
}

int windowPlaceCounter = 0;
const int MAX_PLACES = 54;
int placeCounter = 1;

int main() {
	std::unordered_set<std::unordered_set<std::string>> rooms;
	std::unordered_set<std::string> room;

	std::string rawInput;
	std::cin >> rawInput;

	std::unordered_set <std::string> inputPlaces = split(rawInput, ',');

	setlocale(LC_CTYPE, "rus");

	for (int i = 1; i < MAX_PLACES + 1; i += 6) {
		for (int k = 0; k < 4; k++) {
			room.insert(std::to_string(placeCounter));
			placeCounter++;
		}
		for (int j = 0; j < 2; j++) {
			room.insert(std::to_string(MAX_PLACES - windowPlaceCounter));
			windowPlaceCounter++;
		}
		rooms.insert(room);
		room.clear();
	}

	std::cout << std::endl;

	std::sort(inputPlaces.begin(), inputPlaces.end());
	for (auto singleRoom : rooms) {

		if (std::includes(singleRoom.begin(), singleRoom.end(), inputPlaces.begin(), inputPlaces.end())) {
			std::cout << "\nÌ³ñöÿ ïîðÿäf\n";
			system("pause");
			return 0;
		}
	}

	std::cout << "\nÌ³ñöÿ íå ïîðÿä\n";
	system("pause");

	return 0;
}