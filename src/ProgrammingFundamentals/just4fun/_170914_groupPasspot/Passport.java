package ProgrammingFundamentals.just4fun._170914_groupPasspot;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Passport {
    static Scanner in = new Scanner(System.in);
    static int i;

    public static void main(String[] args) {
        List<String> passport = new ArrayList<>();
        passport.add("Назва групи: ПЗАС-12");
        passport.add("Дата народження: 01.09.2014");
        passport.add("Місто: Файне місто Тернопіль");
        passport.add("Батько: Дивак Микола Петрович");
        passport.add("Мати: Гончар Людмила Іванівна");
        passport.add("Національність: Програмісти");
        passport.add("Місце прописки: Тернопільський національний економічний університет");

        System.out.println("Паспорт групи:");

        while (i < 7) {
            if (in.nextLine().contains(" ")) {
                System.out.println(passport.get(i));
                i++;
            }
        }
    }
}
