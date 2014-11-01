package ProgrammingFundamentals.just4fun._190914_lecture.java;

import java.util.Random;

public class Matrix {
    public static void main(String[] args) throws InterruptedException {
        int width = 0;
        while (true) {
            if (width < 30) {
                if (new Random().nextInt() % 2 == 0) {
                    System.out.print(1);
                } else System.out.print(0);
                width++;
            } else {
                System.out.println();
                Thread.sleep(50);
                width = 0;
            }
        }
    }
}
