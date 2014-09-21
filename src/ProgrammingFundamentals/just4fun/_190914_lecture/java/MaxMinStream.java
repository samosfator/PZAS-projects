package ProgrammingFundamentals.just4fun._190914_lecture.java;

import java.util.ArrayList;
import java.util.List;
import java.util.Optional;
import java.util.Scanner;

/*
Завдання:
Користувач вводить числа, закінчуючи введення нулем. Показати найбільше число
серед додатніх і найменше серед негативних
 */

public class MaxMinStream {
    public static Scanner in = new Scanner(System.in);

    public static void main(String[] args) {
        List<Integer> input = new ArrayList<>();
        int nextInt;
        do {
            nextInt = in.nextInt();
            input.add(nextInt);
        } while (nextInt != 0);
        Optional<Integer> max = input.stream().filter(i -> i >= 0).max((o1, o2) -> o1.compareTo(o2));
        Optional<Integer> min = input.stream().filter(i -> i <= 0).min((o1, o2) -> o1.compareTo(o2));

        System.out.println("max among positive: " + max.get());
        System.out.println("min among negative: " + min.get());
    }
}
