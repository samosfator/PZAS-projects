package ua.samosfator.txtDB;

public class SKLAD {
    private String NAME;
    private String TYPE;
    private int QUANTITY;
    private double COST;

    public String getNAME() {
        return NAME;
    }

    public void setNAME(String NAME) {
        this.NAME = NAME;
    }

    public String getTYPE() {
        return TYPE;
    }

    public void setTYPE(String TYPE) {
        this.TYPE = TYPE;
    }

    public int getQUANTITY() {
        return QUANTITY;
    }

    public void setQUANTITY(int QUANTITY) {
        this.QUANTITY = QUANTITY;
    }

    public double getCOST() {
        return COST;
    }

    public void setCOST(double COST) {
        this.COST = COST;
    }
}
