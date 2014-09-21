package ProgrammingFundamentals.hometask._01_QuadraticEquationsSolver.java;

import java.util.Scanner;

public class Main {
    private static Scanner input = new Scanner(System.in);

    public static void main(String[] args) {
        try {
            do {
                double a = input.nextDouble();
                double b = input.nextDouble();
                double c = input.nextDouble();

                Equation equation = new Equation(a, b, c);
                String result = equation.solve().toString();

                System.out.println(result);

            } while (!input.nextLine().equals("stop"));
        } catch (Exception ignored) { }
    }
}
