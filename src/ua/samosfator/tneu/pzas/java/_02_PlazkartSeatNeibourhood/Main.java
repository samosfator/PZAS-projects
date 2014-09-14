package ua.samosfator.tneu.pzas.java._02_PlazkartSeatNeibourhood;

import java.util.*;

public class Main {
    public static Scanner in = new Scanner(System.in);

    public static void main(String[] args) {
        List<List<Integer>> rooms = new ArrayList<>();
        List<Integer> room = new ArrayList<>();

        int windowPlacesCounter = 0;
        final int MAX_PLACES = 54;
        int placeCounter = 1;

        for (int i = 1; i < MAX_PLACES + 1; i += 6) {
            for (int k = 0; k < 4; k++) {
                room.add(placeCounter);
                placeCounter++;
            }
            for (int j = 0; j < 2; j++) {
                room.add(MAX_PLACES - windowPlacesCounter);
                windowPlacesCounter++;
            }
            rooms.add(room);
            room = new ArrayList<>();
        }

        System.out.print("Введіть через пробіл від 2 до 6 місць: ");

        List<Integer> inputPlaces = new ArrayList<>();
        for (String s : in.nextLine().split(" ")) {
            inputPlaces.add(Integer.valueOf(s));
        }

        for (List<Integer> singleRoom : rooms) {
            if (singleRoom.containsAll(inputPlaces)) {
                System.out.println("Місця поряд");
                return;
            }
        }

        System.out.println("Місця не поряд");
    }
}