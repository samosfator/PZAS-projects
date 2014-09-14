package ua.samosfator.tneu.pzas.java._00_QuadraticEquationsSolver;

public class Result {
    private String nanResult;
    private double x1 = Double.POSITIVE_INFINITY;
    private double x2 = Double.POSITIVE_INFINITY;

    public Result(double x1, double x2) {
        this.x1 = x1;
        this.x2 = x2;
    }

    public Result(double x1) {
        this.x1 = x1;
    }

    public Result(String nanResult) {
        this.nanResult = nanResult;
    }

    @Override
    public String toString() {
        if (Double.isFinite(x1) && Double.isFinite(x2)) {
            return "Результат: x1 = " + x1 + ", x2 = " + x2;
        } else if (Double.isFinite(x1)) {
            return "Результат: x1 = " + x1;
        } else return "Результат: " + nanResult;
    }
}
