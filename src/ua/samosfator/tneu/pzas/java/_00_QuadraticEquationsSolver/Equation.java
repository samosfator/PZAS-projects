package ua.samosfator.tneu.pzas.java._00_QuadraticEquationsSolver;

public class Equation {
    private double a;
    private double b;
    private double c;

    private double d;

    private Result result;

    public Equation(double a, double b, double c) {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public Result solve() {
        if (a == 0) {
            if (b == 0) {
                if (c == 0) {
                    result = new Result("Будь-який x");
                } else {
                    result = new Result("Розв'язків немає");
                }
            } else {
                result = new Result(-c / b);
            }
        } else if (a != 0) {
            d = (b * b) - (4 * (a * c));
            if (d >= 0) {
                result = regularCalc();
            } else {
                result = new Result("Розв'язків немає");
            }
        }

        return result;
    }

    private Result regularCalc() {
        double x1 = (-b + Math.sqrt(d)) / (2 * a);
        double x2 = (-b - Math.sqrt(d)) / (2 * a);

        return new Result(x1, x2);
    }
}
