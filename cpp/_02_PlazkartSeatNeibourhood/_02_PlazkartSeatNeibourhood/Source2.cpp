#include <iostream>
#include <string>
#include <sstream>
#include <unordered_set>

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

int main() {
	int containsCounter[9] = {};
	int placesInRoom = 0;
	int placesNearWindow = 0;

	std::string rawInput;
	std::cin >> rawInput;

	std::unordered_set <int> inputPlaces = split(rawInput, ',');

	setlocale(LC_CTYPE, "rus");

	for (int inputPlace : inputPlaces) {
		if (inputPlace > 0 && inputPlace < 5 || inputPlace == 53 || inputPlace == 54) {
			containsCounter[0]++;
		} else if (inputPlace > 4 && inputPlace < 9 || inputPlace == 52 || inputPlace == 51) {
			containsCounter[1]++;
		} else if (inputPlace > 8 && inputPlace < 13 || inputPlace == 50 || inputPlace == 49) {
			containsCounter[2]++;
		} else if (inputPlace > 12 && inputPlace < 17 || inputPlace == 48 || inputPlace == 47) {
			containsCounter[3]++;
		} else if (inputPlace > 16 && inputPlace < 21 || inputPlace == 46 || inputPlace == 45) {
			containsCounter[4]++;
		} else if (inputPlace > 20 && inputPlace < 25 || inputPlace == 44 || inputPlace == 43) {
			containsCounter[5]++;
		} else if (inputPlace > 24 && inputPlace < 29 || inputPlace == 42 || inputPlace == 41) {
			containsCounter[6]++;
		} else if (inputPlace > 28 && inputPlace < 33 || inputPlace == 40 || inputPlace == 39) {
			containsCounter[7]++;
		} else if (inputPlace > 32 && inputPlace < 39) {
			containsCounter[8]++;
		}
	}

	if (containsCounter[0] == inputPlaces.size()
		|| containsCounter[1] == inputPlaces.size()
		|| containsCounter[2] == inputPlaces.size()
		|| containsCounter[3] == inputPlaces.size()
		|| containsCounter[4] == inputPlaces.size()
		|| containsCounter[5] == inputPlaces.size()
		|| containsCounter[6] == inputPlaces.size()
		|| containsCounter[7] == inputPlaces.size()
		|| containsCounter[8] == inputPlaces.size()) {
		std::cout << "Місця поряд\n";
	} else {
		std::cout << "Місця не поряд\n";
	}

	system("pause");

	return 0;
}

/*

#include <iostream>
#include <string>
#include <sstream>
#include <unordered_set>

using namespace std;

int main() {
setlocale(LC_CTYPE, "rus");

int a, b;

cin >> a;
cin >> b;

if (a <= 36) {
a = (a - 1) / 4;
} else {
a = 8 - (a - 37) / 2;
}

if (b <= 36) {
b = (b - 1) / 4;
} else {
b = 8 - (b - 37) / 2;
}

if (a == b) {
cout << "так";
} else cout << "ні";

system("pause");
return 0;
}
*/