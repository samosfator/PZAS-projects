package ProgrammingFundamentals.hometask._03_PlazkartSeatNeibourhood.java;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class _02_Variant {

    public static Scanner in = new Scanner(System.in);

    public static void main(String[] args) {
        int containsCounter[] = new int[9];

        List<Integer> inputPlaces = new ArrayList<>();
        for (String s : in.nextLine().split(" ")) {
            inputPlaces.add(Integer.valueOf(s));
        }

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

        for (int i : containsCounter) {
            if (i == inputPlaces.size()) {
                System.out.println("Місця поряд");
                return;
            } else System.out.println("Місця не поряд");
        }
    }
}
