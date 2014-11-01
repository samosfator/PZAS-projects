package ua.samosfator.txtDB;

import java.io.IOException;
import java.nio.file.Paths;

public class Main {

    public static void main(String[] args) throws IOException {
        DB db = new DB("db.txt");
        db.set("name", "Vlad");
        System.out.println(db.get("name"));
        db.delete("name");
        System.out.println(db.get("name"));
    }
}
