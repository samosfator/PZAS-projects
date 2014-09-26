package ua.samosfator.txtDB;

import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;

/**
 * 1. Написати програму, яка копіює вміст вхідного файла у вихідний файл;
 * підраховує кількість чисел у тексті (не цифр, а саме чисел);
 * виділяє всі слова, що складаються тільки з латинських літер;
 * видаляє кожне друге слово.
 */

public class TextUtils {

    //копіює вміст вхідного файла у вихідний файл;
    public static void copyTxt(Path input) throws IOException {
        Files.copy(input, Paths.get("output.txt"));
    }

    //підраховує кількість чисел у тексті (не цифр, а саме чисел);
    public static int countNumbers(Path input) throws IOException {
        List<String> rawText = Files.readAllLines(input);
        List<String> split = new ArrayList<>();

        for (String s : rawText) {
            List<String> collected = Arrays.asList(s.split("\\D"))
                    .stream().filter(e -> e.length() > 0).collect(Collectors.toList());
            split.addAll(collected);
        }

        return split.size();
    }

    //виділяє всі слова, що складаються тільки з латинських літер;
    public static int countLatinWords(Path input) throws IOException {
        List<String> strings = Files.readAllLines(input);
        List<String> latinWords = new ArrayList<>();
        for (String string : strings) {
            List<String> collected = Arrays.asList(string.split("[Aa-zZ]*")).stream()
                    .filter(e -> e.equals("")).collect(Collectors.toList());
            System.out.println(collected);
        }

        System.out.println(latinWords);
        System.out.println(latinWords.size());
        return latinWords.size();
    }
}
